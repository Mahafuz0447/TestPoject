using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PostgreSQL_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var connection = string.Format("Server=localhost;Port=5432;Database=PG_DB_MY_First_DB;Uid=postgres;Pwd=1qaz*2wsx#;");
            var query = string.Format("SELECT * FROM public.appuser");
            NpgsqlDataAdapter adaptegr = new NpgsqlDataAdapter(query, connection);
            DataSet  aDataSet = new DataSet();
            adaptegr.Fill(aDataSet, "TestTable");
            dataAppInfo.DataSource = aDataSet.Tables[0];
        }
    }
}
