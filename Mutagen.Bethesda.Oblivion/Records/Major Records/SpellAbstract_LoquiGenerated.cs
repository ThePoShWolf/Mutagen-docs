/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loqui;
using Noggog;
using Noggog.Notifying;
using Mutagen.Bethesda.Oblivion.Internals;
using ReactiveUI;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Internals;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using Noggog.Xml;
using Loqui.Xml;
using Loqui.Internal;
using System.Diagnostics;
using System.Collections.Specialized;
using Mutagen.Bethesda.Binary;

namespace Mutagen.Bethesda.Oblivion
{
    #region Class
    public abstract partial class SpellAbstract : 
        MajorRecord,
        ISpellAbstract,
        ILoquiObject<SpellAbstract>,
        ILoquiObjectSetter,
        ILinkSubContainer,
        IEquatable<SpellAbstract>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => SpellAbstract_Registration.Instance;
        public new static SpellAbstract_Registration Registration => SpellAbstract_Registration.Instance;

        #region Ctor
        public SpellAbstract()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region Loqui Getter Interface

        protected override object GetNthObject(ushort index) => SpellAbstractCommon.GetNthObject(index, this);

        protected override bool GetNthObjectHasBeenSet(ushort index) => SpellAbstractCommon.GetNthObjectHasBeenSet(index, this);

        protected override void UnsetNthObject(ushort index, NotifyingUnsetParameters cmds) => SpellAbstractCommon.UnsetNthObject(index, this, cmds);

        #endregion

        #region Loqui Interface
        protected override void SetNthObjectHasBeenSet(ushort index, bool on)
        {
            SpellAbstractCommon.SetNthObjectHasBeenSet(index, on, this);
        }

        #endregion

        IMask<bool> IEqualsMask<SpellAbstract>.GetEqualsMask(SpellAbstract rhs) => SpellAbstractCommon.GetEqualsMask(this, rhs);
        IMask<bool> IEqualsMask<ISpellAbstractGetter>.GetEqualsMask(ISpellAbstractGetter rhs) => SpellAbstractCommon.GetEqualsMask(this, rhs);
        #region To String
        public string ToString(
            string name = null,
            SpellAbstract_Mask<bool> printMask = null)
        {
            return SpellAbstractCommon.ToString(this, name: name, printMask: printMask);
        }

        public override void ToString(
            FileGeneration fg,
            string name = null)
        {
            SpellAbstractCommon.ToString(this, fg, name: name, printMask: null);
        }

        #endregion

        IMask<bool> ILoquiObjectGetter.GetHasBeenSetMask() => this.GetHasBeenSetMask();
        public new SpellAbstract_Mask<bool> GetHasBeenSetMask()
        {
            return SpellAbstractCommon.GetHasBeenSetMask(this);
        }
        #region Equals and Hash
        public override bool Equals(object obj)
        {
            if (!(obj is SpellAbstract rhs)) return false;
            return Equals(rhs);
        }

        public bool Equals(SpellAbstract rhs)
        {
            if (rhs == null) return false;
            if (!base.Equals(rhs)) return false;
            return true;
        }

        public override int GetHashCode()
        {
            int ret = 0;
            ret = ret.CombineHashCode(base.GetHashCode());
            return ret;
        }

        #endregion


        #region Xml Translation
        #region Xml Copy In
        public override void CopyIn_Xml(
            XElement root,
            NotifyingFireParameters cmds = null)
        {
            CopyIn_Xml_Internal(
                root: root,
                errorMask: null,
                translationMask: null,
                cmds: cmds);
        }

        public virtual void CopyIn_Xml(
            XElement root,
            out SpellAbstract_ErrorMask errorMask,
            SpellAbstract_TranslationMask translationMask = null,
            bool doMasks = true,
            NotifyingFireParameters cmds = null)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            CopyIn_Xml_Internal(
                root: root,
                errorMask: errorMaskBuilder,
                translationMask: translationMask?.GetCrystal(),
                cmds: cmds);
            errorMask = SpellAbstract_ErrorMask.Factory(errorMaskBuilder);
        }

        protected override void CopyIn_Xml_Internal(
            XElement root,
            ErrorMaskBuilder errorMask,
            TranslationCrystal translationMask,
            NotifyingFireParameters cmds = null)
        {
            LoquiXmlTranslation<SpellAbstract>.Instance.CopyIn(
                root: root,
                item: this,
                skipProtected: true,
                errorMask: errorMask,
                translationMask: translationMask,
                cmds: cmds);
        }

        public void CopyIn_Xml(
            string path,
            NotifyingFireParameters cmds = null)
        {
            var root = XDocument.Load(path).Root;
            this.CopyIn_Xml(
                root: root,
                cmds: cmds);
        }

        public void CopyIn_Xml(
            string path,
            out SpellAbstract_ErrorMask errorMask,
            SpellAbstract_TranslationMask translationMask,
            NotifyingFireParameters cmds = null,
            bool doMasks = true)
        {
            var root = XDocument.Load(path).Root;
            this.CopyIn_Xml(
                root: root,
                errorMask: out errorMask,
                translationMask: translationMask,
                cmds: cmds,
                doMasks: doMasks);
        }

        public void CopyIn_Xml(
            Stream stream,
            NotifyingFireParameters cmds = null)
        {
            var root = XDocument.Load(stream).Root;
            this.CopyIn_Xml(
                root: root,
                cmds: cmds);
        }

        public void CopyIn_Xml(
            Stream stream,
            out SpellAbstract_ErrorMask errorMask,
            SpellAbstract_TranslationMask translationMask,
            NotifyingFireParameters cmds = null,
            bool doMasks = true)
        {
            var root = XDocument.Load(stream).Root;
            this.CopyIn_Xml(
                root: root,
                errorMask: out errorMask,
                translationMask: translationMask,
                cmds: cmds,
                doMasks: doMasks);
        }

        public override void CopyIn_Xml(
            XElement root,
            out MajorRecord_ErrorMask errorMask,
            MajorRecord_TranslationMask translationMask = null,
            bool doMasks = true,
            NotifyingFireParameters cmds = null)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            CopyIn_Xml_Internal(
                root: root,
                errorMask: errorMaskBuilder,
                translationMask: translationMask?.GetCrystal(),
                cmds: cmds);
            errorMask = SpellAbstract_ErrorMask.Factory(errorMaskBuilder);
        }

        #endregion

        #region Xml Write
        public virtual void Write_Xml(
            XElement node,
            out SpellAbstract_ErrorMask errorMask,
            bool doMasks = true,
            SpellAbstract_TranslationMask translationMask = null,
            string name = null)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            this.Write_Xml_Internal(
                node: node,
                name: name,
                errorMask: errorMaskBuilder,
                translationMask: translationMask?.GetCrystal());
            errorMask = SpellAbstract_ErrorMask.Factory(errorMaskBuilder);
        }

        public virtual void Write_Xml(
            string path,
            out SpellAbstract_ErrorMask errorMask,
            SpellAbstract_TranslationMask translationMask = null,
            bool doMasks = true,
            string name = null)
        {
            XElement topNode = new XElement("topnode");
            Write_Xml(
                node: topNode,
                name: name,
                errorMask: out errorMask,
                doMasks: doMasks,
                translationMask: translationMask);
            topNode.Elements().First().Save(path);
        }

        public virtual void Write_Xml(
            Stream stream,
            out SpellAbstract_ErrorMask errorMask,
            SpellAbstract_TranslationMask translationMask = null,
            bool doMasks = true,
            string name = null)
        {
            XElement topNode = new XElement("topnode");
            Write_Xml(
                node: topNode,
                name: name,
                errorMask: out errorMask,
                doMasks: doMasks,
                translationMask: translationMask);
            topNode.Elements().First().Save(stream);
        }

        #region Base Class Trickdown Overrides
        public override void Write_Xml(
            XElement node,
            out MajorRecord_ErrorMask errorMask,
            bool doMasks = true,
            MajorRecord_TranslationMask translationMask = null,
            string name = null)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            this.Write_Xml_Internal(
                node: node,
                name: name,
                errorMask: errorMaskBuilder,
                translationMask: translationMask?.GetCrystal());
            errorMask = SpellAbstract_ErrorMask.Factory(errorMaskBuilder);
        }

        #endregion

        protected override void Write_Xml_Internal(
            XElement node,
            ErrorMaskBuilder errorMask,
            TranslationCrystal translationMask,
            string name = null)
        {
            SpellAbstractCommon.Write_Xml(
                item: this,
                node: node,
                name: name,
                errorMask: errorMask,
                translationMask: translationMask);
        }
        #endregion

        protected static void Fill_Xml_Internal(
            SpellAbstract item,
            XElement root,
            string name,
            ErrorMaskBuilder errorMask,
            TranslationCrystal translationMask)
        {
            switch (name)
            {
                default:
                    MajorRecord.Fill_Xml_Internal(
                        item: item,
                        root: root,
                        name: name,
                        errorMask: errorMask,
                        translationMask: translationMask);
                    break;
            }
        }

        #endregion

        #region Mutagen
        public override IEnumerable<ILink> Links => GetLinks();
        private IEnumerable<ILink> GetLinks()
        {
            foreach (var item in base.Links)
            {
                yield return item;
            }
            yield break;
        }

        public override void Link<M>(
            ModList<M> modList,
            M sourceMod,
            NotifyingFireParameters cmds = null)
            
        {
            base.Link(
                modList,
                sourceMod,
                cmds);
        }

        #endregion

        #region Binary Translation
        #region Binary Write
        public virtual void Write_Binary(
            MutagenWriter writer,
            MasterReferences masterReferences,
            out SpellAbstract_ErrorMask errorMask,
            bool doMasks = true)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            this.Write_Binary_Internal(
                writer: writer,
                masterReferences: masterReferences,
                recordTypeConverter: null,
                errorMask: errorMaskBuilder);
            errorMask = SpellAbstract_ErrorMask.Factory(errorMaskBuilder);
        }

        public virtual void Write_Binary(
            string path,
            MasterReferences masterReferences,
            out SpellAbstract_ErrorMask errorMask,
            bool doMasks = true)
        {
            using (var memStream = new MemoryTributary())
            {
                using (var writer = new MutagenWriter(memStream, dispose: false))
                {
                    Write_Binary(
                        writer: writer,
                        masterReferences: masterReferences,
                        errorMask: out errorMask,
                        doMasks: doMasks);
                }
                using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    memStream.Position = 0;
                    memStream.CopyTo(fs);
                }
            }
        }

        public virtual void Write_Binary(
            Stream stream,
            MasterReferences masterReferences,
            out SpellAbstract_ErrorMask errorMask,
            bool doMasks = true)
        {
            using (var writer = new MutagenWriter(stream))
            {
                Write_Binary(
                    writer: writer,
                    masterReferences: masterReferences,
                    errorMask: out errorMask,
                    doMasks: doMasks);
            }
        }

        #region Base Class Trickdown Overrides
        public override void Write_Binary(
            MutagenWriter writer,
            MasterReferences masterReferences,
            out MajorRecord_ErrorMask errorMask,
            bool doMasks = true)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            this.Write_Binary_Internal(
                writer: writer,
                masterReferences: masterReferences,
                errorMask: errorMaskBuilder,
                recordTypeConverter: null);
            errorMask = SpellAbstract_ErrorMask.Factory(errorMaskBuilder);
        }

        #endregion

        protected override void Write_Binary_Internal(
            MutagenWriter writer,
            MasterReferences masterReferences,
            RecordTypeConverter recordTypeConverter,
            ErrorMaskBuilder errorMask)
        {
            SpellAbstractCommon.Write_Binary(
                item: this,
                writer: writer,
                masterReferences: masterReferences,
                recordTypeConverter: recordTypeConverter,
                errorMask: errorMask);
        }
        #endregion

        #endregion

        public SpellAbstract Copy(
            SpellAbstract_CopyMask copyMask = null,
            ISpellAbstractGetter def = null)
        {
            return SpellAbstract.Copy(
                this,
                copyMask: copyMask,
                def: def);
        }

        public static SpellAbstract Copy(
            ISpellAbstract item,
            SpellAbstract_CopyMask copyMask = null,
            ISpellAbstractGetter def = null)
        {
            SpellAbstract ret = (SpellAbstract)System.Activator.CreateInstance(item.GetType());
            ret.CopyFieldsFrom(
                item,
                copyMask: copyMask,
                def: def);
            return ret;
        }

        public static SpellAbstract Copy_ToLoqui(
            ISpellAbstractGetter item,
            SpellAbstract_CopyMask copyMask = null,
            ISpellAbstractGetter def = null)
        {
            SpellAbstract ret = (SpellAbstract)System.Activator.CreateInstance(item.GetType());
            ret.CopyFieldsFrom(
                item,
                copyMask: copyMask,
                def: def);
            return ret;
        }

        public void CopyFieldsFrom(
            ISpellAbstractGetter rhs,
            SpellAbstract_CopyMask copyMask,
            ISpellAbstractGetter def = null,
            NotifyingFireParameters cmds = null)
        {
            this.CopyFieldsFrom(
                rhs: rhs,
                def: def,
                doMasks: false,
                errorMask: out var errMask,
                copyMask: copyMask,
                cmds: cmds);
        }

        public void CopyFieldsFrom(
            ISpellAbstractGetter rhs,
            out SpellAbstract_ErrorMask errorMask,
            SpellAbstract_CopyMask copyMask = null,
            ISpellAbstractGetter def = null,
            NotifyingFireParameters cmds = null,
            bool doMasks = true)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            SpellAbstractCommon.CopyFieldsFrom(
                item: this,
                rhs: rhs,
                def: def,
                errorMask: errorMaskBuilder,
                copyMask: copyMask,
                cmds: cmds);
            errorMask = SpellAbstract_ErrorMask.Factory(errorMaskBuilder);
        }

        public void CopyFieldsFrom(
            ISpellAbstractGetter rhs,
            ErrorMaskBuilder errorMask,
            SpellAbstract_CopyMask copyMask = null,
            ISpellAbstractGetter def = null,
            NotifyingFireParameters cmds = null,
            bool doMasks = true)
        {
            SpellAbstractCommon.CopyFieldsFrom(
                item: this,
                rhs: rhs,
                def: def,
                errorMask: errorMask,
                copyMask: copyMask,
                cmds: cmds);
        }

        protected override void SetNthObject(ushort index, object obj, NotifyingFireParameters cmds = null)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    base.SetNthObject(index, obj, cmds);
                    break;
            }
        }

        public override void Clear(NotifyingUnsetParameters cmds = null)
        {
            CallClearPartial_Internal(cmds);
            SpellAbstractCommon.Clear(this, cmds);
        }


        protected new static void CopyInInternal_SpellAbstract(SpellAbstract obj, KeyValuePair<ushort, object> pair)
        {
            if (!EnumExt.TryParse(pair.Key, out SpellAbstract_FieldIndex enu))
            {
                CopyInInternal_MajorRecord(obj, pair);
            }
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Unknown enum type: {enu}");
            }
        }
        public static void CopyIn(IEnumerable<KeyValuePair<ushort, object>> fields, SpellAbstract obj)
        {
            ILoquiObjectExt.CopyFieldsIn(obj, fields, def: null, skipProtected: false, cmds: null);
        }

    }
    #endregion

    #region Interface
    public partial interface ISpellAbstract : ISpellAbstractGetter, IMajorRecord, ILoquiClass<ISpellAbstract, ISpellAbstractGetter>, ILoquiClass<SpellAbstract, ISpellAbstractGetter>
    {
    }

    public partial interface ISpellAbstractGetter : IMajorRecordGetter
    {

    }

    #endregion

}

namespace Mutagen.Bethesda.Oblivion.Internals
{
    #region Field Index
    public enum SpellAbstract_FieldIndex
    {
        MajorRecordFlags = 0,
        FormKey = 1,
        Version = 2,
        EditorID = 3,
        RecordType = 4,
    }
    #endregion

    #region Registration
    public class SpellAbstract_Registration : ILoquiRegistration
    {
        public static readonly SpellAbstract_Registration Instance = new SpellAbstract_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Oblivion.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Oblivion.ProtocolKey,
            msgID: 168,
            version: 0);

        public const string GUID = "f6a3a278-3052-4bee-8416-05eeb28d7eb7";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 5;

        public static readonly Type MaskType = typeof(SpellAbstract_Mask<>);

        public static readonly Type ErrorMaskType = typeof(SpellAbstract_ErrorMask);

        public static readonly Type ClassType = typeof(SpellAbstract);

        public static readonly Type GetterType = typeof(ISpellAbstractGetter);

        public static readonly Type SetterType = typeof(ISpellAbstract);

        public static readonly Type CommonType = typeof(SpellAbstractCommon);

        public const string FullName = "Mutagen.Bethesda.Oblivion.SpellAbstract";

        public const string Name = "SpellAbstract";

        public const string Namespace = "Mutagen.Bethesda.Oblivion";

        public const byte GenericCount = 0;

        public static readonly Type GenericRegistrationType = null;

        public static ushort? GetNameIndex(StringCaseAgnostic str)
        {
            switch (str.Upper)
            {
                default:
                    return null;
            }
        }

        public static bool GetNthIsEnumerable(ushort index)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.GetNthIsEnumerable(index);
            }
        }

        public static bool GetNthIsLoqui(ushort index)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.GetNthIsLoqui(index);
            }
        }

        public static bool GetNthIsSingleton(ushort index)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.GetNthIsSingleton(index);
            }
        }

        public static string GetNthName(ushort index)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.GetNthName(index);
            }
        }

        public static bool IsNthDerivative(ushort index)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.IsNthDerivative(index);
            }
        }

        public static bool IsProtected(ushort index)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.IsProtected(index);
            }
        }

        public static Type GetNthType(ushort index)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.GetNthType(index);
            }
        }

        public static readonly RecordType LVSP_HEADER = new RecordType("LVSP");
        public static readonly RecordType FULL_HEADER = new RecordType("FULL");
        public static readonly RecordType SPEL_HEADER = new RecordType("SPEL");
        public static ICollectionGetter<RecordType> TriggeringRecordTypes => _TriggeringRecordTypes.Value;
        private static readonly Lazy<ICollectionGetter<RecordType>> _TriggeringRecordTypes = new Lazy<ICollectionGetter<RecordType>>(() =>
        {
            return new CollectionGetterWrapper<RecordType>(
                new HashSet<RecordType>(
                    new RecordType[]
                    {
                        LVSP_HEADER,
                        FULL_HEADER,
                        SPEL_HEADER
                    })
            );
        });
        public const int NumStructFields = 0;
        public const int NumTypedFields = 0;
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
        ObjectKey ILoquiRegistration.ObjectKey => ObjectKey;
        string ILoquiRegistration.GUID => GUID;
        ushort ILoquiRegistration.FieldCount => FieldCount;
        ushort ILoquiRegistration.AdditionalFieldCount => AdditionalFieldCount;
        Type ILoquiRegistration.MaskType => MaskType;
        Type ILoquiRegistration.ErrorMaskType => ErrorMaskType;
        Type ILoquiRegistration.ClassType => ClassType;
        Type ILoquiRegistration.SetterType => SetterType;
        Type ILoquiRegistration.GetterType => GetterType;
        Type ILoquiRegistration.CommonType => CommonType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => GetNameIndex(name);
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => GetNthIsEnumerable(index);
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => GetNthIsLoqui(index);
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => GetNthIsSingleton(index);
        string ILoquiRegistration.GetNthName(ushort index) => GetNthName(index);
        bool ILoquiRegistration.IsNthDerivative(ushort index) => IsNthDerivative(index);
        bool ILoquiRegistration.IsProtected(ushort index) => IsProtected(index);
        Type ILoquiRegistration.GetNthType(ushort index) => GetNthType(index);
        #endregion

    }
    #endregion

    #region Extensions
    public static partial class SpellAbstractCommon
    {
        #region Copy Fields From
        public static void CopyFieldsFrom(
            ISpellAbstract item,
            ISpellAbstractGetter rhs,
            ISpellAbstractGetter def,
            ErrorMaskBuilder errorMask,
            SpellAbstract_CopyMask copyMask,
            NotifyingFireParameters cmds = null)
        {
            MajorRecordCommon.CopyFieldsFrom(
                item,
                rhs,
                def,
                errorMask,
                copyMask,
                cmds);
        }

        #endregion

        public static void SetNthObjectHasBeenSet(
            ushort index,
            bool on,
            ISpellAbstract obj,
            NotifyingFireParameters cmds = null)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    MajorRecordCommon.SetNthObjectHasBeenSet(index, on, obj);
                    break;
            }
        }

        public static void UnsetNthObject(
            ushort index,
            ISpellAbstract obj,
            NotifyingUnsetParameters cmds = null)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    MajorRecordCommon.UnsetNthObject(index, obj);
                    break;
            }
        }

        public static bool GetNthObjectHasBeenSet(
            ushort index,
            ISpellAbstract obj)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecordCommon.GetNthObjectHasBeenSet(index, obj);
            }
        }

        public static object GetNthObject(
            ushort index,
            ISpellAbstractGetter obj)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecordCommon.GetNthObject(index, obj);
            }
        }

        public static void Clear(
            ISpellAbstract item,
            NotifyingUnsetParameters cmds = null)
        {
        }

        public static SpellAbstract_Mask<bool> GetEqualsMask(
            this ISpellAbstractGetter item,
            ISpellAbstractGetter rhs)
        {
            var ret = new SpellAbstract_Mask<bool>();
            FillEqualsMask(item, rhs, ret);
            return ret;
        }

        public static void FillEqualsMask(
            ISpellAbstractGetter item,
            ISpellAbstractGetter rhs,
            SpellAbstract_Mask<bool> ret)
        {
            if (rhs == null) return;
            MajorRecordCommon.FillEqualsMask(item, rhs, ret);
        }

        public static string ToString(
            this ISpellAbstractGetter item,
            string name = null,
            SpellAbstract_Mask<bool> printMask = null)
        {
            var fg = new FileGeneration();
            item.ToString(fg, name, printMask);
            return fg.ToString();
        }

        public static void ToString(
            this ISpellAbstractGetter item,
            FileGeneration fg,
            string name = null,
            SpellAbstract_Mask<bool> printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"{nameof(SpellAbstract)} =>");
            }
            else
            {
                fg.AppendLine($"{name} ({nameof(SpellAbstract)}) =>");
            }
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
            }
            fg.AppendLine("]");
        }

        public static bool HasBeenSet(
            this ISpellAbstractGetter item,
            SpellAbstract_Mask<bool?> checkMask)
        {
            return true;
        }

        public static SpellAbstract_Mask<bool> GetHasBeenSetMask(ISpellAbstractGetter item)
        {
            var ret = new SpellAbstract_Mask<bool>();
            return ret;
        }

        public static SpellAbstract_FieldIndex? ConvertFieldIndex(MajorRecord_FieldIndex? index)
        {
            if (!index.HasValue) return null;
            return ConvertFieldIndex(index: index.Value);
        }

        public static SpellAbstract_FieldIndex ConvertFieldIndex(MajorRecord_FieldIndex index)
        {
            switch (index)
            {
                case MajorRecord_FieldIndex.MajorRecordFlags:
                    return (SpellAbstract_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.FormKey:
                    return (SpellAbstract_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.Version:
                    return (SpellAbstract_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.EditorID:
                    return (SpellAbstract_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.RecordType:
                    return (SpellAbstract_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }

        #region Xml Translation
        #region Xml Write
        public static void Write_Xml(
            XElement node,
            SpellAbstract item,
            bool doMasks,
            out SpellAbstract_ErrorMask errorMask,
            SpellAbstract_TranslationMask translationMask,
            string name = null)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            Write_Xml(
                node: node,
                name: name,
                item: item,
                errorMask: errorMaskBuilder,
                translationMask: translationMask?.GetCrystal());
            errorMask = SpellAbstract_ErrorMask.Factory(errorMaskBuilder);
        }

        public static void Write_Xml(
            XElement node,
            SpellAbstract item,
            ErrorMaskBuilder errorMask,
            TranslationCrystal translationMask,
            string name = null)
        {
            var elem = new XElement(name ?? "Mutagen.Bethesda.Oblivion.SpellAbstract");
            node.Add(elem);
            if (name != null)
            {
                elem.SetAttributeValue("type", "Mutagen.Bethesda.Oblivion.SpellAbstract");
            }
        }
        #endregion

        #endregion

        #region Binary Translation
        #region Binary Write
        public static void Write_Binary(
            MutagenWriter writer,
            SpellAbstract item,
            MasterReferences masterReferences,
            RecordTypeConverter recordTypeConverter,
            bool doMasks,
            out SpellAbstract_ErrorMask errorMask)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            Write_Binary(
                writer: writer,
                masterReferences: masterReferences,
                item: item,
                recordTypeConverter: recordTypeConverter,
                errorMask: errorMaskBuilder);
            errorMask = SpellAbstract_ErrorMask.Factory(errorMaskBuilder);
        }

        public static void Write_Binary(
            MutagenWriter writer,
            SpellAbstract item,
            MasterReferences masterReferences,
            RecordTypeConverter recordTypeConverter,
            ErrorMaskBuilder errorMask)
        {
            MajorRecordCommon.Write_Binary_Embedded(
                item: item,
                writer: writer,
                errorMask: errorMask,
                masterReferences: masterReferences);
            MajorRecordCommon.Write_Binary_RecordTypes(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter,
                errorMask: errorMask,
                masterReferences: masterReferences);
        }
        #endregion

        #endregion

    }
    #endregion

    #region Modules
    #region Mask
    public class SpellAbstract_Mask<T> : MajorRecord_Mask<T>, IMask<T>, IEquatable<SpellAbstract_Mask<T>>
    {
        #region Ctors
        public SpellAbstract_Mask()
        {
        }

        public SpellAbstract_Mask(T initialValue)
        {
        }
        #endregion

        #region Equals
        public override bool Equals(object obj)
        {
            if (!(obj is SpellAbstract_Mask<T> rhs)) return false;
            return Equals(rhs);
        }

        public bool Equals(SpellAbstract_Mask<T> rhs)
        {
            if (rhs == null) return false;
            if (!base.Equals(rhs)) return false;
            return true;
        }
        public override int GetHashCode()
        {
            int ret = 0;
            ret = ret.CombineHashCode(base.GetHashCode());
            return ret;
        }

        #endregion

        #region All Equal
        public override bool AllEqual(Func<T, bool> eval)
        {
            if (!base.AllEqual(eval)) return false;
            return true;
        }
        #endregion

        #region Translate
        public new SpellAbstract_Mask<R> Translate<R>(Func<T, R> eval)
        {
            var ret = new SpellAbstract_Mask<R>();
            this.Translate_InternalFill(ret, eval);
            return ret;
        }

        protected void Translate_InternalFill<R>(SpellAbstract_Mask<R> obj, Func<T, R> eval)
        {
            base.Translate_InternalFill(obj, eval);
        }
        #endregion

        #region Clear Enumerables
        public override void ClearEnumerables()
        {
            base.ClearEnumerables();
        }
        #endregion

        #region To String
        public override string ToString()
        {
            return ToString(printMask: null);
        }

        public string ToString(SpellAbstract_Mask<bool> printMask = null)
        {
            var fg = new FileGeneration();
            ToString(fg, printMask);
            return fg.ToString();
        }

        public void ToString(FileGeneration fg, SpellAbstract_Mask<bool> printMask = null)
        {
            fg.AppendLine($"{nameof(SpellAbstract_Mask<T>)} =>");
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
            }
            fg.AppendLine("]");
        }
        #endregion

    }

    public class SpellAbstract_ErrorMask : MajorRecord_ErrorMask, IErrorMask<SpellAbstract_ErrorMask>
    {
        #region IErrorMask
        public override object GetNthMask(int index)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    return base.GetNthMask(index);
            }
        }

        public override void SetNthException(int index, Exception ex)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    base.SetNthException(index, ex);
                    break;
            }
        }

        public override void SetNthMask(int index, object obj)
        {
            SpellAbstract_FieldIndex enu = (SpellAbstract_FieldIndex)index;
            switch (enu)
            {
                default:
                    base.SetNthMask(index, obj);
                    break;
            }
        }

        public override bool IsInError()
        {
            if (Overall != null) return true;
            return false;
        }
        #endregion

        #region To String
        public override string ToString()
        {
            var fg = new FileGeneration();
            ToString(fg);
            return fg.ToString();
        }

        public override void ToString(FileGeneration fg)
        {
            fg.AppendLine("SpellAbstract_ErrorMask =>");
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
                if (this.Overall != null)
                {
                    fg.AppendLine("Overall =>");
                    fg.AppendLine("[");
                    using (new DepthWrapper(fg))
                    {
                        fg.AppendLine($"{this.Overall}");
                    }
                    fg.AppendLine("]");
                }
                ToString_FillInternal(fg);
            }
            fg.AppendLine("]");
        }
        protected override void ToString_FillInternal(FileGeneration fg)
        {
            base.ToString_FillInternal(fg);
        }
        #endregion

        #region Combine
        public SpellAbstract_ErrorMask Combine(SpellAbstract_ErrorMask rhs)
        {
            var ret = new SpellAbstract_ErrorMask();
            return ret;
        }
        public static SpellAbstract_ErrorMask Combine(SpellAbstract_ErrorMask lhs, SpellAbstract_ErrorMask rhs)
        {
            if (lhs != null && rhs != null) return lhs.Combine(rhs);
            return lhs ?? rhs;
        }
        #endregion

        #region Factory
        public static SpellAbstract_ErrorMask Factory(ErrorMaskBuilder errorMask)
        {
            if (errorMask?.Empty ?? true) return null;
            return new SpellAbstract_ErrorMask();
        }
        #endregion

    }
    public class SpellAbstract_CopyMask : MajorRecord_CopyMask
    {
    }
    public class SpellAbstract_TranslationMask : MajorRecord_TranslationMask
    {
        #region Members
        private TranslationCrystal _crystal;
        #endregion

        protected override void GetCrystal(List<(bool On, TranslationCrystal SubCrystal)> ret)
        {
            base.GetCrystal(ret);
        }
    }
    #endregion

    #endregion

}
