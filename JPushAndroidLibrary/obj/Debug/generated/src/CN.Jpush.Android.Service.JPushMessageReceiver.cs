using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='JPushMessageReceiver']"
	[global::Android.Runtime.Register ("cn/jpush/android/service/JPushMessageReceiver", DoNotGenerateAcw=true)]
	public abstract partial class JPushMessageReceiver : global::Android.Content.BroadcastReceiver {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/service/JPushMessageReceiver", typeof (JPushMessageReceiver));
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

		protected JPushMessageReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='JPushMessageReceiver']/constructor[@name='JPushMessageReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JPushMessageReceiver ()
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

		static Delegate cb_onAliasOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_;
#pragma warning disable 0169
		static Delegate GetOnAliasOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_Handler ()
		{
			if (cb_onAliasOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_ == null)
				cb_onAliasOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAliasOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_);
			return cb_onAliasOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_;
		}

		static void n_OnAliasOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jpush.Android.Service.JPushMessageReceiver __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.JPushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::CN.Jpush.Android.Api.JPushMessage p1 = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAliasOperatorResult (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='JPushMessageReceiver']/method[@name='onAliasOperatorResult' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jpush.android.api.JPushMessage']]"
		[Register ("onAliasOperatorResult", "(Landroid/content/Context;Lcn/jpush/android/api/JPushMessage;)V", "GetOnAliasOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_Handler")]
		public virtual unsafe void OnAliasOperatorResult (global::Android.Content.Context p0, global::CN.Jpush.Android.Api.JPushMessage p1)
		{
			const string __id = "onAliasOperatorResult.(Landroid/content/Context;Lcn/jpush/android/api/JPushMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onCheckTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_;
#pragma warning disable 0169
		static Delegate GetOnCheckTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_Handler ()
		{
			if (cb_onCheckTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_ == null)
				cb_onCheckTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCheckTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_);
			return cb_onCheckTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_;
		}

		static void n_OnCheckTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jpush.Android.Service.JPushMessageReceiver __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.JPushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::CN.Jpush.Android.Api.JPushMessage p1 = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCheckTagOperatorResult (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='JPushMessageReceiver']/method[@name='onCheckTagOperatorResult' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jpush.android.api.JPushMessage']]"
		[Register ("onCheckTagOperatorResult", "(Landroid/content/Context;Lcn/jpush/android/api/JPushMessage;)V", "GetOnCheckTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_Handler")]
		public virtual unsafe void OnCheckTagOperatorResult (global::Android.Content.Context p0, global::CN.Jpush.Android.Api.JPushMessage p1)
		{
			const string __id = "onCheckTagOperatorResult.(Landroid/content/Context;Lcn/jpush/android/api/JPushMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onMobileNumberOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_;
#pragma warning disable 0169
		static Delegate GetOnMobileNumberOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_Handler ()
		{
			if (cb_onMobileNumberOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_ == null)
				cb_onMobileNumberOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMobileNumberOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_);
			return cb_onMobileNumberOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_;
		}

		static void n_OnMobileNumberOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jpush.Android.Service.JPushMessageReceiver __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.JPushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::CN.Jpush.Android.Api.JPushMessage p1 = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMobileNumberOperatorResult (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='JPushMessageReceiver']/method[@name='onMobileNumberOperatorResult' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jpush.android.api.JPushMessage']]"
		[Register ("onMobileNumberOperatorResult", "(Landroid/content/Context;Lcn/jpush/android/api/JPushMessage;)V", "GetOnMobileNumberOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_Handler")]
		public virtual unsafe void OnMobileNumberOperatorResult (global::Android.Content.Context p0, global::CN.Jpush.Android.Api.JPushMessage p1)
		{
			const string __id = "onMobileNumberOperatorResult.(Landroid/content/Context;Lcn/jpush/android/api/JPushMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='JPushMessageReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public override sealed unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			const string __id = "onReceive.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_;
#pragma warning disable 0169
		static Delegate GetOnTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_Handler ()
		{
			if (cb_onTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_ == null)
				cb_onTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_);
			return cb_onTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_;
		}

		static void n_OnTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jpush.Android.Service.JPushMessageReceiver __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.JPushMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::CN.Jpush.Android.Api.JPushMessage p1 = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnTagOperatorResult (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='JPushMessageReceiver']/method[@name='onTagOperatorResult' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jpush.android.api.JPushMessage']]"
		[Register ("onTagOperatorResult", "(Landroid/content/Context;Lcn/jpush/android/api/JPushMessage;)V", "GetOnTagOperatorResult_Landroid_content_Context_Lcn_jpush_android_api_JPushMessage_Handler")]
		public virtual unsafe void OnTagOperatorResult (global::Android.Content.Context p0, global::CN.Jpush.Android.Api.JPushMessage p1)
		{
			const string __id = "onTagOperatorResult.(Landroid/content/Context;Lcn/jpush/android/api/JPushMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("cn/jpush/android/service/JPushMessageReceiver", DoNotGenerateAcw=true)]
	internal partial class JPushMessageReceiverInvoker : JPushMessageReceiver {

		public JPushMessageReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("cn/jpush/android/service/JPushMessageReceiver", typeof (JPushMessageReceiverInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
