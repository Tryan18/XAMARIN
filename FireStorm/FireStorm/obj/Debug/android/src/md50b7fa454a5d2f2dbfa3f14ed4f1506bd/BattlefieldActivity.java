package md50b7fa454a5d2f2dbfa3f14ed4f1506bd;


public class BattlefieldActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onStart:()V:GetOnStartHandler\n" +
			"";
		mono.android.Runtime.register ("FireStorm.BattlefieldActivity, FireStorm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BattlefieldActivity.class, __md_methods);
	}


	public BattlefieldActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BattlefieldActivity.class)
			mono.android.TypeManager.Activate ("FireStorm.BattlefieldActivity, FireStorm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onStart ()
	{
		n_onStart ();
	}

	private native void n_onStart ();

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
