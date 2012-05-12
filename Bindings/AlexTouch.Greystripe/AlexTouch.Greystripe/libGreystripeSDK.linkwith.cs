using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libGreystripeSDK.a", LinkTarget.ArmV7 | LinkTarget.ArmV6 | LinkTarget.Simulator, ForceLoad = true, Frameworks = "AudioToolbox AVFoundation CoreGraphics MediaPlayer OpenAL QuartzCore SystemConfiguration", LinkerFlags = "-lz -lsqlite3")]
