using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SilentHelp
{
	public partial class App : Application
	{
	    public const string NOTIFICATION_RECEIVED_KEY = "NotificationReceived";

		public App ()
		{
			InitializeComponent();

			MainPage = new SilentHelp.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
