package md588781a0187efbe2e9204810c2ac3f7ac;


public class FormsWebViewBridge
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_InvokeAction:(Ljava/lang/String;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("Xam.Plugin.WebView.Droid.FormsWebViewBridge, Xam.Plugin.WebView.Droid", FormsWebViewBridge.class, __md_methods);
	}


	public FormsWebViewBridge ()
	{
		super ();
		if (getClass () == FormsWebViewBridge.class)
			mono.android.TypeManager.Activate ("Xam.Plugin.WebView.Droid.FormsWebViewBridge, Xam.Plugin.WebView.Droid", "", this, new java.lang.Object[] {  });
	}

	public FormsWebViewBridge (md588781a0187efbe2e9204810c2ac3f7ac.FormsWebViewRenderer p0)
	{
		super ();
		if (getClass () == FormsWebViewBridge.class)
			mono.android.TypeManager.Activate ("Xam.Plugin.WebView.Droid.FormsWebViewBridge, Xam.Plugin.WebView.Droid", "Xam.Plugin.WebView.Droid.FormsWebViewRenderer, Xam.Plugin.WebView.Droid", this, new java.lang.Object[] { p0 });
	}

	@android.webkit.JavascriptInterface

	public void invokeAction (java.lang.String p0)
	{
		n_InvokeAction (p0);
	}

	private native void n_InvokeAction (java.lang.String p0);

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
