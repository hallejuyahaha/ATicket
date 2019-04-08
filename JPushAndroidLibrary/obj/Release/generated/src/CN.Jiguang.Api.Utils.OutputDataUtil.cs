using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']"
	[global::Android.Runtime.Register ("cn/jiguang/api/utils/OutputDataUtil", DoNotGenerateAcw=true)]
	public partial class OutputDataUtil : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/api/utils/OutputDataUtil", typeof (OutputDataUtil));
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

		protected OutputDataUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/constructor[@name='OutputDataUtil' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe OutputDataUtil (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/constructor[@name='OutputDataUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OutputDataUtil ()
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

		static Delegate cb_current;
#pragma warning disable 0169
		static Delegate GetCurrentHandler ()
		{
			if (cb_current == null)
				cb_current = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Current);
			return cb_current;
		}

		static int n_Current (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Current ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='current' and count(parameter)=0]"
		[Register ("current", "()I", "GetCurrentHandler")]
		public virtual unsafe int Current ()
		{
			const string __id = "current.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='encodeZigZag32' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("encodeZigZag32", "(I)I", "")]
		public static unsafe int EncodeZigZag32 (int p0)
		{
			const string __id = "encodeZigZag32.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='encodeZigZag64' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("encodeZigZag64", "(J)J", "")]
		public static unsafe long EncodeZigZag64 (long p0)
		{
			const string __id = "encodeZigZag64.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_jump_I;
#pragma warning disable 0169
		static Delegate GetJump_IHandler ()
		{
			if (cb_jump_I == null)
				cb_jump_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Jump_I);
			return cb_jump_I;
		}

		static void n_Jump_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Jump (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='jump' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("jump", "(I)V", "GetJump_IHandler")]
		public virtual unsafe void Jump (int p0)
		{
			const string __id = "jump.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_restore;
#pragma warning disable 0169
		static Delegate GetRestoreHandler ()
		{
			if (cb_restore == null)
				cb_restore = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Restore);
			return cb_restore;
		}

		static void n_Restore (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Restore ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='restore' and count(parameter)=0]"
		[Register ("restore", "()V", "GetRestoreHandler")]
		public virtual unsafe void Restore ()
		{
			const string __id = "restore.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_save;
#pragma warning disable 0169
		static Delegate GetSaveHandler ()
		{
			if (cb_save == null)
				cb_save = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Save);
			return cb_save;
		}

		static void n_Save (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Save ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='save' and count(parameter)=0]"
		[Register ("save", "()V", "GetSaveHandler")]
		public virtual unsafe void Save ()
		{
			const string __id = "save.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toByteArray;
#pragma warning disable 0169
		static Delegate GetToByteArrayHandler ()
		{
			if (cb_toByteArray == null)
				cb_toByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToByteArray);
			return cb_toByteArray;
		}

		static IntPtr n_ToByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='toByteArray' and count(parameter)=0]"
		[Register ("toByteArray", "()[B", "GetToByteArrayHandler")]
		public virtual unsafe byte[] ToByteArray ()
		{
			const string __id = "toByteArray.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_writeByteArray_arrayB;
#pragma warning disable 0169
		static Delegate GetWriteByteArray_arrayBHandler ()
		{
			if (cb_writeByteArray_arrayB == null)
				cb_writeByteArray_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteByteArray_arrayB);
			return cb_writeByteArray_arrayB;
		}

		static void n_WriteByteArray_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteByteArray (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeByteArray' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("writeByteArray", "([B)V", "GetWriteByteArray_arrayBHandler")]
		public virtual unsafe void WriteByteArray (byte[] p0)
		{
			const string __id = "writeByteArray.([B)V";
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

		static Delegate cb_writeByteArray_arrayBII;
#pragma warning disable 0169
		static Delegate GetWriteByteArray_arrayBIIHandler ()
		{
			if (cb_writeByteArray_arrayBII == null)
				cb_writeByteArray_arrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_WriteByteArray_arrayBII);
			return cb_writeByteArray_arrayBII;
		}

		static void n_WriteByteArray_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteByteArray (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeByteArray' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("writeByteArray", "([BII)V", "GetWriteByteArray_arrayBIIHandler")]
		public virtual unsafe void WriteByteArray (byte[] p0, int p1, int p2)
		{
			const string __id = "writeByteArray.([BII)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_writeByteArrayincludeLength_arrayB;
#pragma warning disable 0169
		static Delegate GetWriteByteArrayincludeLength_arrayBHandler ()
		{
			if (cb_writeByteArrayincludeLength_arrayB == null)
				cb_writeByteArrayincludeLength_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteByteArrayincludeLength_arrayB);
			return cb_writeByteArrayincludeLength_arrayB;
		}

		static void n_WriteByteArrayincludeLength_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteByteArrayincludeLength (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeByteArrayincludeLength' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("writeByteArrayincludeLength", "([B)V", "GetWriteByteArrayincludeLength_arrayBHandler")]
		public virtual unsafe void WriteByteArrayincludeLength (byte[] p0)
		{
			const string __id = "writeByteArrayincludeLength.([B)V";
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

		static Delegate cb_writeCountedString_arrayB;
#pragma warning disable 0169
		static Delegate GetWriteCountedString_arrayBHandler ()
		{
			if (cb_writeCountedString_arrayB == null)
				cb_writeCountedString_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteCountedString_arrayB);
			return cb_writeCountedString_arrayB;
		}

		static void n_WriteCountedString_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteCountedString (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeCountedString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("writeCountedString", "([B)V", "GetWriteCountedString_arrayBHandler")]
		public virtual unsafe void WriteCountedString (byte[] p0)
		{
			const string __id = "writeCountedString.([B)V";
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

		static Delegate cb_writeRawLittleEndian16_I;
#pragma warning disable 0169
		static Delegate GetWriteRawLittleEndian16_IHandler ()
		{
			if (cb_writeRawLittleEndian16_I == null)
				cb_writeRawLittleEndian16_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_WriteRawLittleEndian16_I);
			return cb_writeRawLittleEndian16_I;
		}

		static void n_WriteRawLittleEndian16_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteRawLittleEndian16 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeRawLittleEndian16' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeRawLittleEndian16", "(I)V", "GetWriteRawLittleEndian16_IHandler")]
		public virtual unsafe void WriteRawLittleEndian16 (int p0)
		{
			const string __id = "writeRawLittleEndian16.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeRawLittleEndian32_I;
#pragma warning disable 0169
		static Delegate GetWriteRawLittleEndian32_IHandler ()
		{
			if (cb_writeRawLittleEndian32_I == null)
				cb_writeRawLittleEndian32_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_WriteRawLittleEndian32_I);
			return cb_writeRawLittleEndian32_I;
		}

		static void n_WriteRawLittleEndian32_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteRawLittleEndian32 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeRawLittleEndian32' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeRawLittleEndian32", "(I)V", "GetWriteRawLittleEndian32_IHandler")]
		public virtual unsafe void WriteRawLittleEndian32 (int p0)
		{
			const string __id = "writeRawLittleEndian32.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeRawLittleEndian64_J;
#pragma warning disable 0169
		static Delegate GetWriteRawLittleEndian64_JHandler ()
		{
			if (cb_writeRawLittleEndian64_J == null)
				cb_writeRawLittleEndian64_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_WriteRawLittleEndian64_J);
			return cb_writeRawLittleEndian64_J;
		}

		static void n_WriteRawLittleEndian64_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteRawLittleEndian64 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeRawLittleEndian64' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeRawLittleEndian64", "(J)V", "GetWriteRawLittleEndian64_JHandler")]
		public virtual unsafe void WriteRawLittleEndian64 (long p0)
		{
			const string __id = "writeRawLittleEndian64.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeU16_I;
#pragma warning disable 0169
		static Delegate GetWriteU16_IHandler ()
		{
			if (cb_writeU16_I == null)
				cb_writeU16_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_WriteU16_I);
			return cb_writeU16_I;
		}

		static void n_WriteU16_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteU16 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeU16' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeU16", "(I)V", "GetWriteU16_IHandler")]
		public virtual unsafe void WriteU16 (int p0)
		{
			const string __id = "writeU16.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeU16At_II;
#pragma warning disable 0169
		static Delegate GetWriteU16At_IIHandler ()
		{
			if (cb_writeU16At_II == null)
				cb_writeU16At_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_WriteU16At_II);
			return cb_writeU16At_II;
		}

		static void n_WriteU16At_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteU16At (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeU16At' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("writeU16At", "(II)V", "GetWriteU16At_IIHandler")]
		public virtual unsafe void WriteU16At (int p0, int p1)
		{
			const string __id = "writeU16At.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeU32_J;
#pragma warning disable 0169
		static Delegate GetWriteU32_JHandler ()
		{
			if (cb_writeU32_J == null)
				cb_writeU32_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_WriteU32_J);
			return cb_writeU32_J;
		}

		static void n_WriteU32_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteU32 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeU32' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeU32", "(J)V", "GetWriteU32_JHandler")]
		public virtual unsafe void WriteU32 (long p0)
		{
			const string __id = "writeU32.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeU32At_JI;
#pragma warning disable 0169
		static Delegate GetWriteU32At_JIHandler ()
		{
			if (cb_writeU32At_JI == null)
				cb_writeU32At_JI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, int>) n_WriteU32At_JI);
			return cb_writeU32At_JI;
		}

		static void n_WriteU32At_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteU32At (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeU32At' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("writeU32At", "(JI)V", "GetWriteU32At_JIHandler")]
		public virtual unsafe void WriteU32At (long p0, int p1)
		{
			const string __id = "writeU32At.(JI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeU64_J;
#pragma warning disable 0169
		static Delegate GetWriteU64_JHandler ()
		{
			if (cb_writeU64_J == null)
				cb_writeU64_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_WriteU64_J);
			return cb_writeU64_J;
		}

		static void n_WriteU64_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteU64 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeU64' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeU64", "(J)V", "GetWriteU64_JHandler")]
		public virtual unsafe void WriteU64 (long p0)
		{
			const string __id = "writeU64.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeU64At_JI;
#pragma warning disable 0169
		static Delegate GetWriteU64At_JIHandler ()
		{
			if (cb_writeU64At_JI == null)
				cb_writeU64At_JI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, int>) n_WriteU64At_JI);
			return cb_writeU64At_JI;
		}

		static void n_WriteU64At_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteU64At (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeU64At' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("writeU64At", "(JI)V", "GetWriteU64At_JIHandler")]
		public virtual unsafe void WriteU64At (long p0, int p1)
		{
			const string __id = "writeU64At.(JI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeU8_I;
#pragma warning disable 0169
		static Delegate GetWriteU8_IHandler ()
		{
			if (cb_writeU8_I == null)
				cb_writeU8_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_WriteU8_I);
			return cb_writeU8_I;
		}

		static void n_WriteU8_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteU8 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeU8' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeU8", "(I)V", "GetWriteU8_IHandler")]
		public virtual unsafe void WriteU8 (int p0)
		{
			const string __id = "writeU8.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeU8At_II;
#pragma warning disable 0169
		static Delegate GetWriteU8At_IIHandler ()
		{
			if (cb_writeU8At_II == null)
				cb_writeU8At_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_WriteU8At_II);
			return cb_writeU8At_II;
		}

		static void n_WriteU8At_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::CN.Jiguang.Api.Utils.OutputDataUtil __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.Utils.OutputDataUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteU8At (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='OutputDataUtil']/method[@name='writeU8At' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("writeU8At", "(II)V", "GetWriteU8At_IIHandler")]
		public virtual unsafe void WriteU8At (int p0, int p1)
		{
			const string __id = "writeU8At.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
