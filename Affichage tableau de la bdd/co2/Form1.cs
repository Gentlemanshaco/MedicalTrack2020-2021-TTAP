using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;


namespace co2
{


    public partial class Form1 : Form
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        
        public Form1()
        {
            InitializeComponent();
    
            //connection a ma BBD

            server = "172.17.3.214";
            database = "essai";
            uid = "test";
            password = "test";
            string connectionString;


            connectionString = "server = " + server + ";" + "database = " + database + ";" + "uid = " + uid + ";" + "password = " + password + ";";
            connection = new MySqlConnection(connectionString);
        }
        private void timer1_Tick(object sender, EventArgs e) // permet avec le timer tick d'afficher en temps reel la date et l'heure
        {
            DateTime heure = System.DateTime.Now;
            label5.Text = heure.Day + "/" + heure.Month + "/" + heure.Year;
            label4.Text = heure.Hour + ":" + heure.Minute;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                
        }

        // booleen qui verifie si vous etes connecte a la BDD
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                                        ///////////  MessageBox.Show("Vous etes bien connecte a la BDD");
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("impossible de se connecter a la BDD, contactez un administrateur");
                        break;
                    case 1045:
                        MessageBox.Show("vos identifiant ne sont pas validées. Réesayer encore!");
                        break;
                }
                return false;
            }
        }

        // boolen pour verifie si on est bien connecter a la BDD
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void refreshForm()
        {
           

        }

        private void Form1_Load(object sender, EventArgs e) 
            // ouvre une connection
            // chercher dans la base de donnee les infos à partir de la requette 
            // remplir le dataset avec les données
            //pause de 2 secondes
            // affiche dans le data griedview les infos de la requetes 
        {
            int n = 1;

            if (this.OpenConnection() == true)
            {
                MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM essai", connection);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                Thread.Sleep(1000);
                dataGridView1.DataSource = DS.Tables[0];

            }
            

            this.Refresh();
            Thread.Sleep(1000);


        }

    


        private void label1_Click_1(object sender, EventArgs e)
        {
            DateTime heure = System.DateTime.Now;
            label4.Text = heure.Hour + ":" + heure.Minute;
        }
        

        private void label4_Click(object sender, EventArgs e)
        {
            DateTime heure = System.DateTime.Now;
            label5.Text = heure.Day + "/" + heure.Month + "/" + heure.Year;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        
     

        }

       
    }
}





