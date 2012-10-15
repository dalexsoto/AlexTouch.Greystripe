using System;
using MonoTouch.ObjCRuntime;

namespace AlexTouch.Greystripe
{
	public partial class GSLeaderboardAdView
	{
		private static float kGSLeaderboardWidth;
		
		public static float GSLeaderboardWidth
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kGSLeaderboardWidth = Dlfcn.GetFloat(RTLD_MAIN_ONLY, "kGSLeaderboardWidth");
				return kGSLeaderboardWidth;
			}
		}

		private static float kGSLeaderboardHeight;
		
		public static float LeaderboardHeight
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kGSLeaderboardHeight = Dlfcn.GetFloat(RTLD_MAIN_ONLY, "kGSLeaderboardHeight");
				return kGSLeaderboardHeight;
			}
		}
	}

	public partial class GSMediumRectangleAdView
	{
		private static float kGSMediumRectangleWidth;
		
		public static float MediumRectangleWidth
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kGSMediumRectangleWidth = Dlfcn.GetFloat(RTLD_MAIN_ONLY, "kGSMediumRectangleWidth");
				return kGSMediumRectangleWidth;
			}
		}
		
		private static float kGSMediumRectangleHeight;
		
		public static float MediumRectangleHeight
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kGSMediumRectangleHeight = Dlfcn.GetFloat(RTLD_MAIN_ONLY, "kGSMediumRectangleHeight");
				return kGSMediumRectangleHeight;
			}
		}
	}

	public partial class GSMobileBannerAdView
	{
		private static float kGSMobileBannerWidth;
		
		public static float MobileBannerWidth
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kGSMobileBannerWidth = Dlfcn.GetFloat(RTLD_MAIN_ONLY, "kGSMobileBannerWidth");
				return kGSMobileBannerWidth;
			}
		}
		
		private static float kGSMobileBannerHeight;
		
		public static float MobileBannerHeight
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kGSMobileBannerHeight = Dlfcn.GetFloat(RTLD_MAIN_ONLY, "kGSMobileBannerHeight");
				return kGSMobileBannerHeight;
			}
		}
	}
}

