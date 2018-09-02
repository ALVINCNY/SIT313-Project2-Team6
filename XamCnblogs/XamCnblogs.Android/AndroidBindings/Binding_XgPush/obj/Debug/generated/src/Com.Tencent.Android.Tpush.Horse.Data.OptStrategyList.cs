using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Horse.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/horse/data/OptStrategyList", DoNotGenerateAcw=true)]
	public partial class OptStrategyList : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/horse/data/OptStrategyList", typeof (OptStrategyList));
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

		protected OptStrategyList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/constructor[@name='OptStrategyList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OptStrategyList ()
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
			global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.A ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/tencent/android/tpush/horse/data/StrategyItem;", "GetAHandler")]
		public virtual unsafe global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem A ()
		{
			const string __id = "a.()Lcom/tencent/android/tpush/horse/data/StrategyItem;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_a_Lcom_tencent_android_tpush_horse_data_StrategyItem_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_tencent_android_tpush_horse_data_StrategyItem_Handler ()
		{
			if (cb_a_Lcom_tencent_android_tpush_horse_data_StrategyItem_ == null)
				cb_a_Lcom_tencent_android_tpush_horse_data_StrategyItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_tencent_android_tpush_horse_data_StrategyItem_);
			return cb_a_Lcom_tencent_android_tpush_horse_data_StrategyItem_;
		}

		static void n_A_Lcom_tencent_android_tpush_horse_data_StrategyItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.tencent.android.tpush.horse.data.StrategyItem']]"
		[Register ("a", "(Lcom/tencent/android/tpush/horse/data/StrategyItem;)V", "GetA_Lcom_tencent_android_tpush_horse_data_StrategyItem_Handler")]
		public virtual unsafe void A (global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem p0)
		{
			const string __id = "a.(Lcom/tencent/android/tpush/horse/data/StrategyItem;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_a_J;
#pragma warning disable 0169
		static Delegate GetA_JHandler ()
		{
			if (cb_a_J == null)
				cb_a_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_A_J);
			return cb_a_J;
		}

		static void n_A_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/method[@name='a' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("a", "(J)V", "GetA_JHandler")]
		public virtual unsafe void A (long p0)
		{
			const string __id = "a.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_a_S;
#pragma warning disable 0169
		static Delegate GetA_SHandler ()
		{
			if (cb_a_S == null)
				cb_a_S = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, IntPtr>) n_A_S);
			return cb_a_S;
		}

		static IntPtr n_A_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.A (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/method[@name='a' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("a", "(S)Ljava/util/List;", "GetA_SHandler")]
		public virtual unsafe global::System.Collections.IList A (short p0)
		{
			const string __id = "a.(S)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.B ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/tencent/android/tpush/horse/data/StrategyItem;", "GetBHandler")]
		public virtual unsafe global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem B ()
		{
			const string __id = "b.()Lcom/tencent/android/tpush/horse/data/StrategyItem;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_b_Lcom_tencent_android_tpush_horse_data_StrategyItem_;
#pragma warning disable 0169
		static Delegate GetB_Lcom_tencent_android_tpush_horse_data_StrategyItem_Handler ()
		{
			if (cb_b_Lcom_tencent_android_tpush_horse_data_StrategyItem_ == null)
				cb_b_Lcom_tencent_android_tpush_horse_data_StrategyItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_B_Lcom_tencent_android_tpush_horse_data_StrategyItem_);
			return cb_b_Lcom_tencent_android_tpush_horse_data_StrategyItem_;
		}

		static void n_B_Lcom_tencent_android_tpush_horse_data_StrategyItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.tencent.android.tpush.horse.data.StrategyItem']]"
		[Register ("b", "(Lcom/tencent/android/tpush/horse/data/StrategyItem;)V", "GetB_Lcom_tencent_android_tpush_horse_data_StrategyItem_Handler")]
		public virtual unsafe void B (global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem p0)
		{
			const string __id = "b.(Lcom/tencent/android/tpush/horse/data/StrategyItem;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.C ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Lcom/tencent/android/tpush/horse/data/StrategyItem;", "GetCHandler")]
		public virtual unsafe global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem C ()
		{
			const string __id = "c.()Lcom/tencent/android/tpush/horse/data/StrategyItem;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_c_Lcom_tencent_android_tpush_horse_data_StrategyItem_;
#pragma warning disable 0169
		static Delegate GetC_Lcom_tencent_android_tpush_horse_data_StrategyItem_Handler ()
		{
			if (cb_c_Lcom_tencent_android_tpush_horse_data_StrategyItem_ == null)
				cb_c_Lcom_tencent_android_tpush_horse_data_StrategyItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_C_Lcom_tencent_android_tpush_horse_data_StrategyItem_);
			return cb_c_Lcom_tencent_android_tpush_horse_data_StrategyItem_;
		}

		static void n_C_Lcom_tencent_android_tpush_horse_data_StrategyItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.C (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/method[@name='c' and count(parameter)=1 and parameter[1][@type='com.tencent.android.tpush.horse.data.StrategyItem']]"
		[Register ("c", "(Lcom/tencent/android/tpush/horse/data/StrategyItem;)V", "GetC_Lcom_tencent_android_tpush_horse_data_StrategyItem_Handler")]
		public virtual unsafe void C (global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem p0)
		{
			const string __id = "c.(Lcom/tencent/android/tpush/horse/data/StrategyItem;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_D);
			return cb_d;
		}

		static IntPtr n_D (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.D ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lcom/tencent/android/tpush/horse/data/StrategyItem;", "GetDHandler")]
		public virtual unsafe global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem D ()
		{
			const string __id = "d.()Lcom/tencent/android/tpush/horse/data/StrategyItem;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_d_Lcom_tencent_android_tpush_horse_data_StrategyItem_;
#pragma warning disable 0169
		static Delegate GetD_Lcom_tencent_android_tpush_horse_data_StrategyItem_Handler ()
		{
			if (cb_d_Lcom_tencent_android_tpush_horse_data_StrategyItem_ == null)
				cb_d_Lcom_tencent_android_tpush_horse_data_StrategyItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_D_Lcom_tencent_android_tpush_horse_data_StrategyItem_);
			return cb_d_Lcom_tencent_android_tpush_horse_data_StrategyItem_;
		}

		static void n_D_Lcom_tencent_android_tpush_horse_data_StrategyItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.D (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/method[@name='d' and count(parameter)=1 and parameter[1][@type='com.tencent.android.tpush.horse.data.StrategyItem']]"
		[Register ("d", "(Lcom/tencent/android/tpush/horse/data/StrategyItem;)V", "GetD_Lcom_tencent_android_tpush_horse_data_StrategyItem_Handler")]
		public virtual unsafe void D (global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem p0)
		{
			const string __id = "d.(Lcom/tencent/android/tpush/horse/data/StrategyItem;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_e;
#pragma warning disable 0169
		static Delegate GetEHandler ()
		{
			if (cb_e == null)
				cb_e = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_E);
			return cb_e;
		}

		static IntPtr n_E (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.E ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Lcom/tencent/android/tpush/horse/data/StrategyItem;", "GetEHandler")]
		public virtual unsafe global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem E ()
		{
			const string __id = "e.()Lcom/tencent/android/tpush/horse/data/StrategyItem;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_f;
#pragma warning disable 0169
		static Delegate GetFHandler ()
		{
			if (cb_f == null)
				cb_f = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_F);
			return cb_f;
		}

		static IntPtr n_F (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.F ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Ljava/util/List;", "GetFHandler")]
		public virtual unsafe global::System.Collections.IList F ()
		{
			const string __id = "f.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_g;
#pragma warning disable 0169
		static Delegate GetGHandler ()
		{
			if (cb_g == null)
				cb_g = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_G);
			return cb_g;
		}

		static long n_G (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.G ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='OptStrategyList']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()J", "GetGHandler")]
		public virtual unsafe long G ()
		{
			const string __id = "g.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
