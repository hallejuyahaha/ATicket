using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']"
	[global::Android.Runtime.Register ("cn/jiguang/net/HttpRequest", DoNotGenerateAcw=true)]
	public partial class HttpRequest : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/net/HttpRequest", typeof (HttpRequest));
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

		protected HttpRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/constructor[@name='HttpRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe HttpRequest (string p0)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/constructor[@name='HttpRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe HttpRequest (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Body);
		}
#pragma warning restore 0169

		static Delegate cb_setBody_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetBody_Ljava_lang_Object_Handler ()
		{
			if (cb_setBody_Ljava_lang_Object_ == null)
				cb_setBody_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBody_Ljava_lang_Object_);
			return cb_setBody_Ljava_lang_Object_;
		}

		static void n_SetBody_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Body = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Ljava/lang/Object;", "GetGetBodyHandler")]
			get {
				const string __id = "getBody.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setBody' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setBody", "(Ljava/lang/Object;)V", "GetSetBody_Ljava_lang_Object_Handler")]
			set {
				const string __id = "setBody.(Ljava/lang/Object;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getConnectTimeout;
#pragma warning disable 0169
		static Delegate GetGetConnectTimeoutHandler ()
		{
			if (cb_getConnectTimeout == null)
				cb_getConnectTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnectTimeout);
			return cb_getConnectTimeout;
		}

		static int n_GetConnectTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setConnectTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetConnectTimeout_IHandler ()
		{
			if (cb_setConnectTimeout_I == null)
				cb_setConnectTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnectTimeout_I);
			return cb_setConnectTimeout_I;
		}

		static void n_SetConnectTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectTimeout = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ConnectTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getConnectTimeout' and count(parameter)=0]"
			[Register ("getConnectTimeout", "()I", "GetGetConnectTimeoutHandler")]
			get {
				const string __id = "getConnectTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setConnectTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectTimeout", "(I)V", "GetSetConnectTimeout_IHandler")]
			set {
				const string __id = "setConnectTimeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDoInPut;
#pragma warning disable 0169
		static Delegate GetIsDoInPutHandler ()
		{
			if (cb_isDoInPut == null)
				cb_isDoInPut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDoInPut);
			return cb_isDoInPut;
		}

		static bool n_IsDoInPut (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoInPut;
		}
#pragma warning restore 0169

		static Delegate cb_setDoInPut_Z;
#pragma warning disable 0169
		static Delegate GetSetDoInPut_ZHandler ()
		{
			if (cb_setDoInPut_Z == null)
				cb_setDoInPut_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDoInPut_Z);
			return cb_setDoInPut_Z;
		}

		static void n_SetDoInPut_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoInPut = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool DoInPut {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='isDoInPut' and count(parameter)=0]"
			[Register ("isDoInPut", "()Z", "GetIsDoInPutHandler")]
			get {
				const string __id = "isDoInPut.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setDoInPut' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDoInPut", "(Z)V", "GetSetDoInPut_ZHandler")]
			set {
				const string __id = "setDoInPut.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDoOutPut;
#pragma warning disable 0169
		static Delegate GetIsDoOutPutHandler ()
		{
			if (cb_isDoOutPut == null)
				cb_isDoOutPut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDoOutPut);
			return cb_isDoOutPut;
		}

		static bool n_IsDoOutPut (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoOutPut;
		}
#pragma warning restore 0169

		static Delegate cb_setDoOutPut_Z;
#pragma warning disable 0169
		static Delegate GetSetDoOutPut_ZHandler ()
		{
			if (cb_setDoOutPut_Z == null)
				cb_setDoOutPut_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDoOutPut_Z);
			return cb_setDoOutPut_Z;
		}

		static void n_SetDoOutPut_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoOutPut = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool DoOutPut {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='isDoOutPut' and count(parameter)=0]"
			[Register ("isDoOutPut", "()Z", "GetIsDoOutPutHandler")]
			get {
				const string __id = "isDoOutPut.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setDoOutPut' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDoOutPut", "(Z)V", "GetSetDoOutPut_ZHandler")]
			set {
				const string __id = "setDoOutPut.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isHaveRspData;
#pragma warning disable 0169
		static Delegate GetIsHaveRspDataHandler ()
		{
			if (cb_isHaveRspData == null)
				cb_isHaveRspData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHaveRspData);
			return cb_isHaveRspData;
		}

		static bool n_IsHaveRspData (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HaveRspData;
		}
#pragma warning restore 0169

		static Delegate cb_setHaveRspData_Z;
#pragma warning disable 0169
		static Delegate GetSetHaveRspData_ZHandler ()
		{
			if (cb_setHaveRspData_Z == null)
				cb_setHaveRspData_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHaveRspData_Z);
			return cb_setHaveRspData_Z;
		}

		static void n_SetHaveRspData_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HaveRspData = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool HaveRspData {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='isHaveRspData' and count(parameter)=0]"
			[Register ("isHaveRspData", "()Z", "GetIsHaveRspDataHandler")]
			get {
				const string __id = "isHaveRspData.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setHaveRspData' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHaveRspData", "(Z)V", "GetSetHaveRspData_ZHandler")]
			set {
				const string __id = "setHaveRspData.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHostnameVerifier;
#pragma warning disable 0169
		static Delegate GetGetHostnameVerifierHandler ()
		{
			if (cb_getHostnameVerifier == null)
				cb_getHostnameVerifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHostnameVerifier);
			return cb_getHostnameVerifier;
		}

		static IntPtr n_GetHostnameVerifier (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HostnameVerifier);
		}
#pragma warning restore 0169

		static Delegate cb_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_;
#pragma warning disable 0169
		static Delegate GetSetHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_Handler ()
		{
			if (cb_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ == null)
				cb_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_);
			return cb_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_;
		}

		static void n_SetHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.IHostnameVerifier p0 = (global::Javax.Net.Ssl.IHostnameVerifier)global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HostnameVerifier = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Javax.Net.Ssl.IHostnameVerifier HostnameVerifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getHostnameVerifier' and count(parameter)=0]"
			[Register ("getHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", "GetGetHostnameVerifierHandler")]
			get {
				const string __id = "getHostnameVerifier.()Ljavax/net/ssl/HostnameVerifier;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setHostnameVerifier' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.HostnameVerifier']]"
			[Register ("setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", "GetSetHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_Handler")]
			set {
				const string __id = "setHostnameVerifier.(Ljavax/net/ssl/HostnameVerifier;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isNeedErrorInput;
#pragma warning disable 0169
		static Delegate GetIsNeedErrorInputHandler ()
		{
			if (cb_isNeedErrorInput == null)
				cb_isNeedErrorInput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNeedErrorInput);
			return cb_isNeedErrorInput;
		}

		static bool n_IsNeedErrorInput (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedErrorInput;
		}
#pragma warning restore 0169

		static Delegate cb_setNeedErrorInput_Z;
#pragma warning disable 0169
		static Delegate GetSetNeedErrorInput_ZHandler ()
		{
			if (cb_setNeedErrorInput_Z == null)
				cb_setNeedErrorInput_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNeedErrorInput_Z);
			return cb_setNeedErrorInput_Z;
		}

		static void n_SetNeedErrorInput_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NeedErrorInput = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool NeedErrorInput {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='isNeedErrorInput' and count(parameter)=0]"
			[Register ("isNeedErrorInput", "()Z", "GetIsNeedErrorInputHandler")]
			get {
				const string __id = "isNeedErrorInput.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setNeedErrorInput' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNeedErrorInput", "(Z)V", "GetSetNeedErrorInput_ZHandler")]
			set {
				const string __id = "setNeedErrorInput.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isNeedRetryIfHttpsFailed;
#pragma warning disable 0169
		static Delegate GetIsNeedRetryIfHttpsFailedHandler ()
		{
			if (cb_isNeedRetryIfHttpsFailed == null)
				cb_isNeedRetryIfHttpsFailed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNeedRetryIfHttpsFailed);
			return cb_isNeedRetryIfHttpsFailed;
		}

		static bool n_IsNeedRetryIfHttpsFailed (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedRetryIfHttpsFailed;
		}
#pragma warning restore 0169

		static Delegate cb_setNeedRetryIfHttpsFailed_Z;
#pragma warning disable 0169
		static Delegate GetSetNeedRetryIfHttpsFailed_ZHandler ()
		{
			if (cb_setNeedRetryIfHttpsFailed_Z == null)
				cb_setNeedRetryIfHttpsFailed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNeedRetryIfHttpsFailed_Z);
			return cb_setNeedRetryIfHttpsFailed_Z;
		}

		static void n_SetNeedRetryIfHttpsFailed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NeedRetryIfHttpsFailed = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool NeedRetryIfHttpsFailed {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='isNeedRetryIfHttpsFailed' and count(parameter)=0]"
			[Register ("isNeedRetryIfHttpsFailed", "()Z", "GetIsNeedRetryIfHttpsFailedHandler")]
			get {
				const string __id = "isNeedRetryIfHttpsFailed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setNeedRetryIfHttpsFailed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNeedRetryIfHttpsFailed", "(Z)V", "GetSetNeedRetryIfHttpsFailed_ZHandler")]
			set {
				const string __id = "setNeedRetryIfHttpsFailed.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getParasMap;
#pragma warning disable 0169
		static Delegate GetGetParasMapHandler ()
		{
			if (cb_getParasMap == null)
				cb_getParasMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParasMap);
			return cb_getParasMap;
		}

		static IntPtr n_GetParasMap (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ParasMap);
		}
#pragma warning restore 0169

		static Delegate cb_setParasMap_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetParasMap_Ljava_util_Map_Handler ()
		{
			if (cb_setParasMap_Ljava_util_Map_ == null)
				cb_setParasMap_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParasMap_Ljava_util_Map_);
			return cb_setParasMap_Ljava_util_Map_;
		}

		static void n_SetParasMap_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParasMap = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ParasMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getParasMap' and count(parameter)=0]"
			[Register ("getParasMap", "()Ljava/util/Map;", "GetGetParasMapHandler")]
			get {
				const string __id = "getParasMap.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setParasMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setParasMap", "(Ljava/util/Map;)V", "GetSetParasMap_Ljava_util_Map_Handler")]
			set {
				const string __id = "setParasMap.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReadTimeout;
#pragma warning disable 0169
		static Delegate GetGetReadTimeoutHandler ()
		{
			if (cb_getReadTimeout == null)
				cb_getReadTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReadTimeout);
			return cb_getReadTimeout;
		}

		static int n_GetReadTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setReadTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetReadTimeout_IHandler ()
		{
			if (cb_setReadTimeout_I == null)
				cb_setReadTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetReadTimeout_I);
			return cb_setReadTimeout_I;
		}

		static void n_SetReadTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadTimeout = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ReadTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getReadTimeout' and count(parameter)=0]"
			[Register ("getReadTimeout", "()I", "GetGetReadTimeoutHandler")]
			get {
				const string __id = "getReadTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setReadTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReadTimeout", "(I)V", "GetSetReadTimeout_IHandler")]
			set {
				const string __id = "setReadTimeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestProperties;
#pragma warning disable 0169
		static Delegate GetGetRequestPropertiesHandler ()
		{
			if (cb_getRequestProperties == null)
				cb_getRequestProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestProperties);
			return cb_getRequestProperties;
		}

		static IntPtr n_GetRequestProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.RequestProperties);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestProperties_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetRequestProperties_Ljava_util_Map_Handler ()
		{
			if (cb_setRequestProperties_Ljava_util_Map_ == null)
				cb_setRequestProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestProperties_Ljava_util_Map_);
			return cb_setRequestProperties_Ljava_util_Map_;
		}

		static void n_SetRequestProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestProperties = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> RequestProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getRequestProperties' and count(parameter)=0]"
			[Register ("getRequestProperties", "()Ljava/util/Map;", "GetGetRequestPropertiesHandler")]
			get {
				const string __id = "getRequestProperties.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setRequestProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setRequestProperties", "(Ljava/util/Map;)V", "GetSetRequestProperties_Ljava_util_Map_Handler")]
			set {
				const string __id = "setRequestProperties.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isRspDatazip;
#pragma warning disable 0169
		static Delegate GetIsRspDatazipHandler ()
		{
			if (cb_isRspDatazip == null)
				cb_isRspDatazip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRspDatazip);
			return cb_isRspDatazip;
		}

		static bool n_IsRspDatazip (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RspDatazip;
		}
#pragma warning restore 0169

		static Delegate cb_setRspDatazip_Z;
#pragma warning disable 0169
		static Delegate GetSetRspDatazip_ZHandler ()
		{
			if (cb_setRspDatazip_Z == null)
				cb_setRspDatazip_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRspDatazip_Z);
			return cb_setRspDatazip_Z;
		}

		static void n_SetRspDatazip_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RspDatazip = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool RspDatazip {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='isRspDatazip' and count(parameter)=0]"
			[Register ("isRspDatazip", "()Z", "GetIsRspDatazipHandler")]
			get {
				const string __id = "isRspDatazip.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setRspDatazip' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRspDatazip", "(Z)V", "GetSetRspDatazip_ZHandler")]
			set {
				const string __id = "setRspDatazip.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSslTrustManager;
#pragma warning disable 0169
		static Delegate GetGetSslTrustManagerHandler ()
		{
			if (cb_getSslTrustManager == null)
				cb_getSslTrustManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSslTrustManager);
			return cb_getSslTrustManager;
		}

		static IntPtr n_GetSslTrustManager (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SslTrustManager);
		}
#pragma warning restore 0169

		static Delegate cb_setSslTrustManager_Lcn_jiguang_net_SSLTrustManager_;
#pragma warning disable 0169
		static Delegate GetSetSslTrustManager_Lcn_jiguang_net_SSLTrustManager_Handler ()
		{
			if (cb_setSslTrustManager_Lcn_jiguang_net_SSLTrustManager_ == null)
				cb_setSslTrustManager_Lcn_jiguang_net_SSLTrustManager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSslTrustManager_Lcn_jiguang_net_SSLTrustManager_);
			return cb_setSslTrustManager_Lcn_jiguang_net_SSLTrustManager_;
		}

		static void n_SetSslTrustManager_Lcn_jiguang_net_SSLTrustManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Jiguang.Net.SSLTrustManager p0 = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.SSLTrustManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SslTrustManager = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::CN.Jiguang.Net.SSLTrustManager SslTrustManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getSslTrustManager' and count(parameter)=0]"
			[Register ("getSslTrustManager", "()Lcn/jiguang/net/SSLTrustManager;", "GetGetSslTrustManagerHandler")]
			get {
				const string __id = "getSslTrustManager.()Lcn/jiguang/net/SSLTrustManager;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.SSLTrustManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setSslTrustManager' and count(parameter)=1 and parameter[1][@type='cn.jiguang.net.SSLTrustManager']]"
			[Register ("setSslTrustManager", "(Lcn/jiguang/net/SSLTrustManager;)V", "GetSetSslTrustManager_Lcn_jiguang_net_SSLTrustManager_Handler")]
			set {
				const string __id = "setSslTrustManager.(Lcn/jiguang/net/SSLTrustManager;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Url = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				const string __id = "getUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUrl.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isUseCaches;
#pragma warning disable 0169
		static Delegate GetIsUseCachesHandler ()
		{
			if (cb_isUseCaches == null)
				cb_isUseCaches = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUseCaches);
			return cb_isUseCaches;
		}

		static bool n_IsUseCaches (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseCaches;
		}
#pragma warning restore 0169

		static Delegate cb_setUseCaches_Z;
#pragma warning disable 0169
		static Delegate GetSetUseCaches_ZHandler ()
		{
			if (cb_setUseCaches_Z == null)
				cb_setUseCaches_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUseCaches_Z);
			return cb_setUseCaches_Z;
		}

		static void n_SetUseCaches_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseCaches = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool UseCaches {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='isUseCaches' and count(parameter)=0]"
			[Register ("isUseCaches", "()Z", "GetIsUseCachesHandler")]
			get {
				const string __id = "isUseCaches.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setUseCaches' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseCaches", "(Z)V", "GetSetUseCaches_ZHandler")]
			set {
				const string __id = "setUseCaches.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getParas;
#pragma warning disable 0169
		static Delegate GetGetParasHandler ()
		{
			if (cb_getParas == null)
				cb_getParas = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParas);
			return cb_getParas;
		}

		static IntPtr n_GetParas (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParas ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getParas' and count(parameter)=0]"
		[Register ("getParas", "()[B", "GetGetParasHandler")]
		public virtual unsafe byte[] GetParas ()
		{
			const string __id = "getParas.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getRequestProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRequestProperty_Ljava_lang_String_Handler ()
		{
			if (cb_getRequestProperty_Ljava_lang_String_ == null)
				cb_getRequestProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRequestProperty_Ljava_lang_String_);
			return cb_getRequestProperty_Ljava_lang_String_;
		}

		static IntPtr n_GetRequestProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetRequestProperty (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getRequestProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetRequestProperty_Ljava_lang_String_Handler")]
		public virtual unsafe string GetRequestProperty (string p0)
		{
			const string __id = "getRequestProperty.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRequestProperty_Ljava_lang_String_Ljava_lang_String_);
			return cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetRequestProperty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestProperty (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setRequestProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetRequestProperty (string p0, string p1)
		{
			const string __id = "setRequestProperty.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setUserAgent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserAgent_Ljava_lang_String_Handler ()
		{
			if (cb_setUserAgent_Ljava_lang_String_ == null)
				cb_setUserAgent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserAgent_Ljava_lang_String_);
			return cb_setUserAgent_Ljava_lang_String_;
		}

		static void n_SetUserAgent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUserAgent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setUserAgent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUserAgent", "(Ljava/lang/String;)V", "GetSetUserAgent_Ljava_lang_String_Handler")]
		public virtual unsafe void SetUserAgent (string p0)
		{
			const string __id = "setUserAgent.(Ljava/lang/String;)V";
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
}
