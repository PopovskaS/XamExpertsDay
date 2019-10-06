using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamExpertsDay.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.ApkFile("../../../XamExpertsDay.Android/bin/Release/com.xamexpertsday.devopsdemo.xamexpertsday-Signed.apk").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}