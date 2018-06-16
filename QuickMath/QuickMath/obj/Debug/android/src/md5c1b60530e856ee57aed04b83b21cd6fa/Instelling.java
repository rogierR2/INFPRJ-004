package md5c1b60530e856ee57aed04b83b21cd6fa;


public class Instelling
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
		mono.android.Runtime.register ("QuickMath.Instelling, QuickMath, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Instelling.class, __md_methods);
	}


	public Instelling ()
	{
		super ();
		if (getClass () == Instelling.class)
			mono.android.TypeManager.Activate ("QuickMath.Instelling, QuickMath, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
