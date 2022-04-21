using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
    public partial class Score : Form
    {
        DataTable dt;
        public Score()
        {
            InitializeComponent();
        }

        private void Score_Load(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (SQLiteConnection conn = new SQLiteConnection(con))
            {
                conn.Open();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(@"select login, TopNumber from Persons
                                                                    order by TopNumber desc", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
                conn.Close();
            }
        }
    }
}
