package mono.android.support.wear.widget.drawer;


public class WearableNavigationDrawerView_OnItemSelectedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.wear.widget.drawer.WearableNavigationDrawerView.OnItemSelectedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemSelected:(I)V:GetOnItemSelected_IHandler:Android.Support.Wear.Widget.Drawer.WearableNavigationDrawerView/IOnItemSelectedListenerInvoker, Xamarin.Android.Support.Wear\n" +
			"";
		mono.android.Runtime.register ("Android.Support.Wear.Widget.Drawer.WearableNavigationDrawerView+IOnItemSelectedListenerImplementor, Xamarin.Android.Support.Wear", WearableNavigationDrawerView_OnItemSelectedListenerImplementor.class, __md_methods);
	}


	public WearableNavigationDrawerView_OnItemSelectedListenerImplementor ()
	{
		super ();
		if (getClass () == WearableNavigationDrawerView_OnItemSelectedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.Wear.Widget.Drawer.WearableNavigationDrawerView+IOnItemSelectedListenerImplementor, Xamarin.Android.Support.Wear", "", this, new java.lang.Object[] {  });
	}


	public void onItemSelected (int p0)
	{
		n_onItemSelected (p0);
	}

	private native void n_onItemSelected (int p0);

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
