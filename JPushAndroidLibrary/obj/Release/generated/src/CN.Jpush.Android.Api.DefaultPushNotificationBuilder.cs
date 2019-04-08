using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='DefaultPushNotificationBuilder']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/DefaultPushNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class DefaultPushNotificationBuilder : global::Java.Lang.Object, global::CN.Jpush.Android.Api.IPushNotificationBuilder {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/api/DefaultPushNotificationBuilder", typeof (DefaultPushNotificationBuilder));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected DefaultPushNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='DefaultPushNotificationBuilder']/constructor[@name='DefaultPushNotificationBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultPushNotificationBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getDeveloperArg0;
#pragma warning disable 0169
		static Delegate GetGetDeveloperArg0Handler ()
		{
			if (cb_getDeveloperArg0 == null)
				cb_getDeveloperArg0 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeveloperArg0);
			return cb_getDeveloperArg0;
		}

		static IntPtr n_GetDeveloperArg0 (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeveloperArg0);
		}
#pragma warning restore 0169

		public virtual unsafe string DeveloperArg0 {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='DefaultPushNotificationBuilder']/method[@name='getDeveloperArg0' and count(parameter)=0]"
			[Register ("getDeveloperArg0", "()Ljava/lang/String;", "GetGetDeveloperArg0Handler")]
			get {
				const string __id = "getDeveloperArg0.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_buildNotification_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetBuildNotification_Ljava_util_Map_Handler ()
		{
			if (cb_buildNotification_Ljava_util_Map_ == null)
				cb_buildNotification_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildNotification_Ljava_util_Map_);
			return cb_buildNotification_Ljava_util_Map_;
		}

		static IntPtr n_BuildNotification_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildNotification (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='DefaultPushNotificationBuilder']/method[@name='buildNotification' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("buildNotification", "(Ljava/util/Map;)Landroid/app/Notification;", "GetBuildNotification_Ljava_util_Map_Handler")]
		public virtual unsafe global::Android.App.Notification BuildNotification (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			const string __id = "buildNotification.(Ljava/util/Map;)Landroid/app/Notification;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.Notification> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
