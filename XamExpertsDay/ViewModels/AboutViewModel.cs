using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace XamExpertsDay.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://expertday.forxamarin.com/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}