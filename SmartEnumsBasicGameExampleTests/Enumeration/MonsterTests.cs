using Shouldly;
using SmartEnumsExample;
using SmartEnumsExample.Enumeration;
using Xunit;

namespace SmartEnumsExampleTests.Enumeration
{
    public class MonsterTests
    {
        private readonly MobileEntity _monsterEnumeration;
        public MonsterTests()
        {
            _monsterEnumeration = MobileEntity.FromName(nameof(Monster));
        }

        [Fact]
        public void Should_have_all_action_rules_defined_for_monsters()
        {
            //Act & Assert
            _monsterEnumeration.CanRun.ShouldBeTrue();
            _monsterEnumeration.CanTalk.ShouldBeFalse();
            _monsterEnumeration.CanBuild.ShouldBeFalse();
            _monsterEnumeration.CanAttack.ShouldBeTrue();
        }
    }
}
