using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']"
	[global::Android.Runtime.Register ("cn/jpush/android/ui/FullScreenView", DoNotGenerateAcw=true)]
	public partial class FullScreenView : global::Android.Widget.LinearLayout {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/ui/FullScreenView", typeof (FullScreenView));
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

		protected FullScreenView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/constructor[@name='FullScreenView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe FullScreenView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

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

		static Delegate cb_destory;
#pragma warning disable 0169
		static Delegate GetDestoryHandler ()
		{
			if (cb_destory == null)
				cb_destory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destory);
			return cb_destory;
		}

		static void n_Destory (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destory ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='destory' and count(parameter)=0]"
		[Register ("destory", "()V", "GetDestoryHandler")]
		public virtual unsafe void Destory ()
		{
			const string __id = "destory.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_loadUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadUrl_Ljava_lang_String_Handler ()
		{
			if (cb_loadUrl_Ljava_lang_String_ == null)
				cb_loadUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadUrl_Ljava_lang_String_);
			return cb_loadUrl_Ljava_lang_String_;
		}

		static void n_LoadUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadUrl (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='loadUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadUrl", "(Ljava/lang/String;)V", "GetLoadUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadUrl (string p0)
		{
			const string __id = "loadUrl.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			const string __id = "resume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_showTitleBar;
#pragma warning disable 0169
		static Delegate GetShowTitleBarHandler ()
		{
			if (cb_showTitleBar == null)
				cb_showTitleBar = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowTitleBar);
			return cb_showTitleBar;
		}

		static void n_ShowTitleBar (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowTitleBar ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='showTitleBar' and count(parameter)=0]"
		[Register ("showTitleBar", "()V", "GetShowTitleBarHandler")]
		public virtual unsafe void ShowTitleBar ()
		{
			const string __id = "showTitleBar.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_webviewCanGoBack;
#pragma warning disable 0169
		static Delegate GetWebviewCanGoBackHandler ()
		{
			if (cb_webviewCanGoBack == null)
				cb_webviewCanGoBack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_WebviewCanGoBack);
			return cb_webviewCanGoBack;
		}

		static bool n_WebviewCanGoBack (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WebviewCanGoBack ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='webviewCanGoBack' and count(parameter)=0]"
		[Register ("webviewCanGoBack", "()Z", "GetWebviewCanGoBackHandler")]
		public virtual unsafe bool WebviewCanGoBack ()
		{
			const string __id = "webviewCanGoBack.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_webviewGoBack;
#pragma warning disable 0169
		static Delegate GetWebviewGoBackHandler ()
		{
			if (cb_webviewGoBack == null)
				cb_webviewGoBack = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WebviewGoBack);
			return cb_webviewGoBack;
		}

		static void n_WebviewGoBack (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WebviewGoBack ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='webviewGoBack' and count(parameter)=0]"
		[Register ("webviewGoBack", "()V", "GetWebviewGoBackHandler")]
		public virtual unsafe void WebviewGoBack ()
		{
			const string __id = "webviewGoBack.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
