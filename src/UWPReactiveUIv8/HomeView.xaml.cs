using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

using ReactiveUI;
using ReactiveUI.XamForms;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UWPReactiveUIv8
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeView : ReactiveContentPage<HomeViewModel>
    {
		public HomeView ()
		{
			InitializeComponent ();

            this.WhenActivated(disposables =>
            {
                this.BindCommand(ViewModel, 
                                 vm => vm.HelloCommand, 
                                 v => v.HelloButton.Command)
                    .DisposeWith(disposables);
            });
		}
	}
}