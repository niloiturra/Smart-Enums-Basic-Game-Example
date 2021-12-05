using Shouldly;
using SmartEnumsExample;
using SmartEnumsExample.Enumeration;
using Xunit;

namespace SmartEnumsExampleTests.Enumeration
{
    public class NpcTests
    {
        private readonly MobileEntity _npcEnumeration;
        public NpcTests()
        {
            _npcEnumeration = MobileEntity.FromName(nameof(Npc));
        }

        [Fact]
        public void Should_have_all_action_rules_defined_for_npc()
        {
            //Act & Assert
            _npcEnumeration.CanRun.ShouldBeTrue();
            _npcEnumeration.CanTalk.ShouldBeTrue();
            _npcEnumeration.CanBuild.ShouldBeFalse();
            _npcEnumeration.CanAttack.ShouldBeFalse();
        }
    }
}
