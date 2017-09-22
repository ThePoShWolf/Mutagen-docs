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
using Mutagen.Internals;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using Noggog.Xml;
using Loqui.Xml;
using Mutagen.Binary;

namespace Mutagen
{
    #region Class
    public abstract partial class GameSetting : MajorRecord, IGameSetting, ILoquiObjectSetter, IEquatable<GameSetting>
    {
        ILoquiRegistration ILoquiObject.Registration => GameSetting_Registration.Instance;
        public new static GameSetting_Registration Registration => GameSetting_Registration.Instance;

        #region Ctor
        public GameSetting()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region GenericData
        protected readonly INotifyingItem<Object> _GenericData = new NotifyingItemConvertWrapper<Object>(
            (change) => TryGet<Object>.Succeed(WildcardLink.Validate(change.New)),
            default(Object),
            markAsSet: false
        );
        public INotifyingItemGetter<Object> GenericData_Property => _GenericData;
        public Object GenericData { get => _GenericData.Item; protected set => _GenericData.Item = value; }
        INotifyingItemGetter<Object> IGameSettingGetter.GenericData_Property => this.GenericData_Property;
        #endregion

        #region Loqui Getter Interface

        protected override object GetNthObject(ushort index) => GameSettingCommon.GetNthObject(index, this);

        protected override bool GetNthObjectHasBeenSet(ushort index) => GameSettingCommon.GetNthObjectHasBeenSet(index, this);

        protected override void UnsetNthObject(ushort index, NotifyingUnsetParameters? cmds) => GameSettingCommon.UnsetNthObject(index, this, cmds);

        #endregion

        #region Loqui Interface
        protected override void SetNthObjectHasBeenSet(ushort index, bool on)
        {
            GameSettingCommon.SetNthObjectHasBeenSet(index, on, this);
        }

        #endregion

        #region To String
        public override string ToString()
        {
            return GameSettingCommon.ToString(this, printMask: null);
        }

        public string ToString(
            string name = null,
            GameSetting_Mask<bool> printMask = null)
        {
            return GameSettingCommon.ToString(this, name: name, printMask: printMask);
        }

        public override void ToString(
            FileGeneration fg,
            string name = null)
        {
            GameSettingCommon.ToString(this, fg, name: name, printMask: null);
        }

        #endregion

        public new GameSetting_Mask<bool> GetHasBeenSetMask()
        {
            return GameSettingCommon.GetHasBeenSetMask(this);
        }
        #region Equals and Hash
        public override bool Equals(object obj)
        {
            if (!(obj is GameSetting rhs)) return false;
            return Equals(rhs);
        }

        public bool Equals(GameSetting rhs)
        {
            if (rhs == null) return false;
            if (!base.Equals(rhs)) return false;
            if (GenericData_Property.HasBeenSet != rhs.GenericData_Property.HasBeenSet) return false;
            if (GenericData_Property.HasBeenSet)
            {
                if (!object.Equals(GenericData, rhs.GenericData)) return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            int ret = 0;
            if (GenericData_Property.HasBeenSet)
            {
                ret = HashHelper.GetHashCode(GenericData).CombineHashCode(ret);
            }
            ret = ret.CombineHashCode(base.GetHashCode());
            return ret;
        }

        #endregion


        #region XML Translation
        #region XML Copy In
        public override void CopyIn_XML(
            XElement root,
            NotifyingFireParameters? cmds = null)
        {
            LoquiXmlTranslation<GameSetting, GameSetting_ErrorMask>.Instance.CopyIn(
                root: root,
                item: this,
                skipProtected: true,
                doMasks: false,
                mask: out GameSetting_ErrorMask errorMask,
                cmds: cmds);
        }

        public virtual void CopyIn_XML(
            XElement root,
            out GameSetting_ErrorMask errorMask,
            NotifyingFireParameters? cmds = null)
        {
            LoquiXmlTranslation<GameSetting, GameSetting_ErrorMask>.Instance.CopyIn(
                root: root,
                item: this,
                skipProtected: true,
                doMasks: true,
                mask: out errorMask,
                cmds: cmds);
        }

        public void CopyIn_XML(
            string path,
            NotifyingFireParameters? cmds = null)
        {
            var root = XDocument.Load(path).Root;
            this.CopyIn_XML(
                root: root,
                cmds: cmds);
        }

        public void CopyIn_XML(
            string path,
            out GameSetting_ErrorMask errorMask,
            NotifyingFireParameters? cmds = null)
        {
            var root = XDocument.Load(path).Root;
            this.CopyIn_XML(
                root: root,
                errorMask: out errorMask,
                cmds: cmds);
        }

        public void CopyIn_XML(
            Stream stream,
            NotifyingFireParameters? cmds = null)
        {
            var root = XDocument.Load(stream).Root;
            this.CopyIn_XML(
                root: root,
                cmds: cmds);
        }

        public void CopyIn_XML(
            Stream stream,
            out GameSetting_ErrorMask errorMask,
            NotifyingFireParameters? cmds = null)
        {
            var root = XDocument.Load(stream).Root;
            this.CopyIn_XML(
                root: root,
                errorMask: out errorMask,
                cmds: cmds);
        }

        public override void CopyIn_XML(
            XElement root,
            out MajorRecord_ErrorMask errorMask,
            NotifyingFireParameters? cmds = null)
        {
            this.CopyIn_XML(
                root: root,
                errorMask: out GameSetting_ErrorMask errMask,
                cmds: cmds);
            errorMask = errMask;
        }

        #endregion

        #region XML Write
        public virtual void Write_XML(
            XmlWriter writer,
            out GameSetting_ErrorMask errorMask,
            string name = null)
        {
            GameSettingCommon.Write_XML(
                writer: writer,
                name: name,
                item: this,
                doMasks: true,
                errorMask: out errorMask);
        }

        public virtual void Write_XML(
            string path,
            out GameSetting_ErrorMask errorMask,
            string name = null)
        {
            using (var writer = new XmlTextWriter(path, Encoding.ASCII))
            {
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 3;
                Write_XML(
                    writer: writer,
                    name: name,
                    errorMask: out errorMask);
            }
        }

        public virtual void Write_XML(
            Stream stream,
            out GameSetting_ErrorMask errorMask,
            string name = null)
        {
            using (var writer = new XmlTextWriter(stream, Encoding.ASCII))
            {
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 3;
                Write_XML(
                    writer: writer,
                    name: name,
                    errorMask: out errorMask);
            }
        }

        #endregion

        protected static void Fill_XML_Internal(
            GameSetting item,
            XElement root,
            string name,
            bool doMasks,
            Func<GameSetting_ErrorMask> errorMask)
        {
            switch (name)
            {
                case "GenericData":
                    {
                        object subMask;
                        var tryGet = WildcardXmlTranslation.Instance.Parse(
                            root: root,
                            doMasks: doMasks,
                            maskObj: out subMask);
                        item._GenericData.SetIfSucceeded(tryGet.Bubble<Object>(i => (Object)i));
                        if (doMasks && subMask != null)
                        {
                            errorMask().GenericData = subMask;
                        }
                    }
                    break;
                default:
                    MajorRecord.Fill_XML_Internal(
                        item: item,
                        root: root,
                        name: name,
                        doMasks: doMasks,
                        errorMask: errorMask);
                    break;
            }
        }

        #endregion

        #region Binary Translation
        #region Binary Copy In
        public override void CopyIn_Binary(
            BinaryReader reader,
            NotifyingFireParameters? cmds = null)
        {
            LoquiBinaryTranslation<GameSetting, GameSetting_ErrorMask>.Instance.CopyIn(
                reader: reader,
                item: this,
                skipProtected: true,
                doMasks: false,
                mask: out GameSetting_ErrorMask errorMask,
                cmds: cmds);
        }

        public virtual void CopyIn_Binary(
            BinaryReader reader,
            out GameSetting_ErrorMask errorMask,
            NotifyingFireParameters? cmds = null)
        {
            LoquiBinaryTranslation<GameSetting, GameSetting_ErrorMask>.Instance.CopyIn(
                reader: reader,
                item: this,
                skipProtected: true,
                doMasks: true,
                mask: out errorMask,
                cmds: cmds);
        }

        public void CopyIn_Binary(
            string path,
            NotifyingFireParameters? cmds = null)
        {
            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(fileStream))
                {
                    this.CopyIn_Binary(
                        reader: reader,
                        cmds: cmds);
                }
            }
        }

        public void CopyIn_Binary(
            string path,
            out GameSetting_ErrorMask errorMask,
            NotifyingFireParameters? cmds = null)
        {
            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(fileStream))
                {
                    this.CopyIn_Binary(
                        reader: reader,
                        errorMask: out errorMask,
                        cmds: cmds);
                }
            }
        }

        public void CopyIn_Binary(
            Stream stream,
            NotifyingFireParameters? cmds = null)
        {
            using (var reader = new BinaryReader(stream))
            {
                this.CopyIn_Binary(
                    reader: reader,
                    cmds: cmds);
            }
        }

        public void CopyIn_Binary(
            Stream stream,
            out GameSetting_ErrorMask errorMask,
            NotifyingFireParameters? cmds = null)
        {
            using (var reader = new BinaryReader(stream))
            {
                this.CopyIn_Binary(
                    reader: reader,
                    errorMask: out errorMask,
                    cmds: cmds);
            }
        }

        public override void CopyIn_Binary(
            BinaryReader reader,
            out MajorRecord_ErrorMask errorMask,
            NotifyingFireParameters? cmds = null)
        {
            this.CopyIn_Binary(
                reader: reader,
                errorMask: out GameSetting_ErrorMask errMask,
                cmds: cmds);
            errorMask = errMask;
        }

        #endregion

        #region Binary Write
        public virtual void Write_Binary(
            BinaryWriter writer,
            out GameSetting_ErrorMask errorMask)
        {
            GameSettingCommon.Write_Binary(
                writer: writer,
                item: this,
                doMasks: true,
                errorMask: out errorMask);
        }

        public virtual void Write_Binary(
            string path,
            out GameSetting_ErrorMask errorMask)
        {
            using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new BinaryWriter(fileStream))
                {
                    Write_Binary(
                        writer: writer,
                        errorMask: out errorMask);
                }
            }
        }

        public virtual void Write_Binary(
            Stream stream,
            out GameSetting_ErrorMask errorMask)
        {
            using (var writer = new BinaryWriter(stream))
            {
                Write_Binary(
                    writer: writer,
                    errorMask: out errorMask);
            }
        }

        #endregion

        protected static void Fill_Binary(
            GameSetting item,
            BinaryReader reader,
            bool doMasks,
            Func<GameSetting_ErrorMask> errorMask)
        {
            MajorRecord.Fill_Binary(
                item: item,
                reader: reader,
                doMasks: doMasks,
                errorMask: errorMask);
        }

        #endregion

        protected override void SetNthObject(ushort index, object obj, NotifyingFireParameters? cmds = null)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    throw new ArgumentException($"Tried to set at a derivative index {index}");
                default:
                    base.SetNthObject(index, obj, cmds);
                    break;
            }
        }

        public override void Clear(NotifyingUnsetParameters? cmds = null)
        {
            CallClearPartial_Internal(cmds);
            GameSettingCommon.Clear(this, cmds);
        }


        protected new static void CopyInInternal_GameSetting(GameSetting obj, KeyValuePair<ushort, object> pair)
        {
            if (!EnumExt.TryParse(pair.Key, out GameSetting_FieldIndex enu))
            {
                CopyInInternal_MajorRecord(obj, pair);
            }
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Unknown enum type: {enu}");
            }
        }
        public static void CopyIn(IEnumerable<KeyValuePair<ushort, object>> fields, GameSetting obj)
        {
            ILoquiObjectExt.CopyFieldsIn(obj, fields, def: null, skipProtected: false, cmds: null);
        }

    }
    #endregion

    #region Interface
    public interface IGameSetting : IGameSettingGetter, IMajorRecord, ILoquiClass<IGameSetting, IGameSettingGetter>, ILoquiClass<GameSetting, IGameSettingGetter>
    {
    }

    public interface IGameSettingGetter : IMajorRecordGetter
    {
        #region GenericData
        Object GenericData { get; }
        INotifyingItemGetter<Object> GenericData_Property { get; }

        #endregion

    }

    #endregion

}

namespace Mutagen.Internals
{
    #region Field Index
    public enum GameSetting_FieldIndex
    {
        GenericData = 5,
    }
    #endregion

    #region Registration
    public class GameSetting_Registration : ILoquiRegistration
    {
        public static readonly GameSetting_Registration Instance = new GameSetting_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Mutagen.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Mutagen.ProtocolKey,
            msgID: 7,
            version: 0);

        public const string GUID = "6ce31534-6f55-4575-a914-20e70476f6ad";

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(GameSetting_Mask<>);

        public static readonly Type ErrorMaskType = typeof(GameSetting_ErrorMask);

        public static readonly Type ClassType = typeof(GameSetting);

        public static readonly Type GetterType = typeof(IGameSettingGetter);

        public static readonly Type SetterType = typeof(IGameSetting);

        public static readonly Type CommonType = typeof(GameSettingCommon);

        public const string FullName = "Mutagen.GameSetting";

        public const string Name = "GameSetting";

        public const string Namespace = "Mutagen";

        public const byte GenericCount = 0;

        public static readonly Type GenericRegistrationType = null;

        public static ushort? GetNameIndex(StringCaseAgnostic str)
        {
            switch (str.Upper)
            {
                case "GENERICDATA":
                    return (ushort)GameSetting_FieldIndex.GenericData;
                default:
                    return null;
            }
        }

        public static bool GetNthIsEnumerable(ushort index)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    return false;
                default:
                    return MajorRecord_Registration.GetNthIsEnumerable(index);
            }
        }

        public static bool GetNthIsLoqui(ushort index)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    return false;
                default:
                    return MajorRecord_Registration.GetNthIsLoqui(index);
            }
        }

        public static bool GetNthIsSingleton(ushort index)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    return false;
                default:
                    return MajorRecord_Registration.GetNthIsSingleton(index);
            }
        }

        public static string GetNthName(ushort index)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    return "GenericData";
                default:
                    return MajorRecord_Registration.GetNthName(index);
            }
        }

        public static bool IsNthDerivative(ushort index)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    return true;
                default:
                    return MajorRecord_Registration.IsNthDerivative(index);
            }
        }

        public static bool IsProtected(ushort index)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    return true;
                default:
                    return MajorRecord_Registration.IsProtected(index);
            }
        }

        public static Type GetNthType(ushort index)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    return typeof(Object);
                default:
                    return MajorRecord_Registration.GetNthType(index);
            }
        }

        public static readonly RecordType GMST_HEADER = new RecordType("GMST");
        public static readonly RecordType TRIGGERING_RECORD_TYPE = GMST_HEADER;
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
        ObjectKey ILoquiRegistration.ObjectKey => ObjectKey;
        string ILoquiRegistration.GUID => GUID;
        int ILoquiRegistration.FieldCount => FieldCount;
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
    public static class GameSettingCommon
    {
        #region Copy Fields From
        public static void CopyFieldsFrom(
            this IGameSetting item,
            IGameSettingGetter rhs,
            GameSetting_CopyMask copyMask = null,
            IGameSettingGetter def = null,
            NotifyingFireParameters? cmds = null)
        {
            GameSettingCommon.CopyFieldsFrom(
                item: item,
                rhs: rhs,
                def: def,
                doErrorMask: false,
                errorMask: null,
                copyMask: copyMask,
                cmds: cmds);
        }

        public static void CopyFieldsFrom(
            this IGameSetting item,
            IGameSettingGetter rhs,
            out GameSetting_ErrorMask errorMask,
            GameSetting_CopyMask copyMask = null,
            IGameSettingGetter def = null,
            NotifyingFireParameters? cmds = null)
        {
            GameSettingCommon.CopyFieldsFrom(
                item: item,
                rhs: rhs,
                def: def,
                doErrorMask: true,
                errorMask: out errorMask,
                copyMask: copyMask,
                cmds: cmds);
        }

        public static void CopyFieldsFrom(
            this IGameSetting item,
            IGameSettingGetter rhs,
            IGameSettingGetter def,
            bool doErrorMask,
            out GameSetting_ErrorMask errorMask,
            GameSetting_CopyMask copyMask,
            NotifyingFireParameters? cmds)
        {
            GameSetting_ErrorMask retErrorMask = null;
            Func<GameSetting_ErrorMask> maskGetter = () =>
            {
                if (retErrorMask == null)
                {
                    retErrorMask = new GameSetting_ErrorMask();
                }
                return retErrorMask;
            };
            CopyFieldsFrom(
                item: item,
                rhs: rhs,
                def: def,
                doErrorMask: true,
                errorMask: maskGetter,
                copyMask: copyMask,
                cmds: cmds);
            errorMask = retErrorMask;
        }

        public static void CopyFieldsFrom(
            this IGameSetting item,
            IGameSettingGetter rhs,
            IGameSettingGetter def,
            bool doErrorMask,
            Func<GameSetting_ErrorMask> errorMask,
            GameSetting_CopyMask copyMask,
            NotifyingFireParameters? cmds)
        {
            MajorRecordCommon.CopyFieldsFrom(
                item,
                rhs,
                def,
                doErrorMask,
                errorMask,
                copyMask,
                cmds);
        }

        #endregion

        public static void SetNthObjectHasBeenSet(
            ushort index,
            bool on,
            IGameSetting obj,
            NotifyingFireParameters? cmds = null)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    throw new ArgumentException($"Tried to set at a derivative index {index}");
                default:
                    MajorRecordCommon.SetNthObjectHasBeenSet(index, on, obj);
                    break;
            }
        }

        public static void UnsetNthObject(
            ushort index,
            IGameSetting obj,
            NotifyingUnsetParameters? cmds = null)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    throw new ArgumentException($"Tried to unset at a derivative index {index}");
                default:
                    MajorRecordCommon.UnsetNthObject(index, obj);
                    break;
            }
        }

        public static bool GetNthObjectHasBeenSet(
            ushort index,
            IGameSetting obj)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    return obj.GenericData_Property.HasBeenSet;
                default:
                    return MajorRecordCommon.GetNthObjectHasBeenSet(index, obj);
            }
        }

        public static object GetNthObject(
            ushort index,
            IGameSettingGetter obj)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    return obj.GenericData;
                default:
                    return MajorRecordCommon.GetNthObject(index, obj);
            }
        }

        public static void Clear(
            IGameSetting item,
            NotifyingUnsetParameters? cmds = null)
        {
        }

        public static GameSetting_Mask<bool> GetEqualsMask(
            this IGameSettingGetter item,
            IGameSettingGetter rhs)
        {
            var ret = new GameSetting_Mask<bool>();
            FillEqualsMask(item, rhs, ret);
            return ret;
        }

        public static void FillEqualsMask(
            IGameSettingGetter item,
            IGameSettingGetter rhs,
            GameSetting_Mask<bool> ret)
        {
            if (rhs == null) return;
            ret.GenericData = item.GenericData_Property.Equals(rhs.GenericData_Property, (l, r) => object.Equals(l, r));
            MajorRecordCommon.FillEqualsMask(item, rhs, ret);
        }

        public static string ToString(
            this IGameSettingGetter item,
            string name = null,
            GameSetting_Mask<bool> printMask = null)
        {
            var fg = new FileGeneration();
            item.ToString(fg, name, printMask);
            return fg.ToString();
        }

        public static void ToString(
            this IGameSettingGetter item,
            FileGeneration fg,
            string name = null,
            GameSetting_Mask<bool> printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"{nameof(GameSetting)} =>");
            }
            else
            {
                fg.AppendLine($"{name} ({nameof(GameSetting)}) =>");
            }
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
                if (printMask?.GenericData ?? true)
                {
                    fg.AppendLine($"GenericData => {item.GenericData}");
                }
            }
            fg.AppendLine("]");
        }

        public static bool HasBeenSet(
            this IGameSettingGetter item,
            GameSetting_Mask<bool?> checkMask)
        {
            if (checkMask.GenericData.HasValue && checkMask.GenericData.Value != item.GenericData_Property.HasBeenSet) return false;
            return true;
        }

        public static GameSetting_Mask<bool> GetHasBeenSetMask(IGameSettingGetter item)
        {
            var ret = new GameSetting_Mask<bool>();
            ret.GenericData = item.GenericData_Property.HasBeenSet;
            return ret;
        }

        #region XML Translation
        #region XML Write
        public static void Write_XML(
            XmlWriter writer,
            IGameSettingGetter item,
            bool doMasks,
            out GameSetting_ErrorMask errorMask,
            string name = null)
        {
            GameSetting_ErrorMask errMaskRet = null;
            Write_XML_Internal(
                writer: writer,
                name: name,
                item: item,
                doMasks: doMasks,
                errorMask: doMasks ? () => errMaskRet ?? (errMaskRet = new GameSetting_ErrorMask()) : default(Func<GameSetting_ErrorMask>));
            errorMask = errMaskRet;
        }

        private static void Write_XML_Internal(
            XmlWriter writer,
            IGameSettingGetter item,
            bool doMasks,
            Func<GameSetting_ErrorMask> errorMask,
            string name = null)
        {
            try
            {
                using (new ElementWrapper(writer, name ?? "Mutagen.GameSetting"))
                {
                    if (name != null)
                    {
                        writer.WriteAttributeString("type", "Mutagen.GameSetting");
                    }
                }
            }
            catch (Exception ex)
            when (doMasks)
            {
                errorMask().Overall = ex;
            }
        }
        #endregion

        #endregion

        #region Binary Translation
        #region Binary Write
        public static void Write_Binary(
            BinaryWriter writer,
            IGameSettingGetter item,
            bool doMasks,
            out GameSetting_ErrorMask errorMask)
        {
            GameSetting_ErrorMask errMaskRet = null;
            Write_Binary_Internal(
                writer: writer,
                item: item,
                doMasks: doMasks,
                errorMask: doMasks ? () => errMaskRet ?? (errMaskRet = new GameSetting_ErrorMask()) : default(Func<GameSetting_ErrorMask>));
            errorMask = errMaskRet;
        }

        private static void Write_Binary_Internal(
            BinaryWriter writer,
            IGameSettingGetter item,
            bool doMasks,
            Func<GameSetting_ErrorMask> errorMask)
        {
            try
            {
                using (HeaderExport.ExportHeader(
                    writer: writer,
                    record: GameSetting_Registration.GMST_HEADER,
                    type: ObjectType.Record))
                {
                    Write_Binary_Embedded(
                        item: item,
                        writer: writer,
                        doMasks: doMasks,
                        errorMask: errorMask);
                    MajorRecordCommon.Write_Binary_RecordTypes(
                        item: item,
                        writer: writer,
                        doMasks: doMasks,
                        errorMask: errorMask);
                }
            }
            catch (Exception ex)
            when (doMasks)
            {
                errorMask().Overall = ex;
            }
        }
        #endregion

        public static void Write_Binary_Embedded(
            IGameSettingGetter item,
            BinaryWriter writer,
            bool doMasks,
            Func<GameSetting_ErrorMask> errorMask)
        {
            MajorRecordCommon.Write_Binary_Embedded(
                item: item,
                writer: writer,
                doMasks: doMasks,
                errorMask: errorMask);
        }

        #endregion

    }
    #endregion

    #region Modules

    #region Mask
    public class GameSetting_Mask<T> : MajorRecord_Mask<T>, IMask<T>, IEquatable<GameSetting_Mask<T>>
    {
        #region Ctors
        public GameSetting_Mask()
        {
        }

        public GameSetting_Mask(T initialValue)
        {
            this.GenericData = initialValue;
        }
        #endregion

        #region Members
        public T GenericData;
        #endregion

        #region Equals
        public override bool Equals(object obj)
        {
            if (!(obj is GameSetting_Mask<T> rhs)) return false;
            return Equals(rhs);
        }

        public bool Equals(GameSetting_Mask<T> rhs)
        {
            if (rhs == null) return false;
            if (!base.Equals(rhs)) return false;
            if (!object.Equals(this.GenericData, rhs.GenericData)) return false;
            return true;
        }
        public override int GetHashCode()
        {
            int ret = 0;
            ret = ret.CombineHashCode(this.GenericData?.GetHashCode());
            ret = ret.CombineHashCode(base.GetHashCode());
            return ret;
        }

        #endregion

        #region All Equal
        public override bool AllEqual(Func<T, bool> eval)
        {
            if (!base.AllEqual(eval)) return false;
            if (!eval(this.GenericData)) return false;
            return true;
        }
        #endregion

        #region Translate
        public new GameSetting_Mask<R> Translate<R>(Func<T, R> eval)
        {
            var ret = new GameSetting_Mask<R>();
            this.Translate_InternalFill(ret, eval);
            return ret;
        }

        protected void Translate_InternalFill<R>(GameSetting_Mask<R> obj, Func<T, R> eval)
        {
            base.Translate_InternalFill(obj, eval);
            obj.GenericData = eval(this.GenericData);
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

        public string ToString(GameSetting_Mask<bool> printMask = null)
        {
            var fg = new FileGeneration();
            ToString(fg, printMask);
            return fg.ToString();
        }

        public void ToString(FileGeneration fg, GameSetting_Mask<bool> printMask = null)
        {
            fg.AppendLine($"{nameof(GameSetting_Mask<T>)} =>");
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
                if (printMask?.GenericData ?? true)
                {
                    fg.AppendLine($"GenericData => {GenericData.ToStringSafe()}");
                }
            }
            fg.AppendLine("]");
        }
        #endregion

    }

    public class GameSetting_ErrorMask : MajorRecord_ErrorMask
    {
        #region Members
        public object GenericData;
        #endregion

        #region IErrorMask
        public override void SetNthException(ushort index, Exception ex)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    this.GenericData = ex;
                    break;
                default:
                    base.SetNthException(index, ex);
                    break;
            }
        }

        public override void SetNthMask(ushort index, object obj)
        {
            GameSetting_FieldIndex enu = (GameSetting_FieldIndex)index;
            switch (enu)
            {
                case GameSetting_FieldIndex.GenericData:
                    this.GenericData = obj;
                    break;
                default:
                    base.SetNthMask(index, obj);
                    break;
            }
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
            fg.AppendLine("GameSetting_ErrorMask =>");
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
            if (GenericData != null)
            {
                fg.AppendLine($"GenericData => {GenericData.ToStringSafe()}");
            }
        }
        #endregion

        #region Combine
        public GameSetting_ErrorMask Combine(GameSetting_ErrorMask rhs)
        {
            var ret = new GameSetting_ErrorMask();
            ret.GenericData = this.GenericData ?? rhs.GenericData;
            return ret;
        }
        public static GameSetting_ErrorMask Combine(GameSetting_ErrorMask lhs, GameSetting_ErrorMask rhs)
        {
            if (lhs != null && rhs != null) return lhs.Combine(rhs);
            return lhs ?? rhs;
        }
        #endregion

    }
    public class GameSetting_CopyMask : MajorRecord_CopyMask
    {
        #region Members
        public bool GenericData;
        #endregion

    }
    #endregion




    #endregion

}
