using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']"
	[global::Android.Runtime.Register ("cn/jiguang/net/HttpConstants", DoNotGenerateAcw=true)]
	public partial class HttpConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='CACHE_CONTROL']"
		[Register ("CACHE_CONTROL")]
		public const string CacheControl = (string) "cache-control";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='EXPIRES']"
		[Register ("EXPIRES")]
		public const string Expires = (string) "expires";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='NET_ERROR_CODE']"
		[Register ("NET_ERROR_CODE")]
		public const int NetErrorCode = (int) 2998;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='NET_MALTFORMED_ERROR']"
		[Register ("NET_MALTFORMED_ERROR")]
		public const int NetMaltformedError = (int) 3004;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='NET_SSL_EXECPTION']"
		[Register ("NET_SSL_EXECPTION")]
		public const int NetSslExecption = (int) 3005;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='NET_TIMEOUT_CODE']"
		[Register ("NET_TIMEOUT_CODE")]
		public const int NetTimeoutCode = (int) 3001;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='NET_UNKNOW_HOST']"
		[Register ("NET_UNKNOW_HOST")]
		public const int NetUnknowHost = (int) 3003;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='STACK_OVER_EXECPTION']"
		[Register ("STACK_OVER_EXECPTION")]
		public const int StackOverExecption = (int) 3007;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='UNKNOW_EXECPTION']"
		[Register ("UNKNOW_EXECPTION")]
		public const int UnknowExecption = (int) 3006;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/net/HttpConstants", typeof (HttpConstants));
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

		protected HttpConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/constructor[@name='HttpConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpConstants ()
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

	}
}
