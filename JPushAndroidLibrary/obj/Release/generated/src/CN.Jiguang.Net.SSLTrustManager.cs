using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.net']/class[@name='SSLTrustManager']"
	[global::Android.Runtime.Register ("cn/jiguang/net/SSLTrustManager", DoNotGenerateAcw=true)]
	public partial class SSLTrustManager : global::Java.Lang.Object, global::Javax.Net.Ssl.IX509TrustManager {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/net/SSLTrustManager", typeof (SSLTrustManager));
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

		protected SSLTrustManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='SSLTrustManager']/constructor[@name='SSLTrustManager' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe SSLTrustManager (string p0)
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

		static Delegate cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler ()
		{
			if (cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == null)
				cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_);
			return cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
		}

		static void n_CheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Net.SSLTrustManager __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.SSLTrustManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.Cert.X509Certificate[] p0 = (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Security.Cert.X509Certificate));
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CheckClientTrusted (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='SSLTrustManager']/method[@name='checkClientTrusted' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "GetCheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler")]
		public virtual unsafe void CheckClientTrusted (global::Java.Security.Cert.X509Certificate[] p0, string p1)
		{
			const string __id = "checkClientTrusted.([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler ()
		{
			if (cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == null)
				cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_);
			return cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
		}

		static void n_CheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Net.SSLTrustManager __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.SSLTrustManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.Cert.X509Certificate[] p0 = (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Security.Cert.X509Certificate));
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CheckServerTrusted (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='SSLTrustManager']/method[@name='checkServerTrusted' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "GetCheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler")]
		public virtual unsafe void CheckServerTrusted (global::Java.Security.Cert.X509Certificate[] p0, string p1)
		{
			const string __id = "checkServerTrusted.([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getAcceptedIssuers;
#pragma warning disable 0169
		static Delegate GetGetAcceptedIssuersHandler ()
		{
			if (cb_getAcceptedIssuers == null)
				cb_getAcceptedIssuers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAcceptedIssuers);
			return cb_getAcceptedIssuers;
		}

		static IntPtr n_GetAcceptedIssuers (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.SSLTrustManager __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.SSLTrustManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAcceptedIssuers ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='SSLTrustManager']/method[@name='getAcceptedIssuers' and count(parameter)=0]"
		[Register ("getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;", "GetGetAcceptedIssuersHandler")]
		public virtual unsafe global::Java.Security.Cert.X509Certificate[] GetAcceptedIssuers ()
		{
			const string __id = "getAcceptedIssuers.()[Ljava/security/cert/X509Certificate;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
			} finally {
			}
		}

	}
}
