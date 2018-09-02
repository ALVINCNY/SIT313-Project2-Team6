package md5c586788638ffaeced5598419b57b9411;


public class XgMessageReceiver
	extends com.tencent.android.tpush.XGPushBaseReceiver
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDeleteTagResult:(Landroid/content/Context;ILjava/lang/String;)V:GetOnDeleteTagResult_Landroid_content_Context_ILjava_lang_String_Handler\n" +
			"n_onNotifactionClickedResult:(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushClickedResult;)V:GetOnNotifactionClickedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushClickedResult_Handler\n" +
			"n_onNotifactionShowedResult:(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushShowedResult;)V:GetOnNotifactionShowedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushShowedResult_Handler\n" +
			"n_onRegisterResult:(Landroid/content/Context;ILcom/tencent/android/tpush/XGPushRegisterResult;)V:GetOnRegisterResult_Landroid_content_Context_ILcom_tencent_android_tpush_XGPushRegisterResult_Handler\n" +
			"n_onSetTagResult:(Landroid/content/Context;ILjava/lang/String;)V:GetOnSetTagResult_Landroid_content_Context_ILjava_lang_String_Handler\n" +
			"n_onTextMessage:(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushTextMessage;)V:GetOnTextMessage_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushTextMessage_Handler\n" +
			"n_onUnregisterResult:(Landroid/content/Context;I)V:GetOnUnregisterResult_Landroid_content_Context_IHandler\n" +
			"";
		mono.android.Runtime.register ("XamCnblogs.Droid.Receivers.XgMessageReceiver, XamCnblogs.Android", XgMessageReceiver.class, __md_methods);
	}


	public XgMessageReceiver ()
	{
		super ();
		if (getClass () == XgMessageReceiver.class)
			mono.android.TypeManager.Activate ("XamCnblogs.Droid.Receivers.XgMessageReceiver, XamCnblogs.Android", "", this, new java.lang.Object[] {  });
	}


	public void onDeleteTagResult (android.content.Context p0, int p1, java.lang.String p2)
	{
		n_onDeleteTagResult (p0, p1, p2);
	}

	private native void n_onDeleteTagResult (android.content.Context p0, int p1, java.lang.String p2);


	public void onNotifactionClickedResult (android.content.Context p0, com.tencent.android.tpush.XGPushClickedResult p1)
	{
		n_onNotifactionClickedResult (p0, p1);
	}

	private native void n_onNotifactionClickedResult (android.content.Context p0, com.tencent.android.tpush.XGPushClickedResult p1);


	public void onNotifactionShowedResult (android.content.Context p0, com.tencent.android.tpush.XGPushShowedResult p1)
	{
		n_onNotifactionShowedResult (p0, p1);
	}

	private native void n_onNotifactionShowedResult (android.content.Context p0, com.tencent.android.tpush.XGPushShowedResult p1);


	public void onRegisterResult (android.content.Context p0, int p1, com.tencent.android.tpush.XGPushRegisterResult p2)
	{
		n_onRegisterResult (p0, p1, p2);
	}

	private native void n_onRegisterResult (android.content.Context p0, int p1, com.tencent.android.tpush.XGPushRegisterResult p2);


	public void onSetTagResult (android.content.Context p0, int p1, java.lang.String p2)
	{
		n_onSetTagResult (p0, p1, p2);
	}

	private native void n_onSetTagResult (android.content.Context p0, int p1, java.lang.String p2);


	public void onTextMessage (android.content.Context p0, com.tencent.android.tpush.XGPushTextMessage p1)
	{
		n_onTextMessage (p0, p1);
	}

	private native void n_onTextMessage (android.content.Context p0, com.tencent.android.tpush.XGPushTextMessage p1);


	public void onUnregisterResult (android.content.Context p0, int p1)
	{
		n_onUnregisterResult (p0, p1);
	}

	private native void n_onUnregisterResult (android.content.Context p0, int p1);

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
