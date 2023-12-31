﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MVVMLiveDemo23.Models;
using MVVMLiveDemo23.ViewModels;

namespace MVVMLiveDemo23
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var demoModel = new DemoModel();
            var demoViewModel = new DemoViewModel(demoModel);
            var peopleViewModel = new PeopleViewModel();
            var mainViewModel = new MainViewModel(demoViewModel, peopleViewModel);

            var mainWindow = new MainWindow(){ DataContext = mainViewModel};

            mainWindow.Show();
        }
    }
}
