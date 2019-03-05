using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;
using CN.Jpush.Android.Api;

namespace ATicket.Droid
{
    //[Activity(Label = "ATicket", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    [Activity(Label = "ATicket", Icon = "@drawable/xamarin_logo", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);


            //JPushInterface.SetDebugMode(true);
            //JPushInterface.Init(this);
            try
            {
                initPushNotification();

                global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
                LoadApplication(new App());
            }
            catch (Exception e) {  }


        }
        private void initPushNotification()
        {
            IntentFilter filter = new IntentFilter();
            filter.AddAction(JPushInterface.ActionNotificationOpened);
            filter.AddAction(JPushInterface.ActionNotificationReceived);
            filter.AddAction(JPushInterface.ActionMessageReceived);
            filter.AddAction(JPushInterface.ActionRegistrationId);
            filter.AddAction(JPushInterface.ActionConnectionChange);
            NotificationReceiver receiver = new NotificationReceiver();
            RegisterReceiver(receiver, filter);
            JPushInterface.SetDebugMode(true);
            JPushInterface.Init(this.ApplicationContext);
        }
    }
}