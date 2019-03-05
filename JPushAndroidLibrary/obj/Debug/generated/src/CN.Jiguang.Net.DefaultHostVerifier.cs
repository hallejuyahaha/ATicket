using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.net']/class[@name='DefaultHostVerifier']"
	[global::Android.Runtime.Register ("cn/jiguang/net/DefaultHostVerifier", DoNotGenerateAcw=true)]
	public partial class DefaultHostVerifier : global::Java.Lang.Object, global::Javax.Net.Ssl.IHostnameVerifier {



		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='DefaultHostVerifier']/field[@name='a']"
		[Register ("a")]
		public string A {
			get {
				const string __id = "a.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/net/DefaultHostVerifier", typeof (DefaultHostVerifier));
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

		protected DefaultHostVerifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='DefaultHostVerifier']/constructor[@name='DefaultHostVerifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe DefaultHostVerifier (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_;
#pragma warning disable 0169
		static Delegate GetVerify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_Handler ()
		{
			if (cb_verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_ == null)
				cb_verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_);
			return cb_verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_;
		}

		static bool n_Verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Net.DefaultHostVerifier __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.DefaultHostVerifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.ISSLSession p1 = (global::Javax.Net.Ssl.ISSLSession)global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.ISSLSession> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Verify (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='DefaultHostVerifier']/method[@name='verify' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='javax.net.ssl.SSLSession']]"
		[Register ("verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z", "GetVerify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_Handler")]
		public virtual unsafe bool Verify (string p0, global::Javax.Net.Ssl.ISSLSession p1)
		{
			const string __id = "verify.(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
