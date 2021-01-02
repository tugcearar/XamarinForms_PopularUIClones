using PopularUI.Netflix;
using PopularUI.Shazam;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace PopularUI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            App.Current.Resources = new Helpers.Themes.LightTheme();
        }

        private void Netflix_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainTabbedPage();
        }

        private void Shazam_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Shazam_Main();
        }

       
        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
                App.Current.Resources = new Helpers.Themes.DarkTheme();
            else
                App.Current.Resources = new Helpers.Themes.LightTheme();
        }
    }
}