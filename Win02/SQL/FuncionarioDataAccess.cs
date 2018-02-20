using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;

namespace Win02.SQL {
    class FuncionarioDataAccess {

        public static DataTable PegarFuncionarios()
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\Users\tiago.castilhos\Desktop\Pessoais\C#\WindowsForms01\Win02\SQL\sql.sdf");

            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM Funcionario", con);
            DataSet ds = new DataSet();

            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
