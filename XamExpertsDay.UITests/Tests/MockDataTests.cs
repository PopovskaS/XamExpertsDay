using NUnit.Framework;
using Xamarin.UITest;

namespace XamExpertsDay.UITests
{
    public class MockDataTests : BaseTest
    {
        public MockDataTests(Platform platform) : base(platform)
        {
        }

        public override void BeforeEachTest()
        {
            base.BeforeEachTest();
        }

        [Test]
        public void AddNewItem()
        {
            app.Tap(x => x.Marked("Agenda"));
            app.Screenshot("Navigate to agenda tab");
            app.Tap(x => x.Marked("About"));
            app.Screenshot("App navigated back");
            app.ScrollDownTo(c => c.Button().Marked("Learn more"));
            app.Tap(x => x.Marked("Learn more"));
            app.Screenshot("Learn More Button Clicked");
        }
    }
}
