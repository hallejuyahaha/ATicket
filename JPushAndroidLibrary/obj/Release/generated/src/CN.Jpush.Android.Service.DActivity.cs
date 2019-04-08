using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='DActivity']"
	[global::Android.Runtime.Register ("cn/jpush/android/service/DActivity", DoNotGenerateAcw=true)]
	public partial class DActivity : global::Android.App.Activity, global::Java.Lang.IRunnable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/service/DActivity", typeof (DActivity));
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

		protected DActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='DActivity']/constructor[@name='DActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DActivity ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='DActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "")]
		protected override sealed unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			const string __id = "onCreate.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='DActivity']/method[@name='onNewIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onNewIntent", "(Landroid/content/Intent;)V", "")]
		protected override sealed unsafe void OnNewIntent (global::Android.Content.Intent p0)
		{
			const string __id = "onNewIntent.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Service.DActivity __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.DActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='DActivity']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
