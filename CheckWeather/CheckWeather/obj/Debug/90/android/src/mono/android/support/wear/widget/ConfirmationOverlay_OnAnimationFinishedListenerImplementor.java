package mono.android.support.wear.widget;


public class ConfirmationOverlay_OnAnimationFinishedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.wear.widget.ConfirmationOverlay.OnAnimationFinishedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAnimationFinished:()V:GetOnAnimationFinishedHandler:Android.Support.Wear.Widget.ConfirmationOverlay/IOnAnimationFinishedListenerInvoker, Xamarin.Android.Support.Wear\n" +
			"";
		mono.android.Runtime.register ("Android.Support.Wear.Widget.ConfirmationOverlay+IOnAnimationFinishedListenerImplementor, Xamarin.Android.Support.Wear", ConfirmationOverlay_OnAnimationFinishedListenerImplementor.class, __md_methods);
	}


	public ConfirmationOverlay_OnAnimationFinishedListenerImplementor ()
	{
		super ();
		if (getClass () == ConfirmationOverlay_OnAnimationFinishedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.Wear.Widget.ConfirmationOverlay+IOnAnimationFinishedListenerImplementor, Xamarin.Android.Support.Wear", "", this, new java.lang.Object[] {  });
	}


	public void onAnimationFinished ()
	{
		n_onAnimationFinished ();
	}

	private native void n_onAnimationFinished ();

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
