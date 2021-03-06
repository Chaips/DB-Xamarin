﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        public static Conexion DB;
        public App()
        {
            String basedatos = "Prueba.db3";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var dbPath = System.IO.Path.Combine(docPath, basedatos);
            DB = new Conexion(dbPath);
            MainPage = new NavigationPage(new MainPage());
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
