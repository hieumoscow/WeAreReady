using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeAreReady.Views
{
    public class ScanView : ContentPage
    {

        StackLayout mainStack = new StackLayout();
        Entry userNameEntry = new Entry();
        Entry passwordEntry = new Entry();

        public ScanView()
        {
            BuildLayout();
            Content = mainStack;
        }

        public void BuildLayout()
        {
            mainStack.Spacing = 20;
            mainStack.Padding = 50;
            mainStack.VerticalOptions = LayoutOptions.Center;

            
            userNameEntry.Placeholder = "Username";
            
            passwordEntry.Placeholder = "Password";
            passwordEntry.IsPassword = true;

            Button loginButton = new Button();
            loginButton.Text = "Login";
            loginButton.TextColor = Color.Black;
            loginButton.BackgroundColor = Color.FromHex("77D065");
            var tapGesture = new TapGestureRecognizer { Command = new Command(LoginTap)};
            loginButton.GestureRecognizers.Add(tapGesture);

            mainStack.Children.Add(userNameEntry);
            mainStack.Children.Add(passwordEntry);
            mainStack.Children.Add(loginButton);

            
        }

        private async void LoginTap()
        {
            await Navigation.PushAsync(new NFCViews.NFCScanView());
        }
    }
}