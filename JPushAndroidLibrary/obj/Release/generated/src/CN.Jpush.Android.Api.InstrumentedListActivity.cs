using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='InstrumentedListActivity']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/InstrumentedListActivity", DoNotGenerateAcw=true)]
	public partial class InstrumentedListActivity : global::Android.App.ListActivity {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/api/InstrumentedListActivity", typeof (InstrumentedListActivity));
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

		protected InstrumentedListActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='InstrumentedListActivity']/constructor[@name='InstrumentedListActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstrumentedListActivity ()
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

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.InstrumentedListActivity __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.InstrumentedListActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='InstrumentedListActivity']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			const string __id = "onStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.InstrumentedListActivity __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.InstrumentedListActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='InstrumentedListActivity']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			const string __id = "onStop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
