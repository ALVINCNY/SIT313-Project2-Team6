package md5727754016b6df7b95ae686f1fc282f28;


public class XamEditorRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.EditorRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XamCnblogs.Droid.Renderers.XamEditorRenderer, XamCnblogs.Android", XamEditorRenderer.class, __md_methods);
	}


	public XamEditorRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == XamEditorRenderer.class)
			mono.android.TypeManager.Activate ("XamCnblogs.Droid.Renderers.XamEditorRenderer, XamCnblogs.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public XamEditorRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == XamEditorRenderer.class)
			mono.android.TypeManager.Activate ("XamCnblogs.Droid.Renderers.XamEditorRenderer, XamCnblogs.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public XamEditorRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == XamEditorRenderer.class)
			mono.android.TypeManager.Activate ("XamCnblogs.Droid.Renderers.XamEditorRenderer, XamCnblogs.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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
