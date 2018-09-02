using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Horse.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/horse/data/StrategyItem", DoNotGenerateAcw=true)]
	public partial class StrategyItem : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/horse/data/StrategyItem", typeof (StrategyItem));
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

		protected StrategyItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']/constructor[@name='StrategyItem' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;ILjava/lang/String;III)V", "")]
		public unsafe StrategyItem (string p0, int p1, string p2, int p3, int p4, int p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;ILjava/lang/String;III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.A ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "GetAHandler")]
		public virtual unsafe string A ()
		{
			const string __id = "a.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_a_Lcom_tencent_android_tpush_horse_data_StrategyItem_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_tencent_android_tpush_horse_data_StrategyItem_Handler ()
		{
			if (cb_a_Lcom_tencent_android_tpush_horse_data_StrategyItem_ == null)
				cb_a_Lcom_tencent_android_tpush_horse_data_StrategyItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_A_Lcom_tencent_android_tpush_horse_data_StrategyItem_);
			return cb_a_Lcom_tencent_android_tpush_horse_data_StrategyItem_;
		}

		static bool n_A_Lcom_tencent_android_tpush_horse_data_StrategyItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.tencent.android.tpush.horse.data.StrategyItem']]"
		[Register ("a", "(Lcom/tencent/android/tpush/horse/data/StrategyItem;)Z", "GetA_Lcom_tencent_android_tpush_horse_data_StrategyItem_Handler")]
		public virtual unsafe bool A (global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem p0)
		{
			const string __id = "a.(Lcom/tencent/android/tpush/horse/data/StrategyItem;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_a_I;
#pragma warning disable 0169
		static Delegate GetA_IHandler ()
		{
			if (cb_a_I == null)
				cb_a_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_A_I);
			return cb_a_I;
		}

		static void n_A_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)V", "GetA_IHandler")]
		public virtual unsafe void A (int p0)
		{
			const string __id = "a.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_B);
			return cb_b;
		}

		static int n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.B ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()I", "GetBHandler")]
		public virtual unsafe int B ()
		{
			const string __id = "b.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_C);
			return cb_c;
		}

		static IntPtr n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.C ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/String;", "GetCHandler")]
		public virtual unsafe string C ()
		{
			const string __id = "c.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_D);
			return cb_d;
		}

		static int n_D (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.D ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()I", "GetDHandler")]
		public virtual unsafe int D ()
		{
			const string __id = "d.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_e;
#pragma warning disable 0169
		static Delegate GetEHandler ()
		{
			if (cb_e == null)
				cb_e = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_E);
			return cb_e;
		}

		static int n_E (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.E ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()I", "GetEHandler")]
		public virtual unsafe int E ()
		{
			const string __id = "e.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_f;
#pragma warning disable 0169
		static Delegate GetFHandler ()
		{
			if (cb_f == null)
				cb_f = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_F);
			return cb_f;
		}

		static int n_F (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.F ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()I", "GetFHandler")]
		public virtual unsafe int F ()
		{
			const string __id = "f.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_g;
#pragma warning disable 0169
		static Delegate GetGHandler ()
		{
			if (cb_g == null)
				cb_g = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_G);
			return cb_g;
		}

		static bool n_G (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.G ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Z", "GetGHandler")]
		public virtual unsafe bool G ()
		{
			const string __id = "g.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_h;
#pragma warning disable 0169
		static Delegate GetHHandler ()
		{
			if (cb_h == null)
				cb_h = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_H);
			return cb_h;
		}

		static bool n_H (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.H ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Z", "GetHHandler")]
		public virtual unsafe bool H ()
		{
			const string __id = "h.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_i;
#pragma warning disable 0169
		static Delegate GetIHandler ()
		{
			if (cb_i == null)
				cb_i = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_I);
			return cb_i;
		}

		static bool n_I (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.I ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Z", "GetIHandler")]
		public virtual unsafe bool I ()
		{
			const string __id = "i.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_j;
#pragma warning disable 0169
		static Delegate GetJHandler ()
		{
			if (cb_j == null)
				cb_j = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_J);
			return cb_j;
		}

		static bool n_J (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.J ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='StrategyItem']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Z", "GetJHandler")]
		public virtual unsafe bool J ()
		{
			const string __id = "j.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
