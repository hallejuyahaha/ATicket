using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']"
	[global::Android.Runtime.Register ("cn/jiguang/api/utils/ProtocolUtil", DoNotGenerateAcw=true)]
	public partial class ProtocolUtil : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/api/utils/ProtocolUtil", typeof (ProtocolUtil));
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

		protected ProtocolUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/constructor[@name='ProtocolUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProtocolUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='fillIntData' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("fillIntData", "([BII)V", "")]
		public static unsafe void FillIntData (byte[] p0, int p1, int p2)
		{
			const string __id = "fillIntData.([BII)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='fillStringData' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("fillStringData", "([BLjava/lang/String;I)V", "")]
		public static unsafe void FillStringData (byte[] p0, string p1, int p2)
		{
			const string __id = "fillStringData.([BLjava/lang/String;I)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='fixedStringToBytes' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("fixedStringToBytes", "(Ljava/lang/String;I)[B", "")]
		public static unsafe byte[] FixedStringToBytes (string p0, int p1)
		{
			const string __id = "fixedStringToBytes.(Ljava/lang/String;I)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='getBytes' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getBytes", "(Ljava/nio/ByteBuffer;)[B", "")]
		public static unsafe byte[] GetBytes (global::Java.Nio.ByteBuffer p0)
		{
			const string __id = "getBytes.(Ljava/nio/ByteBuffer;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='getBytesConsumed' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getBytesConsumed", "(Ljava/nio/ByteBuffer;)[B", "")]
		public static unsafe byte[] GetBytesConsumed (global::Java.Nio.ByteBuffer p0)
		{
			const string __id = "getBytesConsumed.(Ljava/nio/ByteBuffer;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='getDefaultByte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDefaultByte", "(I)[B", "")]
		public static unsafe byte[] GetDefaultByte (int p0)
		{
			const string __id = "getDefaultByte.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("getString", "(Ljava/nio/ByteBuffer;I)Ljava/lang/String;", "")]
		public static unsafe string GetString (global::Java.Nio.ByteBuffer p0, int p1)
		{
			const string __id = "getString.(Ljava/nio/ByteBuffer;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='getTlv2' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getTlv2", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;", "")]
		public static unsafe string GetTlv2 (global::Java.Nio.ByteBuffer p0)
		{
			const string __id = "getTlv2.(Ljava/nio/ByteBuffer;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='getTlv2' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='cn.jiguang.api.JResponse']]"
		[Register ("getTlv2", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)Ljava/lang/String;", "")]
		public static unsafe string GetTlv2 (global::Java.Nio.ByteBuffer p0, global::CN.Jiguang.Api.JResponse p1)
		{
			const string __id = "getTlv2.(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='int2ByteArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("int2ByteArray", "(I)[B", "")]
		public static unsafe byte[] Int2ByteArray (int p0)
		{
			const string __id = "int2ByteArray.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='long2ByteArray' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("long2ByteArray", "(J)[B", "")]
		public static unsafe byte[] Long2ByteArray (long p0)
		{
			const string __id = "long2ByteArray.(J)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			const string __id = "main.([Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='short2ByteArray' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("short2ByteArray", "(S)[B", "")]
		public static unsafe byte[] Short2ByteArray (short p0)
		{
			const string __id = "short2ByteArray.(S)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='tlv2ToByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("tlv2ToByteArray", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Tlv2ToByteArray (string p0)
		{
			const string __id = "tlv2ToByteArray.(Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
