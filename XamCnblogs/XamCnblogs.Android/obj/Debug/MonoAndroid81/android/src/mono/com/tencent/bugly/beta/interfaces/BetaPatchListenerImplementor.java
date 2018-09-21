package mono.com.tencent.bugly.beta.interfaces;


public class BetaPatchListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.tencent.bugly.beta.interfaces.BetaPatchListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onApplyFailure:(Ljava/lang/String;)V:GetOnApplyFailure_Ljava_lang_String_Handler:Com.Tencent.Bugly.Beta.Interfaces.IBetaPatchListenerInvoker, Bugly\n" +
			"n_onApplySuccess:(Ljava/lang/String;)V:GetOnApplySuccess_Ljava_lang_String_Handler:Com.Tencent.Bugly.Beta.Interfaces.IBetaPatchListenerInvoker, Bugly\n" +
			"n_onDownloadFailure:(Ljava/lang/String;)V:GetOnDownloadFailure_Ljava_lang_String_Handler:Com.Tencent.Bugly.Beta.Interfaces.IBetaPatchListenerInvoker, Bugly\n" +
			"n_onDownloadReceived:(JJ)V:GetOnDownloadReceived_JJHandler:Com.Tencent.Bugly.Beta.Interfaces.IBetaPatchListenerInvoker, Bugly\n" +
			"n_onDownloadSuccess:(Ljava/lang/String;)V:GetOnDownloadSuccess_Ljava_lang_String_Handler:Com.Tencent.Bugly.Beta.Interfaces.IBetaPatchListenerInvoker, Bugly\n" +
			"n_onPatchReceived:(Ljava/lang/String;)V:GetOnPatchReceived_Ljava_lang_String_Handler:Com.Tencent.Bugly.Beta.Interfaces.IBetaPatchListenerInvoker, Bugly\n" +
			"n_onPatchRollback:()V:GetOnPatchRollbackHandler:Com.Tencent.Bugly.Beta.Interfaces.IBetaPatchListenerInvoker, Bugly\n" +
			"";
		mono.android.Runtime.register ("Com.Tencent.Bugly.Beta.Interfaces.IBetaPatchListenerImplementor, Bugly", BetaPatchListenerImplementor.class, __md_methods);
	}


	public BetaPatchListenerImplementor ()
	{
		super ();
		if (getClass () == BetaPatchListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Tencent.Bugly.Beta.Interfaces.IBetaPatchListenerImplementor, Bugly", "", this, new java.lang.Object[] {  });
	}


	public void onApplyFailure (java.lang.String p0)
	{
		n_onApplyFailure (p0);
	}

	private native void n_onApplyFailure (java.lang.String p0);


	public void onApplySuccess (java.lang.String p0)
	{
		n_onApplySuccess (p0);
	}

	private native void n_onApplySuccess (java.lang.String p0);


	public void onDownloadFailure (java.lang.String p0)
	{
		n_onDownloadFailure (p0);
	}

	private native void n_onDownloadFailure (java.lang.String p0);


	public void onDownloadReceived (long p0, long p1)
	{
		n_onDownloadReceived (p0, p1);
	}

	private native void n_onDownloadReceived (long p0, long p1);


	public void onDownloadSuccess (java.lang.String p0)
	{
		n_onDownloadSuccess (p0);
	}

	private native void n_onDownloadSuccess (java.lang.String p0);


	public void onPatchReceived (java.lang.String p0)
	{
		n_onPatchReceived (p0);
	}

	private native void n_onPatchReceived (java.lang.String p0);


	public void onPatchRollback ()
	{
		n_onPatchRollback ();
	}

	private native void n_onPatchRollback ();

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
