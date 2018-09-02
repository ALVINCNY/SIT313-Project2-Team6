using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='PushClickEntity']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/data/PushClickEntity", DoNotGenerateAcw=true)]
	public partial class PushClickEntity : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='PushClickEntity']/field[@name='accessId']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='PushClickEntity']/field[@name='action']"
		[Register ("action")]
		public int Action {
			get {
				const string __id = "action.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "action.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='PushClickEntity']/field[@name='broadcastId']"
		[Register ("broadcastId")]
		public long BroadcastId {
			get {
				const string __id = "broadcastId.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "broadcastId.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='PushClickEntity']/field[@name='clickTime']"
		[Register ("clickTime")]
		public long ClickTime {
			get {
				const string __id = "clickTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "clickTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='PushClickEntity']/field[@name='msgId']"
		[Register ("msgId")]
		public long MsgId {
			get {
				const string __id = "msgId.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "msgId.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='PushClickEntity']/field[@name='pkgName']"
		[Register ("pkgName")]
		public string PkgName {
			get {
				const string __id = "pkgName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pkgName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='PushClickEntity']/field[@name='timestamp']"
		[Register ("timestamp")]
		public long Timestamp {
			get {
				const string __id = "timestamp.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "timestamp.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='PushClickEntity']/field[@name='type']"
		[Register ("type")]
		public long Type {
			get {
				const string __id = "type.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "type.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/data/PushClickEntity", typeof (PushClickEntity));
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

		protected PushClickEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='PushClickEntity']/constructor[@name='PushClickEntity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushClickEntity ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='PushClickEntity']/constructor[@name='PushClickEntity' and count(parameter)=8 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='long'] and parameter[7][@type='long'] and parameter[8][@type='int']]"
		[Register (".ctor", "(JJJJLjava/lang/String;JJI)V", "")]
		public unsafe PushClickEntity (long p0, long p1, long p2, long p3, string p4, long p5, long p6, int p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JJJJLjava/lang/String;JJI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (p7);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}
}
