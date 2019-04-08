using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='MultiActionsNotificationBuilder']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/MultiActionsNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class MultiActionsNotificationBuilder : global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder {



		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='MultiActionsNotificationBuilder']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				const string __id = "mContext.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContext.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/api/MultiActionsNotificationBuilder", typeof (MultiActionsNotificationBuilder));
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

		protected MultiActionsNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='MultiActionsNotificationBuilder']/constructor[@name='MultiActionsNotificationBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MultiActionsNotificationBuilder (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addJPushAction_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddJPushAction_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addJPushAction_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_addJPushAction_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_AddJPushAction_ILjava_lang_String_Ljava_lang_String_);
			return cb_addJPushAction_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_AddJPushAction_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jpush.Android.Api.MultiActionsNotificationBuilder __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.MultiActionsNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddJPushAction (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='MultiActionsNotificationBuilder']/method[@name='addJPushAction' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("addJPushAction", "(ILjava/lang/String;Ljava/lang/String;)V", "GetAddJPushAction_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddJPushAction (int p0, string p1, string p2)
		{
			const string __id = "addJPushAction.(ILjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
