using System;
using Xamarin.Forms;

namespace FlyoutPageNavigation
{
	public partial class TodoListPage : ContentPage
	{
		public TodoListPage()
		{
			InitializeComponent();
		}

		private async void Button_OnClicked(object sender, EventArgs e)
		{
			var navigationPage = (NavigationPage)Parent;
			await navigationPage.Navigation.PushAsync(new ContactsPage());
		}
	}
}