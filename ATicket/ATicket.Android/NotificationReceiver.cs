using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CN.Jpush.Android.Api;
using CN.Jpush.Android.Service;

namespace ATicket.Droid
{
    [BroadcastReceiver]
    [IntentFilter(new string[] { "cn.jpush.android.intent.REGISTRATION" }, Categories = new string[] { "com.companyname.ATicket" })]
    [IntentFilter(new string[] { "cn.jpush.android.intent.MESSAGE_RECEIVED" }, Categories = new string[] { "com.companyname.ATicket" })]
    [IntentFilter(new string[] { "cn.jpush.android.intent.NOTIFICATION_RECEIVED" }, Categories = new string[] { "com.companyname.ATicket" })]
    [IntentFilter(new string[] { "cn.jpush.android.intent.NOTIFICATION_OPENED" }, Categories = new string[] { "com.companyname.ATicket" })]
    [IntentFilter(new string[] { "cn.jpush.android.intent.CONNECTION" }, Categories = new string[] { "com.companyname.ATicket" })]
    class NotificationReceiver : PushReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            base.OnReceive(context, intent);

            //当点击消息时进入，进入对应的页面
            if (intent.Action == JPushInterface.ActionNotificationOpened)
            {
                //When user tap the notification on notification center
                Bundle bundle = intent.Extras;
                string jsonData = bundle.GetString(JPushInterface.ExtraExtra);
            }
            //第一次安装app时进入，会拿到registrationID，保存registrationID，当用户登录之后把用户id和registrationID关联，方便之后一对一发送消息
            if (intent.Action == JPushInterface.ActionRegistrationId)
            {
                //Only call when first launch, get the registrationID
                string regID = JPushInterface.GetRegistrationID(context);
            }
            //当接收到信息时进入，弹出消息框
            if (JPushInterface.ActionMessageReceived.Equals(intent.Action))
            {

            }

            //当接收到信息时进入，弹出消息框
            if (JPushInterface.ActionNotificationReceived.Equals(intent.Action))
            {

            }
            if (JPushInterface.ActionNotificationReceived.Equals(intent.Action))
            {

            }
        }
    }
}