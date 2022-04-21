using System;
using System.Configuration;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
    public partial class LoginForm : Form
    {
        string connection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        Dictionary<int, int> win = new Dictionary<int, int>()
        {
            {1, 500}, {2, 1000}, {3, 2000},
            {4, 3000}, {5, 5000}, {6, 10000},
            {7, 15000}, {8, 25000}, {9, 50000},
            {10, 100000}, {11, 200000}, {12, 400000},
            {13, 800000}, {14, 1500000}, {15, 3000000}
        };


        public LoginForm()
        {
            InitializeComponent();
        }

        int FindIdPerson(string login)
        {
            using (SQLiteConnection con = new SQLiteConnection(connection))
            {
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(@"select id from Persons
                                                        where login=@login",
                                                        con);
                cmd.Parameters.AddWithValue("login", login);
                int idPerson = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                return idPerson;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int idPerson = 1;
            using (SQLiteConnection cnn = new SQLiteConnection(connection))
            {
                cnn.Open();

                string login = TBLogin.Text;

                SQLiteCommand cmd = new SQLiteCommand(@"select count(*) from Persons
                                                        where login = @login",
                                                        cnn);
                cmd.Parameters.AddWithValue("login", login);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    cmd = new SQLiteCommand(@"insert into Persons
                                              (login, TopNumber)
                                              values (@login, @num)",
                                              cnn);
                    cmd.Parameters.AddWithValue("login", login);
                    cmd.Parameters.AddWithValue("num", 0);
                    cmd.ExecuteNonQuery();
                    idPerson = FindIdPerson(login);
                }
                else
                {
                    idPerson = FindIdPerson(login);
                }

                cnn.Close();
            }
            var frm = new MainForm(idPerson);
            frm.ShowDialog();
        }
    }
}
