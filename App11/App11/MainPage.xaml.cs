using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace App11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SQLiteAsyncConnection database;
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("Practica.db");
            database = new SQLiteAsyncConnection(db);
            database.CreateTableAsync<TESHDatos>().Wait();

            var elemento = new TESHDatos
            {
                Id = "13090345",
                Dato1 = "Edith Tiffany",
                Dato2 = "Montoya",
                Dato3 = "Mexico",
                Dato4 = "5547919683",
                Dato5 = "isc",
                Dato6 = "Noveno",
                Dato7 = "13090345",
                Dato8 = "edithtiff@gmail.com",
                Dato9 = "TiffanyMontoya",
            };
            database.InsertAsync(elemento);
        }
    }
}
