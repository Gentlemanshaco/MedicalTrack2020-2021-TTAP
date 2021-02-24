using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using C_MySql.cs;
using System.IO;
using System.Windows.Forms;


private MySqlConnection Connection;
private string serveur ;
private string database ;
private string user ;
private string pass ;


namespace Medical_admin
{
    public partial class connection : Form
    {
        public connection()
        {
            InitializeComponent();

            serveur = "172.17.3.223";
            database = "essai";
            uid = "test";
            password = "test";
            string connectionString;

            connectionString= "server=" + serveur + "; user id=" + user + "; password=" + pass + "; database=" + database + "; pooling=false";
            Connection = new MySqlConnection(connectionString);
        }

        private void connection_Load(object sender, EventArgs e)
        {
            C_MySql
        }
    }
}
