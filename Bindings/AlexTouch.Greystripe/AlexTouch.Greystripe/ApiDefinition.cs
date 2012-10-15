using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace AlexTouch.Greystripe
{
	[BaseType (typeof (NSObject))]
	[Model]
	interface GSAd 
	{
		[Wrap ("WeakDelegate")]
		GSAdDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Export ("isAdReady")]
		bool IsAdReady ();

		[Export ("fetch")]
		void Fetch ();
	}

	[BaseType (typeof (NSObject))]
	[Model]
	interface GSAdDelegate 
	{
		[Export ("greystripeBannerDisplayViewController")]
		UIViewController BannerDisplayViewController ();

		[Export ("greystripeGUID")]
		string GreystripeGUID ();

		[Export ("greystripeBannerAutoload")]
		bool BannerAutoload ();

		[Export ("greystripeAdFetchSucceeded:")]
		void AdFetchSucceeded (GSAd ad);

		[Export ("greystripeAdFetchFailed:withError:")]
		void AdFetchFailed (GSAd ad, GSAdError error);

		[Export ("greystripeAdClickedThrough:")]
		void AdClickedThrough (GSAd ad);

		[Export ("greystripeWillPresentModalViewController")]
		void WillPresentModalViewController ();

		[Export ("greystripeWillDismissModalViewController")]
		void WillDismissModalViewController ();

		[Export ("greystripeDidDismissModalViewController")]
		void DidDismissModalViewController ();
	}

	[BaseType (typeof (UIView))]
	interface GSAdView
	{

	}

	[BaseType (typeof (GSAdView))]
	interface GSBannerAdView : GSAd
	{
		[Export ("initWithDelegate:")]
		IntPtr Constructor (GSAdDelegate aDelegate);

		[Export ("initWithDelegate:GUID:")]
		IntPtr Constructor (GSAdDelegate aDelegate, string guid);

		[Export ("initWithDelegate:GUID:autoload:")]
		IntPtr Constructor (GSAdDelegate aDelegate, string guid, bool autoload);
	}

	[BaseType (typeof (NSObject))]
	interface GSConstants
	{
		[Field ("kGSSDKVersion", "__Internal")]
		NSString GSSDKVersion { get; }

		[Export ("hashedDeviceId")] [Static]
		string HashedDeviceId { get; }

		[Export ("setGUID:")] [Static]
		void SetGUID (string guid);
	}

	[BaseType (typeof (NSObject))]
	interface GSAdModel : GSAd
	{
		
	}

	[BaseType (typeof (GSAdModel))]
	interface GSFullscreenAd
	{
		[Export ("initWithDelegate:")]
		IntPtr Constructor (GSAdDelegate aDelegate);
		
		[Export ("initWithDelegate:GUID:")]
		IntPtr Constructor (GSAdDelegate aDelegate, string guid);

		[Export ("displayFromViewController:")]
		bool DisplayFromViewController (UIViewController viewController);
	}

	[BaseType (typeof (GSBannerAdView))]
	interface GSLeaderboardAdView
	{
		[Field ("kGSLeaderboardParameter", "__Internal")]
		NSString LeaderboardParameter { get; }
	}

	[BaseType (typeof (GSBannerAdView))]
	interface GSMediumRectangleAdView
	{
		[Field ("kGSMediumRectangleParameter", "__Internal")]
		NSString MediumRectangleParameter { get; }
	}

	[BaseType (typeof (GSBannerAdView))]
	interface GSMobileBannerAdView
	{
		[Field ("kGSMobileBannerParameter", "__Internal")]
		NSString MobileBannerParameter { get; }
	}
}

