package mono.com.umeng.socialize;


public class UMAuthListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.umeng.socialize.UMAuthListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCancel:(Lcom/umeng/socialize/bean/SHARE_MEDIA;I)V:GetOnAuthCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_IHandler:Com.Umeng.Socialize.IUMAuthListenerInvoker, UMeng.Android.Shares\n" +
			"n_onComplete:(Lcom/umeng/socialize/bean/SHARE_MEDIA;ILjava/util/Map;)V:GetOnAuthComplete_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_util_Map_Handler:Com.Umeng.Socialize.IUMAuthListenerInvoker, UMeng.Android.Shares\n" +
			"n_onError:(Lcom/umeng/socialize/bean/SHARE_MEDIA;ILjava/lang/Throwable;)V:GetOnAuthError_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_lang_Throwable_Handler:Com.Umeng.Socialize.IUMAuthListenerInvoker, UMeng.Android.Shares\n" +
			"n_onStart:(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V:GetOnAuthStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler:Com.Umeng.Socialize.IUMAuthListenerInvoker, UMeng.Android.Shares\n" +
			"";
		mono.android.Runtime.register ("Com.Umeng.Socialize.IUMAuthListenerImplementor, UMeng.Android.Shares", UMAuthListenerImplementor.class, __md_methods);
	}


	public UMAuthListenerImplementor ()
	{
		super ();
		if (getClass () == UMAuthListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Umeng.Socialize.IUMAuthListenerImplementor, UMeng.Android.Shares", "", this, new java.lang.Object[] {  });
	}


	public void onCancel (com.umeng.socialize.bean.SHARE_MEDIA p0, int p1)
	{
		n_onCancel (p0, p1);
	}

	private native void n_onCancel (com.umeng.socialize.bean.SHARE_MEDIA p0, int p1);


	public void onComplete (com.umeng.socialize.bean.SHARE_MEDIA p0, int p1, java.util.Map p2)
	{
		n_onComplete (p0, p1, p2);
	}

	private native void n_onComplete (com.umeng.socialize.bean.SHARE_MEDIA p0, int p1, java.util.Map p2);


	public void onError (com.umeng.socialize.bean.SHARE_MEDIA p0, int p1, java.lang.Throwable p2)
	{
		n_onError (p0, p1, p2);
	}

	private native void n_onError (com.umeng.socialize.bean.SHARE_MEDIA p0, int p1, java.lang.Throwable p2);


	public void onStart (com.umeng.socialize.bean.SHARE_MEDIA p0)
	{
		n_onStart (p0);
	}

	private native void n_onStart (com.umeng.socialize.bean.SHARE_MEDIA p0);

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
