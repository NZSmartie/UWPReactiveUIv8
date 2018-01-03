using ReactiveUI;
using ReactiveUI.XamForms;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace UWPReactiveUIv8
{
	public partial class App : Application, IScreen
	{
        public RoutingState Router { get; protected set; }

        public App ()
		{
			InitializeComponent();

            var services = Locator.CurrentMutable;

            services.RegisterConstant<IScreen>(this);

            services.Register<IViewFor<HomeViewModel>>(() => new HomeView());

            Router = new RoutingState();
            Router.NavigateAndReset
                  .Execute(new HomeViewModel())
                  .Subscribe();

            MainPage = new RoutedViewHost();
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
