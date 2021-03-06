using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='BasicPushNotificationBuilder']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/BasicPushNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class BasicPushNotificationBuilder : global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder {



		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='BasicPushNotificationBuilder']/field[@name='a']"
		[Register ("a")]
		protected global::Android.Content.Context A {
			get {
				const string __id = "a.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='BasicPushNotificationBuilder']/field[@name='notificationDefaults']"
		[Register ("notificationDefaults")]
		public int NotificationDefaults {
			get {
				const string __id = "notificationDefaults.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "notificationDefaults.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='BasicPushNotificationBuilder']/field[@name='notificationFlags']"
		[Register ("notificationFlags")]
		public int NotificationFlags {
			get {
				const string __id = "notificationFlags.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "notificationFlags.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='BasicPushNotificationBuilder']/field[@name='statusBarDrawable']"
		[Register ("statusBarDrawable")]
		public int StatusBarDrawable {
			get {
				const string __id = "statusBarDrawable.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "statusBarDrawable.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/api/BasicPushNotificationBuilder", typeof (BasicPushNotificationBuilder));
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

		protected BasicPushNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='BasicPushNotificationBuilder']/constructor[@name='BasicPushNotificationBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BasicPushNotificationBuilder (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
