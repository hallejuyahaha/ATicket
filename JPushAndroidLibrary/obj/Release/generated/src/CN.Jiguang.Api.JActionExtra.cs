using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JActionExtra']"
	[global::Android.Runtime.Register ("cn/jiguang/api/JActionExtra", DoNotGenerateAcw=true)]
	public abstract partial class JActionExtra : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/api/JActionExtra", typeof (JActionExtra));
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

		protected JActionExtra (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JActionExtra']/constructor[@name='JActionExtra' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JActionExtra ()
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

		static Delegate cb_beforLogin_Landroid_content_Context_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBeforLogin_Landroid_content_Context_ILjava_lang_String_Handler ()
		{
			if (cb_beforLogin_Landroid_content_Context_ILjava_lang_String_ == null)
				cb_beforLogin_Landroid_content_Context_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_BeforLogin_Landroid_content_Context_ILjava_lang_String_);
			return cb_beforLogin_Landroid_content_Context_ILjava_lang_String_;
		}

		static IntPtr n_BeforLogin_Landroid_content_Context_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.JActionExtra __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JActionExtra> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BeforLogin (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JActionExtra']/method[@name='beforLogin' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("beforLogin", "(Landroid/content/Context;ILjava/lang/String;)Ljava/lang/Object;", "GetBeforLogin_Landroid_content_Context_ILjava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object BeforLogin (global::Android.Content.Context p0, int p1, string p2)
		{
			const string __id = "beforLogin.(Landroid/content/Context;ILjava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_beforRegister_Landroid_content_Context_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBeforRegister_Landroid_content_Context_ILjava_lang_String_Handler ()
		{
			if (cb_beforRegister_Landroid_content_Context_ILjava_lang_String_ == null)
				cb_beforRegister_Landroid_content_Context_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_BeforRegister_Landroid_content_Context_ILjava_lang_String_);
			return cb_beforRegister_Landroid_content_Context_ILjava_lang_String_;
		}

		static IntPtr n_BeforRegister_Landroid_content_Context_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.JActionExtra __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JActionExtra> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BeforRegister (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JActionExtra']/method[@name='beforRegister' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("beforRegister", "(Landroid/content/Context;ILjava/lang/String;)Ljava/lang/Object;", "GetBeforRegister_Landroid_content_Context_ILjava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object BeforRegister (global::Android.Content.Context p0, int p1, string p2)
		{
			const string __id = "beforRegister.(Landroid/content/Context;ILjava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_checkAction_I;
#pragma warning disable 0169
		static Delegate GetCheckAction_IHandler ()
		{
			if (cb_checkAction_I == null)
				cb_checkAction_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_CheckAction_I);
			return cb_checkAction_I;
		}

		static bool n_CheckAction_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.JActionExtra __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JActionExtra> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckAction (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JActionExtra']/method[@name='checkAction' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkAction", "(I)Z", "GetCheckAction_IHandler")]
		public virtual unsafe bool CheckAction (int p0)
		{
			const string __id = "checkAction.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onSendData_Landroid_content_Context_JJII;
#pragma warning disable 0169
		static Delegate GetOnSendData_Landroid_content_Context_JJIIHandler ()
		{
			if (cb_onSendData_Landroid_content_Context_JJII == null)
				cb_onSendData_Landroid_content_Context_JJII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long, int, int, IntPtr>) n_OnSendData_Landroid_content_Context_JJII);
			return cb_onSendData_Landroid_content_Context_JJII;
		}

		static IntPtr n_OnSendData_Landroid_content_Context_JJII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, int p3, int p4)
		{
			global::CN.Jiguang.Api.JActionExtra __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JActionExtra> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnSendData (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JActionExtra']/method[@name='onSendData' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onSendData", "(Landroid/content/Context;JJII)Ljava/lang/Object;", "GetOnSendData_Landroid_content_Context_JJIIHandler")]
		public virtual unsafe global::Java.Lang.Object OnSendData (global::Android.Content.Context p0, long p1, long p2, int p3, int p4)
		{
			const string __id = "onSendData.(Landroid/content/Context;JJII)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("cn/jiguang/api/JActionExtra", DoNotGenerateAcw=true)]
	internal partial class JActionExtraInvoker : JActionExtra {

		public JActionExtraInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("cn/jiguang/api/JActionExtra", typeof (JActionExtraInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
