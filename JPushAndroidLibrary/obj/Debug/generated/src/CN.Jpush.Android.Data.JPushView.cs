using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushView']"
	[global::Android.Runtime.Register ("cn/jpush/android/data/JPushView", DoNotGenerateAcw=true)]
	public partial class JPushView : global::Android.Widget.LinearLayout {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/data/JPushView", typeof (JPushView));
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

		protected JPushView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
