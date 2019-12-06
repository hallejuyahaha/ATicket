using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/JPushInterface", DoNotGenerateAcw=true)]
	public partial class JPushInterface : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_CONNECTION_CHANGE']"
		[Register ("ACTION_CONNECTION_CHANGE")]
		public const string ActionConnectionChange = (string) "cn.jpush.android.intent.CONNECTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_MESSAGE_RECEIVED']"
		[Register ("ACTION_MESSAGE_RECEIVED")]
		public const string ActionMessageReceived = (string) "cn.jpush.android.intent.MESSAGE_RECEIVED";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_NOTIFICATION_CLICK_ACTION']"
		[Register ("ACTION_NOTIFICATION_CLICK_ACTION")]
		public const string ActionNotificationClickAction = (string) "cn.jpush.android.intent.NOTIFICATION_CLICK_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_NOTIFICATION_OPENED']"
		[Register ("ACTION_NOTIFICATION_OPENED")]
		public const string ActionNotificationOpened = (string) "cn.jpush.android.intent.NOTIFICATION_OPENED";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_NOTIFICATION_RECEIVED']"
		[Register ("ACTION_NOTIFICATION_RECEIVED")]
		public const string ActionNotificationReceived = (string) "cn.jpush.android.intent.NOTIFICATION_RECEIVED";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_NOTIFICATION_RECEIVED_PROXY']"
		[Register ("ACTION_NOTIFICATION_RECEIVED_PROXY")]
		public const string ActionNotificationReceivedProxy = (string) "cn.jpush.android.intent.NOTIFICATION_RECEIVED_PROXY";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_REGISTRATION_ID']"
		[Register ("ACTION_REGISTRATION_ID")]
		public const string ActionRegistrationId = (string) "cn.jpush.android.intent.REGISTRATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_RICHPUSH_CALLBACK']"
		[Register ("ACTION_RICHPUSH_CALLBACK")]
		public const string ActionRichpushCallback = (string) "cn.jpush.android.intent.ACTION_RICHPUSH_CALLBACK";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_ACTIVITY_PARAM']"
		[Register ("EXTRA_ACTIVITY_PARAM")]
		public const string ExtraActivityParam = (string) "cn.jpush.android.ACTIVITY_PARAM";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_ALERT']"
		[Register ("EXTRA_ALERT")]
		public const string ExtraAlert = (string) "cn.jpush.android.ALERT";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_ALERT_TYPE']"
		[Register ("EXTRA_ALERT_TYPE")]
		public const string ExtraAlertType = (string) "cn.jpush.android.ALERT_TYPE";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_APP_KEY']"
		[Register ("EXTRA_APP_KEY")]
		public const string ExtraAppKey = (string) "cn.jpush.android.APPKEY";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_BIG_PIC_PATH']"
		[Register ("EXTRA_BIG_PIC_PATH")]
		public const string ExtraBigPicPath = (string) "cn.jpush.android.BIG_PIC_PATH";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_BIG_TEXT']"
		[Register ("EXTRA_BIG_TEXT")]
		public const string ExtraBigText = (string) "cn.jpush.android.BIG_TEXT";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_CONNECTION_CHANGE']"
		[Register ("EXTRA_CONNECTION_CHANGE")]
		public const string ExtraConnectionChange = (string) "cn.jpush.android.CONNECTION_CHANGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_CONTENT_TYPE']"
		[Register ("EXTRA_CONTENT_TYPE")]
		public const string ExtraContentType = (string) "cn.jpush.android.CONTENT_TYPE";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_EXTRA']"
		[Register ("EXTRA_EXTRA")]
		public const string ExtraExtra = (string) "cn.jpush.android.EXTRA";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_INBOX']"
		[Register ("EXTRA_INBOX")]
		public const string ExtraInbox = (string) "cn.jpush.android.INBOX";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_MESSAGE']"
		[Register ("EXTRA_MESSAGE")]
		public const string ExtraMessage = (string) "cn.jpush.android.MESSAGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_MSG_ID']"
		[Register ("EXTRA_MSG_ID")]
		public const string ExtraMsgId = (string) "cn.jpush.android.MSG_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTIFICATION_ACTION_EXTRA']"
		[Register ("EXTRA_NOTIFICATION_ACTION_EXTRA")]
		public const string ExtraNotificationActionExtra = (string) "cn.jpush.android.NOTIFIACATION_ACTION_EXTRA";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTIFICATION_DEVELOPER_ARG0']"
		[Register ("EXTRA_NOTIFICATION_DEVELOPER_ARG0")]
		public const string ExtraNotificationDeveloperArg0 = (string) "cn.jpush.android.NOTIFICATION_DEVELOPER_ARG0";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTIFICATION_ID']"
		[Register ("EXTRA_NOTIFICATION_ID")]
		public const string ExtraNotificationId = (string) "cn.jpush.android.NOTIFICATION_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTIFICATION_LARGET_ICON']"
		[Register ("EXTRA_NOTIFICATION_LARGET_ICON")]
		public const string ExtraNotificationLargetIcon = (string) "cn.jpush.android.NOTIFICATION_LARGE_ICON";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTIFICATION_TITLE']"
		[Register ("EXTRA_NOTIFICATION_TITLE")]
		public const string ExtraNotificationTitle = (string) "cn.jpush.android.NOTIFICATION_CONTENT_TITLE";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTIFICATION_URL']"
		[Register ("EXTRA_NOTIFICATION_URL")]
		public const string ExtraNotificationUrl = (string) "cn.jpush.android.NOTIFICATION_URL";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTI_CATEGORY']"
		[Register ("EXTRA_NOTI_CATEGORY")]
		public const string ExtraNotiCategory = (string) "cn.jpush.android.NOTI_CATEGORY";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTI_PRIORITY']"
		[Register ("EXTRA_NOTI_PRIORITY")]
		public const string ExtraNotiPriority = (string) "cn.jpush.android.NOTI_PRIORITY";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTI_TYPE']"
		[Register ("EXTRA_NOTI_TYPE")]
		public const string ExtraNotiType = (string) "cn.jpush.android.NOTIFICATION_TYPE";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_PUSH_ID']"
		[Register ("EXTRA_PUSH_ID")]
		public const string ExtraPushId = (string) "cn.jpush.android.PUSH_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_REGISTRATION_ID']"
		[Register ("EXTRA_REGISTRATION_ID")]
		public const string ExtraRegistrationId = (string) "cn.jpush.android.REGISTRATION_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_RICHPUSH_FILE_PATH']"
		[Register ("EXTRA_RICHPUSH_FILE_PATH")]
		public const string ExtraRichpushFilePath = (string) "cn.jpush.android.FILE_PATH";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_RICHPUSH_FILE_TYPE']"
		[Register ("EXTRA_RICHPUSH_FILE_TYPE")]
		public const string ExtraRichpushFileType = (string) "cn.jpush.android.FILE_TYPE";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_RICHPUSH_HTML_PATH']"
		[Register ("EXTRA_RICHPUSH_HTML_PATH")]
		public const string ExtraRichpushHtmlPath = (string) "cn.jpush.android.HTML_PATH";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_RICHPUSH_HTML_RES']"
		[Register ("EXTRA_RICHPUSH_HTML_RES")]
		public const string ExtraRichpushHtmlRes = (string) "cn.jpush.android.HTML_RES";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_STATUS']"
		[Register ("EXTRA_STATUS")]
		public const string ExtraStatus = (string) "cn.jpush.android.STATUS";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_TITLE']"
		[Register ("EXTRA_TITLE")]
		public const string ExtraTitle = (string) "cn.jpush.android.TITLE";


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='a']"
		[Register ("a")]
		public static int A {
			get {
				const string __id = "a.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "a.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/api/JPushInterface", typeof (JPushInterface));
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

		protected JPushInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/constructor[@name='JPushInterface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JPushInterface ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='addLocalNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jpush.android.data.JPushLocalNotification']]"
		[Register ("addLocalNotification", "(Landroid/content/Context;Lcn/jpush/android/data/JPushLocalNotification;)V", "")]
		public static unsafe void AddLocalNotification (global::Android.Content.Context p0, global::CN.Jpush.Android.Data.JPushLocalNotification p1)
		{
			const string __id = "addLocalNotification.(Landroid/content/Context;Lcn/jpush/android/data/JPushLocalNotification;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='addTags' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("addTags", "(Landroid/content/Context;ILjava/util/Set;)V", "")]
		public static unsafe void AddTags (global::Android.Content.Context p0, int p1, global::System.Collections.Generic.ICollection<string> p2)
		{
			const string __id = "addTags.(Landroid/content/Context;ILjava/util/Set;)V";
			IntPtr native_p2 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='checkTagBindState' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("checkTagBindState", "(Landroid/content/Context;ILjava/lang/String;)V", "")]
		public static unsafe void CheckTagBindState (global::Android.Content.Context p0, int p1, string p2)
		{
			const string __id = "checkTagBindState.(Landroid/content/Context;ILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='cleanTags' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("cleanTags", "(Landroid/content/Context;I)V", "")]
		public static unsafe void CleanTags (global::Android.Content.Context p0, int p1)
		{
			const string __id = "cleanTags.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='clearAllNotifications' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearAllNotifications", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearAllNotifications (global::Android.Content.Context p0)
		{
			const string __id = "clearAllNotifications.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='clearLocalNotifications' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearLocalNotifications", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearLocalNotifications (global::Android.Content.Context p0)
		{
			const string __id = "clearLocalNotifications.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='clearNotificationById' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("clearNotificationById", "(Landroid/content/Context;I)V", "")]
		public static unsafe void ClearNotificationById (global::Android.Content.Context p0, int p1)
		{
			const string __id = "clearNotificationById.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='deleteAlias' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("deleteAlias", "(Landroid/content/Context;I)V", "")]
		public static unsafe void DeleteAlias (global::Android.Content.Context p0, int p1)
		{
			const string __id = "deleteAlias.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='deleteTags' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("deleteTags", "(Landroid/content/Context;ILjava/util/Set;)V", "")]
		public static unsafe void DeleteTags (global::Android.Content.Context p0, int p1, global::System.Collections.Generic.ICollection<string> p2)
		{
			const string __id = "deleteTags.(Landroid/content/Context;ILjava/util/Set;)V";
			IntPtr native_p2 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='filterValidTags' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("filterValidTags", "(Ljava/util/Set;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<string> FilterValidTags (global::System.Collections.Generic.ICollection<string> p0)
		{
			const string __id = "filterValidTags.(Ljava/util/Set;)Ljava/util/Set;";
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='getAlias' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getAlias", "(Landroid/content/Context;I)V", "")]
		public static unsafe void GetAlias (global::Android.Content.Context p0, int p1)
		{
			const string __id = "getAlias.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='getAllTags' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getAllTags", "(Landroid/content/Context;I)V", "")]
		public static unsafe void GetAllTags (global::Android.Content.Context p0, int p1)
		{
			const string __id = "getAllTags.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='getConnectionState' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getConnectionState", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool GetConnectionState (global::Android.Content.Context p0)
		{
			const string __id = "getConnectionState.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='getRegistrationID' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRegistrationID", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetRegistrationID (global::Android.Content.Context p0)
		{
			const string __id = "getRegistrationID.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='getStringTags' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("getStringTags", "(Ljava/util/Set;)Ljava/lang/String;", "")]
		public static unsafe string GetStringTags (global::System.Collections.Generic.ICollection<string> p0)
		{
			const string __id = "getStringTags.(Ljava/util/Set;)Ljava/lang/String;";
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='getUdid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUdid", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetUdid (global::Android.Content.Context p0)
		{
			const string __id = "getUdid.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='initCrashHandler' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initCrashHandler", "(Landroid/content/Context;)V", "")]
		public static unsafe void InitCrashHandler (global::Android.Content.Context p0)
		{
			const string __id = "initCrashHandler.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='isPushStopped' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isPushStopped", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsPushStopped (global::Android.Content.Context p0)
		{
			const string __id = "isPushStopped.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='onFragmentPause' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFragmentPause", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void OnFragmentPause (global::Android.Content.Context p0, string p1)
		{
			const string __id = "onFragmentPause.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='onFragmentResume' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFragmentResume", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void OnFragmentResume (global::Android.Content.Context p0, string p1)
		{
			const string __id = "onFragmentResume.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='onKillProcess' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onKillProcess", "(Landroid/content/Context;)V", "")]
		public static unsafe void OnKillProcess (global::Android.Content.Context p0)
		{
			const string __id = "onKillProcess.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onPause", "(Landroid/content/Context;)V", "")]
		public static unsafe void OnPause (global::Android.Content.Context p0)
		{
			const string __id = "onPause.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onResume", "(Landroid/content/Context;)V", "")]
		public static unsafe void OnResume (global::Android.Content.Context p0)
		{
			const string __id = "onResume.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='removeLocalNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("removeLocalNotification", "(Landroid/content/Context;J)V", "")]
		public static unsafe void RemoveLocalNotification (global::Android.Content.Context p0, long p1)
		{
			const string __id = "removeLocalNotification.(Landroid/content/Context;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='reportNotificationOpened' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("reportNotificationOpened", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void ReportNotificationOpened (global::Android.Content.Context p0, string p1)
		{
			const string __id = "reportNotificationOpened.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='reportNotificationOpened' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte']]"
		[Register ("reportNotificationOpened", "(Landroid/content/Context;Ljava/lang/String;B)V", "")]
		public static unsafe void ReportNotificationOpened (global::Android.Content.Context p0, string p1, sbyte p2)
		{
			const string __id = "reportNotificationOpened.(Landroid/content/Context;Ljava/lang/String;B)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='requestPermission' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("requestPermission", "(Landroid/content/Context;)V", "")]
		public static unsafe void RequestPermission (global::Android.Content.Context p0)
		{
			const string __id = "requestPermission.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='resumePush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("resumePush", "(Landroid/content/Context;)V", "")]
		public static unsafe void ResumePush (global::Android.Content.Context p0)
		{
			const string __id = "resumePush.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setAlias' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("setAlias", "(Landroid/content/Context;ILjava/lang/String;)V", "")]
		public static unsafe void SetAlias (global::Android.Content.Context p0, int p1, string p2)
		{
			const string __id = "setAlias.(Landroid/content/Context;ILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setAlias' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='cn.jpush.android.api.TagAliasCallback']]"
		[Obsolete (@"deprecated")]
		[Register ("setAlias", "(Landroid/content/Context;Ljava/lang/String;Lcn/jpush/android/api/TagAliasCallback;)V", "")]
		public static unsafe void SetAlias (global::Android.Content.Context p0, string p1, global::CN.Jpush.Android.Api.ITagAliasCallback p2)
		{
			const string __id = "setAlias.(Landroid/content/Context;Ljava/lang/String;Lcn/jpush/android/api/TagAliasCallback;)V";
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

		static Delegate cb_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_Handler ()
		{
			if (cb_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_ == null)
				cb_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_);
			return cb_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_;
		}

		[Obsolete]
		static void n_SetAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jpush.Android.Api.JPushInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetAliasAndTags (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setAliasAndTags' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("setAliasAndTags", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Set;)V", "GetSetAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_Handler")]
		public virtual unsafe void SetAliasAndTags (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.ICollection<string> p2)
		{
			const string __id = "setAliasAndTags.(Landroid/content/Context;Ljava/lang/String;Ljava/util/Set;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setAliasAndTags' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[4][@type='cn.jpush.android.api.TagAliasCallback']]"
		[Obsolete (@"deprecated")]
		[Register ("setAliasAndTags", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Set;Lcn/jpush/android/api/TagAliasCallback;)V", "")]
		public static unsafe void SetAliasAndTags (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.ICollection<string> p2, global::CN.Jpush.Android.Api.ITagAliasCallback p3)
		{
			const string __id = "setAliasAndTags.(Landroid/content/Context;Ljava/lang/String;Ljava/util/Set;Lcn/jpush/android/api/TagAliasCallback;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setChannel' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setChannel", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetChannel (global::Android.Content.Context p0, string p1)
		{
			const string __id = "setChannel.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setDaemonAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDaemonAction", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetDaemonAction (string p0)
		{
			const string __id = "setDaemonAction.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setDebugMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebugMode", "(Z)V", "")]
		public static unsafe void SetDebugMode (bool p0)
		{
			const string __id = "setDebugMode.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setDefaultPushNotificationBuilder' and count(parameter)=1 and parameter[1][@type='cn.jpush.android.api.DefaultPushNotificationBuilder']]"
		[Register ("setDefaultPushNotificationBuilder", "(Lcn/jpush/android/api/DefaultPushNotificationBuilder;)V", "")]
		public static unsafe void SetDefaultPushNotificationBuilder (global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder p0)
		{
			const string __id = "setDefaultPushNotificationBuilder.(Lcn/jpush/android/api/DefaultPushNotificationBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setGeofenceInterval' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("setGeofenceInterval", "(Landroid/content/Context;J)V", "")]
		public static unsafe void SetGeofenceInterval (global::Android.Content.Context p0, long p1)
		{
			const string __id = "setGeofenceInterval.(Landroid/content/Context;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setLatestNotificationNumber' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setLatestNotificationNumber", "(Landroid/content/Context;I)V", "")]
		public static unsafe void SetLatestNotificationNumber (global::Android.Content.Context p0, int p1)
		{
			const string __id = "setLatestNotificationNumber.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setMaxGeofenceNumber' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setMaxGeofenceNumber", "(Landroid/content/Context;I)V", "")]
		public static unsafe void SetMaxGeofenceNumber (global::Android.Content.Context p0, int p1)
		{
			const string __id = "setMaxGeofenceNumber.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setMobileNumber' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("setMobileNumber", "(Landroid/content/Context;ILjava/lang/String;)V", "")]
		public static unsafe void SetMobileNumber (global::Android.Content.Context p0, int p1, string p2)
		{
			const string __id = "setMobileNumber.(Landroid/content/Context;ILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setPowerSaveMode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setPowerSaveMode", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SetPowerSaveMode (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "setPowerSaveMode.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setPushNotificationBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='cn.jpush.android.api.DefaultPushNotificationBuilder']]"
		[Register ("setPushNotificationBuilder", "(Ljava/lang/Integer;Lcn/jpush/android/api/DefaultPushNotificationBuilder;)V", "")]
		public static unsafe void SetPushNotificationBuilder (global::Java.Lang.Integer p0, global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder p1)
		{
			const string __id = "setPushNotificationBuilder.(Ljava/lang/Integer;Lcn/jpush/android/api/DefaultPushNotificationBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setPushTime' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Set&lt;java.lang.Integer&gt;'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setPushTime", "(Landroid/content/Context;Ljava/util/Set;II)V", "")]
		public static unsafe void SetPushTime (global::Android.Content.Context p0, global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p1, int p2, int p3)
		{
			const string __id = "setPushTime.(Landroid/content/Context;Ljava/util/Set;II)V";
			IntPtr native_p1 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setSilenceTime' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("setSilenceTime", "(Landroid/content/Context;IIII)V", "")]
		public static unsafe void SetSilenceTime (global::Android.Content.Context p0, int p1, int p2, int p3, int p4)
		{
			const string __id = "setSilenceTime.(Landroid/content/Context;IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setStatisticsEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setStatisticsEnable", "(Z)V", "")]
		public static unsafe void SetStatisticsEnable (bool p0)
		{
			const string __id = "setStatisticsEnable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setStatisticsSessionTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setStatisticsSessionTimeout", "(J)V", "")]
		public static unsafe void SetStatisticsSessionTimeout (long p0)
		{
			const string __id = "setStatisticsSessionTimeout.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setTags' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("setTags", "(Landroid/content/Context;ILjava/util/Set;)V", "")]
		public static unsafe void SetTags (global::Android.Content.Context p0, int p1, global::System.Collections.Generic.ICollection<string> p2)
		{
			const string __id = "setTags.(Landroid/content/Context;ILjava/util/Set;)V";
			IntPtr native_p2 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setTags' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='cn.jpush.android.api.TagAliasCallback']]"
		[Obsolete (@"deprecated")]
		[Register ("setTags", "(Landroid/content/Context;Ljava/util/Set;Lcn/jpush/android/api/TagAliasCallback;)V", "")]
		public static unsafe void SetTags (global::Android.Content.Context p0, global::System.Collections.Generic.ICollection<string> p1, global::CN.Jpush.Android.Api.ITagAliasCallback p2)
		{
			const string __id = "setTags.(Landroid/content/Context;Ljava/util/Set;Lcn/jpush/android/api/TagAliasCallback;)V";
			IntPtr native_p1 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p1);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='stopCrashHandler' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stopCrashHandler", "(Landroid/content/Context;)V", "")]
		public static unsafe void StopCrashHandler (global::Android.Content.Context p0)
		{
			const string __id = "stopCrashHandler.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='stopPush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stopPush", "(Landroid/content/Context;)V", "")]
		public static unsafe void StopPush (global::Android.Content.Context p0)
		{
			const string __id = "stopPush.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
