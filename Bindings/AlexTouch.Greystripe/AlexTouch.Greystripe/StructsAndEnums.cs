using System;

namespace AlexTouch.Greystripe
{
	public enum GSAdSize
	{
		Banner = 1,				// 320x48
		IPhoneFullScreen,		// full screen
		IPadMediumRectangle,	// 300x250
		IPadLeaderboard,		// 728x90
		IPadWideSkyscraper		// 160x600	
	}

	public enum GSAdError
	{
		NoError = 0,
		NoNetwork,
		NoAd,
		Timeout,
		ServerError,
		InvalidApplicationIdentifier,
		AdExpired,
		FetchLimitExceeded,
		Unknown
	}
}

