package md57de57d54cb83e69cfe6991ddc96ab663;


public class MainActivity
	extends md51558244f76c53b6aeda52c8a337f2c37.FormsAppCompatActivity
	implements
		mono.android.IGCUserPeer,
		com.tencent.android.tpush.XGIOperateCallback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onActivityResult:(IILandroid/content/Intent;)V:GetOnActivityResult_IILandroid_content_Intent_Handler\n" +
			"n_onRequestPermissionsResult:(I[Ljava/lang/String;[I)V:GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler\n" +
			"n_onFail:(Ljava/lang/Object;ILjava/lang/String;)V:GetOnFail_Ljava_lang_Object_ILjava_lang_String_Handler:Com.Tencent.Android.Tpush.IXGIOperateCallbackInvoker, XgPush.Android\n" +
			"n_onSuccess:(Ljava/lang/Object;I)V:GetOnSuccess_Ljava_lang_Object_IHandler:Com.Tencent.Android.Tpush.IXGIOperateCallbackInvoker, XgPush.Android\n" +
			"";
		mono.android.Runtime.register ("XamCnblogs.Droid.MainActivity, XamCnblogs.Android", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("XamCnblogs.Droid.MainActivity, XamCnblogs.Android", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onActivityResult (int p0, int p1, android.content.Intent p2)
	{
		n_onActivityResult (p0, p1, p2);
	}

	private native void n_onActivityResult (int p0, int p1, android.content.Intent p2);


	public void onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2)
	{
		n_onRequestPermissionsResult (p0, p1, p2);
	}

	private native void n_onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2);


	public void onFail (java.lang.Object p0, int p1, java.lang.String p2)
	{
		n_onFail (p0, p1, p2);
	}

	private native void n_onFail (java.lang.Object p0, int p1, java.lang.String p2);


	public void onSuccess (java.lang.Object p0, int p1)
	{
		n_onSuccess (p0, p1);
	}

	private native void n_onSuccess (java.lang.Object p0, int p1);

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
