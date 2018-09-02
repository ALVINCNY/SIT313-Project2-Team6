package mono.com.umeng.socialize;


public class UMShareListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.umeng.socialize.UMShareListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCancel:(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V:GetOnCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler:Com.Umeng.Socialize.IUMShareListenerInvoker, UMeng.Android.Shares\n" +
			"n_onError:(Lcom/umeng/socialize/bean/SHARE_MEDIA;Ljava/lang/Throwable;)V:GetOnError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_Handler:Com.Umeng.Socialize.IUMShareListenerInvoker, UMeng.Android.Shares\n" +
			"n_onResult:(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V:GetOnResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler:Com.Umeng.Socialize.IUMShareListenerInvoker, UMeng.Android.Shares\n" +
			"n_onStart:(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V:GetOnStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler:Com.Umeng.Socialize.IUMShareListenerInvoker, UMeng.Android.Shares\n" +
			"";
		mono.android.Runtime.register ("Com.Umeng.Socialize.IUMShareListenerImplementor, UMeng.Android.Shares", UMShareListenerImplementor.class, __md_methods);
	}


	public UMShareListenerImplementor ()
	{
		super ();
		if (getClass () == UMShareListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Umeng.Socialize.IUMShareListenerImplementor, UMeng.Android.Shares", "", this, new java.lang.Object[] {  });
	}


	public void onCancel (com.umeng.socialize.bean.SHARE_MEDIA p0)
	{
		n_onCancel (p0);
	}

	private native void n_onCancel (com.umeng.socialize.bean.SHARE_MEDIA p0);


	public void onError (com.umeng.socialize.bean.SHARE_MEDIA p0, java.lang.Throwable p1)
	{
		n_onError (p0, p1);
	}

	private native void n_onError (com.umeng.socialize.bean.SHARE_MEDIA p0, java.lang.Throwable p1);


	public void onResult (com.umeng.socialize.bean.SHARE_MEDIA p0)
	{
		n_onResult (p0);
	}

	private native void n_onResult (com.umeng.socialize.bean.SHARE_MEDIA p0);


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
