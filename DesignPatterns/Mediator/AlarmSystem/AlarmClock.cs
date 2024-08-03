namespace DesignPatterns.Mediator.AlarmSystem
{
    public class AlarmClock : Item
    {
        public AlarmClock(AlarmSystem alarmSystem) : base(alarmSystem)
        {
        }

        public void AlarmOn()
        {
            AlarmSystem.SetAlarmOn();
        }
    }
}
