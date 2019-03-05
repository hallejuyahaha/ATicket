using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/JPushMessage", DoNotGenerateAcw=true)]
	public partial class JPushMessage : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("cn/jpush/android/api/JPushMessage", typeof (JPushMessage));
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

		protected JPushMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/constructor[@name='JPushMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JPushMessage ()
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

		static Delegate cb_getAlias;
#pragma warning disable 0169
		static Delegate GetGetAliasHandler ()
		{
			if (cb_getAlias == null)
				cb_getAlias = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlias);
			return cb_getAlias;
		}

		static IntPtr n_GetAlias (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Alias);
		}
#pragma warning restore 0169

		static Delegate cb_setAlias_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAlias_Ljava_lang_String_Handler ()
		{
			if (cb_setAlias_Ljava_lang_String_ == null)
				cb_setAlias_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlias_Ljava_lang_String_);
			return cb_setAlias_Ljava_lang_String_;
		}

		static void n_SetAlias_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Alias = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Alias {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='getAlias' and count(parameter)=0]"
			[Register ("getAlias", "()Ljava/lang/String;", "GetGetAliasHandler")]
			get {
				const string __id = "getAlias.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='setAlias' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAlias", "(Ljava/lang/String;)V", "GetSetAlias_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAlias.(Ljava/lang/String;)V";
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

		static Delegate cb_getCheckTag;
#pragma warning disable 0169
		static Delegate GetGetCheckTagHandler ()
		{
			if (cb_getCheckTag == null)
				cb_getCheckTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCheckTag);
			return cb_getCheckTag;
		}

		static IntPtr n_GetCheckTag (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CheckTag);
		}
#pragma warning restore 0169

		static Delegate cb_setCheckTag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCheckTag_Ljava_lang_String_Handler ()
		{
			if (cb_setCheckTag_Ljava_lang_String_ == null)
				cb_setCheckTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCheckTag_Ljava_lang_String_);
			return cb_setCheckTag_Ljava_lang_String_;
		}

		static void n_SetCheckTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CheckTag = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string CheckTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='getCheckTag' and count(parameter)=0]"
			[Register ("getCheckTag", "()Ljava/lang/String;", "GetGetCheckTagHandler")]
			get {
				const string __id = "getCheckTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='setCheckTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCheckTag", "(Ljava/lang/String;)V", "GetSetCheckTag_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCheckTag.(Ljava/lang/String;)V";
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

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static int n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCode;
		}
#pragma warning restore 0169

		static Delegate cb_setErrorCode_I;
#pragma warning disable 0169
		static Delegate GetSetErrorCode_IHandler ()
		{
			if (cb_setErrorCode_I == null)
				cb_setErrorCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetErrorCode_I);
			return cb_setErrorCode_I;
		}

		static void n_SetErrorCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ErrorCode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				const string __id = "getErrorCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='setErrorCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setErrorCode", "(I)V", "GetSetErrorCode_IHandler")]
			set {
				const string __id = "setErrorCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMobileNumber;
#pragma warning disable 0169
		static Delegate GetGetMobileNumberHandler ()
		{
			if (cb_getMobileNumber == null)
				cb_getMobileNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMobileNumber);
			return cb_getMobileNumber;
		}

		static IntPtr n_GetMobileNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MobileNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setMobileNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMobileNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setMobileNumber_Ljava_lang_String_ == null)
				cb_setMobileNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMobileNumber_Ljava_lang_String_);
			return cb_setMobileNumber_Ljava_lang_String_;
		}

		static void n_SetMobileNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MobileNumber = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string MobileNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='getMobileNumber' and count(parameter)=0]"
			[Register ("getMobileNumber", "()Ljava/lang/String;", "GetGetMobileNumberHandler")]
			get {
				const string __id = "getMobileNumber.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='setMobileNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMobileNumber", "(Ljava/lang/String;)V", "GetSetMobileNumber_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMobileNumber.(Ljava/lang/String;)V";
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

		static Delegate cb_getSequence;
#pragma warning disable 0169
		static Delegate GetGetSequenceHandler ()
		{
			if (cb_getSequence == null)
				cb_getSequence = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSequence);
			return cb_getSequence;
		}

		static int n_GetSequence (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sequence;
		}
#pragma warning restore 0169

		static Delegate cb_setSequence_I;
#pragma warning disable 0169
		static Delegate GetSetSequence_IHandler ()
		{
			if (cb_setSequence_I == null)
				cb_setSequence_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSequence_I);
			return cb_setSequence_I;
		}

		static void n_SetSequence_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sequence = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Sequence {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='getSequence' and count(parameter)=0]"
			[Register ("getSequence", "()I", "GetGetSequenceHandler")]
			get {
				const string __id = "getSequence.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='setSequence' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSequence", "(I)V", "GetSetSequence_IHandler")]
			set {
				const string __id = "setSequence.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isTagCheckOperator;
#pragma warning disable 0169
		static Delegate GetIsTagCheckOperatorHandler ()
		{
			if (cb_isTagCheckOperator == null)
				cb_isTagCheckOperator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTagCheckOperator);
			return cb_isTagCheckOperator;
		}

		static bool n_IsTagCheckOperator (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TagCheckOperator;
		}
#pragma warning restore 0169

		static Delegate cb_setTagCheckOperator_Z;
#pragma warning disable 0169
		static Delegate GetSetTagCheckOperator_ZHandler ()
		{
			if (cb_setTagCheckOperator_Z == null)
				cb_setTagCheckOperator_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTagCheckOperator_Z);
			return cb_setTagCheckOperator_Z;
		}

		static void n_SetTagCheckOperator_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TagCheckOperator = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool TagCheckOperator {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='isTagCheckOperator' and count(parameter)=0]"
			[Register ("isTagCheckOperator", "()Z", "GetIsTagCheckOperatorHandler")]
			get {
				const string __id = "isTagCheckOperator.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='setTagCheckOperator' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTagCheckOperator", "(Z)V", "GetSetTagCheckOperator_ZHandler")]
			set {
				const string __id = "setTagCheckOperator.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTagCheckStateResult;
#pragma warning disable 0169
		static Delegate GetGetTagCheckStateResultHandler ()
		{
			if (cb_getTagCheckStateResult == null)
				cb_getTagCheckStateResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTagCheckStateResult);
			return cb_getTagCheckStateResult;
		}

		static bool n_GetTagCheckStateResult (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TagCheckStateResult;
		}
#pragma warning restore 0169

		static Delegate cb_setTagCheckStateResult_Z;
#pragma warning disable 0169
		static Delegate GetSetTagCheckStateResult_ZHandler ()
		{
			if (cb_setTagCheckStateResult_Z == null)
				cb_setTagCheckStateResult_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTagCheckStateResult_Z);
			return cb_setTagCheckStateResult_Z;
		}

		static void n_SetTagCheckStateResult_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TagCheckStateResult = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool TagCheckStateResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='getTagCheckStateResult' and count(parameter)=0]"
			[Register ("getTagCheckStateResult", "()Z", "GetGetTagCheckStateResultHandler")]
			get {
				const string __id = "getTagCheckStateResult.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='setTagCheckStateResult' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTagCheckStateResult", "(Z)V", "GetSetTagCheckStateResult_ZHandler")]
			set {
				const string __id = "setTagCheckStateResult.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTags;
#pragma warning disable 0169
		static Delegate GetGetTagsHandler ()
		{
			if (cb_getTags == null)
				cb_getTags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTags);
			return cb_getTags;
		}

		static IntPtr n_GetTags (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Tags);
		}
#pragma warning restore 0169

		static Delegate cb_setTags_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetTags_Ljava_util_Set_Handler ()
		{
			if (cb_setTags_Ljava_util_Set_ == null)
				cb_setTags_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTags_Ljava_util_Set_);
			return cb_setTags_Ljava_util_Set_;
		}

		static void n_SetTags_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.JPushMessage __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tags = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<string> Tags {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='getTags' and count(parameter)=0]"
			[Register ("getTags", "()Ljava/util/Set;", "GetGetTagsHandler")]
			get {
				const string __id = "getTags.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushMessage']/method[@name='setTags' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
			[Register ("setTags", "(Ljava/util/Set;)V", "GetSetTags_Ljava_util_Set_Handler")]
			set {
				const string __id = "setTags.(Ljava/util/Set;)V";
				IntPtr native_value = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
