package md52aa53cd7dcc0f82021799b5e1306c0d7;


public class Rutina_layout
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
		mono.android.Runtime.register ("GymApp.Rutina_layout, GymApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Rutina_layout.class, __md_methods);
	}


	public Rutina_layout ()
	{
		super ();
		if (getClass () == Rutina_layout.class)
			mono.android.TypeManager.Activate ("GymApp.Rutina_layout, GymApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
