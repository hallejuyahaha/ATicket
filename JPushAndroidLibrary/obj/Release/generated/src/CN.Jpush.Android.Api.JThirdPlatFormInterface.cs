using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/JThirdPlatFormInterface", DoNotGenerateAcw=true)]
	public abstract partial class JThirdPlatFormInterface : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/field[@name='ACTION_NOTIFICATION_ARRIVED']"
		[Register ("ACTION_NOTIFICATION_ARRIVED")]
		public const string ActionNotificationArrived = (string) "action_notification_arrived";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/field[@name='ACTION_NOTIFICATION_CLCKED']"
		[Register ("ACTION_NOTIFICATION_CLCKED")]
		public const string ActionNotificationClcked = (string) "action_notification_clicked";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/field[@name='ACTION_NOTIFICATION_SHOW']"
		[Register ("ACTION_NOTIFICATION_SHOW")]
		public const string ActionNotificationShow = (string) "action_notification_show";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/field[@name='ACTION_PLUGIN_PALTFORM_ON_MESSAGING']"
		[Register ("ACTION_PLUGIN_PALTFORM_ON_MESSAGING")]
		public const string ActionPluginPaltformOnMessaging = (string) "intent.plugin.platform.ON_MESSAGING";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/field[@name='ACTION_PLUGIN_PALTFORM_REFRESSH_REGID']"
		[Register ("ACTION_PLUGIN_PALTFORM_REFRESSH_REGID")]
		public const string ActionPluginPaltformRefresshRegid = (string) "intent.plugin.platform.REFRESSH_REGID";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/field[@name='ACTION_PLUGIN_PALTFORM_REQUEST_REGID']"
		[Register ("ACTION_PLUGIN_PALTFORM_REQUEST_REGID")]
		public const string ActionPluginPaltformRequestRegid = (string) "intent.plugin.platform.REQUEST_REGID";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/field[@name='ACTION_REGISTER_TOKEN']"
		[Register ("ACTION_REGISTER_TOKEN")]
		public const string ActionRegisterToken = (string) "action_register_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/field[@name='KEY_DATA']"
		[Register ("KEY_DATA")]
		public const string KeyData = (string) "data";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/field[@name='KEY_MSG_ID']"
		[Register ("KEY_MSG_ID")]
		public const string KeyMsgId = (string) "msg_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/field[@name='KEY_NOTI_ID']"
		[Register ("KEY_NOTI_ID")]
		public const string KeyNotiId = (string) "noti_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/field[@name='KEY_PLATFORM']"
		[Register ("KEY_PLATFORM")]
		public const string KeyPlatform = (string) "platform";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/field[@name='KEY_TOKEN']"
		[Register ("KEY_TOKEN")]
		public const string KeyToken = (string) "token";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/api/JThirdPlatFormInterface", typeof (JThirdPlatFormInterface));
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

		protected JThirdPlatFormInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/constructor[@name='JThirdPlatFormInterface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JThirdPlatFormInterface ()
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

		static Delegate cb_getRomName;
#pragma warning disable 0169
		static Delegate GetGetRomNameHandler ()
		{
			if (cb_getRomName == null)
				cb_getRomName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRomName);
			return cb_getRomName;
		}

		static IntPtr n_GetRomName (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.JThirdPlatFormInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JThirdPlatFormInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RomName);
		}
#pragma warning restore 0169

		public abstract string RomName {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='getRomName' and count(parameter)=0]"
			[Register ("getRomName", "()Ljava/lang/String;", "GetGetRomNameHandler")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='doAction' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("doAction", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public static unsafe void DoAction (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2)
		{
			const string __id = "doAction.(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getAppId_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetAppId_Landroid_content_Context_Handler ()
		{
			if (cb_getAppId_Landroid_content_Context_ == null)
				cb_getAppId_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAppId_Landroid_content_Context_);
			return cb_getAppId_Landroid_content_Context_;
		}

		static IntPtr n_GetAppId_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JThirdPlatFormInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JThirdPlatFormInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAppId (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='getAppId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppId", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetAppId_Landroid_content_Context_Handler")]
		public abstract string GetAppId (global::Android.Content.Context p0);

		static Delegate cb_getAppkey_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetAppkey_Landroid_content_Context_Handler ()
		{
			if (cb_getAppkey_Landroid_content_Context_ == null)
				cb_getAppkey_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAppkey_Landroid_content_Context_);
			return cb_getAppkey_Landroid_content_Context_;
		}

		static IntPtr n_GetAppkey_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JThirdPlatFormInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JThirdPlatFormInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAppkey (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='getAppkey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppkey", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetAppkey_Landroid_content_Context_Handler")]
		public abstract string GetAppkey (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='getNofiticationID' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getNofiticationID", "(Ljava/lang/String;I)I", "")]
		public static unsafe int GetNofiticationID (string p0, int p1)
		{
			const string __id = "getNofiticationID.(Ljava/lang/String;I)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getRomType_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetRomType_Landroid_content_Context_Handler ()
		{
			if (cb_getRomType_Landroid_content_Context_ == null)
				cb_getRomType_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, sbyte>) n_GetRomType_Landroid_content_Context_);
			return cb_getRomType_Landroid_content_Context_;
		}

		static sbyte n_GetRomType_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JThirdPlatFormInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JThirdPlatFormInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			sbyte __ret = __this.GetRomType (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='getRomType' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRomType", "(Landroid/content/Context;)B", "GetGetRomType_Landroid_content_Context_Handler")]
		public abstract sbyte GetRomType (global::Android.Content.Context p0);

		static Delegate cb_getToken_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetToken_Landroid_content_Context_Handler ()
		{
			if (cb_getToken_Landroid_content_Context_ == null)
				cb_getToken_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetToken_Landroid_content_Context_);
			return cb_getToken_Landroid_content_Context_;
		}

		static IntPtr n_GetToken_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JThirdPlatFormInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JThirdPlatFormInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='getToken' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getToken", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetToken_Landroid_content_Context_Handler")]
		public abstract string GetToken (global::Android.Content.Context p0);

		static Delegate cb_init_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Handler ()
		{
			if (cb_init_Landroid_content_Context_ == null)
				cb_init_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_);
			return cb_init_Landroid_content_Context_;
		}

		static void n_Init_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JThirdPlatFormInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JThirdPlatFormInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public abstract void Init (global::Android.Content.Context p0);

		static Delegate cb_isNeedClearToken_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsNeedClearToken_Landroid_content_Context_Handler ()
		{
			if (cb_isNeedClearToken_Landroid_content_Context_ == null)
				cb_isNeedClearToken_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsNeedClearToken_Landroid_content_Context_);
			return cb_isNeedClearToken_Landroid_content_Context_;
		}

		static bool n_IsNeedClearToken_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JThirdPlatFormInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JThirdPlatFormInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsNeedClearToken (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='isNeedClearToken' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNeedClearToken", "(Landroid/content/Context;)Z", "GetIsNeedClearToken_Landroid_content_Context_Handler")]
		public abstract bool IsNeedClearToken (global::Android.Content.Context p0);

		static Delegate cb_isSupport_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsSupport_Landroid_content_Context_Handler ()
		{
			if (cb_isSupport_Landroid_content_Context_ == null)
				cb_isSupport_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSupport_Landroid_content_Context_);
			return cb_isSupport_Landroid_content_Context_;
		}

		static bool n_IsSupport_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JThirdPlatFormInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JThirdPlatFormInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSupport (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='isSupport' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isSupport", "(Landroid/content/Context;)Z", "GetIsSupport_Landroid_content_Context_Handler")]
		public abstract bool IsSupport (global::Android.Content.Context p0);

		static Delegate cb_needSendToMainProcess;
#pragma warning disable 0169
		static Delegate GetNeedSendToMainProcessHandler ()
		{
			if (cb_needSendToMainProcess == null)
				cb_needSendToMainProcess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NeedSendToMainProcess);
			return cb_needSendToMainProcess;
		}

		static bool n_NeedSendToMainProcess (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.JThirdPlatFormInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JThirdPlatFormInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedSendToMainProcess ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='needSendToMainProcess' and count(parameter)=0]"
		[Register ("needSendToMainProcess", "()Z", "GetNeedSendToMainProcessHandler")]
		public virtual unsafe bool NeedSendToMainProcess ()
		{
			const string __id = "needSendToMainProcess.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_register_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetRegister_Landroid_content_Context_Handler ()
		{
			if (cb_register_Landroid_content_Context_ == null)
				cb_register_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Register_Landroid_content_Context_);
			return cb_register_Landroid_content_Context_;
		}

		static void n_Register_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JThirdPlatFormInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JThirdPlatFormInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("register", "(Landroid/content/Context;)V", "GetRegister_Landroid_content_Context_Handler")]
		public abstract void Register (global::Android.Content.Context p0);

		static Delegate cb_resumePush_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetResumePush_Landroid_content_Context_Handler ()
		{
			if (cb_resumePush_Landroid_content_Context_ == null)
				cb_resumePush_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResumePush_Landroid_content_Context_);
			return cb_resumePush_Landroid_content_Context_;
		}

		static void n_ResumePush_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JThirdPlatFormInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JThirdPlatFormInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResumePush (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='resumePush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("resumePush", "(Landroid/content/Context;)V", "GetResumePush_Landroid_content_Context_Handler")]
		public virtual unsafe void ResumePush (global::Android.Content.Context p0)
		{
			const string __id = "resumePush.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='sendActionByJCore' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendActionByJCore", "(Landroid/content/Context;Landroid/os/Bundle;Ljava/lang/String;)V", "")]
		public static unsafe void SendActionByJCore (global::Android.Content.Context p0, global::Android.OS.Bundle p1, string p2)
		{
			const string __id = "sendActionByJCore.(Landroid/content/Context;Landroid/os/Bundle;Ljava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='setNotificationChannel' and count(parameter)=5 and parameter[1][@type='android.app.Notification.Builder'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.CharSequence'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("setNotificationChannel", "(Landroid/app/Notification$Builder;Ljava/lang/String;Ljava/lang/CharSequence;II)V", "")]
		public static unsafe void SetNotificationChannel (global::Android.App.Notification.Builder p0, string p1, global::Java.Lang.ICharSequence p2, int p3, int p4)
		{
			const string __id = "setNotificationChannel.(Landroid/app/Notification$Builder;Ljava/lang/String;Ljava/lang/CharSequence;II)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = CharSequence.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		public static void SetNotificationChannel (global::Android.App.Notification.Builder p0, string p1, string p2, int p3, int p4)
		{
			global::Java.Lang.String jls_p2 = p2 == null ? null : new global::Java.Lang.String (p2);
			SetNotificationChannel (p0, p1, jls_p2, p3, p4);
			jls_p2?.Dispose ();
		}

		static Delegate cb_stopPush_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetStopPush_Landroid_content_Context_Handler ()
		{
			if (cb_stopPush_Landroid_content_Context_ == null)
				cb_stopPush_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StopPush_Landroid_content_Context_);
			return cb_stopPush_Landroid_content_Context_;
		}

		static void n_StopPush_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JThirdPlatFormInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JThirdPlatFormInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopPush (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='stopPush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stopPush", "(Landroid/content/Context;)V", "GetStopPush_Landroid_content_Context_Handler")]
		public virtual unsafe void StopPush (global::Android.Content.Context p0)
		{
			const string __id = "stopPush.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='toMD5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toMD5", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToMD5 (string p0)
		{
			const string __id = "toMD5.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("cn/jpush/android/api/JThirdPlatFormInterface", DoNotGenerateAcw=true)]
	internal partial class JThirdPlatFormInterfaceInvoker : JThirdPlatFormInterface {

		public JThirdPlatFormInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("cn/jpush/android/api/JThirdPlatFormInterface", typeof (JThirdPlatFormInterfaceInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe string RomName {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='getRomName' and count(parameter)=0]"
			[Register ("getRomName", "()Ljava/lang/String;", "GetGetRomNameHandler")]
			get {
				const string __id = "getRomName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='getAppId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppId", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetAppId_Landroid_content_Context_Handler")]
		public override unsafe string GetAppId (global::Android.Content.Context p0)
		{
			const string __id = "getAppId.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='getAppkey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppkey", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetAppkey_Landroid_content_Context_Handler")]
		public override unsafe string GetAppkey (global::Android.Content.Context p0)
		{
			const string __id = "getAppkey.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='getRomType' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRomType", "(Landroid/content/Context;)B", "GetGetRomType_Landroid_content_Context_Handler")]
		public override unsafe sbyte GetRomType (global::Android.Content.Context p0)
		{
			const string __id = "getRomType.(Landroid/content/Context;)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractSByteMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='getToken' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getToken", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetToken_Landroid_content_Context_Handler")]
		public override unsafe string GetToken (global::Android.Content.Context p0)
		{
			const string __id = "getToken.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public override unsafe void Init (global::Android.Content.Context p0)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='isNeedClearToken' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNeedClearToken", "(Landroid/content/Context;)Z", "GetIsNeedClearToken_Landroid_content_Context_Handler")]
		public override unsafe bool IsNeedClearToken (global::Android.Content.Context p0)
		{
			const string __id = "isNeedClearToken.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='isSupport' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isSupport", "(Landroid/content/Context;)Z", "GetIsSupport_Landroid_content_Context_Handler")]
		public override unsafe bool IsSupport (global::Android.Content.Context p0)
		{
			const string __id = "isSupport.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JThirdPlatFormInterface']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("register", "(Landroid/content/Context;)V", "GetRegister_Landroid_content_Context_Handler")]
		public override unsafe void Register (global::Android.Content.Context p0)
		{
			const string __id = "register.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
