using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='TagEntity']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/data/TagEntity", DoNotGenerateAcw=true)]
	public partial class TagEntity : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='TagEntity']/field[@name='accessId']"
		[Register ("accessId")]
		public long AccessId {
			get {
				const string __id = "accessId.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "accessId.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='TagEntity']/field[@name='flag']"
		[Register ("flag")]
		public int Flag {
			get {
				const string __id = "flag.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "flag.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='TagEntity']/field[@name='tag']"
		[Register ("tag")]
		public string Tag {
			get {
				const string __id = "tag.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tag.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/data/TagEntity", typeof (TagEntity));
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

		protected TagEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='TagEntity']/constructor[@name='TagEntity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TagEntity ()
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

	}
}
