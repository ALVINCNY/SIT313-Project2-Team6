package md5dfb2b978a13de7e3916454501587a198;


public class SharesWidget
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.umeng.socialize.utils.ShareBoardlistener,
		com.umeng.socialize.UMShareListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onclick:(Lcom/umeng/socialize/shareboard/SnsPlatform;Lcom/umeng/socialize/bean/SHARE_MEDIA;)V:GetOnclick_Lcom_umeng_socialize_shareboard_SnsPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler:Com.Umeng.Socialize.Utils.IShareBoardlistenerInvoker, UMeng.Android.Shares\n" +
			"n_onCancel:(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V:GetOnCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler:Com.Umeng.Socialize.IUMShareListenerInvoker, UMeng.Android.Shares\n" +
			"n_onError:(Lcom/umeng/socialize/bean/SHARE_MEDIA;Ljava/lang/Throwable;)V:GetOnError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_Handler:Com.Umeng.Socialize.IUMShareListenerInvoker, UMeng.Android.Shares\n" +
			"n_onResult:(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V:GetOnResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler:Com.Umeng.Socialize.IUMShareListenerInvoker, UMeng.Android.Shares\n" +
			"n_onStart:(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V:GetOnStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler:Com.Umeng.Socialize.IUMShareListenerInvoker, UMeng.Android.Shares\n" +
			"";
		mono.android.Runtime.register ("XamCnblogs.Droid.Helpers.SharesWidget, XamCnblogs.Android", SharesWidget.class, __md_methods);
	}


	public SharesWidget ()
	{
		super ();
		if (getClass () == SharesWidget.class)
			mono.android.TypeManager.Activate ("XamCnblogs.Droid.Helpers.SharesWidget, XamCnblogs.Android", "", this, new java.lang.Object[] {  });
	}

	public SharesWidget (android.app.Activity p0)
	{
		super ();
		if (getClass () == SharesWidget.class)
			mono.android.TypeManager.Activate ("XamCnblogs.Droid.Helpers.SharesWidget, XamCnblogs.Android", "Android.App.Activity, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onclick (com.umeng.socialize.shareboard.SnsPlatform p0, com.umeng.socialize.bean.SHARE_MEDIA p1)
	{
		n_onclick (p0, p1);
	}

	private native void n_onclick (com.umeng.socialize.shareboard.SnsPlatform p0, com.umeng.socialize.bean.SHARE_MEDIA p1);


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
