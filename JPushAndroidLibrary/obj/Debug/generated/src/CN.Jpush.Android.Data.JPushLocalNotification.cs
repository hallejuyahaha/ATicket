using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']"
	[global::Android.Runtime.Register ("cn/jpush/android/data/JPushLocalNotification", DoNotGenerateAcw=true)]
	public partial class JPushLocalNotification : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/data/JPushLocalNotification", typeof (JPushLocalNotification));
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

		protected JPushLocalNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/constructor[@name='JPushLocalNotification' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JPushLocalNotification ()
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

		static Delegate cb_getBroadcastTime;
#pragma warning disable 0169
		static Delegate GetGetBroadcastTimeHandler ()
		{
			if (cb_getBroadcastTime == null)
				cb_getBroadcastTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBroadcastTime);
			return cb_getBroadcastTime;
		}

		static long n_GetBroadcastTime (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BroadcastTime;
		}
#pragma warning restore 0169

		static Delegate cb_setBroadcastTime_J;
#pragma warning disable 0169
		static Delegate GetSetBroadcastTime_JHandler ()
		{
			if (cb_setBroadcastTime_J == null)
				cb_setBroadcastTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetBroadcastTime_J);
			return cb_setBroadcastTime_J;
		}

		static void n_SetBroadcastTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BroadcastTime = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long BroadcastTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='getBroadcastTime' and count(parameter)=0]"
			[Register ("getBroadcastTime", "()J", "GetGetBroadcastTimeHandler")]
			get {
				const string __id = "getBroadcastTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setBroadcastTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setBroadcastTime", "(J)V", "GetSetBroadcastTime_JHandler")]
			set {
				const string __id = "setBroadcastTime.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBuilderId;
#pragma warning disable 0169
		static Delegate GetGetBuilderIdHandler ()
		{
			if (cb_getBuilderId == null)
				cb_getBuilderId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBuilderId);
			return cb_getBuilderId;
		}

		static long n_GetBuilderId (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BuilderId;
		}
#pragma warning restore 0169

		static Delegate cb_setBuilderId_J;
#pragma warning disable 0169
		static Delegate GetSetBuilderId_JHandler ()
		{
			if (cb_setBuilderId_J == null)
				cb_setBuilderId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetBuilderId_J);
			return cb_setBuilderId_J;
		}

		static void n_SetBuilderId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BuilderId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long BuilderId {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='getBuilderId' and count(parameter)=0]"
			[Register ("getBuilderId", "()J", "GetGetBuilderIdHandler")]
			get {
				const string __id = "getBuilderId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setBuilderId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setBuilderId", "(J)V", "GetSetBuilderId_JHandler")]
			set {
				const string __id = "setBuilderId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Content);
		}
#pragma warning restore 0169

		static Delegate cb_setContent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContent_Ljava_lang_String_Handler ()
		{
			if (cb_setContent_Ljava_lang_String_ == null)
				cb_setContent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContent_Ljava_lang_String_);
			return cb_setContent_Ljava_lang_String_;
		}

		static void n_SetContent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Content = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/lang/String;", "GetGetContentHandler")]
			get {
				const string __id = "getContent.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setContent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContent", "(Ljava/lang/String;)V", "GetSetContent_Ljava_lang_String_Handler")]
			set {
				const string __id = "setContent.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getExtras;
#pragma warning disable 0169
		static Delegate GetGetExtrasHandler ()
		{
			if (cb_getExtras == null)
				cb_getExtras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtras);
			return cb_getExtras;
		}

		static IntPtr n_GetExtras (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Extras);
		}
#pragma warning restore 0169

		static Delegate cb_setExtras_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExtras_Ljava_lang_String_Handler ()
		{
			if (cb_setExtras_Ljava_lang_String_ == null)
				cb_setExtras_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtras_Ljava_lang_String_);
			return cb_setExtras_Ljava_lang_String_;
		}

		static void n_SetExtras_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Extras = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Extras {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='getExtras' and count(parameter)=0]"
			[Register ("getExtras", "()Ljava/lang/String;", "GetGetExtrasHandler")]
			get {
				const string __id = "getExtras.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setExtras' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExtras", "(Ljava/lang/String;)V", "GetSetExtras_Ljava_lang_String_Handler")]
			set {
				const string __id = "setExtras.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNotificationId;
#pragma warning disable 0169
		static Delegate GetGetNotificationIdHandler ()
		{
			if (cb_getNotificationId == null)
				cb_getNotificationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNotificationId);
			return cb_getNotificationId;
		}

		static long n_GetNotificationId (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotificationId;
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationId_J;
#pragma warning disable 0169
		static Delegate GetSetNotificationId_JHandler ()
		{
			if (cb_setNotificationId_J == null)
				cb_setNotificationId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetNotificationId_J);
			return cb_setNotificationId_J;
		}

		static void n_SetNotificationId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotificationId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long NotificationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='getNotificationId' and count(parameter)=0]"
			[Register ("getNotificationId", "()J", "GetGetNotificationIdHandler")]
			get {
				const string __id = "getNotificationId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setNotificationId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setNotificationId", "(J)V", "GetSetNotificationId_JHandler")]
			set {
				const string __id = "setNotificationId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTitle.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setBroadcastTime_IIIIII;
#pragma warning disable 0169
		static Delegate GetSetBroadcastTime_IIIIIIHandler ()
		{
			if (cb_setBroadcastTime_IIIIII == null)
				cb_setBroadcastTime_IIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int, int, int>) n_SetBroadcastTime_IIIIII);
			return cb_setBroadcastTime_IIIIII;
		}

		static void n_SetBroadcastTime_IIIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, int p5)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBroadcastTime (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setBroadcastTime' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("setBroadcastTime", "(IIIIII)V", "GetSetBroadcastTime_IIIIIIHandler")]
		public virtual unsafe void SetBroadcastTime (int p0, int p1, int p2, int p3, int p4, int p5)
		{
			const string __id = "setBroadcastTime.(IIIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBroadcastTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetBroadcastTime_Ljava_util_Date_Handler ()
		{
			if (cb_setBroadcastTime_Ljava_util_Date_ == null)
				cb_setBroadcastTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBroadcastTime_Ljava_util_Date_);
			return cb_setBroadcastTime_Ljava_util_Date_;
		}

		static void n_SetBroadcastTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBroadcastTime (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setBroadcastTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("setBroadcastTime", "(Ljava/util/Date;)V", "GetSetBroadcastTime_Ljava_util_Date_Handler")]
		public virtual unsafe void SetBroadcastTime (global::Java.Util.Date p0)
		{
			const string __id = "setBroadcastTime.(Ljava/util/Date;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_toJSON;
#pragma warning disable 0169
		static Delegate GetToJSONHandler ()
		{
			if (cb_toJSON == null)
				cb_toJSON = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJSON);
			return cb_toJSON;
		}

		static IntPtr n_ToJSON (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJSON ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='toJSON' and count(parameter)=0]"
		[Register ("toJSON", "()Ljava/lang/String;", "GetToJSONHandler")]
		public virtual unsafe string ToJSON ()
		{
			const string __id = "toJSON.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
