package mono.com.tencent.bugly.beta.upgrade;


public class UpgradeStateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.tencent.bugly.beta.upgrade.UpgradeStateListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDownloadCompleted:(Z)V:GetOnDownloadCompleted_ZHandler:Com.Tencent.Bugly.Beta.Upgrade.IUpgradeStateListenerInvoker, Bugly\n" +
			"n_onUpgradeFailed:(Z)V:GetOnUpgradeFailed_ZHandler:Com.Tencent.Bugly.Beta.Upgrade.IUpgradeStateListenerInvoker, Bugly\n" +
			"n_onUpgradeNoVersion:(Z)V:GetOnUpgradeNoVersion_ZHandler:Com.Tencent.Bugly.Beta.Upgrade.IUpgradeStateListenerInvoker, Bugly\n" +
			"n_onUpgradeSuccess:(Z)V:GetOnUpgradeSuccess_ZHandler:Com.Tencent.Bugly.Beta.Upgrade.IUpgradeStateListenerInvoker, Bugly\n" +
			"n_onUpgrading:(Z)V:GetOnUpgrading_ZHandler:Com.Tencent.Bugly.Beta.Upgrade.IUpgradeStateListenerInvoker, Bugly\n" +
			"";
		mono.android.Runtime.register ("Com.Tencent.Bugly.Beta.Upgrade.IUpgradeStateListenerImplementor, Bugly", UpgradeStateListenerImplementor.class, __md_methods);
	}


	public UpgradeStateListenerImplementor ()
	{
		super ();
		if (getClass () == UpgradeStateListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Tencent.Bugly.Beta.Upgrade.IUpgradeStateListenerImplementor, Bugly", "", this, new java.lang.Object[] {  });
	}


	public void onDownloadCompleted (boolean p0)
	{
		n_onDownloadCompleted (p0);
	}

	private native void n_onDownloadCompleted (boolean p0);


	public void onUpgradeFailed (boolean p0)
	{
		n_onUpgradeFailed (p0);
	}

	private native void n_onUpgradeFailed (boolean p0);


	public void onUpgradeNoVersion (boolean p0)
	{
		n_onUpgradeNoVersion (p0);
	}

	private native void n_onUpgradeNoVersion (boolean p0);


	public void onUpgradeSuccess (boolean p0)
	{
		n_onUpgradeSuccess (p0);
	}

	private native void n_onUpgradeSuccess (boolean p0);


	public void onUpgrading (boolean p0)
	{
		n_onUpgrading (p0);
	}

	private native void n_onUpgrading (boolean p0);

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
