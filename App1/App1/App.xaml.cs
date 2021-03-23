using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected override void OnAppLinkRequestReceived(Uri uri)
        {
            if (uri.Host.EndsWith("app.matrixcloud.ir", StringComparison.OrdinalIgnoreCase))
            {

                if (uri.Segments != null && uri.Segments.Length == 2)
                {
                    var action = uri.Segments[1].Replace("/", "");

                    switch (action)
                    {
                        case "Privacy":
                                Device.BeginInvokeOnMainThread(async () =>
                                {
                                    await Current.MainPage.DisplayAlert("hello", "Welcome Back ", "ok");
                                });
                            break;

                        default:
                            Device.OpenUri(uri);
                            break;
                    }
                }
            }
        }
    }
}
