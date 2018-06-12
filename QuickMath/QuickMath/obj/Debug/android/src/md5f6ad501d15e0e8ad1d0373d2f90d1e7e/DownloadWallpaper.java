package md5f6ad501d15e0e8ad1d0373d2f90d1e7e;


public class DownloadWallpaper
	extends android.os.AsyncTask
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPostExecute:(Ljava/lang/Object;)V:GetOnPostExecute_Ljava_lang_Object_Handler\n" +
			"n_onPreExecute:()V:GetOnPreExecuteHandler\n" +
			"n_onProgressUpdate:([Ljava/lang/Object;)V:GetOnProgressUpdate_arrayLjava_lang_Object_Handler\n" +
			"n_doInBackground:([Ljava/lang/Object;)Ljava/lang/Object;:GetDoInBackground_arrayLjava_lang_Object_Handler\n" +
			"";
		mono.android.Runtime.register ("QuickMath.DownloadWallpaper, QuickMath", DownloadWallpaper.class, __md_methods);
	}


	public DownloadWallpaper ()
	{
		super ();
		if (getClass () == DownloadWallpaper.class)
			mono.android.TypeManager.Activate ("QuickMath.DownloadWallpaper, QuickMath", "", this, new java.lang.Object[] {  });
	}

	public DownloadWallpaper (android.content.Context p0, android.widget.ImageView p1)
	{
		super ();
		if (getClass () == DownloadWallpaper.class)
			mono.android.TypeManager.Activate ("QuickMath.DownloadWallpaper, QuickMath", "Android.Content.Context, Mono.Android:Android.Widget.ImageView, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public void onPostExecute (java.lang.Object p0)
	{
		n_onPostExecute (p0);
	}

	private native void n_onPostExecute (java.lang.Object p0);


	public void onPreExecute ()
	{
		n_onPreExecute ();
	}

	private native void n_onPreExecute ();


	public void onProgressUpdate (java.lang.Object[] p0)
	{
		n_onProgressUpdate (p0);
	}

	private native void n_onProgressUpdate (java.lang.Object[] p0);


	public java.lang.Object doInBackground (java.lang.Object[] p0)
	{
		return n_doInBackground (p0);
	}

	private native java.lang.Object n_doInBackground (java.lang.Object[] p0);

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
