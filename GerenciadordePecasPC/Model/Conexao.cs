using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadordePecasPC.Model
{
    internal class Conexao
    {
        public static string Conectarbd() 
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wiliam.lsilva\source\repos\GerenciadordePecasPC\GerenciadordePecasPC\Model\pecaspcbd.mdf;Integrated Security=True";
        }
    }
}
