using Java.Lang;

namespace Voxeet.Com.Sdk.Models.Impl
{
    public partial class DefaultMeeting : Object, IComparable
    {

        int IComparable.CompareTo(Object obj)
        {
            return CompareTo((DefaultMeeting)obj);
        }
    }
}
