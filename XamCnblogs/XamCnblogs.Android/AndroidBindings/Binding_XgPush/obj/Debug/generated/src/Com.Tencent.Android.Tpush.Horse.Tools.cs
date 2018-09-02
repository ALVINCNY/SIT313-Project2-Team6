using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Horse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/horse/Tools", DoNotGenerateAcw=true)]
	public partial class Tools : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/field[@name='KEY']"
		[Register ("KEY")]
		public const string Key = (string) ".com.tencent.tpush.toolschannel";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/field[@name='SHARE_NAME']"
		[Register ("SHARE_NAME")]
		public const string ShareName = (string) ".com.tencent.tpush.toolschannel_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/field[@name='STRATEGY']"
		[Register ("STRATEGY")]
		public const string Strategy = (string) ".com.tencent.tpush.toolsstrategy";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/field[@name='TOOLS_NAME_UNI_SUFFIX']"
		[Register ("TOOLS_NAME_UNI_SUFFIX")]
		public const string ToolsNameUniSuffix = (string) ".com.tencent.tpush.tools";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/field[@name='TYPE_DEFAULT']"
		[Register ("TYPE_DEFAULT")]
		public const int TypeDefault = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/field[@name='TYPE_HTTP']"
		[Register ("TYPE_HTTP")]
		public const int TypeHttp = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/field[@name='TYPE_HTTP_WAP']"
		[Register ("TYPE_HTTP_WAP")]
		public const int TypeHttpWap = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/field[@name='TYPE_TCP']"
		[Register ("TYPE_TCP")]
		public const int TypeTcp = (int) 1;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/horse/Tools", typeof (Tools));
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

		protected Tools (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/constructor[@name='Tools' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Tools ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/method[@name='clearAll' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearAll", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearAll (global::Android.Content.Context p0)
		{
			const string __id = "clearAll.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/method[@name='clearCacheServerItems' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearCacheServerItems", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearCacheServerItems (global::Android.Content.Context p0)
		{
			const string __id = "clearCacheServerItems.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/method[@name='clearOptKeyList' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearOptKeyList", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearOptKeyList (global::Android.Content.Context p0)
		{
			const string __id = "clearOptKeyList.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/method[@name='clearOptStrategyItem' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearOptStrategyItem", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearOptStrategyItem (global::Android.Content.Context p0)
		{
			const string __id = "clearOptStrategyItem.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/method[@name='clearRegisterInfo' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("clearRegisterInfo", "(Landroid/content/Context;J)V", "")]
		public static unsafe void ClearRegisterInfo (global::Android.Content.Context p0, long p1)
		{
			const string __id = "clearRegisterInfo.(Landroid/content/Context;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/method[@name='getChannelType' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getChannelType", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetChannelType (global::Android.Content.Context p0)
		{
			const string __id = "getChannelType.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='Tools']/method[@name='setChannelType' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setChannelType", "(Landroid/content/Context;I)V", "")]
		public static unsafe void SetChannelType (global::Android.Content.Context p0, int p1)
		{
			const string __id = "setChannelType.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
