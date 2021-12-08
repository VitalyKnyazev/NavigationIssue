using System;
using Xamarin.Forms;

namespace FlyoutPageNavigation
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            flyoutPage.listView.ItemSelected += OnItemSelected;

            if (Device.RuntimePlatform == Device.UWP)
            {
                FlyoutLayoutBehavior = FlyoutLayoutBehavior.Popover;
            }
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
	        if (e.SelectedItem is FlyoutPageItem item)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                flyoutPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}