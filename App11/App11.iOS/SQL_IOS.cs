using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using App11.iOS;
using Xamarin.Forms;

using Foundation;
using UIKit;

[assembly : Dependency(typeof(SQL_IOS))]
namespace App11.iOS
{
     public class SQL_IOS :ISQLite
    {
        public string GetLocalFilePath(string filname)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, filname);
        }
    }

    
    }
