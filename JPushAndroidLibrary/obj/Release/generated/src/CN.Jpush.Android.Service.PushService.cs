using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']"
	[global::Android.Runtime.Register ("cn/jpush/android/service/PushService", DoNotGenerateAcw=true)]
	public partial class PushService : global::Android.App.Service {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/service/PushService", typeof (PushService));
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

		protected PushService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/constructor[@name='PushService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushService ()
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

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Service.PushService __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			const string __id = "onBind.(Landroid/content/Intent;)Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_runCreate;
#pragma warning disable 0169
		static Delegate GetRunCreateHandler ()
		{
			if (cb_runCreate == null)
				cb_runCreate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RunCreate);
			return cb_runCreate;
		}

		static void n_RunCreate (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Service.PushService __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunCreate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='runCreate' and count(parameter)=0]"
		[Register ("runCreate", "()V", "GetRunCreateHandler")]
		public virtual unsafe void RunCreate ()
		{
			const string __id = "runCreate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_runDestroy;
#pragma warning disable 0169
		static Delegate GetRunDestroyHandler ()
		{
			if (cb_runDestroy == null)
				cb_runDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RunDestroy);
			return cb_runDestroy;
		}

		static void n_RunDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Service.PushService __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='runDestroy' and count(parameter)=0]"
		[Register ("runDestroy", "()V", "GetRunDestroyHandler")]
		public virtual unsafe void RunDestroy ()
		{
			const string __id = "runDestroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_runStart_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetRunStart_Landroid_content_Intent_Handler ()
		{
			if (cb_runStart_Landroid_content_Intent_ == null)
				cb_runStart_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RunStart_Landroid_content_Intent_);
			return cb_runStart_Landroid_content_Intent_;
		}

		static void n_RunStart_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Service.PushService __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RunStart (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='runStart' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("runStart", "(Landroid/content/Intent;)V", "GetRunStart_Landroid_content_Intent_Handler")]
		public virtual unsafe void RunStart (global::Android.Content.Intent p0)
		{
			const string __id = "runStart.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDozePowerReceiver;
#pragma warning disable 0169
		static Delegate GetSetDozePowerReceiverHandler ()
		{
			if (cb_setDozePowerReceiver == null)
				cb_setDozePowerReceiver = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetDozePowerReceiver);
			return cb_setDozePowerReceiver;
		}

		static void n_SetDozePowerReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Service.PushService __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDozePowerReceiver ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='setDozePowerReceiver' and count(parameter)=0]"
		[Register ("setDozePowerReceiver", "()V", "GetSetDozePowerReceiverHandler")]
		public virtual unsafe void SetDozePowerReceiver ()
		{
			const string __id = "setDozePowerReceiver.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
