package mono.com.umeng.socialize.shareboard.widgets;


public class SocializeViewPager_OnPageChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.umeng.socialize.shareboard.widgets.SocializeViewPager.OnPageChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPageScrollStateChanged:(I)V:GetOnPageScrollStateChanged_IHandler:Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager/IOnPageChangeListenerInvoker, UMeng.Android.Shares\n" +
			"n_onPageScrolled:(IFI)V:GetOnPageScrolled_IFIHandler:Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager/IOnPageChangeListenerInvoker, UMeng.Android.Shares\n" +
			"n_onPageSelected:(I)V:GetOnPageSelected_IHandler:Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager/IOnPageChangeListenerInvoker, UMeng.Android.Shares\n" +
			"";
		mono.android.Runtime.register ("Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager+IOnPageChangeListenerImplementor, UMeng.Android.Shares", SocializeViewPager_OnPageChangeListenerImplementor.class, __md_methods);
	}


	public SocializeViewPager_OnPageChangeListenerImplementor ()
	{
		super ();
		if (getClass () == SocializeViewPager_OnPageChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager+IOnPageChangeListenerImplementor, UMeng.Android.Shares", "", this, new java.lang.Object[] {  });
	}


	public void onPageScrollStateChanged (int p0)
	{
		n_onPageScrollStateChanged (p0);
	}

	private native void n_onPageScrollStateChanged (int p0);


	public void onPageScrolled (int p0, float p1, int p2)
	{
		n_onPageScrolled (p0, p1, p2);
	}

	private native void n_onPageScrolled (int p0, float p1, int p2);


	public void onPageSelected (int p0)
	{
		n_onPageSelected (p0);
	}

	private native void n_onPageSelected (int p0);

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
