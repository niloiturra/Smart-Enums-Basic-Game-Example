using Ardalis.SmartEnum;
using SmartEnumsExample.Enumeration;

namespace SmartEnumsExample
{
    public abstract class MobileEntity: SmartEnum<MobileEntity>
    {
        public static readonly MobileEntity Player = new Player(nameof(Player), 1);
        public static readonly MobileEntity Monster = new Monster(nameof(Monster), 2);
        public static readonly MobileEntity Npc = new Npc(nameof(Npc), 3);

        public MobileEntity(string name, int value): base(name, value)
        {
        }

        public abstract bool CanRun { get; }
        public abstract bool CanTalk { get; }
        public abstract bool CanBuild { get; }
        public abstract bool CanAttack { get; }
    }
}
