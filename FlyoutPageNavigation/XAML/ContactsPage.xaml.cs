using System;

namespace FlyoutPageNavigation
{
	public partial class ContactsPage
	{
		public ContactsPage()
		{
			InitializeComponent();
		}

		private async void Button_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync(false); // does not work
			// await Navigation.PopAsync(); // this works
		}
	}
}