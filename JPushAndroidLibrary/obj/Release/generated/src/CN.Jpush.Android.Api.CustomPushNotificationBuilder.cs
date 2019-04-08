using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/CustomPushNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class CustomPushNotificationBuilder : global::CN.Jpush.Android.Api.BasicPushNotificationBuilder {



		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']/field[@name='layout']"
		[Register ("layout")]
		public int Layout {
			get {
				const string __id = "layout.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "layout.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']/field[@name='layoutContentId']"
		[Register ("layoutContentId")]
		public int LayoutContentId {
			get {
				const string __id = "layoutContentId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "layoutContentId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']/field[@name='layoutIconDrawable']"
		[Register ("layoutIconDrawable")]
		public int LayoutIconDrawable {
			get {
				const string __id = "layoutIconDrawable.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "layoutIconDrawable.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']/field[@name='layoutIconId']"
		[Register ("layoutIconId")]
		public int LayoutIconId {
			get {
				const string __id = "layoutIconId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "layoutIconId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']/field[@name='layoutTitleId']"
		[Register ("layoutTitleId")]
		public int LayoutTitleId {
			get {
				const string __id = "layoutTitleId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "layoutTitleId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/api/CustomPushNotificationBuilder", typeof (CustomPushNotificationBuilder));
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

		protected CustomPushNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']/constructor[@name='CustomPushNotificationBuilder' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;IIII)V", "")]
		public unsafe CustomPushNotificationBuilder (global::Android.Content.Context p0, int p1, int p2, int p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;IIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
