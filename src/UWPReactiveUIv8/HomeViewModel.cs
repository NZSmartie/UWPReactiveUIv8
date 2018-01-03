using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using ReactiveUI;
using Splat;

namespace UWPReactiveUIv8
{
    public class HomeViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "Home";

        public IScreen HostScreen {get;}

        public ReactiveCommand HelloCommand { get; private set; }

        public HomeViewModel(IScreen hostScreen = null)
        {
            HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();

            HelloCommand = ReactiveCommand.Create(() => Debug.WriteLine("Hello World"));
        }
    }
}
