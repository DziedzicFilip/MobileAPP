using SeenIT.Services;
using SeenIT.ServiceReference;
using SeenIT.Views;
using System;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeenIT
{
    public partial class App : Application
    {

        public App()
        {
            //In case of using HTTPS on local - that's only for testing 
            //- you can use preprocessor method for checking if we are running in development.
            var handler = new HttpClientHandler();
#if DEBUG
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };
#endif
            var client = new HttpClient(handler);
            InitializeComponent();
            DependencyService.RegisterSingleton(new SeenitService("https://10.0.2.2:7206", client));
            DependencyService.Register<MockDataStore>();
            DependencyService.Register<FilmDataStore>();
            DependencyService.Register<RodzajDataStore>();
            DependencyService.Register<UzytkownikDataStore>();
            DependencyService.Register<SerialDataStore>();
            MainPage = new AppShell();
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
    }
}
