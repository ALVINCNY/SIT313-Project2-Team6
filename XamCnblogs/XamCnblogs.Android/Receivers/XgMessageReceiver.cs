using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Tencent.Android.Tpush;
using FormsToolkit;
using Org.Json;
using XamCnblogs.Portable.Helpers;

namespace XamCnblogs.Droid.Receivers
{
    [BroadcastReceiver(Exported = true)]
    [IntentFilter(new[] { "com.tencent.android.tpush.action.PUSH_MESSAGE", "com.tencent.android.tpush.action.FEEDBACK" })]
    public class XgMessageReceiver : XGPushBaseReceiver
    {
        public override void OnDeleteTagResult(Context context, int errorCode, string tagName)
        {
        }

        public override void OnNotifactionClickedResult(Context context, XGPushClickedResult message)
        {
            NotificationManager notificationManager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            notificationManager.CancelAll();
            if (context == null || message == null)
            {
                return;
            }
            if (message.ActionType == XGPushClickedResult.NotifactionClickedType)
            {
                // The notification was clicked in the notification bar.。。。。。
                // The APP itself handles the related actions of the click

                // Get custom key-value
                string customContent = message.CustomContent;
                if (customContent != null && customContent.Length != 0)
                {
                    MessagingService.Current.SendMessage(MessageKeys.NavigateNotification, customContent);
                }
            }
            else if (message.ActionType == XGPushClickedResult.NotifactionDeletedType)
            {
                // The notice was cleared。。。。
                // The APP itself processes the related actions after the notification is cleared.
            }
        }

        public override void OnNotifactionShowedResult(Context context, XGPushShowedResult notifiShowedRlt)
        {

        }

        public override void OnRegisterResult(Context context, int errorCode, XGPushRegisterResult message)
        {
        }

        public override void OnSetTagResult(Context context, int errorCode, string tagName)
        {
        }

        public override void OnTextMessage(Context context, XGPushTextMessage message)
        {
            string customContent = message.CustomContent;
            if (customContent != null && customContent.Length != 0)
            {
                MessagingService.Current.SendMessage(MessageKeys.NavigateNotification, customContent);
            }
        }

        public override void OnUnregisterResult(Context context, int errorCode)
        {
        }
    }
}