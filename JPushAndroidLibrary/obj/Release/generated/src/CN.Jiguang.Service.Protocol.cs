using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.service']/class[@name='Protocol']"
	[global::Android.Runtime.Register ("cn/jiguang/service/Protocol", DoNotGenerateAcw=true)]
	public partial class Protocol : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/service/Protocol", typeof (Protocol));
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

		protected Protocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe string CerTificate {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.service']/class[@name='Protocol']/method[@name='getCerTificate' and count(parameter)=0]"
			[Register ("getCerTificate", "()Ljava/lang/String;", "GetGetCerTificateHandler")]
			get {
				const string __id = "getCerTificate.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.service']/class[@name='Protocol']/method[@name='GetSdkVersion' and count(parameter)=0]"
			[Register ("GetSdkVersion", "()I", "GetGetSdkVersionHandler")]
			get {
				const string __id = "GetSdkVersion.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
