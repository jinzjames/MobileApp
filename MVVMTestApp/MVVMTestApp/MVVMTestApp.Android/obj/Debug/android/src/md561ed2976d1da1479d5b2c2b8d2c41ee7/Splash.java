package md561ed2976d1da1479d5b2c2b8d2c41ee7;


public class Splash
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("MVVMTestApp.Droid.Splash, MVVMTestApp.Android", Splash.class, __md_methods);
	}


	public Splash ()
	{
		super ();
		if (getClass () == Splash.class)
			mono.android.TypeManager.Activate ("MVVMTestApp.Droid.Splash, MVVMTestApp.Android", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
