using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Java.Interop;

namespace Com.Voxeet.Toolkit.Utils
{
    public partial class ParticipantViewAdapter
    {

        static Delegate cb_onBindViewHolder_Landroid_view_ViewHolder_I;

        static Delegate GetOnBindViewHolder_Landroid_view_ViewHolder_IHandler()
        {
            if (cb_onBindViewHolder_Landroid_view_ViewHolder_I == null)
                cb_onBindViewHolder_Landroid_view_ViewHolder_I = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, int>)n_OnBindViewHolder_Landroid_view_ViewHolder_I);
            return cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
        }

        static void n_OnBindViewHolder_Landroid_view_ViewHolder_I(IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int position)
        {
            global::Com.Voxeet.Toolkit.Utils.ParticipantViewAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Voxeet.Toolkit.Utils.ParticipantViewAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            RecyclerView.ViewHolder holder = global::Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_holder, JniHandleOwnership.DoNotTransfer);
            __this.OnBindViewHolder(holder, position);
        }
        [Register("onBindViewHolder", "(Landroid/view/ViewHolder;I)V", "GetOnBindViewHolder_Landroid_view_ViewHolder_IHandler")]
        public override unsafe void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            const string __id = "onBindViewHolder.(Landroid/view/ViewHolder;I)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object)holder).Handle);
                __args[1] = new JniArgumentValue(position);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
            }
            finally
            {
            }
        }
    }
}