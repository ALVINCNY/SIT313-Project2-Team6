package md588781a0187efbe2e9204810c2ac3f7ac;


public class FormsWebViewRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xam.Plugin.WebView.Droid.FormsWebViewRenderer, Xam.Plugin.WebView.Droid", FormsWebViewRenderer.class, __md_methods);
	}


	public FormsWebViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == FormsWebViewRenderer.class)
			mono.android.TypeManager.Activate ("Xam.Plugin.WebView.Droid.FormsWebViewRenderer, Xam.Plugin.WebView.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public FormsWebViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == FormsWebViewRenderer.class)
			mono.android.TypeManager.Activate ("Xam.Plugin.WebView.Droid.FormsWebViewRenderer, Xam.Plugin.WebView.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public FormsWebViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == FormsWebViewRenderer.class)
			mono.android.TypeManager.Activate ("Xam.Plugin.WebView.Droid.FormsWebViewRenderer, Xam.Plugin.WebView.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}

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
