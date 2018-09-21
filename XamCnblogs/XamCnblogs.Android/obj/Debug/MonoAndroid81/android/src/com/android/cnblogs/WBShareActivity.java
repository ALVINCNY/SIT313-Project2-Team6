package com.android.cnblogs;


public class WBShareActivity
	extends com.umeng.socialize.media.WBShareCallBackActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Cnblogs.Droid.WBShareActivity, XamCnblogs.Android", WBShareActivity.class, __md_methods);
	}


	public WBShareActivity ()
	{
		super ();
		if (getClass () == WBShareActivity.class)
			mono.android.TypeManager.Activate ("Cnblogs.Droid.WBShareActivity, XamCnblogs.Android", "", this, new java.lang.Object[] {  });
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
