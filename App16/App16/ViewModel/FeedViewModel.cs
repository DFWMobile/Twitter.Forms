using App16.Models;
using App16.Services;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App16.ViewModel
{
    public class FeedViewModel
        : BaseViewModel
    {
        private UserService _userService;
        private ICommand _refreshCommand;

        public ObservableRangeCollection<RandomUserResult> Users { get; set; }
            = new ObservableRangeCollection<RandomUserResult>();

        public FeedViewModel(UserService userService)
        {
            _userService = userService;
        }

        public ICommand RefreshCommand =>
            _refreshCommand ?? (_refreshCommand = new Command(async () => await ExecuteRefreshCommandAsync()));

        private async Task ExecuteRefreshCommandAsync()
        {
            try
            {
                IsBusy = true;
                Users.Clear();
                Users.AddRange(await _userService.GetUsersAsync(100));
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
