using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AjandekLista
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;


        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = ajandek; Uid = root; Pwd =;");
            conn.Open();
            this.FormClosed += (sender, args) =>
              {
                  if (conn != null)
                  {
                      conn.Close();
                  }

              };

            AdatBetoltes();
        }

        void AdatBetoltes()
        {
            string sql = @"
                SELECT id,nev,uzlet
                FROM ajandek
                ORDER BY nev";

            var comm =this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string uzlet;
                    try
                    {
                        uzlet = reader.GetString("uzlet");
                    }
                    catch(SqlNullValueException ex)
                    {
                        uzlet = "";
                    }
                    var ajandek = new Ajandek(id, nev, uzlet);
                    ajandekLstBx.Items.Add(ajandek);
                   
                }
                reader.Close();
            }
            
        }

        private void mentesBtn_Click(object sender, EventArgs e)
        {
            
            if (nevTB.Text.Equals(null) || nevTB.Text=="")
            {
                MessageBox.Show("Nem adta meg az ajándék nevét!");
            }
            else
            {
                string nev = nevTB.Text;
                string uzlet = uzletTB.Text;
                string sql = @"INSERT INTO ajandek (nev,uzlet) VALUES ('" + nev + "','" + uzlet + "');";
                var comm1 = this.conn.CreateCommand();
                comm1.CommandText = sql;
                var vegrehajt=comm1.ExecuteReader();
                ajandekLstBx.Items.Clear();
                AdatBetoltes();
                vegrehajt.Close();
            }
        }

        private void ajandekLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            torlesBtn.Visible = true;
        }

        private void torlesBtn_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM ajandek WHERE nev ='"+ajandekLstBx.SelectedItem.ToString()+"';";
            var comm1 = this.conn.CreateCommand();
            comm1.CommandText = sql;
            var vegrehajt =comm1.ExecuteReader();
            ajandekLstBx.Items.Clear();
            AdatBetoltes();
            torlesBtn.Visible = false;
            vegrehajt.Close();
        }
    }
}
