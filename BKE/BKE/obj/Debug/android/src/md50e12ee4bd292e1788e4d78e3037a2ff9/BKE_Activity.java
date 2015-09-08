package md50e12ee4bd292e1788e4d78e3037a2ff9;


public class BKE_Activity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("BKE.BKE_Activity, BKE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BKE_Activity.class, __md_methods);
	}


	public BKE_Activity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BKE_Activity.class)
			mono.android.TypeManager.Activate ("BKE.BKE_Activity, BKE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
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
