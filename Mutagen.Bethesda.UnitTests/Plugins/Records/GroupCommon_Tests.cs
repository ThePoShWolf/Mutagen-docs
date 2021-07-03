using FluentAssertions;
using Mutagen.Bethesda.Oblivion;
using System.Linq;
using Xunit;

namespace Mutagen.Bethesda.UnitTests.Plugins.Records
{
    public class GroupCommon_Tests
    {
        [Fact]
        public void AddNew()
        {
            var mod = new OblivionMod(Utility.PluginModKey);
            var rec = mod.Npcs.AddNew();
            Assert.Equal(1, mod.Npcs.Count);
            Assert.Same(mod.Npcs.Records.First(), rec);
        }

        [Fact]
        public void AddNew_DifferentForSecond()
        {
            var mod = new OblivionMod(Utility.PluginModKey);
            var rec = mod.Npcs.AddNew();
            var rec2 = mod.Npcs.AddNew();
            Assert.Equal(2, mod.Npcs.Count);
            Assert.NotSame(rec, rec2);
        }

        [Fact]
        public void AddWithFormKey()
        {
            var mod = new OblivionMod(Utility.PluginModKey);
            var rec = mod.Npcs.AddNew(Utility.Form1);
            Assert.Equal(1, mod.Npcs.Count);
            Assert.Same(mod.Npcs.Records.First(), rec);
            rec.FormKey.Should().Be(Utility.Form1);
        }
    }
}
