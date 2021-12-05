using Shouldly;
using SmartEnumsExample;
using SmartEnumsExample.Enumeration;
using Xunit;

namespace SmartEnumsExampleTests.Enumeration
{
    public class PlayerTests
    {
        private readonly MobileEntity _playerEnumeration;
        public PlayerTests()
        {
            _playerEnumeration = MobileEntity.FromName(nameof(Player));
        }

        [Fact]
        public void Should_have_all_action_rules_defined_for_monsters()
        {
            //Act & Assert
            _playerEnumeration.CanRun.ShouldBeTrue();
            _playerEnumeration.CanTalk.ShouldBeTrue();
            _playerEnumeration.CanBuild.ShouldBeTrue();
            _playerEnumeration.CanAttack.ShouldBeTrue();
        }
    }
}
