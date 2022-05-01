using System.Linq;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Meta;
using Noggog;
using Xunit;

namespace Mutagen.Bethesda.UnitTests.Plugins.Binary;

public class UtilityTranslationTests
{
    public static readonly RecordType FirstTypicalType = new RecordType("EDID");
    public static readonly int FirstTypicalLocation = 0;
    public static readonly RecordType SecondTypicalType = new RecordType("FNAM");
    public static readonly int SecondTypicalLocation = 7 + GameConstants.Oblivion.SubConstants.HeaderLength;
    public static readonly RecordType DuplicateType = new RecordType("EDID");
    public static readonly int DuplicateLocation = 7 + GameConstants.Oblivion.SubConstants.HeaderLength * 2 + 9;
    public static ReadOnlyMemorySlice<byte> GetTypical()
    {
        return new ReadOnlyMemorySlice<byte>(new byte[]
        {
            (byte)'E',(byte)'D',(byte)'I',(byte)'D',
            7, 0,
            0, 1, 2, 3, 4, 5, 6,
            (byte)'F',(byte)'N',(byte)'A',(byte)'M',
            9, 0,
            0, 1, 2, 3, 4, 5, 6, 7, 8,
        });
    }
    public static ReadOnlyMemorySlice<byte> GetDuplicate()
    {
        return new ReadOnlyMemorySlice<byte>(new byte[]
        {
            (byte)'E',(byte)'D',(byte)'I',(byte)'D',
            7, 0,
            0, 1, 2, 3, 4, 5, 6,
            (byte)'F',(byte)'N',(byte)'A',(byte)'M',
            9, 0,
            0, 1, 2, 3, 4, 5, 6, 7, 8,
            (byte)'E',(byte)'D',(byte)'I',(byte)'D',
            7, 0,
            0, 1, 2, 3, 4, 5, 6,
        });
    }

    #region EnumerateSubrecords
    [Fact]
    public void EnumerateSubrecords_Empty()
    {
        byte[] b = new byte[0];
        Assert.Empty(RecordSpanExtensions.EnumerateSubrecords(new ReadOnlyMemorySlice<byte>(b), GameConstants.Oblivion));
    }

    [Fact]
    public void EnumerateSubrecords_Typical()
    {
        var ret = RecordSpanExtensions.EnumerateSubrecords(GetTypical(), GameConstants.Oblivion).ToArray();
        Assert.Equal(2, ret.Length);
        Assert.Equal(new RecordType("EDID"), ret[0].Key);
        Assert.Equal(FirstTypicalLocation, ret[0].Value);
        Assert.Equal(new RecordType("FNAM"), ret[1].Key);
        Assert.Equal(SecondTypicalLocation, ret[1].Value);
    }

    [Fact]
    public void EnumerateSubrecords_Duplicate()
    {
        var ret = RecordSpanExtensions.EnumerateSubrecords(GetDuplicate(), GameConstants.Oblivion).ToArray();
        Assert.Equal(3, ret.Length);
        Assert.Equal(new RecordType("EDID"), ret[0].Key);
        Assert.Equal(FirstTypicalLocation, ret[0].Value);
        Assert.Equal(new RecordType("FNAM"), ret[1].Key);
        Assert.Equal(SecondTypicalLocation, ret[1].Value);
        Assert.Equal(new RecordType("EDID"), ret[2].Key);
        Assert.Equal(DuplicateLocation, ret[2].Value);
    }
    #endregion

    #region FindFirstSubrecords
    [Fact]
    public void FindFirstSubrecords_Empty()
    {
        var b = new byte[0];
        var ret = RecordSpanExtensions.TryFindFirstSubrecords(b, GameConstants.Oblivion, FirstTypicalType, SecondTypicalType);
        Assert.Equal(2, ret.Length);
        Assert.Null(ret[0]);
        Assert.Null(ret[1]);
    }

    [Fact]
    public void FindFirstSubrecords_Typical()
    {
        var ret = RecordSpanExtensions.TryFindFirstSubrecords(GetTypical(), GameConstants.Oblivion, SecondTypicalType, FirstTypicalType);
        Assert.Equal(2, ret.Length);
        Assert.Equal(SecondTypicalLocation, ret[0]?.Location);
        Assert.Equal(FirstTypicalLocation, ret[1]?.Location);
    }

    [Fact]
    public void FindFirstSubrecords_Single()
    {
        var ret = RecordSpanExtensions.TryFindFirstSubrecords(GetTypical(), GameConstants.Oblivion, SecondTypicalType);
        Assert.Single(ret);
        Assert.Equal(SecondTypicalLocation, ret[0]?.Location);
    }

    [Fact]
    public void FindFirstSubrecords_Duplicate()
    {
        var ret = RecordSpanExtensions.TryFindFirstSubrecords(GetDuplicate(), GameConstants.Oblivion, SecondTypicalType, FirstTypicalType);
        Assert.Equal(2, ret.Length);
        Assert.Equal(SecondTypicalLocation, ret[0]?.Location);
        Assert.Equal(FirstTypicalLocation, ret[1]?.Location);
    }
    #endregion

    #region FindFirstSubrecord
    [Fact]
    public void FindFirstSubrecord_Empty()
    {
        var b = new byte[0];
        Assert.Null(RecordSpanExtensions.TryFindSubrecord(b, GameConstants.Oblivion, SecondTypicalType));
    }

    [Fact]
    public void FindFirstSubrecord_Typical()
    {
        Assert.Equal(SecondTypicalLocation, RecordSpanExtensions.TryFindSubrecord(GetTypical(), GameConstants.Oblivion, SecondTypicalType)?.Location);
    }

    [Fact]
    public void FindFirstSubrecord_Duplicate()
    {
        Assert.Equal(FirstTypicalLocation, RecordSpanExtensions.TryFindSubrecord(GetTypical(), GameConstants.Oblivion, FirstTypicalType)?.Location);
    }
    #endregion
}