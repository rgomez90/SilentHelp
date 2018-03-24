using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace SilentHelp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<object,string>(this,App.NOTIFICATION_RECEIVED_KEY,OnMesssageReceived);
        }

	    protected override void OnDisappearing()
	    {
	        base.OnDisappearing();
	        MessagingCenter.Unsubscribe<object>(this, App.NOTIFICATION_RECEIVED_KEY);
	    }

        private void OnMesssageReceived(object sender, string msg)
	    {
	        Device.BeginInvokeOnMainThread(() =>
	        {
                Debug.WriteLine( "MessageReceived: "+ msg);
	            Lbl.Text = msg;
	        });
	    }

	    private void HelpButtonClicked(object sender, EventArgs e)
	    {
	        throw new NotImplementedException();
	    }
	}
}
