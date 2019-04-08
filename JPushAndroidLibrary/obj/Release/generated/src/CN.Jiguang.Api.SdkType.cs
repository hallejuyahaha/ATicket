using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']"
	[global::Android.Runtime.Register ("cn/jiguang/api/SdkType", DoNotGenerateAcw=true)]
	public sealed partial class SdkType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/field[@name='JANALYTICS']"
		[Register ("JANALYTICS")]
		public static global::CN.Jiguang.Api.SdkType Janalytics {
			get {
				const string __id = "JANALYTICS.Lcn/jiguang/api/SdkType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/field[@name='JCORE']"
		[Register ("JCORE")]
		public static global::CN.Jiguang.Api.SdkType Jcore {
			get {
				const string __id = "JCORE.Lcn/jiguang/api/SdkType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/field[@name='JMESSAGE']"
		[Register ("JMESSAGE")]
		public static global::CN.Jiguang.Api.SdkType Jmessage {
			get {
				const string __id = "JMESSAGE.Lcn/jiguang/api/SdkType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/field[@name='JPUSH']"
		[Register ("JPUSH")]
		public static global::CN.Jiguang.Api.SdkType Jpush {
			get {
				const string __id = "JPUSH.Lcn/jiguang/api/SdkType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/field[@name='JSHARE']"
		[Register ("JSHARE")]
		public static global::CN.Jiguang.Api.SdkType Jshare {
			get {
				const string __id = "JSHARE.Lcn/jiguang/api/SdkType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/field[@name='JSSP']"
		[Register ("JSSP")]
		public static global::CN.Jiguang.Api.SdkType Jssp {
			get {
				const string __id = "JSSP.Lcn/jiguang/api/SdkType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/field[@name='JVERIFICATION']"
		[Register ("JVERIFICATION")]
		public static global::CN.Jiguang.Api.SdkType Jverification {
			get {
				const string __id = "JVERIFICATION.Lcn/jiguang/api/SdkType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/api/SdkType", typeof (SdkType));
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

		internal SdkType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcn/jiguang/api/SdkType;", "")]
		public static unsafe global::CN.Jiguang.Api.SdkType ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcn/jiguang/api/SdkType;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcn/jiguang/api/SdkType;", "")]
		public static unsafe global::CN.Jiguang.Api.SdkType[] Values ()
		{
			const string __id = "values.()[Lcn/jiguang/api/SdkType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::CN.Jiguang.Api.SdkType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::CN.Jiguang.Api.SdkType));
			} finally {
			}
		}

	}
}
