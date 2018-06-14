package md5c1b60530e856ee57aed04b83b21cd6fa;


public class Som
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("QuickMath.Som, QuickMath, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Som.class, __md_methods);
	}


	public Som ()
	{
		super ();
		if (getClass () == Som.class)
			mono.android.TypeManager.Activate ("QuickMath.Som, QuickMath, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
