using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Yurt_Kayitv1
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-LBFJ9LQ\WOLVOX8;Initial Catalog=YurtKayıt;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
