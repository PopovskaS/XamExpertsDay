using System.ComponentModel;
using Xamarin.Forms;

using XamExpertsDay.Models;

namespace XamExpertsDay.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {
        public Session Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new Session();

            BindingContext = this;
        }
    }
}