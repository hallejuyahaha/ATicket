using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JResponse']"
	[global::Android.Runtime.Register ("cn/jiguang/api/JResponse", DoNotGenerateAcw=true)]
	public abstract partial class JResponse : global::CN.Jiguang.Api.JProtocol {



		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JResponse']/field[@name='code']"
		[Register ("code")]
		public int Code {
			get {
				const string __id = "code.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "code.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/api/JResponse", typeof (JResponse));
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

		protected JResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JResponse']/constructor[@name='JResponse' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;[B)V", "")]
		public unsafe JResponse (global::Java.Nio.ByteBuffer p0, byte[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/nio/ByteBuffer;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JResponse']/constructor[@name='JResponse' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/nio/ByteBuffer;)V", "")]
		public unsafe JResponse (global::Java.Lang.Object p0, global::Java.Nio.ByteBuffer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;Ljava/nio/ByteBuffer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JResponse']/constructor[@name='JResponse' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(IIJJILjava/lang/String;)V", "")]
		public unsafe JResponse (int p0, int p1, long p2, long p3, int p4, string p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIJJILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (native_p5);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_parseBody;
#pragma warning disable 0169
		static Delegate GetParseBodyHandler ()
		{
			if (cb_parseBody == null)
				cb_parseBody = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ParseBody);
			return cb_parseBody;
		}

		static void n_ParseBody (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ParseBody ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JResponse']/method[@name='parseBody' and count(parameter)=0]"
		[Register ("parseBody", "()V", "GetParseBodyHandler")]
		protected override unsafe void ParseBody ()
		{
			const string __id = "parseBody.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writeBody;
#pragma warning disable 0169
		static Delegate GetWriteBodyHandler ()
		{
			if (cb_writeBody == null)
				cb_writeBody = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WriteBody);
			return cb_writeBody;
		}

		static void n_WriteBody (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteBody ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JResponse']/method[@name='writeBody' and count(parameter)=0]"
		[Register ("writeBody", "()V", "GetWriteBodyHandler")]
		protected override unsafe void WriteBody ()
		{
			const string __id = "writeBody.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("cn/jiguang/api/JResponse", DoNotGenerateAcw=true)]
	internal partial class JResponseInvoker : JResponse {

		public JResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("cn/jiguang/api/JResponse", typeof (JResponseInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe bool IsNeedParseeErrorMsg {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='isNeedParseeErrorMsg' and count(parameter)=0]"
			[Register ("isNeedParseeErrorMsg", "()Z", "GetIsNeedParseeErrorMsgHandler")]
			get {
				const string __id = "isNeedParseeErrorMsg.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
