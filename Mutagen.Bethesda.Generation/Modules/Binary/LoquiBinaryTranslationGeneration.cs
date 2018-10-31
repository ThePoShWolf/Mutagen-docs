﻿using Loqui;
using Loqui.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutagen.Bethesda.Generation
{
    public class LoquiBinaryTranslationGeneration : BinaryTranslationGeneration
    {
        public string ModNickname;

        public override bool AllowDirectParse(ObjectGeneration objGen, TypeGeneration typeGen, bool squashedRepeatedList)
        {
            return false;
        }

        public override bool AllowDirectWrite(ObjectGeneration objGen, TypeGeneration typeGen)
        {
            return false;
        }

        public override string GetTranslatorInstance(TypeGeneration typeGen)
        {
            var loquiGen = typeGen as LoquiType;
            if (loquiGen.CanStronglyType)
            {
                return $"LoquiBinaryTranslation<{loquiGen.TypeName}>.Instance";
            }
            else
            {
                return $"LoquiBinaryTranslation.Instance";
            }
        }

        public LoquiBinaryTranslationGeneration(string modNickname)
        {
            this.ModNickname = modNickname;
        }

        public override void GenerateWrite(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration typeGen,
            string writerAccessor,
            Accessor itemAccessor,
            string maskAccessor,
            string translationMaskAccessor)
        {
            var loquiGen = typeGen as LoquiType;
            if (loquiGen.TryGetFieldData(out var data)
                && data.MarkerType.HasValue)
            {
                fg.AppendLine($"using (HeaderExport.ExportHeader(writer, {objGen.RegistrationName}.{data.MarkerType.Value.Type}_HEADER, ObjectType.Subrecord)) {{ }}");
            }
            bool isGroup = objGen.GetObjectType() == ObjectType.Mod
                && loquiGen.TargetObjectGeneration.GetObjectData().ObjectType == ObjectType.Group;
            if (isGroup)
            {
                fg.AppendLine($"if ({itemAccessor.PropertyOrDirectAccess}.Items.Count > 0)");
            }
            using (new BraceWrapper(fg, doIt: isGroup))
            {
                using (var args = new ArgsWrapper(fg,
                $"LoquiBinaryTranslation<{loquiGen.ObjectTypeName}{loquiGen.GenericTypes}>.Instance.Write"))
                {
                    args.Add($"writer: {writerAccessor}");
                    args.Add($"item: {itemAccessor.DirectAccess}");
                    if (loquiGen.HasIndex)
                    {
                        args.Add($"fieldIndex: (int){typeGen.IndexEnumName}");
                    }
                    args.Add($"errorMask: {maskAccessor}");
                    args.Add($"masterReferences: masterReferences");
                    if (data?.RecordTypeConverter != null
                        && data.RecordTypeConverter.FromConversions.Count > 0)
                    {
                        args.Add($"recordTypeConverter: {objGen.RegistrationName}.{typeGen.Name}Converter");
                    }
                }
            }
        }

        public override bool ShouldGenerateCopyIn(TypeGeneration typeGen)
        {
            var loquiGen = typeGen as LoquiType;
            return loquiGen.SingletonType != SingletonLevel.Singleton || loquiGen.InterfaceType != LoquiInterfaceType.IGetter;
        }

        public override void GenerateCopyIn(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration typeGen,
            string frameAccessor,
            Accessor itemAccessor,
            string maskAccessor,
            string translationMaskAccessor)
        {
            var loquiGen = typeGen as LoquiType;
            if (loquiGen.TargetObjectGeneration != null)
            {
                if (loquiGen.TryGetFieldData(out var data)
                    && data.MarkerType.HasValue)
                {
                    fg.AppendLine("frame.Position += Mutagen.Bethesda.Constants.SUBRECORD_LENGTH + contentLength; // Skip marker");
                }

                if (loquiGen.SingletonType == SingletonLevel.Singleton)
                {
                    if (loquiGen.InterfaceType == LoquiInterfaceType.IGetter) return;
                    fg.AppendLine($"using (errorMask.PushIndex((int){typeGen.IndexEnumName}))");
                    using (new BraceWrapper(fg))
                    {
                        using (var args = new ArgsWrapper(fg,
                            $"var tmp{typeGen.Name} = {loquiGen.TypeName}.Create_{ModNickname}"))
                        {
                            args.Add($"frame: {frameAccessor}");
                            args.Add($"errorMask: {maskAccessor}");
                            args.Add($"recordTypeConverter: null");
                            args.Add($"masterReferences: masterReferences");
                        }
                        using (var args = new ArgsWrapper(fg,
                            $"{itemAccessor.DirectAccess}.CopyFieldsFrom{loquiGen.GetGenericTypes(MaskType.Copy)}"))
                        {
                            args.Add($"rhs: tmp{typeGen.Name}");
                            args.Add("def: null");
                            args.Add("cmds: null");
                            args.Add("copyMask: null");
                            args.Add($"errorMask: {maskAccessor}");
                        }
                    }
                }
                else
                {
                    List<string> extraArgs = new List<string>();
                    extraArgs.Add($"frame: {frameAccessor}{(loquiGen.TargetObjectGeneration.HasRecordType() ? null : ".Spawn(snapToFinalPosition: false)")}");
                    if (data?.RecordTypeConverter != null
                        && data.RecordTypeConverter.FromConversions.Count > 0)
                    {
                        extraArgs.Add($"recordTypeConverter: {objGen.RegistrationName}.{typeGen.Name}Converter");
                    }
                    extraArgs.Add($"masterReferences: masterReferences");
                    TranslationGeneration.WrapParseCall(
                        new TranslationWrapParseArgs()
                        {
                            FG = fg,
                            TypeGen = typeGen,
                            TranslatorLine = $"LoquiBinaryTranslation<{loquiGen.ObjectTypeName}{loquiGen.GenericTypes}>.Instance",
                            MaskAccessor = maskAccessor,
                            ItemAccessor = itemAccessor,
                            TranslationMaskAccessor = null,
                            IndexAccessor = typeGen.HasIndex ? typeGen.IndexEnumInt : null,
                            ExtraArgs = extraArgs.ToArray(),
                        });
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public override void GenerateCopyInRet(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration targetGen,
            TypeGeneration typeGen,
            string readerAccessor,
            bool squashedRepeatedList,
            string retAccessor,
            Accessor outItemAccessor,
            string maskAccessor,
            string translationMaskAccessor)
        {
            var targetLoquiGen = targetGen as LoquiType;
            var loquiGen = typeGen as LoquiType;
            var data = loquiGen.GetFieldData();
            using (var args = new ArgsWrapper(fg,
                $"{retAccessor}LoquiBinaryTranslation<{loquiGen.ObjectTypeName}{loquiGen.GenericTypes}>.Instance.Parse"))
            {
                args.Add($"frame: {readerAccessor}.Spawn(snapToFinalPosition: false)");
                if (loquiGen.HasIndex)
                {
                    args.Add($"fieldIndex: (int){typeGen.IndexEnumName}");
                }
                args.Add($"item: out {outItemAccessor.DirectAccess}");
                args.Add($"errorMask: {maskAccessor}");
                if (objGen.GetObjectType() == ObjectType.Mod)
                {
                    args.Add($"masterReferences: item.TES4.MasterReferences");
                }
                else
                {
                    args.Add($"masterReferences: masterReferences");
                }
                if (data?.RecordTypeConverter != null
                    && data.RecordTypeConverter.FromConversions.Count > 0)
                {
                    args.Add($"recordTypeConverter: {objGen.RegistrationName}.{typeGen.Name}Converter");
                }
            }
        }
    }
}
