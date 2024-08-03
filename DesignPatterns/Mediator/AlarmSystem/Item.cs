namespace DesignPatterns.Mediator.AlarmSystem
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
