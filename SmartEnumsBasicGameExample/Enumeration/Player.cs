namespace SmartEnumsExample.Enumeration
{
    public class Player : MobileEntity
    {
        public Player(string name, int value) : base(name, value)
        {
        }

        public override bool CanRun => true;

        public override bool CanTalk => true;

        public override bool CanBuild => true;

        public override bool CanAttack => true;
    }
}
