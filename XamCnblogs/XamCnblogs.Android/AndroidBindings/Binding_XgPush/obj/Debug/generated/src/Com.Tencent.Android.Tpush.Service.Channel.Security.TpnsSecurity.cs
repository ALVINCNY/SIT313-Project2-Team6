using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Service.Channel.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/service/channel/security/TpnsSecurity", DoNotGenerateAcw=true)]
	public partial class TpnsSecurity : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/field[@name='encKey']"
		[Register ("encKey")]
		protected IList<byte> EncKey {
			get {
				const string __id = "encKey.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "encKey.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/field[@name='incRemote']"
		[Register ("incRemote")]
		protected long IncRemote {
			get {
				const string __id = "incRemote.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "incRemote.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/field[@name='iv']"
		[Register ("iv")]
		protected IList<byte> Iv {
			get {
				const string __id = "iv.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "iv.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/field[@name='key']"
		[Register ("key")]
		protected IList<byte> Key {
			get {
				const string __id = "key.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "key.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/field[@name='tpnsSecurityLibFullName']"
		[Register ("tpnsSecurityLibFullName")]
		public const string TpnsSecurityLibFullName = (string) "libtpnsSecurity.so";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/service/channel/security/TpnsSecurity", typeof (TpnsSecurity));
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

		protected TpnsSecurity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/constructor[@name='TpnsSecurity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TpnsSecurity ()
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

		static Delegate cb_getInc;
#pragma warning disable 0169
		static Delegate GetGetIncHandler ()
		{
			if (cb_getInc == null)
				cb_getInc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetInc);
			return cb_getInc;
		}

		static long n_GetInc (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Inc;
		}
#pragma warning restore 0169

		public virtual unsafe long Inc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='getInc' and count(parameter)=0]"
			[Register ("getInc", "()J", "GetGetIncHandler")]
			get {
				const string __id = "getInc.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRandom;
#pragma warning disable 0169
		static Delegate GetGetRandomHandler ()
		{
			if (cb_getRandom == null)
				cb_getRandom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRandom);
			return cb_getRandom;
		}

		static long n_GetRandom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Random;
		}
#pragma warning restore 0169

		public virtual unsafe long Random {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='getRandom' and count(parameter)=0]"
			[Register ("getRandom", "()J", "GetGetRandomHandler")]
			get {
				const string __id = "getRandom.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_checkRemoteInc_J;
#pragma warning disable 0169
		static Delegate GetCheckRemoteInc_JHandler ()
		{
			if (cb_checkRemoteInc_J == null)
				cb_checkRemoteInc_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_CheckRemoteInc_J);
			return cb_checkRemoteInc_J;
		}

		static void n_CheckRemoteInc_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckRemoteInc (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='checkRemoteInc' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("checkRemoteInc", "(J)V", "GetCheckRemoteInc_JHandler")]
		public virtual unsafe void CheckRemoteInc (long p0)
		{
			const string __id = "checkRemoteInc.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='checkTpnsSecurityLibSo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkTpnsSecurityLibSo", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool CheckTpnsSecurityLibSo (global::Android.Content.Context p0)
		{
			const string __id = "checkTpnsSecurityLibSo.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_decryptByAES_arrayBJ;
#pragma warning disable 0169
		static Delegate GetDecryptByAES_arrayBJHandler ()
		{
			if (cb_decryptByAES_arrayBJ == null)
				cb_decryptByAES_arrayBJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_DecryptByAES_arrayBJ);
			return cb_decryptByAES_arrayBJ;
		}

		static IntPtr n_DecryptByAES_arrayBJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.DecryptByAES (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='decryptByAES' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='long']]"
		[Register ("decryptByAES", "([BJ)[B", "GetDecryptByAES_arrayBJHandler")]
		public virtual unsafe byte[] DecryptByAES (byte[] p0, long p1)
		{
			const string __id = "decryptByAES.([BJ)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_decryptData_arrayB;
#pragma warning disable 0169
		static Delegate GetDecryptData_arrayBHandler ()
		{
			if (cb_decryptData_arrayB == null)
				cb_decryptData_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecryptData_arrayB);
			return cb_decryptData_arrayB;
		}

		static IntPtr n_DecryptData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.DecryptData (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='decryptData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decryptData", "([B)[B", "GetDecryptData_arrayBHandler")]
		public virtual unsafe byte[] DecryptData (byte[] p0)
		{
			const string __id = "decryptData.([B)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_encryptByAES_arrayBJ;
#pragma warning disable 0169
		static Delegate GetEncryptByAES_arrayBJHandler ()
		{
			if (cb_encryptByAES_arrayBJ == null)
				cb_encryptByAES_arrayBJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_EncryptByAES_arrayBJ);
			return cb_encryptByAES_arrayBJ;
		}

		static IntPtr n_EncryptByAES_arrayBJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.EncryptByAES (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='encryptByAES' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='long']]"
		[Register ("encryptByAES", "([BJ)[B", "GetEncryptByAES_arrayBJHandler")]
		public virtual unsafe byte[] EncryptByAES (byte[] p0, long p1)
		{
			const string __id = "encryptByAES.([BJ)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_encryptByRSA_arrayB;
#pragma warning disable 0169
		static Delegate GetEncryptByRSA_arrayBHandler ()
		{
			if (cb_encryptByRSA_arrayB == null)
				cb_encryptByRSA_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncryptByRSA_arrayB);
			return cb_encryptByRSA_arrayB;
		}

		static IntPtr n_EncryptByRSA_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.EncryptByRSA (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='encryptByRSA' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encryptByRSA", "([B)[B", "GetEncryptByRSA_arrayBHandler")]
		public virtual unsafe byte[] EncryptByRSA (byte[] p0)
		{
			const string __id = "encryptByRSA.([B)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_encryptData_arrayB;
#pragma warning disable 0169
		static Delegate GetEncryptData_arrayBHandler ()
		{
			if (cb_encryptData_arrayB == null)
				cb_encryptData_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncryptData_arrayB);
			return cb_encryptData_arrayB;
		}

		static IntPtr n_EncryptData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.EncryptData (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='encryptData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encryptData", "([B)[B", "GetEncryptData_arrayBHandler")]
		public virtual unsafe byte[] EncryptData (byte[] p0)
		{
			const string __id = "encryptData.([B)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='generateAESKey' and count(parameter)=0]"
		[Register ("generateAESKey", "()[B", "")]
		public static unsafe byte[] GenerateAESKey ()
		{
			const string __id = "generateAESKey.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='generateIV' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("generateIV", "(J)[B", "")]
		public static unsafe byte[] GenerateIV (long p0)
		{
			const string __id = "generateIV.(J)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='generateLocalSocketServieName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("generateLocalSocketServieName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GenerateLocalSocketServieName (global::Android.Content.Context p0)
		{
			const string __id = "generateLocalSocketServieName.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='generateLocalSocketServieNameNative' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("generateLocalSocketServieNameNative", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string GenerateLocalSocketServieNameNative (global::Java.Lang.Object p0)
		{
			const string __id = "generateLocalSocketServieNameNative.(Ljava/lang/Object;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='getBusinessDeviceId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getBusinessDeviceId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetBusinessDeviceId (global::Android.Content.Context p0)
		{
			const string __id = "getBusinessDeviceId.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='getBusinessDeviceIdNative' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getBusinessDeviceIdNative", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string GetBusinessDeviceIdNative (global::Java.Lang.Object p0)
		{
			const string __id = "getBusinessDeviceIdNative.(Ljava/lang/Object;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getEncKey;
#pragma warning disable 0169
		static Delegate GetGetEncKeyHandler ()
		{
			if (cb_getEncKey == null)
				cb_getEncKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncKey);
			return cb_getEncKey;
		}

		static IntPtr n_GetEncKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncKey ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='getEncKey' and count(parameter)=0]"
		[Register ("getEncKey", "()[B", "GetGetEncKeyHandler")]
		public virtual unsafe byte[] GetEncKey ()
		{
			const string __id = "getEncKey.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='getEncryptAPKSignature' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getEncryptAPKSignature", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetEncryptAPKSignature (global::Android.Content.Context p0)
		{
			const string __id = "getEncryptAPKSignature.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='getEncryptAPKSignatureNative' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getEncryptAPKSignatureNative", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string GetEncryptAPKSignatureNative (global::Java.Lang.Object p0)
		{
			const string __id = "getEncryptAPKSignatureNative.(Ljava/lang/Object;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_java_decryptByAES_arrayBJ;
#pragma warning disable 0169
		static Delegate GetJava_decryptByAES_arrayBJHandler ()
		{
			if (cb_java_decryptByAES_arrayBJ == null)
				cb_java_decryptByAES_arrayBJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_Java_decryptByAES_arrayBJ);
			return cb_java_decryptByAES_arrayBJ;
		}

		static IntPtr n_Java_decryptByAES_arrayBJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Java_decryptByAES (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='java_decryptByAES' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='long']]"
		[Register ("java_decryptByAES", "([BJ)[B", "GetJava_decryptByAES_arrayBJHandler")]
		public virtual unsafe byte[] Java_decryptByAES (byte[] p0, long p1)
		{
			const string __id = "java_decryptByAES.([BJ)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_java_encryptByAES_arrayBJ;
#pragma warning disable 0169
		static Delegate GetJava_encryptByAES_arrayBJHandler ()
		{
			if (cb_java_encryptByAES_arrayBJ == null)
				cb_java_encryptByAES_arrayBJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_Java_encryptByAES_arrayBJ);
			return cb_java_encryptByAES_arrayBJ;
		}

		static IntPtr n_Java_encryptByAES_arrayBJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Java_encryptByAES (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='java_encryptByAES' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='long']]"
		[Register ("java_encryptByAES", "([BJ)[B", "GetJava_encryptByAES_arrayBJHandler")]
		public virtual unsafe byte[] Java_encryptByAES (byte[] p0, long p1)
		{
			const string __id = "java_encryptByAES.([BJ)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_java_encryptByRSA_arrayB;
#pragma warning disable 0169
		static Delegate GetJava_encryptByRSA_arrayBHandler ()
		{
			if (cb_java_encryptByRSA_arrayB == null)
				cb_java_encryptByRSA_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Java_encryptByRSA_arrayB);
			return cb_java_encryptByRSA_arrayB;
		}

		static IntPtr n_Java_encryptByRSA_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Java_encryptByRSA (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='java_encryptByRSA' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("java_encryptByRSA", "([B)[B", "GetJava_encryptByRSA_arrayBHandler")]
		public virtual unsafe byte[] Java_encryptByRSA (byte[] p0)
		{
			const string __id = "java_encryptByRSA.([B)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='java_generateAESKey' and count(parameter)=0]"
		[Register ("java_generateAESKey", "()[B", "")]
		public static unsafe byte[] Java_generateAESKey ()
		{
			const string __id = "java_generateAESKey.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='java_generateIV' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("java_generateIV", "(J)[B", "")]
		public static unsafe byte[] Java_generateIV (long p0)
		{
			const string __id = "java_generateIV.(J)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='java_oiSymmetryDecrypt2Byte' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("java_oiSymmetryDecrypt2Byte", "([B)[B", "")]
		public static unsafe byte[] Java_oiSymmetryDecrypt2Byte (byte[] p0)
		{
			const string __id = "java_oiSymmetryDecrypt2Byte.([B)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='java_oiSymmetryEncrypt2Byte' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("java_oiSymmetryEncrypt2Byte", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Java_oiSymmetryEncrypt2Byte (string p0)
		{
			const string __id = "java_oiSymmetryEncrypt2Byte.(Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_needsUpdate;
#pragma warning disable 0169
		static Delegate GetNeedsUpdateHandler ()
		{
			if (cb_needsUpdate == null)
				cb_needsUpdate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NeedsUpdate);
			return cb_needsUpdate;
		}

		static bool n_NeedsUpdate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedsUpdate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='needsUpdate' and count(parameter)=0]"
		[Register ("needsUpdate", "()Z", "GetNeedsUpdateHandler")]
		public virtual unsafe bool NeedsUpdate ()
		{
			const string __id = "needsUpdate.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='oiSymmetryDecrypt2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("oiSymmetryDecrypt2", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string OiSymmetryDecrypt2 (string p0)
		{
			const string __id = "oiSymmetryDecrypt2.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='oiSymmetryDecrypt2Byte' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("oiSymmetryDecrypt2Byte", "([B)[B", "")]
		public static unsafe byte[] OiSymmetryDecrypt2Byte (byte[] p0)
		{
			const string __id = "oiSymmetryDecrypt2Byte.([B)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='oiSymmetryEncrypt2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("oiSymmetryEncrypt2", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string OiSymmetryEncrypt2 (string p0)
		{
			const string __id = "oiSymmetryEncrypt2.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='oiSymmetryEncrypt2Byte' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("oiSymmetryEncrypt2Byte", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] OiSymmetryEncrypt2Byte (string p0)
		{
			const string __id = "oiSymmetryEncrypt2Byte.(Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_update;
#pragma warning disable 0169
		static Delegate GetUpdateHandler ()
		{
			if (cb_update == null)
				cb_update = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Update);
			return cb_update;
		}

		static void n_Update (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Security.TpnsSecurity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.security']/class[@name='TpnsSecurity']/method[@name='update' and count(parameter)=0]"
		[Register ("update", "()V", "GetUpdateHandler")]
		public virtual unsafe void Update ()
		{
			const string __id = "update.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
