package com.android.cnblogs.wxapi;


public class WXEntryActivity
	extends com.umeng.weixin.callback.WXCallbackActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XamCnblogs.Droid.wxapi.WXEntryActivity, XamCnblogs.Android", WXEntryActivity.class, __md_methods);
	}


	public WXEntryActivity ()
	{
		super ();
		if (getClass () == WXEntryActivity.class)
			mono.android.TypeManager.Activate ("XamCnblogs.Droid.wxapi.WXEntryActivity, XamCnblogs.Android", "", this, new java.lang.Object[] {  });
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
