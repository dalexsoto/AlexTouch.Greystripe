using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace AlexTouch.Greystripe
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_types
	//

	[BaseType (typeof (UIView))]
    interface GSAdView
	{
		[Static, Export ("adViewForSlotNamed:delegate:")]
	    GSAdView AdViewForSlotNamed (string name, GreystripeDelegate adDelegate);
	    //NSObject AdViewForSlotNamed (string name, GreystripeDelegate adDelegate);
		
		[Static, Export ("adViewForSlotNamed:delegate:refreshInterval:")]
	    GSAdView AdViewForSlotNamed (string name, GreystripeDelegate adDelegate, double interval);
	    //NSObject AdViewForSlotNamed (string name, GreystripeDelegate adDelegate, double interval);
		
		[Export ("refresh")]
		void Refresh();
		
		[Static, Field ("kGSMinimumRefreshInterval", "__Internal")]
    	double MinimumRefreshInterval { get; }
	}
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface GreystripeDelegate 
	{
		[Export ("greystripeAdReadyForSlotNamed:")]
		void GreystripeAdReadyForSlotNamed (string name);
		
		[Export ("greystripeFullScreenDisplayWillOpen")]
		void GreystripeFullScreenDisplayWillOpen ();
		
		[Export ("greystripeFullScreenDisplayWillClose")]
		void GreystripeFullScreenDisplayWillClose ();
		
		[Export ("greystripeDidReceiveMemoryWarning")]
		void GreystripeDidReceiveMemoryWarning ();
	}
	
	[BaseType (typeof (NSObject))]
    interface GSAdSlotDescription
	{
		[Export ("size")]
		GSAdSize Size { get; }
		
		[Export ("name")]
		string Name { get; }
		
		[Static, Export ("descriptionWithSize:name:")]
	    GSAdSlotDescription DescriptionWithSizeName (GSAdSize size, string name);
	    //NSObject DescriptionWithSizeName (GSAdSize size, string name);
		
		[Export ("initWithSize:name:")]
	    IntPtr Constructor (GSAdSize size, string name);
	}
	
	[BaseType (typeof (NSObject))]
    interface GSAdEngine
	{		
		[Static, Export ("startupWithAppID:adSlotDescriptions:")]
	    void StartupWithAppIDAdSlotDescriptions (string appID, GSAdSlotDescription [] descriptions);
		
		[Static, Export ("displayFullScreenAdForSlotNamed:")]
	    bool DisplayFullScreenAdForSlotNamed (string name);
		
		[Static, Export ("setFullScreenDelegate:forSlotNamed:")]
	    void SetFullScreenDelegateForSlotNamed (GreystripeDelegate adDelegate, string name);
		
		[Static, Export ("isAdReadyForSlotNamed:")]
	    bool IsAdReadyForSlotNamed (string name);
		
		[Static, Export ("isNextAdDownloadedForSlotNamed:")]
	    bool IsNextAdDownloadedForSlotNamed (string name);
		
		[Static, Export ("version")]
		string Version { get; }
		
		[Static, Export ("hashedDeviceIdentifier")]
		string HashedDeviceIdentifier { get; }
	}
}

