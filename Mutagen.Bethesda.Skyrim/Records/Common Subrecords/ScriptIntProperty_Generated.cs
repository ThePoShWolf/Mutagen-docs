/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Interfaces;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Aspects;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Skyrim.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Skyrim.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class ScriptIntProperty :
        ScriptProperty,
        IEquatable<IScriptIntPropertyGetter>,
        ILoquiObjectSetter<ScriptIntProperty>,
        IScriptIntProperty
    {
        #region Ctor
        public ScriptIntProperty()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Data
        public Int32 Data { get; set; } = default;
        #endregion

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            ScriptIntPropertyMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IScriptIntPropertyGetter rhs) return false;
            return ((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IScriptIntPropertyGetter? obj)
        {
            return ((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            ScriptProperty.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
                this.Data = initialValue;
            }

            public Mask(
                TItem Name,
                TItem Flags,
                TItem Data)
            : base(
                Name: Name,
                Flags: Flags)
            {
                this.Data = Data;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Data;
            #endregion

            #region Equals
            public override bool Equals(object? obj)
            {
                if (!(obj is Mask<TItem> rhs)) return false;
                return Equals(rhs);
            }

            public bool Equals(Mask<TItem>? rhs)
            {
                if (rhs == null) return false;
                if (!base.Equals(rhs)) return false;
                if (!object.Equals(this.Data, rhs.Data)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Data);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Data)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Data)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new ScriptIntProperty.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Data = eval(this.Data);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(ScriptIntProperty.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, ScriptIntProperty.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(ScriptIntProperty.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Data ?? true)
                    {
                        sb.AppendItem(Data, "Data");
                    }
                }
            }
            #endregion

        }

        public new class ErrorMask :
            ScriptProperty.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Data;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                ScriptIntProperty_FieldIndex enu = (ScriptIntProperty_FieldIndex)index;
                switch (enu)
                {
                    case ScriptIntProperty_FieldIndex.Data:
                        return Data;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                ScriptIntProperty_FieldIndex enu = (ScriptIntProperty_FieldIndex)index;
                switch (enu)
                {
                    case ScriptIntProperty_FieldIndex.Data:
                        this.Data = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                ScriptIntProperty_FieldIndex enu = (ScriptIntProperty_FieldIndex)index;
                switch (enu)
                {
                    case ScriptIntProperty_FieldIndex.Data:
                        this.Data = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Data != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public override void Print(StructuredStringBuilder sb, string? name = null)
            {
                sb.AppendLine($"{(name ?? "ErrorMask")} =>");
                using (sb.Brace())
                {
                    if (this.Overall != null)
                    {
                        sb.AppendLine("Overall =>");
                        using (sb.Brace())
                        {
                            sb.AppendLine($"{this.Overall}");
                        }
                    }
                    PrintFillInternal(sb);
                }
            }
            protected override void PrintFillInternal(StructuredStringBuilder sb)
            {
                base.PrintFillInternal(sb);
                {
                    sb.AppendItem(Data, "Data");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Data = this.Data.Combine(rhs.Data);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static new ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public new class TranslationMask :
            ScriptProperty.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Data;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Data = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Data, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => ScriptIntPropertyBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((ScriptIntPropertyBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static ScriptIntProperty CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new ScriptIntProperty();
            ((ScriptIntPropertySetterCommon)((IScriptIntPropertyGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out ScriptIntProperty item,
            TypedParseParams translationParams = default)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        void IClearable.Clear()
        {
            ((ScriptIntPropertySetterCommon)((IScriptIntPropertyGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new ScriptIntProperty GetNew()
        {
            return new ScriptIntProperty();
        }

    }
    #endregion

    #region Interface
    public partial interface IScriptIntProperty :
        ILoquiObjectSetter<IScriptIntProperty>,
        INamedRequired,
        IScriptIntPropertyGetter,
        IScriptProperty
    {
        new Int32 Data { get; set; }
    }

    public partial interface IScriptIntPropertyGetter :
        IScriptPropertyGetter,
        IBinaryItem,
        ILoquiObject<IScriptIntPropertyGetter>,
        INamedRequiredGetter
    {
        static new ILoquiRegistration StaticRegistration => ScriptIntProperty_Registration.Instance;
        Int32 Data { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class ScriptIntPropertyMixIn
    {
        public static void Clear(this IScriptIntProperty item)
        {
            ((ScriptIntPropertySetterCommon)((IScriptIntPropertyGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static ScriptIntProperty.Mask<bool> GetEqualsMask(
            this IScriptIntPropertyGetter item,
            IScriptIntPropertyGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IScriptIntPropertyGetter item,
            string? name = null,
            ScriptIntProperty.Mask<bool>? printMask = null)
        {
            return ((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IScriptIntPropertyGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            ScriptIntProperty.Mask<bool>? printMask = null)
        {
            ((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IScriptIntPropertyGetter item,
            IScriptIntPropertyGetter rhs,
            ScriptIntProperty.TranslationMask? equalsMask = null)
        {
            return ((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IScriptIntProperty lhs,
            IScriptIntPropertyGetter rhs,
            out ScriptIntProperty.ErrorMask errorMask,
            ScriptIntProperty.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((ScriptIntPropertySetterTranslationCommon)((IScriptIntPropertyGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = ScriptIntProperty.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IScriptIntProperty lhs,
            IScriptIntPropertyGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((ScriptIntPropertySetterTranslationCommon)((IScriptIntPropertyGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static ScriptIntProperty DeepCopy(
            this IScriptIntPropertyGetter item,
            ScriptIntProperty.TranslationMask? copyMask = null)
        {
            return ((ScriptIntPropertySetterTranslationCommon)((IScriptIntPropertyGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static ScriptIntProperty DeepCopy(
            this IScriptIntPropertyGetter item,
            out ScriptIntProperty.ErrorMask errorMask,
            ScriptIntProperty.TranslationMask? copyMask = null)
        {
            return ((ScriptIntPropertySetterTranslationCommon)((IScriptIntPropertyGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static ScriptIntProperty DeepCopy(
            this IScriptIntPropertyGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((ScriptIntPropertySetterTranslationCommon)((IScriptIntPropertyGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IScriptIntProperty item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((ScriptIntPropertySetterCommon)((IScriptIntPropertyGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    #region Field Index
    internal enum ScriptIntProperty_FieldIndex
    {
        Name = 0,
        Flags = 1,
        Data = 2,
    }
    #endregion

    #region Registration
    internal partial class ScriptIntProperty_Registration : ILoquiRegistration
    {
        public static readonly ScriptIntProperty_Registration Instance = new ScriptIntProperty_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 96,
            version: 0);

        public const string GUID = "5a3fea67-c5c6-457b-963d-9ef6ac5f200d";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 3;

        public static readonly Type MaskType = typeof(ScriptIntProperty.Mask<>);

        public static readonly Type ErrorMaskType = typeof(ScriptIntProperty.ErrorMask);

        public static readonly Type ClassType = typeof(ScriptIntProperty);

        public static readonly Type GetterType = typeof(IScriptIntPropertyGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IScriptIntProperty);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.ScriptIntProperty";

        public const string Name = "ScriptIntProperty";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(ScriptIntPropertyBinaryWriteTranslation);
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
        Type? ILoquiRegistration.InternalSetterType => InternalSetterType;
        Type ILoquiRegistration.GetterType => GetterType;
        Type? ILoquiRegistration.InternalGetterType => InternalGetterType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type? ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => throw new NotImplementedException();
        string ILoquiRegistration.GetNthName(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsNthDerivative(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsProtected(ushort index) => throw new NotImplementedException();
        Type ILoquiRegistration.GetNthType(ushort index) => throw new NotImplementedException();
        #endregion

    }
    #endregion

    #region Common
    internal partial class ScriptIntPropertySetterCommon : ScriptPropertySetterCommon
    {
        public new static readonly ScriptIntPropertySetterCommon Instance = new ScriptIntPropertySetterCommon();

        partial void ClearPartial();
        
        public void Clear(IScriptIntProperty item)
        {
            ClearPartial();
            item.Data = default;
            base.Clear(item);
        }
        
        public override void Clear(IScriptProperty item)
        {
            Clear(item: (IScriptIntProperty)item);
        }
        
        #region Mutagen
        public void RemapLinks(IScriptIntProperty obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IScriptIntProperty item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: ScriptIntPropertyBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IScriptProperty item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (ScriptIntProperty)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class ScriptIntPropertyCommon : ScriptPropertyCommon
    {
        public new static readonly ScriptIntPropertyCommon Instance = new ScriptIntPropertyCommon();

        public ScriptIntProperty.Mask<bool> GetEqualsMask(
            IScriptIntPropertyGetter item,
            IScriptIntPropertyGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new ScriptIntProperty.Mask<bool>(false);
            ((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IScriptIntPropertyGetter item,
            IScriptIntPropertyGetter rhs,
            ScriptIntProperty.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.Data = item.Data == rhs.Data;
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IScriptIntPropertyGetter item,
            string? name = null,
            ScriptIntProperty.Mask<bool>? printMask = null)
        {
            var sb = new StructuredStringBuilder();
            Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
            return sb.ToString();
        }
        
        public void Print(
            IScriptIntPropertyGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            ScriptIntProperty.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"ScriptIntProperty =>");
            }
            else
            {
                sb.AppendLine($"{name} (ScriptIntProperty) =>");
            }
            using (sb.Brace())
            {
                ToStringFields(
                    item: item,
                    sb: sb,
                    printMask: printMask);
            }
        }
        
        protected static void ToStringFields(
            IScriptIntPropertyGetter item,
            StructuredStringBuilder sb,
            ScriptIntProperty.Mask<bool>? printMask = null)
        {
            ScriptPropertyCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.Data ?? true)
            {
                sb.AppendItem(item.Data, "Data");
            }
        }
        
        public static ScriptIntProperty_FieldIndex ConvertFieldIndex(ScriptProperty_FieldIndex index)
        {
            switch (index)
            {
                case ScriptProperty_FieldIndex.Name:
                    return (ScriptIntProperty_FieldIndex)((int)index);
                case ScriptProperty_FieldIndex.Flags:
                    return (ScriptIntProperty_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IScriptIntPropertyGetter? lhs,
            IScriptIntPropertyGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IScriptPropertyGetter)lhs, (IScriptPropertyGetter)rhs, equalsMask)) return false;
            if ((equalsMask?.GetShouldTranslate((int)ScriptIntProperty_FieldIndex.Data) ?? true))
            {
                if (lhs.Data != rhs.Data) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IScriptPropertyGetter? lhs,
            IScriptPropertyGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (IScriptIntPropertyGetter?)lhs,
                rhs: rhs as IScriptIntPropertyGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(IScriptIntPropertyGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Data);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IScriptPropertyGetter item)
        {
            return GetHashCode(item: (IScriptIntPropertyGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return ScriptIntProperty.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IScriptIntPropertyGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        #endregion
        
    }
    internal partial class ScriptIntPropertySetterTranslationCommon : ScriptPropertySetterTranslationCommon
    {
        public new static readonly ScriptIntPropertySetterTranslationCommon Instance = new ScriptIntPropertySetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IScriptIntProperty item,
            IScriptIntPropertyGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IScriptProperty)item,
                (IScriptPropertyGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)ScriptIntProperty_FieldIndex.Data) ?? true))
            {
                item.Data = rhs.Data;
            }
        }
        
        
        public override void DeepCopyIn(
            IScriptProperty item,
            IScriptPropertyGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IScriptIntProperty)item,
                rhs: (IScriptIntPropertyGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public ScriptIntProperty DeepCopy(
            IScriptIntPropertyGetter item,
            ScriptIntProperty.TranslationMask? copyMask = null)
        {
            ScriptIntProperty ret = (ScriptIntProperty)((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)item).CommonInstance()!).GetNew();
            ((ScriptIntPropertySetterTranslationCommon)((IScriptIntPropertyGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public ScriptIntProperty DeepCopy(
            IScriptIntPropertyGetter item,
            out ScriptIntProperty.ErrorMask errorMask,
            ScriptIntProperty.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ScriptIntProperty ret = (ScriptIntProperty)((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)item).CommonInstance()!).GetNew();
            ((ScriptIntPropertySetterTranslationCommon)((IScriptIntPropertyGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = ScriptIntProperty.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public ScriptIntProperty DeepCopy(
            IScriptIntPropertyGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            ScriptIntProperty ret = (ScriptIntProperty)((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)item).CommonInstance()!).GetNew();
            ((ScriptIntPropertySetterTranslationCommon)((IScriptIntPropertyGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: true);
            return ret;
        }
        
    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    public partial class ScriptIntProperty
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ScriptIntProperty_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => ScriptIntProperty_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => ScriptIntPropertyCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return ScriptIntPropertySetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => ScriptIntPropertySetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim
{
    public partial class ScriptIntPropertyBinaryWriteTranslation :
        ScriptPropertyBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly ScriptIntPropertyBinaryWriteTranslation Instance = new();

        public static void WriteEmbedded(
            IScriptIntPropertyGetter item,
            MutagenWriter writer)
        {
            ScriptPropertyBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
            writer.Write(item.Data);
        }

        public void Write(
            MutagenWriter writer,
            IScriptIntPropertyGetter item,
            TypedWriteParams translationParams)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IScriptIntPropertyGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IScriptPropertyGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (IScriptIntPropertyGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class ScriptIntPropertyBinaryCreateTranslation : ScriptPropertyBinaryCreateTranslation
    {
        public new static readonly ScriptIntPropertyBinaryCreateTranslation Instance = new ScriptIntPropertyBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IScriptIntProperty item,
            MutagenFrame frame)
        {
            ScriptPropertyBinaryCreateTranslation.FillBinaryStructs(
                item: item,
                frame: frame);
            item.Data = frame.ReadInt32();
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class ScriptIntPropertyBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim
{
    internal partial class ScriptIntPropertyBinaryOverlay :
        ScriptPropertyBinaryOverlay,
        IScriptIntPropertyGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ScriptIntProperty_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => ScriptIntProperty_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => ScriptIntPropertyCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => ScriptIntPropertySetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => ScriptIntPropertyBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((ScriptIntPropertyBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public Int32 Data => BinaryPrimitives.ReadInt32LittleEndian(_structData.Slice(0x0, 0x4));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected ScriptIntPropertyBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IScriptIntPropertyGetter ScriptIntPropertyFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                length: 0x4,
                memoryPair: out var memoryPair,
                offset: out var offset);
            var ret = new ScriptIntPropertyBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            stream.Position += 0x4;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IScriptIntPropertyGetter ScriptIntPropertyFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return ScriptIntPropertyFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            ScriptIntPropertyMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IScriptIntPropertyGetter rhs) return false;
            return ((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IScriptIntPropertyGetter? obj)
        {
            return ((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((ScriptIntPropertyCommon)((IScriptIntPropertyGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

