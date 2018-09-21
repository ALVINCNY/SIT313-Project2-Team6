package mono.com.tencent.tinker.lib.listener;


public class PatchListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.tencent.tinker.lib.listener.PatchListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPatchReceived:(Ljava/lang/String;)I:GetOnPatchReceived_Ljava_lang_String_Handler:Com.Tencent.Tinker.Lib.Listener.IPatchListenerInvoker, Bugly\n" +
			"";
		mono.android.Runtime.register ("Com.Tencent.Tinker.Lib.Listener.IPatchListenerImplementor, Bugly", PatchListenerImplementor.class, __md_methods);
	}


	public PatchListenerImplementor ()
	{
		super ();
		if (getClass () == PatchListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Tencent.Tinker.Lib.Listener.IPatchListenerImplementor, Bugly", "", this, new java.lang.Object[] {  });
	}


	public int onPatchReceived (java.lang.String p0)
	{
		return n_onPatchReceived (p0);
	}

	private native int n_onPatchReceived (java.lang.String p0);

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
