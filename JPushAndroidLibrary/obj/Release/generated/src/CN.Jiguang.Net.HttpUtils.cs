using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jiguang.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']"
	[global::Android.Runtime.Register ("cn/jiguang/net/HttpUtils", DoNotGenerateAcw=true)]
	public partial class HttpUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/field[@name='ENCODING_UTF_8']"
		[Register ("ENCODING_UTF_8")]
		public const string EncodingUtf8 = (string) "UTF-8";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/field[@name='EQUAL_SIGN']"
		[Register ("EQUAL_SIGN")]
		public const string EqualSign = (string) "=";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/field[@name='HTTP_DEFUALT_PROXY']"
		[Register ("HTTP_DEFUALT_PROXY")]
		public const string HttpDefualtProxy = (string) "10.0.0.172";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/field[@name='PARAMETERS_SEPARATOR']"
		[Register ("PARAMETERS_SEPARATOR")]
		public const string ParametersSeparator = (string) "&";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/field[@name='PATHS_SEPARATOR']"
		[Register ("PATHS_SEPARATOR")]
		public const string PathsSeparator = (string) "/";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/field[@name='URL_AND_PARA_SEPARATOR']"
		[Register ("URL_AND_PARA_SEPARATOR")]
		public const string UrlAndParaSeparator = (string) "?";
		// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils.HttpListener']"
		[global::Android.Runtime.Register ("cn/jiguang/net/HttpUtils$HttpListener", DoNotGenerateAcw=true)]
		public abstract partial class HttpListener : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/net/HttpUtils$HttpListener", typeof (HttpListener));
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

			protected HttpListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils.HttpListener']/constructor[@name='HttpUtils.HttpListener' and count(parameter)=1 and parameter[1][@type='cn.jiguang.net.HttpUtils']]"
			[Register (".ctor", "(Lcn/jiguang/net/HttpUtils;)V", "")]
			public unsafe HttpListener (global::CN.Jiguang.Net.HttpUtils __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("cn/jiguang/net/HttpUtils$HttpListener", DoNotGenerateAcw=true)]
		internal partial class HttpListenerInvoker : HttpListener {

			public HttpListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("cn/jiguang/net/HttpUtils$HttpListener", typeof (HttpListenerInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jiguang/net/HttpUtils", typeof (HttpUtils));
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

		protected HttpUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/constructor[@name='HttpUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='appendParaToUrl' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("appendParaToUrl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string AppendParaToUrl (string p0, string p1, string p2)
		{
			const string __id = "appendParaToUrl.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='getHttpURLConnectionWithProxy' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getHttpURLConnectionWithProxy", "(Landroid/content/Context;Ljava/lang/String;)Ljava/net/HttpURLConnection;", "")]
		public static unsafe global::Java.Net.HttpURLConnection GetHttpURLConnectionWithProxy (global::Android.Content.Context p0, string p1)
		{
			const string __id = "getHttpURLConnectionWithProxy.(Landroid/content/Context;Ljava/lang/String;)Ljava/net/HttpURLConnection;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='getUrlWithParas' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getUrlWithParas", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string GetUrlWithParas (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			const string __id = "getUrlWithParas.(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='getUrlWithValueEncodeParas' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getUrlWithValueEncodeParas", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string GetUrlWithValueEncodeParas (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			const string __id = "getUrlWithValueEncodeParas.(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpGet' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jiguang.net.HttpRequest']]"
		[Register ("httpGet", "(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;)Lcn/jiguang/net/HttpResponse;", "")]
		public static unsafe global::CN.Jiguang.Net.HttpResponse HttpGet (global::Android.Content.Context p0, global::CN.Jiguang.Net.HttpRequest p1)
		{
			const string __id = "httpGet.(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;)Lcn/jiguang/net/HttpResponse;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpGet' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jiguang.net.HttpRequest'] and parameter[3][@type='cn.jiguang.net.HttpUtils.HttpListener']]"
		[Register ("httpGet", "(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;Lcn/jiguang/net/HttpUtils$HttpListener;)V", "")]
		public static unsafe void HttpGet (global::Android.Content.Context p0, global::CN.Jiguang.Net.HttpRequest p1, global::CN.Jiguang.Net.HttpUtils.HttpListener p2)
		{
			const string __id = "httpGet.(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;Lcn/jiguang/net/HttpUtils$HttpListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpGet' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("httpGet", "(Landroid/content/Context;Ljava/lang/String;)Lcn/jiguang/net/HttpResponse;", "")]
		public static unsafe global::CN.Jiguang.Net.HttpResponse HttpGet (global::Android.Content.Context p0, string p1)
		{
			const string __id = "httpGet.(Landroid/content/Context;Ljava/lang/String;)Lcn/jiguang/net/HttpResponse;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpGet' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='cn.jiguang.net.HttpUtils.HttpListener']]"
		[Register ("httpGet", "(Landroid/content/Context;Ljava/lang/String;Lcn/jiguang/net/HttpUtils$HttpListener;)V", "")]
		public static unsafe void HttpGet (global::Android.Content.Context p0, string p1, global::CN.Jiguang.Net.HttpUtils.HttpListener p2)
		{
			const string __id = "httpGet.(Landroid/content/Context;Ljava/lang/String;Lcn/jiguang/net/HttpUtils$HttpListener;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpGetString' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jiguang.net.HttpRequest']]"
		[Register ("httpGetString", "(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;)Ljava/lang/String;", "")]
		public static unsafe string HttpGetString (global::Android.Content.Context p0, global::CN.Jiguang.Net.HttpRequest p1)
		{
			const string __id = "httpGetString.(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpGetString' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("httpGetString", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HttpGetString (global::Android.Content.Context p0, string p1)
		{
			const string __id = "httpGetString.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpPost' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jiguang.net.HttpRequest']]"
		[Register ("httpPost", "(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;)Lcn/jiguang/net/HttpResponse;", "")]
		public static unsafe global::CN.Jiguang.Net.HttpResponse HttpPost (global::Android.Content.Context p0, global::CN.Jiguang.Net.HttpRequest p1)
		{
			const string __id = "httpPost.(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;)Lcn/jiguang/net/HttpResponse;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpPost' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("httpPost", "(Landroid/content/Context;Ljava/lang/String;)Lcn/jiguang/net/HttpResponse;", "")]
		public static unsafe global::CN.Jiguang.Net.HttpResponse HttpPost (global::Android.Content.Context p0, string p1)
		{
			const string __id = "httpPost.(Landroid/content/Context;Ljava/lang/String;)Lcn/jiguang/net/HttpResponse;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpPostString' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("httpPostString", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HttpPostString (global::Android.Content.Context p0, string p1)
		{
			const string __id = "httpPostString.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpPostString' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("httpPostString", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string HttpPostString (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			const string __id = "httpPostString.(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='joinParas' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("joinParas", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string JoinParas (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			const string __id = "joinParas.(Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='joinParasWithEncodedValue' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("joinParasWithEncodedValue", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string JoinParasWithEncodedValue (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			const string __id = "joinParasWithEncodedValue.(Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='parseGmtTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseGmtTime", "(Ljava/lang/String;)J", "")]
		public static unsafe long ParseGmtTime (string p0)
		{
			const string __id = "parseGmtTime.(Ljava/lang/String;)J";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='readInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readInputStream", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] ReadInputStream (global::System.IO.Stream p0)
		{
			const string __id = "readInputStream.(Ljava/io/InputStream;)[B";
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='setURLConnection' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.net.HttpURLConnection']]"
		[Register ("setURLConnection", "(Ljava/util/Map;Ljava/net/HttpURLConnection;)V", "")]
		public static unsafe void SetURLConnection (global::System.Collections.Generic.IDictionary<string, string> p0, global::Java.Net.HttpURLConnection p1)
		{
			const string __id = "setURLConnection.(Ljava/util/Map;Ljava/net/HttpURLConnection;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
