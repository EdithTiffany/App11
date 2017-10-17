using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using App11.UWP;
using Windows.Storage;

[assembly: Dependency(typeof(SQL_UWP))]
namespace App11.UWP
{
    public class SQL_UWP :ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);

        }
    }

}