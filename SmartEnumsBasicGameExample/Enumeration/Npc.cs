namespace SmartEnumsExample.Enumeration
{
    public class Npc : MobileEntity
    {
        public Npc(string name, int value) : base(name, value)
        {
        }

        public override bool CanRun => true;

        public override bool CanTalk => true;

        public override bool CanBuild => false;

        public override bool CanAttack => false;
    }
}
