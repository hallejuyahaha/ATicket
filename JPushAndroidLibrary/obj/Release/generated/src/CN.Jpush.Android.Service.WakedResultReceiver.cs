using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='WakedResultReceiver']"
	[global::Android.Runtime.Register ("cn/jpush/android/service/WakedResultReceiver", DoNotGenerateAcw=true)]
	public partial class WakedResultReceiver : global::Android.Content.BroadcastReceiver {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='WakedResultReceiver']/field[@name='CONTEXT_KEY']"
		[Register ("CONTEXT_KEY")]
		public const string ContextKey = (string) "1";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='WakedResultReceiver']/field[@name='WAKE_TYPE_KEY']"
		[Register ("WAKE_TYPE_KEY")]
		public const string WakeTypeKey = (string) "2";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/service/WakedResultReceiver", typeof (WakedResultReceiver));
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

		protected WakedResultReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='WakedResultReceiver']/constructor[@name='WakedResultReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WakedResultReceiver ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='WakedResultReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
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

		static Delegate cb_onWake_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetOnWake_Landroid_content_Context_IHandler ()
		{
			if (cb_onWake_Landroid_content_Context_I == null)
				cb_onWake_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnWake_Landroid_content_Context_I);
			return cb_onWake_Landroid_content_Context_I;
		}

		static void n_OnWake_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::CN.Jpush.Android.Service.WakedResultReceiver __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.WakedResultReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnWake (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='WakedResultReceiver']/method[@name='onWake' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("onWake", "(Landroid/content/Context;I)V", "GetOnWake_Landroid_content_Context_IHandler")]
		public virtual unsafe void OnWake (global::Android.Content.Context p0, int p1)
		{
			const string __id = "onWake.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onWake_I;
#pragma warning disable 0169
		static Delegate GetOnWake_IHandler ()
		{
			if (cb_onWake_I == null)
				cb_onWake_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnWake_I);
			return cb_onWake_I;
		}

		static void n_OnWake_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jpush.Android.Service.WakedResultReceiver __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.WakedResultReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnWake (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='WakedResultReceiver']/method[@name='onWake' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onWake", "(I)V", "GetOnWake_IHandler")]
		public virtual unsafe void OnWake (int p0)
		{
			const string __id = "onWake.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='WakedResultReceiver']/method[@name='onWakeMap' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("onWakeMap", "(Ljava/util/Map;)V", "")]
		public unsafe void OnWakeMap (global::System.Collections.IDictionary p0)
		{
			const string __id = "onWakeMap.(Ljava/util/Map;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
