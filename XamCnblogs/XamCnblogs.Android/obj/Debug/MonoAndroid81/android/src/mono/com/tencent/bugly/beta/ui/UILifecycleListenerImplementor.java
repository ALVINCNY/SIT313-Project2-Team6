package mono.com.tencent.bugly.beta.ui;


public class UILifecycleListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.tencent.bugly.beta.ui.UILifecycleListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/content/Context;Landroid/view/View;Ljava/lang/Object;)V:GetOnCreate_Landroid_content_Context_Landroid_view_View_Ljava_lang_Object_Handler:Com.Tencent.Bugly.Beta.UI.IUILifecycleListenerInvoker, Bugly\n" +
			"n_onDestroy:(Landroid/content/Context;Landroid/view/View;Ljava/lang/Object;)V:GetOnDestroy_Landroid_content_Context_Landroid_view_View_Ljava_lang_Object_Handler:Com.Tencent.Bugly.Beta.UI.IUILifecycleListenerInvoker, Bugly\n" +
			"n_onPause:(Landroid/content/Context;Landroid/view/View;Ljava/lang/Object;)V:GetOnPause_Landroid_content_Context_Landroid_view_View_Ljava_lang_Object_Handler:Com.Tencent.Bugly.Beta.UI.IUILifecycleListenerInvoker, Bugly\n" +
			"n_onResume:(Landroid/content/Context;Landroid/view/View;Ljava/lang/Object;)V:GetOnResume_Landroid_content_Context_Landroid_view_View_Ljava_lang_Object_Handler:Com.Tencent.Bugly.Beta.UI.IUILifecycleListenerInvoker, Bugly\n" +
			"n_onStart:(Landroid/content/Context;Landroid/view/View;Ljava/lang/Object;)V:GetOnStart_Landroid_content_Context_Landroid_view_View_Ljava_lang_Object_Handler:Com.Tencent.Bugly.Beta.UI.IUILifecycleListenerInvoker, Bugly\n" +
			"n_onStop:(Landroid/content/Context;Landroid/view/View;Ljava/lang/Object;)V:GetOnStop_Landroid_content_Context_Landroid_view_View_Ljava_lang_Object_Handler:Com.Tencent.Bugly.Beta.UI.IUILifecycleListenerInvoker, Bugly\n" +
			"";
		mono.android.Runtime.register ("Com.Tencent.Bugly.Beta.UI.IUILifecycleListenerImplementor, Bugly", UILifecycleListenerImplementor.class, __md_methods);
	}


	public UILifecycleListenerImplementor ()
	{
		super ();
		if (getClass () == UILifecycleListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Tencent.Bugly.Beta.UI.IUILifecycleListenerImplementor, Bugly", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.content.Context p0, android.view.View p1, java.lang.Object p2)
	{
		n_onCreate (p0, p1, p2);
	}

	private native void n_onCreate (android.content.Context p0, android.view.View p1, java.lang.Object p2);


	public void onDestroy (android.content.Context p0, android.view.View p1, java.lang.Object p2)
	{
		n_onDestroy (p0, p1, p2);
	}

	private native void n_onDestroy (android.content.Context p0, android.view.View p1, java.lang.Object p2);


	public void onPause (android.content.Context p0, android.view.View p1, java.lang.Object p2)
	{
		n_onPause (p0, p1, p2);
	}

	private native void n_onPause (android.content.Context p0, android.view.View p1, java.lang.Object p2);


	public void onResume (android.content.Context p0, android.view.View p1, java.lang.Object p2)
	{
		n_onResume (p0, p1, p2);
	}

	private native void n_onResume (android.content.Context p0, android.view.View p1, java.lang.Object p2);


	public void onStart (android.content.Context p0, android.view.View p1, java.lang.Object p2)
	{
		n_onStart (p0, p1, p2);
	}

	private native void n_onStart (android.content.Context p0, android.view.View p1, java.lang.Object p2);


	public void onStop (android.content.Context p0, android.view.View p1, java.lang.Object p2)
	{
		n_onStop (p0, p1, p2);
	}

	private native void n_onStop (android.content.Context p0, android.view.View p1, java.lang.Object p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
