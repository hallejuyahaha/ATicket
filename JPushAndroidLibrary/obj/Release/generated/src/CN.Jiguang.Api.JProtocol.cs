using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']"
	[global::Android.Runtime.Register ("cn/jiguang/api/JProtocol", DoNotGenerateAcw=true)]
	public abstract partial class JProtocol : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/field[@name='DEFAULT_RESP_CODE']"
		[Register ("DEFAULT_RESP_CODE")]
		public const int DefaultRespCode = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/field[@name='DEFAULT_RID']"
		[Register ("DEFAULT_RID")]
		public const int DefaultRid = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/field[@name='DEFAULT_SID']"
		[Register ("DEFAULT_SID")]
		public const int DefaultSid = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/field[@name='NO_JUID']"
		[Register ("NO_JUID")]
		public const int NoJuid = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/field[@name='NO_RESP_CODE']"
		[Register ("NO_RESP_CODE")]
		public const int NoRespCode = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/field[@name='NO_SID']"
		[Register ("NO_SID")]
		public const int NoSid = (int) -1;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/api/JProtocol", typeof (JProtocol));
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

		protected JProtocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/constructor[@name='JProtocol' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register (".ctor", "(ZIIJ)V", "")]
		public unsafe JProtocol (bool p0, int p1, int p2, long p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZIIJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/constructor[@name='JProtocol' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='int'] and parameter[6][@type='long']]"
		[Register (".ctor", "(ZIIJIJ)V", "")]
		public unsafe JProtocol (bool p0, int p1, int p2, long p3, int p4, long p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZIIJIJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/constructor[@name='JProtocol' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(ZLjava/nio/ByteBuffer;[B)V", "")]
		public unsafe JProtocol (bool p0, global::Java.Nio.ByteBuffer p1, byte[] p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZLjava/nio/ByteBuffer;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/constructor[@name='JProtocol' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(ZLjava/lang/Object;Ljava/nio/ByteBuffer;)V", "")]
		public unsafe JProtocol (bool p0, global::Java.Lang.Object p1, global::Java.Nio.ByteBuffer p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZLjava/lang/Object;Ljava/nio/ByteBuffer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Body);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.ByteBuffer Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Ljava/nio/ByteBuffer;", "GetGetBodyHandler")]
			get {
				const string __id = "getBody.()Ljava/nio/ByteBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCommand;
#pragma warning disable 0169
		static Delegate GetGetCommandHandler ()
		{
			if (cb_getCommand == null)
				cb_getCommand = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCommand);
			return cb_getCommand;
		}

		static int n_GetCommand (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Command;
		}
#pragma warning restore 0169

		public virtual unsafe int Command {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getCommand' and count(parameter)=0]"
			[Register ("getCommand", "()I", "GetGetCommandHandler")]
			get {
				const string __id = "getCommand.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isNeedParseeErrorMsg;
#pragma warning disable 0169
		static Delegate GetIsNeedParseeErrorMsgHandler ()
		{
			if (cb_isNeedParseeErrorMsg == null)
				cb_isNeedParseeErrorMsg = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNeedParseeErrorMsg);
			return cb_isNeedParseeErrorMsg;
		}

		static bool n_IsNeedParseeErrorMsg (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeedParseeErrorMsg;
		}
#pragma warning restore 0169

		protected abstract bool IsNeedParseeErrorMsg {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='isNeedParseeErrorMsg' and count(parameter)=0]"
			[Register ("isNeedParseeErrorMsg", "()Z", "GetIsNeedParseeErrorMsgHandler")] get;
		}

		static Delegate cb_getJuid;
#pragma warning disable 0169
		static Delegate GetGetJuidHandler ()
		{
			if (cb_getJuid == null)
				cb_getJuid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetJuid);
			return cb_getJuid;
		}

		static long n_GetJuid (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Juid;
		}
#pragma warning restore 0169

		public virtual unsafe long Juid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getJuid' and count(parameter)=0]"
			[Register ("getJuid", "()J", "GetGetJuidHandler")]
			get {
				const string __id = "getJuid.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public abstract string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")] get;
		}

		static Delegate cb_getRid;
#pragma warning disable 0169
		static Delegate GetGetRidHandler ()
		{
			if (cb_getRid == null)
				cb_getRid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRid);
			return cb_getRid;
		}

		static IntPtr n_GetRid (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rid);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long Rid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getRid' and count(parameter)=0]"
			[Register ("getRid", "()Ljava/lang/Long;", "GetGetRidHandler")]
			get {
				const string __id = "getRid.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSid;
#pragma warning disable 0169
		static Delegate GetGetSidHandler ()
		{
			if (cb_getSid == null)
				cb_getSid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSid);
			return cb_getSid;
		}

		static int n_GetSid (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sid;
		}
#pragma warning restore 0169

		public virtual unsafe int Sid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getSid' and count(parameter)=0]"
			[Register ("getSid", "()I", "GetGetSidHandler")]
			get {
				const string __id = "getSid.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		public virtual unsafe int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ParseBody ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='parseBody' and count(parameter)=0]"
		[Register ("parseBody", "()V", "GetParseBodyHandler")]
		protected abstract void ParseBody ();

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='parseHead' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("parseHead", "(Ljava/lang/Object;)[B", "")]
		public static unsafe byte[] ParseHead (global::Java.Lang.Object p0)
		{
			const string __id = "parseHead.(Ljava/lang/Object;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteBody ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeBody' and count(parameter)=0]"
		[Register ("writeBody", "()V", "GetWriteBodyHandler")]
		protected abstract void WriteBody ();

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeBodyAndToBytes' and count(parameter)=0]"
		[Register ("writeBodyAndToBytes", "()[B", "")]
		public unsafe byte[] WriteBodyAndToBytes ()
		{
			const string __id = "writeBodyAndToBytes.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_writeBytes_arrayB;
#pragma warning disable 0169
		static Delegate GetWriteBytes_arrayBHandler ()
		{
			if (cb_writeBytes_arrayB == null)
				cb_writeBytes_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteBytes_arrayB);
			return cb_writeBytes_arrayB;
		}

		static void n_WriteBytes_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteBytes (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("writeBytes", "([B)V", "GetWriteBytes_arrayBHandler")]
		protected virtual unsafe void WriteBytes (byte[] p0)
		{
			const string __id = "writeBytes.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_writeInt1_I;
#pragma warning disable 0169
		static Delegate GetWriteInt1_IHandler ()
		{
			if (cb_writeInt1_I == null)
				cb_writeInt1_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_WriteInt1_I);
			return cb_writeInt1_I;
		}

		static void n_WriteInt1_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteInt1 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeInt1' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeInt1", "(I)V", "GetWriteInt1_IHandler")]
		protected virtual unsafe void WriteInt1 (int p0)
		{
			const string __id = "writeInt1.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeInt2_I;
#pragma warning disable 0169
		static Delegate GetWriteInt2_IHandler ()
		{
			if (cb_writeInt2_I == null)
				cb_writeInt2_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_WriteInt2_I);
			return cb_writeInt2_I;
		}

		static void n_WriteInt2_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteInt2 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeInt2' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeInt2", "(I)V", "GetWriteInt2_IHandler")]
		protected virtual unsafe void WriteInt2 (int p0)
		{
			const string __id = "writeInt2.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeInt4_I;
#pragma warning disable 0169
		static Delegate GetWriteInt4_IHandler ()
		{
			if (cb_writeInt4_I == null)
				cb_writeInt4_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_WriteInt4_I);
			return cb_writeInt4_I;
		}

		static void n_WriteInt4_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteInt4 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeInt4' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeInt4", "(I)V", "GetWriteInt4_IHandler")]
		protected virtual unsafe void WriteInt4 (int p0)
		{
			const string __id = "writeInt4.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeLong8_J;
#pragma warning disable 0169
		static Delegate GetWriteLong8_JHandler ()
		{
			if (cb_writeLong8_J == null)
				cb_writeLong8_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_WriteLong8_J);
			return cb_writeLong8_J;
		}

		static void n_WriteLong8_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteLong8 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeLong8' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeLong8", "(J)V", "GetWriteLong8_JHandler")]
		protected virtual unsafe void WriteLong8 (long p0)
		{
			const string __id = "writeLong8.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeTlv2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteTlv2_Ljava_lang_String_Handler ()
		{
			if (cb_writeTlv2_Ljava_lang_String_ == null)
				cb_writeTlv2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteTlv2_Ljava_lang_String_);
			return cb_writeTlv2_Ljava_lang_String_;
		}

		static void n_WriteTlv2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTlv2 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeTlv2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeTlv2", "(Ljava/lang/String;)V", "GetWriteTlv2_Ljava_lang_String_Handler")]
		protected virtual unsafe void WriteTlv2 (string p0)
		{
			const string __id = "writeTlv2.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("cn/jiguang/api/JProtocol", DoNotGenerateAcw=true)]
	internal partial class JProtocolInvoker : JProtocol {

		public JProtocolInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("cn/jiguang/api/JProtocol", typeof (JProtocolInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='parseBody' and count(parameter)=0]"
		[Register ("parseBody", "()V", "GetParseBodyHandler")]
		protected override unsafe void ParseBody ()
		{
			const string __id = "parseBody.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeBody' and count(parameter)=0]"
		[Register ("writeBody", "()V", "GetWriteBodyHandler")]
		protected override unsafe void WriteBody ()
		{
			const string __id = "writeBody.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

}
