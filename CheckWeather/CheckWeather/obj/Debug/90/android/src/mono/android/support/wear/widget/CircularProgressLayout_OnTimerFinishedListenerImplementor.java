package mono.android.support.wear.widget;


public class CircularProgressLayout_OnTimerFinishedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.wear.widget.CircularProgressLayout.OnTimerFinishedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTimerFinished:(Landroid/support/wear/widget/CircularProgressLayout;)V:GetOnTimerFinished_Landroid_support_wear_widget_CircularProgressLayout_Handler:Android.Support.Wear.Widget.CircularProgressLayout/IOnTimerFinishedListenerInvoker, Xamarin.Android.Support.Wear\n" +
			"";
		mono.android.Runtime.register ("Android.Support.Wear.Widget.CircularProgressLayout+IOnTimerFinishedListenerImplementor, Xamarin.Android.Support.Wear", CircularProgressLayout_OnTimerFinishedListenerImplementor.class, __md_methods);
	}


	public CircularProgressLayout_OnTimerFinishedListenerImplementor ()
	{
		super ();
		if (getClass () == CircularProgressLayout_OnTimerFinishedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.Wear.Widget.CircularProgressLayout+IOnTimerFinishedListenerImplementor, Xamarin.Android.Support.Wear", "", this, new java.lang.Object[] {  });
	}


	public void onTimerFinished (android.support.wear.widget.CircularProgressLayout p0)
	{
		n_onTimerFinished (p0);
	}

	private native void n_onTimerFinished (android.support.wear.widget.CircularProgressLayout p0);

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
