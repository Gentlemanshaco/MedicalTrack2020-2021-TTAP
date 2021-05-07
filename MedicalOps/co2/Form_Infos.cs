using System;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using System.IO;
using co2;
using MySql.Data.MySqlClient;
using System.Data;


namespace co2
{
    public partial class Form_Infos : Form
    {
        SerialPort my_serie;
        string baudrate = "9600";
        int i = 0;
         MySqlConnection connection;
         string server = "172.17.3.214";
         string database = "planning";
         string uid = "test";
        string password = "test";


        public Form_Infos()
        {
            InitializeComponent();
            Config laconf = new Config();

            server = laconf.get_ip() ;
            database = "planning";
            uid = "sallop1";
            password = "sallop1";
            string connectionString;

            connectionString = "server = " + server + ";" + "database = " + database + ";" + "uid = " + uid + ";" + "password = " + password + ";";
            connection = new MySqlConnection(connectionString);
        }
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
        private void Form_Infos_Load(object sender, EventArgs e)
        {
            //listing de tout les ports série à qui on peut se connecter
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                //ajout de tout les ports dans la combo box
                t_com.Items.Add(s);
            }
            t_com.SelectedIndex = 1;
            string laConnexion;
            string ladresse;
            string labdd;
            string nom_utilisateur;
            string motdepasse;
            //création d'un lecteur et lecture des infos de connexion
            StreamReader lelecteur = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\infocon.txt");
            Config laconf2 = new Config();
            nom_utilisateur = laconf2.get_user();
            motdepasse = laconf2.get_mdp();
            labdd = lelecteur.ReadLine();
            labdd = lelecteur.ReadLine();
            labdd = lelecteur.ReadLine();
            ladresse = laconf2.get_ip();
            laConnexion = @"server=" + ladresse + ";database="+ labdd + ";userid=" + nom_utilisateur + ";password=" + motdepasse + ";";
            lelecteur.Close();
            //fermeture du lecteur et ensuite ouverture de la connexion juste en dessous
            //laConnexion.Open();

            if (this.OpenConnection() == true)
            {
                MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM `planning`", connection);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];

            }

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (100);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }


        delegate void SetTextCallback(string text);
        int j = 0;

        private void ReceptionSerie(object sender, SerialDataReceivedEventArgs e)
        {
            for (j = 0; j <=0 ; j++)
            {

                Thread.Sleep(750);///attente si jamais on a des gros paquets de données
                string data = my_serie.ReadExisting();
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                SetText(data);
            }

        }
        //la fonction en dessous sert a mettre tout ce que on recoit du port série dans la tb en faisant un invoke pour que ca soit dans le meme thread
        private void SetText(string textCOM)
        {

            if (NumBadge.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(SetText);
                NumBadge.Invoke(d, new object[] { textCOM });

                string input = this.NumBadge.Text;
                char[] values = input.ToCharArray();
                textCOM = string.Empty;
                foreach (char letter in values)
                {
                    int value = Convert.ToInt32(letter);
                    textCOM += String.Format("{0:X}", value); ;
                }
            }
            else
            {
                NumBadge.Text = "";
                NumBadge.Text += textCOM;

            }
        }

        private void Button_sortiepatient_Click(object sender, EventArgs e) //code si on clique sur sortie patient  
        {
            Form_brancardiers brancard = new Form_brancardiers();

            if (my_serie.IsOpen == true)
            {
                my_serie.Close();
            }
            else
            {

            }
            
            this.Hide();
            brancard.Show();
        }

        private void B_arriveepatient_Click(object sender, EventArgs e)
        {
            string badge;
            //récup du numéro de badge 
            badge = NumBadge.Text;
            C_MySql sql = new C_MySql();
            string larequete = " UPDATE `sallop1` SET `Drive_Bancardier`= 'en operation' WHERE `Badge`= '" + badge + "'; ";
            sql.TableRequetteNonQuery(larequete);
        }

        
        private void NumBadge_TextChanged(object sender, EventArgs e)
        {
           for (i=this.i; i <= 1; i++)
           {
                try
                {
                    int lalongeur;
                    lalongeur = NumBadge.TextLength - 2;
                    string badge = NumBadge.Text.Substring(0, lalongeur);
                    DataSet ds_nom;
                    DataSet ds_prenom;
                    DataSet ds_pathologie;

                    //création connection
                    C_MySql sql = new C_MySql();

                    //création requetes 
                    string requete1 = "SELECT `nom` FROM `utilisateur` WHERE `badge` = '" + badge + "'";
                    string requete2 = "SELECT `prenom` FROM `utilisateur` WHERE `Badge` = '" + badge + "'";
                    string requete3 = "SELECT `pathologie` FROM `utilisateur` WHERE `Badge` = '" + badge + "'";

                    //on va chercher les données et on les stocke dans les dataset
                    ds_nom = sql.TableLire(requete1);
                    ds_prenom = sql.TableLire(requete2);
                    ds_pathologie = sql.TableLire(requete3);

                    //et on les met dans les tb
                     affiche_nom(ds_nom.Tables[0].Rows[0]);
                    affiche_prenom(ds_prenom.Tables[0].Rows[0]);
                    affiche_pathologie(ds_pathologie.Tables[0].Rows[0]);
                    
                }
                catch
                {
                    //MessageBox.Show("Damien t'a tout kc");
                    TB_Nom.Text = "";
                    TB_prenom.Text = "";
                    TB_Pathologie.Text = "";
                    Thread.Sleep(500);
                    
                }
          }
            i = i - 1;

        }
        // ici c'est les fonctions d'affichage 
        #region   
        private void affiche_nom(DataRow dr)
        {
            
            TB_Nom.Text = dr["Nom"].ToString();
            
        }
        private void affiche_prenom(DataRow dr)
        {

            TB_prenom.Text = dr["Prenom"].ToString();

        }
        private void affiche_pathologie(DataRow dr)
        {

            TB_Pathologie.Text = dr["Pathologie"].ToString();

        }
        #endregion

        private void t_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // création d'un objet port série et ouverture du port 
                my_serie = new System.IO.Ports.SerialPort(t_com.Text);
                my_serie.BaudRate = Convert.ToInt32(baudrate);
                my_serie.DataBits = 8;
                my_serie.StopBits = StopBits.One;
                my_serie.Parity = Parity.None;
                my_serie.Handshake = Handshake.None;
                my_serie.Open();
                my_serie.DataReceived += new SerialDataReceivedEventHandler(ReceptionSerie);
               // if (my_serie.IsOpen) MessageBox.Show("Vous êtes connecté !");
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.dataGridView1.Refresh();
            this.dataGridView1.Parent.Refresh();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (100);
            timer.Tick += new EventHandler(timer1_Tick);
            lire_bdd("");

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.RowTemplate.Height = 90;
            this.dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 30);
        }

        private void lire_bdd(string filtre)
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM `planning` ", connection);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }


    }
}
