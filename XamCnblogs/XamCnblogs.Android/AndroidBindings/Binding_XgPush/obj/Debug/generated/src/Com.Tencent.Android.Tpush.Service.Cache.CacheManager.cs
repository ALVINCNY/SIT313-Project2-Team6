using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Service.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/service/cache/CacheManager", DoNotGenerateAcw=true)]
	public partial class CacheManager : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/service/cache/CacheManager", typeof (CacheManager));
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

		protected CacheManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::System.Collections.IDictionary RegisterEntityMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getRegisterEntityMap' and count(parameter)=0]"
			[Register ("getRegisterEntityMap", "()Ljava/util/Map;", "GetGetRegisterEntityMapHandler")]
			get {
				const string __id = "getRegisterEntityMap.()Ljava/util/Map;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='UninstallInfoByPkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("UninstallInfoByPkgName", "(Ljava/lang/String;)V", "")]
		public static unsafe void UninstallInfoByPkgName (string p0)
		{
			const string __id = "UninstallInfoByPkgName.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='UninstallInfoSuccessByPkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("UninstallInfoSuccessByPkgName", "(Ljava/lang/String;)V", "")]
		public static unsafe void UninstallInfoSuccessByPkgName (string p0)
		{
			const string __id = "UninstallInfoSuccessByPkgName.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='UnregisterInfoByPkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("UnregisterInfoByPkgName", "(Ljava/lang/String;)V", "")]
		public static unsafe void UnregisterInfoByPkgName (string p0)
		{
			const string __id = "UnregisterInfoByPkgName.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='UnregisterInfoSuccessByPkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("UnregisterInfoSuccessByPkgName", "(Ljava/lang/String;)V", "")]
		public static unsafe void UnregisterInfoSuccessByPkgName (string p0)
		{
			const string __id = "UnregisterInfoSuccessByPkgName.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='addOptKey' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("addOptKey", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void AddOptKey (global::Android.Content.Context p0, string p1)
		{
			const string __id = "addOptKey.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='addOptKeyList' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.HashSet']]"
		[Register ("addOptKeyList", "(Landroid/content/Context;Ljava/util/HashSet;)V", "")]
		public static unsafe void AddOptKeyList (global::Android.Content.Context p0, global::Java.Util.HashSet p1)
		{
			const string __id = "addOptKeyList.(Landroid/content/Context;Ljava/util/HashSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='addOptStrategy' and count(parameter)=1 and parameter[1][@type='com.tencent.android.tpush.horse.data.StrategyItem']]"
		[Register ("addOptStrategy", "(Lcom/tencent/android/tpush/horse/data/StrategyItem;)V", "")]
		public static unsafe void AddOptStrategy (global::Com.Tencent.Android.Tpush.Horse.Data.StrategyItem p0)
		{
			const string __id = "addOptStrategy.(Lcom/tencent/android/tpush/horse/data/StrategyItem;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='addOptStrategyList' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.android.tpush.horse.data.OptStrategyList']]"
		[Register ("addOptStrategyList", "(Landroid/content/Context;Ljava/lang/String;Lcom/tencent/android/tpush/horse/data/OptStrategyList;)V", "")]
		public static unsafe void AddOptStrategyList (global::Android.Content.Context p0, string p1, global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList p2)
		{
			const string __id = "addOptStrategyList.(Landroid/content/Context;Ljava/lang/String;Lcom/tencent/android/tpush/horse/data/OptStrategyList;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='addRegisterInfo' and count(parameter)=1 and parameter[1][@type='com.tencent.android.tpush.data.RegisterEntity']]"
		[Register ("addRegisterInfo", "(Lcom/tencent/android/tpush/data/RegisterEntity;)V", "")]
		public static unsafe void AddRegisterInfo (global::Com.Tencent.Android.Tpush.Data.RegisterEntity p0)
		{
			const string __id = "addRegisterInfo.(Lcom/tencent/android/tpush/data/RegisterEntity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='addServerItems' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.ArrayList']]"
		[Register ("addServerItems", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/ArrayList;)V", "")]
		public static unsafe void AddServerItems (global::Android.Content.Context p0, string p1, global::System.Collections.IList p2)
		{
			const string __id = "addServerItems.(Landroid/content/Context;Ljava/lang/String;Ljava/util/ArrayList;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='clearDomainServerItem' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearDomainServerItem", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearDomainServerItem (global::Android.Content.Context p0)
		{
			const string __id = "clearDomainServerItem.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='clearOptKeyList' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='findValidPackageByAccessid' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("findValidPackageByAccessid", "(J)Ljava/lang/String;", "")]
		public static unsafe string FindValidPackageByAccessid (long p0)
		{
			const string __id = "findValidPackageByAccessid.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='findValidRegisterEntityByPkg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findValidRegisterEntityByPkg", "(Ljava/lang/String;)Lcom/tencent/android/tpush/data/RegisterEntity;", "")]
		public static unsafe global::Com.Tencent.Android.Tpush.Data.RegisterEntity FindValidRegisterEntityByPkg (string p0)
		{
			const string __id = "findValidRegisterEntityByPkg.(Ljava/lang/String;)Lcom/tencent/android/tpush/data/RegisterEntity;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Data.RegisterEntity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getCurrentAppRegisterEntity' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCurrentAppRegisterEntity", "(Landroid/content/Context;)Lcom/tencent/android/tpush/data/RegisterEntity;", "")]
		public static unsafe global::Com.Tencent.Android.Tpush.Data.RegisterEntity GetCurrentAppRegisterEntity (global::Android.Content.Context p0)
		{
			const string __id = "getCurrentAppRegisterEntity.(Landroid/content/Context;)Lcom/tencent/android/tpush/data/RegisterEntity;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Data.RegisterEntity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getDomain' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDomain", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetDomain (global::Android.Content.Context p0)
		{
			const string __id = "getDomain.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getDomainKeyList' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDomainKeyList", "(Landroid/content/Context;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.IList GetDomainKeyList (global::Android.Content.Context p0)
		{
			const string __id = "getDomainKeyList.(Landroid/content/Context;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getGuid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getGuid", "(Landroid/content/Context;)J", "")]
		public static unsafe long GetGuid (global::Android.Content.Context p0)
		{
			const string __id = "getGuid.(Landroid/content/Context;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getLastLoadIpTime' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLastLoadIpTime", "(Landroid/content/Context;)J", "")]
		public static unsafe long GetLastLoadIpTime (global::Android.Content.Context p0)
		{
			const string __id = "getLastLoadIpTime.(Landroid/content/Context;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getOptKeyList' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getOptKeyList", "(Landroid/content/Context;)Ljava/util/HashSet;", "")]
		public static unsafe global::Java.Util.HashSet GetOptKeyList (global::Android.Content.Context p0)
		{
			const string __id = "getOptKeyList.(Landroid/content/Context;)Ljava/util/HashSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getOptStrategyList' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getOptStrategyList", "(Landroid/content/Context;Ljava/lang/String;)Lcom/tencent/android/tpush/horse/data/OptStrategyList;", "")]
		public static unsafe global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList GetOptStrategyList (global::Android.Content.Context p0, string p1)
		{
			const string __id = "getOptStrategyList.(Landroid/content/Context;Ljava/lang/String;)Lcom/tencent/android/tpush/horse/data/OptStrategyList;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.OptStrategyList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getQua' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("getQua", "(Landroid/content/Context;J)Ljava/lang/String;", "")]
		public static unsafe string GetQua (global::Android.Content.Context p0, long p1)
		{
			const string __id = "getQua.(Landroid/content/Context;J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getRegisterInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRegisterInfo", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.IList GetRegisterInfo (global::Android.Content.Context p0)
		{
			const string __id = "getRegisterInfo.(Landroid/content/Context;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getRegisterInfoByPkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRegisterInfoByPkgName", "(Ljava/lang/String;)Lcom/tencent/android/tpush/data/RegisterEntity;", "")]
		public static unsafe global::Com.Tencent.Android.Tpush.Data.RegisterEntity GetRegisterInfoByPkgName (string p0)
		{
			const string __id = "getRegisterInfoByPkgName.(Ljava/lang/String;)Lcom/tencent/android/tpush/data/RegisterEntity;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Data.RegisterEntity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getRegisterInfos' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRegisterInfos", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.IList GetRegisterInfos (global::Android.Content.Context p0)
		{
			const string __id = "getRegisterInfos.(Landroid/content/Context;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getServerItems' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getServerItems", "(Landroid/content/Context;Ljava/lang/String;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.IList GetServerItems (global::Android.Content.Context p0, string p1)
		{
			const string __id = "getServerItems.(Landroid/content/Context;Ljava/lang/String;)Ljava/util/ArrayList;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getSpeedTestList' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSpeedTestList", "(Landroid/content/Context;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.IList GetSpeedTestList (global::Android.Content.Context p0)
		{
			const string __id = "getSpeedTestList.(Landroid/content/Context;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getToken' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getToken", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetToken (global::Android.Content.Context p0)
		{
			const string __id = "getToken.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getUninstallAndUnregisterInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUninstallAndUnregisterInfo", "(Landroid/content/Context;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.IList GetUninstallAndUnregisterInfo (global::Android.Content.Context p0)
		{
			const string __id = "getUninstallAndUnregisterInfo.(Landroid/content/Context;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getUninstallInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUninstallInfo", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.IList GetUninstallInfo (global::Android.Content.Context p0)
		{
			const string __id = "getUninstallInfo.(Landroid/content/Context;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='getUnregisterInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUnregisterInfo", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.IList GetUnregisterInfo (global::Android.Content.Context p0)
		{
			const string __id = "getUnregisterInfo.(Landroid/content/Context;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='removeOptStrategyList' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeOptStrategyList", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void RemoveOptStrategyList (global::Android.Content.Context p0, string p1)
		{
			const string __id = "removeOptStrategyList.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='removeRegisterInfoByPkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeRegisterInfoByPkgName", "(Ljava/lang/String;)V", "")]
		public static unsafe void RemoveRegisterInfoByPkgName (string p0)
		{
			const string __id = "removeRegisterInfoByPkgName.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='removeRegisterInfos' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeRegisterInfos", "(Ljava/lang/String;)V", "")]
		public static unsafe void RemoveRegisterInfos (string p0)
		{
			const string __id = "removeRegisterInfos.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='saveDomain' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("saveDomain", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SaveDomain (global::Android.Content.Context p0, string p1)
		{
			const string __id = "saveDomain.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='saveDomainKey' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("saveDomainKey", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SaveDomainKey (global::Android.Content.Context p0, string p1)
		{
			const string __id = "saveDomainKey.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='saveDomainKeyList' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.ArrayList']]"
		[Register ("saveDomainKeyList", "(Landroid/content/Context;Ljava/util/ArrayList;)V", "")]
		public static unsafe void SaveDomainKeyList (global::Android.Content.Context p0, global::System.Collections.IList p1)
		{
			const string __id = "saveDomainKeyList.(Landroid/content/Context;Ljava/util/ArrayList;)V";
			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='saveLoadIpTime' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("saveLoadIpTime", "(Landroid/content/Context;J)V", "")]
		public static unsafe void SaveLoadIpTime (global::Android.Content.Context p0, long p1)
		{
			const string __id = "saveLoadIpTime.(Landroid/content/Context;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='saveSpeedTestList' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.ArrayList']]"
		[Register ("saveSpeedTestList", "(Landroid/content/Context;Ljava/util/ArrayList;)V", "")]
		public static unsafe void SaveSpeedTestList (global::Android.Content.Context p0, global::System.Collections.IList p1)
		{
			const string __id = "saveSpeedTestList.(Landroid/content/Context;Ljava/util/ArrayList;)V";
			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='setCurrentAppRegisterEntity' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.data.RegisterEntity']]"
		[Register ("setCurrentAppRegisterEntity", "(Landroid/content/Context;Lcom/tencent/android/tpush/data/RegisterEntity;)V", "")]
		public static unsafe void SetCurrentAppRegisterEntity (global::Android.Content.Context p0, global::Com.Tencent.Android.Tpush.Data.RegisterEntity p1)
		{
			const string __id = "setCurrentAppRegisterEntity.(Landroid/content/Context;Lcom/tencent/android/tpush/data/RegisterEntity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='setQua' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
		[Register ("setQua", "(Landroid/content/Context;JLjava/lang/String;)V", "")]
		public static unsafe void SetQua (global::Android.Content.Context p0, long p1, string p2)
		{
			const string __id = "setQua.(Landroid/content/Context;JLjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='setToken' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setToken", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool SetToken (global::Android.Content.Context p0, string p1)
		{
			const string __id = "setToken.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='setTokenAndGuid' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("setTokenAndGuid", "(Landroid/content/Context;Ljava/lang/String;J)Z", "")]
		public static unsafe bool SetTokenAndGuid (global::Android.Content.Context p0, string p1, long p2)
		{
			const string __id = "setTokenAndGuid.(Landroid/content/Context;Ljava/lang/String;J)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service.cache']/class[@name='CacheManager']/method[@name='updateUnregUninList' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.ArrayList']]"
		[Register ("updateUnregUninList", "(Landroid/content/Context;Ljava/util/ArrayList;)V", "")]
		public static unsafe void UpdateUnregUninList (global::Android.Content.Context p0, global::System.Collections.IList p1)
		{
			const string __id = "updateUnregUninList.(Landroid/content/Context;Ljava/util/ArrayList;)V";
			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
