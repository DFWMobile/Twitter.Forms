using App16.Services;
using App16.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App16.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FeedView : ContentPage
	{
        private FeedViewModel vm;
        FeedViewModel ViewModel => vm ?? (vm = BindingContext as FeedViewModel);


		public FeedView ()
		{
			InitializeComponent ();
            BindingContext = new FeedViewModel(new UserService());
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ViewModel.RefreshCommand.Execute(null);
        }
    }
}