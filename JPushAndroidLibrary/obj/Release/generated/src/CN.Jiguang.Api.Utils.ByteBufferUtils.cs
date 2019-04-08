using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']"
	[global::Android.Runtime.Register ("cn/jiguang/api/utils/ByteBufferUtils", DoNotGenerateAcw=true)]
	public partial class ByteBufferUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/field[@name='ERROR_CODE']"
		[Register ("ERROR_CODE")]
		public const int ErrorCode = (int) 10000;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/api/utils/ByteBufferUtils", typeof (ByteBufferUtils));
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

		protected ByteBufferUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/constructor[@name='ByteBufferUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ByteBufferUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='byte[]'] and parameter[3][@type='cn.jiguang.api.JResponse']]"
		[Register ("get", "(Ljava/nio/ByteBuffer;[BLcn/jiguang/api/JResponse;)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer Get (global::Java.Nio.ByteBuffer p0, byte[] p1, global::CN.Jiguang.Api.JResponse p2)
		{
			const string __id = "get.(Ljava/nio/ByteBuffer;[BLcn/jiguang/api/JResponse;)Ljava/nio/ByteBuffer;";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='cn.jiguang.api.JResponse']]"
		[Register ("get", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)Ljava/lang/Byte;", "")]
		public static unsafe global::Java.Lang.Byte Get (global::Java.Nio.ByteBuffer p0, global::CN.Jiguang.Api.JResponse p1)
		{
			const string __id = "get.(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)Ljava/lang/Byte;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Byte> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/method[@name='getInt' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='cn.jiguang.api.JResponse']]"
		[Register ("getInt", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)I", "")]
		public static unsafe int GetInt (global::Java.Nio.ByteBuffer p0, global::CN.Jiguang.Api.JResponse p1)
		{
			const string __id = "getInt.(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/method[@name='getLong' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='cn.jiguang.api.JResponse']]"
		[Register ("getLong", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)J", "")]
		public static unsafe long GetLong (global::Java.Nio.ByteBuffer p0, global::CN.Jiguang.Api.JResponse p1)
		{
			const string __id = "getLong.(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/method[@name='getShort' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='cn.jiguang.api.JResponse']]"
		[Register ("getShort", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)S", "")]
		public static unsafe short GetShort (global::Java.Nio.ByteBuffer p0, global::CN.Jiguang.Api.JResponse p1)
		{
			const string __id = "getShort.(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)S";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
