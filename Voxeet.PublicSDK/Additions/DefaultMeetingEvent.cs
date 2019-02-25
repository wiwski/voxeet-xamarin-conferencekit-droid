using Java.Lang;


namespace Voxeet.Com.Sdk.Models.Impl
{
    public partial class DefaultMeetingEvent : Object, IComparable, Models.Abs.IMeetingEvent
    {
        int IComparable.CompareTo(Object obj)
        {
            return CompareTo((DefaultMeetingEvent)obj);
        }

        public Voxeet.Com.Sdk.Models.Abs.MeetingEventType InvokeMeetingEventType() { return this.MeetingEventType; }

    }
}
