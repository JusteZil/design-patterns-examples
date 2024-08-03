namespace Patterns2.Mediator.AlarmSystem
{
    public abstract class Item
    {
        protected AlarmSystem AlarmSystem;

        public Item(AlarmSystem alarmSystem)
        {
            AlarmSystem = alarmSystem;
        }
    }
}
