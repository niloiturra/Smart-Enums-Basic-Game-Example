namespace SmartEnumsExample.Enumeration
{
    public class Monster : MobileEntity
    {
        public Monster(string name, int value) : base(name, value)
        {
        }

        public override bool CanRun => true;

        public override bool CanTalk => false;

        public override bool CanBuild => false;

        public override bool CanAttack => true;
    }
}
