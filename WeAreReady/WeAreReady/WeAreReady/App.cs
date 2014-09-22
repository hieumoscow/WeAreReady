using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeAreReady.ViewModels;
using WeAreReady.Views;
using Xamarin.Forms;

namespace WeAreReady
{
    public class App
    {
        public static Page GetMainPage()
        {

            var scanPage = new ScanView
            {
                Title = "Scan",
            };

            var messagePage = new ReportView
            {
                Title = "Report"
            };

            var homeView = new HomeView();


            var mainView = new NavigationPage(new TabbedPage { Children = { homeView, scanPage, messagePage } });

            return mainView;
        }

        public static HomeViewModel homeViewModel = new HomeViewModel();
    }
}