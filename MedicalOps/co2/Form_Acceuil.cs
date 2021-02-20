using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace co2
{
    public partial class Form_Acceuil : Form
    {
        C_MySql sql = new C_MySql("172.17.3.214","essai","test","test");

        public Form_Acceuil()
        {
            InitializeComponent();
            
        }

        private void button_Connexion_Click(object sender, EventArgs e)
        {
            //ouverture des forms
            Form_Connection Form_Connection = new Form_Connection();
            Form_Connection.Show();
            this.Hide();
        }

        private void Form_Acceuil_Load(object sender, EventArgs e)
        {
            sql.SQl_ConnectionBDD();
        }

        private void button_ModifierBase_Click(object sender, EventArgs e)
        {
            //ouverture des forms
            Form_BaseDeDonnées Form_BaseDeDonnées = new Form_BaseDeDonnées();
            Form_BaseDeDonnées.Show();
            this.Hide();
        }
    }
}
