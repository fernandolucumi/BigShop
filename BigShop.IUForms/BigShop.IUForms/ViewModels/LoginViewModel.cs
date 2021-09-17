namespace BigShop.UIForms.ViewModels
{   
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;
    using BigShop.UIForms.ViewModels;
    using BigShop.UIForms.Views;
    using GalaSoft.MvvmLight.Command;
    using BigShop.IUForms.Views;

    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand => new RelayCommand(Login);

        public LoginViewModel()
        {
            this.Email = "fernandolucumi@gmail.com";
            this.Password = "hello1962";
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an email",
                    "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter a password",
                    "Accept");
                return;
            }

            if(!this.Email.Equals ("fernandolucumi@gmail.com") || !this.Password.Equals("hello1962"))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You email or password are wrong",
                    "Accept");
                return;
            }
            else
            {
                //await Application.Current.MainPage.DisplayAlert(
                //    "OK",
                //    "Fine, you got it!!",
                //    "Accept");

                MainViewModel.GetInstance().Products = new ProductsViewModel();
                await Application.Current.MainPage.Navigation.PushAsync(new ProductsPage());
            }
            
        }
    }
}
