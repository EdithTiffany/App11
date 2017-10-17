using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace App11
{
   public interface ISQLite
    {
        String GetLocalFilePath(string Filename);
    }
}
