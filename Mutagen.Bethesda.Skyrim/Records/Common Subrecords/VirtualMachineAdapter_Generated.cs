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
    public partial class VirtualMachineAdapter :
        AVirtualMachineAdapter,
        IEquatable<IVirtualMachineAdapterGetter>,
        ILoquiObjectSetter<VirtualMachineAdapter>,
        IVirtualMachineAdapter
    {
        #region Ctor
        public VirtualMachineAdapter()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            VirtualMachineAdapterMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IVirtualMachineAdapterGetter rhs) return false;
            return ((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IVirtualMachineAdapterGetter? obj)
        {
            return ((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            AVirtualMachineAdapter.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
            }

            public Mask(
                TItem Version,
                TItem ObjectFormat,
                TItem Scripts)
            : base(
                Version: Version,
                ObjectFormat: ObjectFormat,
                Scripts: Scripts)
            {
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

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
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new VirtualMachineAdapter.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(VirtualMachineAdapter.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, VirtualMachineAdapter.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(VirtualMachineAdapter.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                }
            }
            #endregion

        }

        public new class ErrorMask :
            AVirtualMachineAdapter.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                VirtualMachineAdapter_FieldIndex enu = (VirtualMachineAdapter_FieldIndex)index;
                switch (enu)
                {
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                VirtualMachineAdapter_FieldIndex enu = (VirtualMachineAdapter_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                VirtualMachineAdapter_FieldIndex enu = (VirtualMachineAdapter_FieldIndex)index;
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
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
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
            AVirtualMachineAdapter.TranslationMask,
            ITranslationMask
        {
            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
            }

            #endregion

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public override IEnumerable<IFormLinkGetter> EnumerateFormLinks() => VirtualMachineAdapterCommon.Instance.EnumerateFormLinks(this);
        public override void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => VirtualMachineAdapterSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => VirtualMachineAdapterBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((VirtualMachineAdapterBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static VirtualMachineAdapter CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new VirtualMachineAdapter();
            ((VirtualMachineAdapterSetterCommon)((IVirtualMachineAdapterGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out VirtualMachineAdapter item,
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
            ((VirtualMachineAdapterSetterCommon)((IVirtualMachineAdapterGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new VirtualMachineAdapter GetNew()
        {
            return new VirtualMachineAdapter();
        }

    }
    #endregion

    #region Interface
    public partial interface IVirtualMachineAdapter :
        IAVirtualMachineAdapter,
        ILoquiObjectSetter<IVirtualMachineAdapter>,
        IVirtualMachineAdapterGetter
    {
    }

    public partial interface IVirtualMachineAdapterGetter :
        IAVirtualMachineAdapterGetter,
        IBinaryItem,
        ILoquiObject<IVirtualMachineAdapterGetter>
    {
        static new ILoquiRegistration StaticRegistration => VirtualMachineAdapter_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class VirtualMachineAdapterMixIn
    {
        public static void Clear(this IVirtualMachineAdapter item)
        {
            ((VirtualMachineAdapterSetterCommon)((IVirtualMachineAdapterGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static VirtualMachineAdapter.Mask<bool> GetEqualsMask(
            this IVirtualMachineAdapterGetter item,
            IVirtualMachineAdapterGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IVirtualMachineAdapterGetter item,
            string? name = null,
            VirtualMachineAdapter.Mask<bool>? printMask = null)
        {
            return ((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IVirtualMachineAdapterGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            VirtualMachineAdapter.Mask<bool>? printMask = null)
        {
            ((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IVirtualMachineAdapterGetter item,
            IVirtualMachineAdapterGetter rhs,
            VirtualMachineAdapter.TranslationMask? equalsMask = null)
        {
            return ((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IVirtualMachineAdapter lhs,
            IVirtualMachineAdapterGetter rhs,
            out VirtualMachineAdapter.ErrorMask errorMask,
            VirtualMachineAdapter.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((VirtualMachineAdapterSetterTranslationCommon)((IVirtualMachineAdapterGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = VirtualMachineAdapter.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IVirtualMachineAdapter lhs,
            IVirtualMachineAdapterGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((VirtualMachineAdapterSetterTranslationCommon)((IVirtualMachineAdapterGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static VirtualMachineAdapter DeepCopy(
            this IVirtualMachineAdapterGetter item,
            VirtualMachineAdapter.TranslationMask? copyMask = null)
        {
            return ((VirtualMachineAdapterSetterTranslationCommon)((IVirtualMachineAdapterGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static VirtualMachineAdapter DeepCopy(
            this IVirtualMachineAdapterGetter item,
            out VirtualMachineAdapter.ErrorMask errorMask,
            VirtualMachineAdapter.TranslationMask? copyMask = null)
        {
            return ((VirtualMachineAdapterSetterTranslationCommon)((IVirtualMachineAdapterGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static VirtualMachineAdapter DeepCopy(
            this IVirtualMachineAdapterGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((VirtualMachineAdapterSetterTranslationCommon)((IVirtualMachineAdapterGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IVirtualMachineAdapter item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((VirtualMachineAdapterSetterCommon)((IVirtualMachineAdapterGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    internal enum VirtualMachineAdapter_FieldIndex
    {
        Version = 0,
        ObjectFormat = 1,
        Scripts = 2,
    }
    #endregion

    #region Registration
    internal partial class VirtualMachineAdapter_Registration : ILoquiRegistration
    {
        public static readonly VirtualMachineAdapter_Registration Instance = new VirtualMachineAdapter_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 355,
            version: 0);

        public const string GUID = "4780aba9-4c81-4f2d-9508-6373ee5a87ec";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 3;

        public static readonly Type MaskType = typeof(VirtualMachineAdapter.Mask<>);

        public static readonly Type ErrorMaskType = typeof(VirtualMachineAdapter.ErrorMask);

        public static readonly Type ClassType = typeof(VirtualMachineAdapter);

        public static readonly Type GetterType = typeof(IVirtualMachineAdapterGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IVirtualMachineAdapter);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.VirtualMachineAdapter";

        public const string Name = "VirtualMachineAdapter";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly RecordType TriggeringRecordType = RecordTypes.VMAD;
        public static RecordTriggerSpecs TriggerSpecs => _recordSpecs.Value;
        private static readonly Lazy<RecordTriggerSpecs> _recordSpecs = new Lazy<RecordTriggerSpecs>(() =>
        {
            var all = RecordCollection.Factory(RecordTypes.VMAD);
            return new RecordTriggerSpecs(allRecordTypes: all);
        });
        public static readonly Type BinaryWriteTranslation = typeof(VirtualMachineAdapterBinaryWriteTranslation);
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
    internal partial class VirtualMachineAdapterSetterCommon : AVirtualMachineAdapterSetterCommon
    {
        public new static readonly VirtualMachineAdapterSetterCommon Instance = new VirtualMachineAdapterSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IVirtualMachineAdapter item)
        {
            ClearPartial();
            base.Clear(item);
        }
        
        public override void Clear(IAVirtualMachineAdapter item)
        {
            Clear(item: (IVirtualMachineAdapter)item);
        }
        
        #region Mutagen
        public void RemapLinks(IVirtualMachineAdapter obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IVirtualMachineAdapter item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            frame = frame.SpawnWithFinalPosition(HeaderTranslation.ParseSubrecord(
                frame.Reader,
                translationParams.ConvertToCustom(RecordTypes.VMAD),
                translationParams.LengthOverride));
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: VirtualMachineAdapterBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IAVirtualMachineAdapter item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (VirtualMachineAdapter)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class VirtualMachineAdapterCommon : AVirtualMachineAdapterCommon
    {
        public new static readonly VirtualMachineAdapterCommon Instance = new VirtualMachineAdapterCommon();

        public VirtualMachineAdapter.Mask<bool> GetEqualsMask(
            IVirtualMachineAdapterGetter item,
            IVirtualMachineAdapterGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new VirtualMachineAdapter.Mask<bool>(false);
            ((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IVirtualMachineAdapterGetter item,
            IVirtualMachineAdapterGetter rhs,
            VirtualMachineAdapter.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IVirtualMachineAdapterGetter item,
            string? name = null,
            VirtualMachineAdapter.Mask<bool>? printMask = null)
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
            IVirtualMachineAdapterGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            VirtualMachineAdapter.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"VirtualMachineAdapter =>");
            }
            else
            {
                sb.AppendLine($"{name} (VirtualMachineAdapter) =>");
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
            IVirtualMachineAdapterGetter item,
            StructuredStringBuilder sb,
            VirtualMachineAdapter.Mask<bool>? printMask = null)
        {
            AVirtualMachineAdapterCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
        }
        
        public static VirtualMachineAdapter_FieldIndex ConvertFieldIndex(AVirtualMachineAdapter_FieldIndex index)
        {
            switch (index)
            {
                case AVirtualMachineAdapter_FieldIndex.Version:
                    return (VirtualMachineAdapter_FieldIndex)((int)index);
                case AVirtualMachineAdapter_FieldIndex.ObjectFormat:
                    return (VirtualMachineAdapter_FieldIndex)((int)index);
                case AVirtualMachineAdapter_FieldIndex.Scripts:
                    return (VirtualMachineAdapter_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IVirtualMachineAdapterGetter? lhs,
            IVirtualMachineAdapterGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IAVirtualMachineAdapterGetter)lhs, (IAVirtualMachineAdapterGetter)rhs, crystal)) return false;
            return true;
        }
        
        public override bool Equals(
            IAVirtualMachineAdapterGetter? lhs,
            IAVirtualMachineAdapterGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (IVirtualMachineAdapterGetter?)lhs,
                rhs: rhs as IVirtualMachineAdapterGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(IVirtualMachineAdapterGetter item)
        {
            var hash = new HashCode();
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IAVirtualMachineAdapterGetter item)
        {
            return GetHashCode(item: (IVirtualMachineAdapterGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return VirtualMachineAdapter.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IVirtualMachineAdapterGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        #endregion
        
    }
    internal partial class VirtualMachineAdapterSetterTranslationCommon : AVirtualMachineAdapterSetterTranslationCommon
    {
        public new static readonly VirtualMachineAdapterSetterTranslationCommon Instance = new VirtualMachineAdapterSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IVirtualMachineAdapter item,
            IVirtualMachineAdapterGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IAVirtualMachineAdapter)item,
                (IAVirtualMachineAdapterGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
        }
        
        
        public override void DeepCopyIn(
            IAVirtualMachineAdapter item,
            IAVirtualMachineAdapterGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IVirtualMachineAdapter)item,
                rhs: (IVirtualMachineAdapterGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public VirtualMachineAdapter DeepCopy(
            IVirtualMachineAdapterGetter item,
            VirtualMachineAdapter.TranslationMask? copyMask = null)
        {
            VirtualMachineAdapter ret = (VirtualMachineAdapter)((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)item).CommonInstance()!).GetNew();
            ((VirtualMachineAdapterSetterTranslationCommon)((IVirtualMachineAdapterGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public VirtualMachineAdapter DeepCopy(
            IVirtualMachineAdapterGetter item,
            out VirtualMachineAdapter.ErrorMask errorMask,
            VirtualMachineAdapter.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            VirtualMachineAdapter ret = (VirtualMachineAdapter)((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)item).CommonInstance()!).GetNew();
            ((VirtualMachineAdapterSetterTranslationCommon)((IVirtualMachineAdapterGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = VirtualMachineAdapter.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public VirtualMachineAdapter DeepCopy(
            IVirtualMachineAdapterGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            VirtualMachineAdapter ret = (VirtualMachineAdapter)((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)item).CommonInstance()!).GetNew();
            ((VirtualMachineAdapterSetterTranslationCommon)((IVirtualMachineAdapterGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class VirtualMachineAdapter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => VirtualMachineAdapter_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => VirtualMachineAdapter_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => VirtualMachineAdapterCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return VirtualMachineAdapterSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => VirtualMachineAdapterSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim
{
    public partial class VirtualMachineAdapterBinaryWriteTranslation :
        AVirtualMachineAdapterBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly VirtualMachineAdapterBinaryWriteTranslation Instance = new();

        public void Write(
            MutagenWriter writer,
            IVirtualMachineAdapterGetter item,
            TypedWriteParams translationParams)
        {
            using (HeaderExport.Subrecord(
                writer: writer,
                record: translationParams.ConvertToCustom(RecordTypes.VMAD),
                overflowRecord: translationParams.OverflowRecordType,
                out var writerToUse))
            {
                AVirtualMachineAdapterBinaryWriteTranslation.WriteEmbedded(
                    item: item,
                    writer: writerToUse);
            }
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IVirtualMachineAdapterGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IAVirtualMachineAdapterGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (IVirtualMachineAdapterGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class VirtualMachineAdapterBinaryCreateTranslation : AVirtualMachineAdapterBinaryCreateTranslation
    {
        public new static readonly VirtualMachineAdapterBinaryCreateTranslation Instance = new VirtualMachineAdapterBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class VirtualMachineAdapterBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim
{
    internal partial class VirtualMachineAdapterBinaryOverlay :
        AVirtualMachineAdapterBinaryOverlay,
        IVirtualMachineAdapterGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => VirtualMachineAdapter_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => VirtualMachineAdapter_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => VirtualMachineAdapterCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => VirtualMachineAdapterSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => VirtualMachineAdapterBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((VirtualMachineAdapterBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected VirtualMachineAdapterBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IVirtualMachineAdapterGetter VirtualMachineAdapterFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                memoryPair: out var memoryPair,
                offset: out var offset,
                finalPos: out var finalPos);
            var ret = new VirtualMachineAdapterBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            stream.Position += 0x0 + package.MetaData.Constants.SubConstants.HeaderLength;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IVirtualMachineAdapterGetter VirtualMachineAdapterFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return VirtualMachineAdapterFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            VirtualMachineAdapterMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IVirtualMachineAdapterGetter rhs) return false;
            return ((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IVirtualMachineAdapterGetter? obj)
        {
            return ((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((VirtualMachineAdapterCommon)((IVirtualMachineAdapterGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

