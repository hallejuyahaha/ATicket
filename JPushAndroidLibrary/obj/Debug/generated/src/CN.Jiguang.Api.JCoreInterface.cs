using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']"
	[global::Android.Runtime.Register ("cn/jiguang/api/JCoreInterface", DoNotGenerateAcw=true)]
	public partial class JCoreInterface : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/field[@name='a']"
		[Register ("a")]
		public static string A {
			get {
				const string __id = "a.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/api/JCoreInterface", typeof (JCoreInterface));
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

		protected JCoreInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/constructor[@name='JCoreInterface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JCoreInterface ()
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

		public static unsafe string AccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getAccountId' and count(parameter)=0]"
			[Register ("getAccountId", "()Ljava/lang/String;", "GetGetAccountIdHandler")]
			get {
				const string __id = "getAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccountId", "(Ljava/lang/String;)V", "GetSetAccountId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAccountId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static unsafe bool AesConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getAesConfig' and count(parameter)=0]"
			[Register ("getAesConfig", "()Z", "GetGetAesConfigHandler")]
			get {
				const string __id = "getAesConfig.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string AppKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getAppKey' and count(parameter)=0]"
			[Register ("getAppKey", "()Ljava/lang/String;", "GetGetAppKeyHandler")]
			get {
				const string __id = "getAppKey.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Ljava/lang/String;", "GetGetChannelHandler")]
			get {
				const string __id = "getChannel.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string CommonConfigAppkey {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getCommonConfigAppkey' and count(parameter)=0]"
			[Register ("getCommonConfigAppkey", "()Ljava/lang/String;", "GetGetCommonConfigAppkeyHandler")]
			get {
				const string __id = "getCommonConfigAppkey.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string DaemonAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getDaemonAction' and count(parameter)=0]"
			[Register ("getDaemonAction", "()Ljava/lang/String;", "GetGetDaemonActionHandler")]
			get {
				const string __id = "getDaemonAction.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setDaemonAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDaemonAction", "(Ljava/lang/String;)V", "GetSetDaemonAction_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDaemonAction.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static unsafe bool DebugMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getDebugMode' and count(parameter)=0]"
			[Register ("getDebugMode", "()Z", "GetGetDebugModeHandler")]
			get {
				const string __id = "getDebugMode.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setDebugMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebugMode", "(Z)V", "GetSetDebugMode_ZHandler")]
			set {
				const string __id = "setDebugMode.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe bool IsTcpConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='isTcpConnected' and count(parameter)=0]"
			[Register ("isTcpConnected", "()Z", "GetIsTcpConnectedHandler")]
			get {
				const string __id = "isTcpConnected.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsValidRegistered {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='isValidRegistered' and count(parameter)=0]"
			[Register ("isValidRegistered", "()Z", "GetIsValidRegisteredHandler")]
			get {
				const string __id = "isValidRegistered.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int JCoreSDKVersionInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getJCoreSDKVersionInt' and count(parameter)=0]"
			[Register ("getJCoreSDKVersionInt", "()I", "GetGetJCoreSDKVersionIntHandler")]
			get {
				const string __id = "getJCoreSDKVersionInt.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe long NextRid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getNextRid' and count(parameter)=0]"
			[Register ("getNextRid", "()J", "GetGetNextRidHandler")]
			get {
				const string __id = "getNextRid.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe long ReportTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getReportTime' and count(parameter)=0]"
			[Register ("getReportTime", "()J", "GetGetReportTimeHandler")]
			get {
				const string __id = "getReportTime.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool RuningFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getRuningFlag' and count(parameter)=0]"
			[Register ("getRuningFlag", "()Z", "GetGetRuningFlagHandler")]
			get {
				const string __id = "getRuningFlag.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int Sid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getSid' and count(parameter)=0]"
			[Register ("getSid", "()I", "GetGetSidHandler")]
			get {
				const string __id = "getSid.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool TestConn {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getTestConn' and count(parameter)=0]"
			[Register ("getTestConn", "()Z", "GetGetTestConnHandler")]
			get {
				const string __id = "getTestConn.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setTestConn' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTestConn", "(Z)V", "GetSetTestConn_ZHandler")]
			set {
				const string __id = "setTestConn.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe long Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()J", "GetGetUidHandler")]
			get {
				const string __id = "getUid.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='asyncExecute' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='int...']]"
		[Register ("asyncExecute", "(Ljava/lang/Runnable;[I)V", "")]
		public static unsafe void AsyncExecute (global::Java.Lang.IRunnable p0, params int[] p1)
		{
			const string __id = "asyncExecute.(Ljava/lang/Runnable;[I)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='canCallDirect' and count(parameter)=0]"
		[Register ("canCallDirect", "()Z", "")]
		public static unsafe bool CanCallDirect ()
		{
			const string __id = "canCallDirect.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='execute' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Runnable'] and parameter[3][@type='int...']]"
		[Register ("execute", "(Ljava/lang/String;Ljava/lang/Runnable;[I)V", "")]
		public static unsafe void Execute (string p0, global::Java.Lang.IRunnable p1, params int[] p2)
		{
			const string __id = "execute.(Ljava/lang/String;Ljava/lang/Runnable;[I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='fillBaseReport' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String']]"
		[Register ("fillBaseReport", "(Lorg/json/JSONObject;Ljava/lang/String;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject FillBaseReport (global::Org.Json.JSONObject p0, string p1)
		{
			const string __id = "fillBaseReport.(Lorg/json/JSONObject;Ljava/lang/String;)Lorg/json/JSONObject;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getBinderByType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBinderByType", "(Ljava/lang/String;Ljava/lang/String;)Landroid/os/IBinder;", "")]
		public static unsafe global::Android.OS.IBinder GetBinderByType (string p0, string p1)
		{
			const string __id = "getBinderByType.(Ljava/lang/String;Ljava/lang/String;)Landroid/os/IBinder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getConnectionState' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getConnectionState", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool GetConnectionState (global::Android.Content.Context p0)
		{
			const string __id = "getConnectionState.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getDeviceId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDeviceId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetDeviceId (global::Android.Content.Context p0)
		{
			const string __id = "getDeviceId.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getHttpConfig' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getHttpConfig", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetHttpConfig (global::Android.Content.Context p0, string p1)
		{
			const string __id = "getHttpConfig.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getRegistrationID' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRegistrationID", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetRegistrationID (global::Android.Content.Context p0)
		{
			const string __id = "getRegistrationID.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("init", "(Landroid/content/Context;Z)Z", "")]
		public static unsafe bool Init (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "init.(Landroid/content/Context;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='initAction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;? extends cn.jiguang.api.JAction&gt;']]"
		[Register ("initAction", "(Ljava/lang/String;Ljava/lang/Class;)V", "")]
		public static unsafe void InitAction (string p0, global::Java.Lang.Class p1)
		{
			const string __id = "initAction.(Ljava/lang/String;Ljava/lang/Class;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='initActionExtra' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;? extends cn.jiguang.api.JActionExtra&gt;']]"
		[Register ("initActionExtra", "(Ljava/lang/String;Ljava/lang/Class;)V", "")]
		public static unsafe void InitActionExtra (string p0, global::Java.Lang.Class p1)
		{
			const string __id = "initActionExtra.(Ljava/lang/String;Ljava/lang/Class;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='initCrashHandler' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initCrashHandler", "(Landroid/content/Context;)V", "")]
		public static unsafe void InitCrashHandler (global::Android.Content.Context p0)
		{
			const string __id = "initCrashHandler.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='isServiceStoped' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isServiceStoped", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsServiceStoped (global::Android.Content.Context p0)
		{
			const string __id = "isServiceStoped.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='onFragmentPause' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFragmentPause", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void OnFragmentPause (global::Android.Content.Context p0, string p1)
		{
			const string __id = "onFragmentPause.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='onFragmentResume' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFragmentResume", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void OnFragmentResume (global::Android.Content.Context p0, string p1)
		{
			const string __id = "onFragmentResume.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='onKillProcess' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onKillProcess", "(Landroid/content/Context;)V", "")]
		public static unsafe void OnKillProcess (global::Android.Content.Context p0)
		{
			const string __id = "onKillProcess.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onPause", "(Landroid/content/Context;)V", "")]
		public static unsafe void OnPause (global::Android.Content.Context p0)
		{
			const string __id = "onPause.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onResume", "(Landroid/content/Context;)V", "")]
		public static unsafe void OnResume (global::Android.Content.Context p0)
		{
			const string __id = "onResume.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='processCtrlReport' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("processCtrlReport", "(I)V", "")]
		public static unsafe void ProcessCtrlReport (int p0)
		{
			const string __id = "processCtrlReport.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='putSingleExecutor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putSingleExecutor", "(Ljava/lang/String;)V", "")]
		public static unsafe void PutSingleExecutor (string p0)
		{
			const string __id = "putSingleExecutor.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("register", "(Landroid/content/Context;)V", "")]
		public static unsafe void Register (global::Android.Content.Context p0)
		{
			const string __id = "register.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='report' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='boolean']]"
		[Register ("report", "(Landroid/content/Context;Lorg/json/JSONObject;Z)V", "")]
		public static unsafe void Report (global::Android.Content.Context p0, global::Org.Json.JSONObject p1, bool p2)
		{
			const string __id = "report.(Landroid/content/Context;Lorg/json/JSONObject;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='reportHttpData' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String']]"
		[Register ("reportHttpData", "(Landroid/content/Context;Ljava/lang/Object;Ljava/lang/String;)Z", "")]
		public static unsafe bool ReportHttpData (global::Android.Content.Context p0, global::Java.Lang.Object p1, string p2)
		{
			const string __id = "reportHttpData.(Landroid/content/Context;Ljava/lang/Object;Ljava/lang/String;)Z";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='requestPermission' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("requestPermission", "(Landroid/content/Context;)V", "")]
		public static unsafe void RequestPermission (global::Android.Content.Context p0)
		{
			const string __id = "requestPermission.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='restart' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='boolean']]"
		[Register ("restart", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Z)V", "")]
		public static unsafe void Restart (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2, bool p3)
		{
			const string __id = "restart.(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Z)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='sendAction' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("sendAction", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public static unsafe void SendAction (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2)
		{
			const string __id = "sendAction.(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='sendData' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register ("sendData", "(Landroid/content/Context;Ljava/lang/String;I[B)V", "")]
		public static unsafe void SendData (global::Android.Content.Context p0, string p1, int p2, byte[] p3)
		{
			const string __id = "sendData.(Landroid/content/Context;Ljava/lang/String;I[B)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='sendRequestData' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register ("sendRequestData", "(Landroid/content/Context;Ljava/lang/String;I[B)V", "")]
		public static unsafe void SendRequestData (global::Android.Content.Context p0, string p1, int p2, byte[] p3)
		{
			const string __id = "sendRequestData.(Landroid/content/Context;Ljava/lang/String;I[B)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setAnalysisAction' and count(parameter)=1 and parameter[1][@type='cn.jiguang.api.JAnalyticsAction']]"
		[Register ("setAnalysisAction", "(Lcn/jiguang/api/JAnalyticsAction;)V", "")]
		public static unsafe void SetAnalysisAction (global::CN.Jiguang.Api.IJAnalyticsAction p0)
		{
			const string __id = "setAnalysisAction.(Lcn/jiguang/api/JAnalyticsAction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setCanLaunchedStoppedService' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCanLaunchedStoppedService", "(Z)V", "")]
		public static unsafe void SetCanLaunchedStoppedService (bool p0)
		{
			const string __id = "setCanLaunchedStoppedService.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setImLBSEnable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setImLBSEnable", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SetImLBSEnable (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "setImLBSEnable.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setLocationReportDelay' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("setLocationReportDelay", "(Landroid/content/Context;J)V", "")]
		public static unsafe void SetLocationReportDelay (global::Android.Content.Context p0, long p1)
		{
			const string __id = "setLocationReportDelay.(Landroid/content/Context;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setLogEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLogEnable", "(Z)V", "")]
		public static unsafe void SetLogEnable (bool p0)
		{
			const string __id = "setLogEnable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setPowerSaveMode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setPowerSaveMode", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SetPowerSaveMode (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "setPowerSaveMode.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setTestConnIPPort' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setTestConnIPPort", "(Ljava/lang/String;I)V", "")]
		public static unsafe void SetTestConnIPPort (string p0, int p1)
		{
			const string __id = "setTestConnIPPort.(Ljava/lang/String;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='si' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("si", "(Landroid/content/Context;ILandroid/os/Bundle;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle Si (global::Android.Content.Context p0, int p1, global::Android.OS.Bundle p2)
		{
			const string __id = "si.(Landroid/content/Context;ILandroid/os/Bundle;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='stop' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("stop", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public static unsafe void Stop (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2)
		{
			const string __id = "stop.(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='stopCrashHandler' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stopCrashHandler", "(Landroid/content/Context;)V", "")]
		public static unsafe void StopCrashHandler (global::Android.Content.Context p0)
		{
			const string __id = "stopCrashHandler.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='testCountryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("testCountryCode", "(Ljava/lang/String;)V", "")]
		public static unsafe void TestCountryCode (string p0)
		{
			const string __id = "testCountryCode.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='triggerSceneCheck' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("triggerSceneCheck", "(Landroid/content/Context;I)V", "")]
		public static unsafe void TriggerSceneCheck (global::Android.Content.Context p0, int p1)
		{
			const string __id = "triggerSceneCheck.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
