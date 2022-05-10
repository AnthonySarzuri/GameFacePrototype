using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFacePrototype
{
    public class Global
    {
        //Se usan
        static public int IdUser;
        static public int IdUserThird;
        static public string Conexion = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85e89_gfdb;User Id=db_a85e89_gfdb_admin;Password=l05tvcvs";

        //Todavia no se usan
        static public int Status;
        static public int IdPost;
        static public int IdComments;
        static public int IdComment;
        static public int[] VectorGustos = new int[7];
        static public int tries = 0;
        static public int cont, cont2 = 1;
        static public bool isSuperUser;
    }
}
