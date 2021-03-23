using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Text;


namespace co2
{
    public partial class Form_Connection : Form
    {
        public Form_Connection()
        {
            InitializeComponent();
        }

        private void B_connexion_Click(object sender, EventArgs e)
        {
            string ladresse;
            string nom_utilisateur;
            string motdepasse;
            string bdd;
            string laConnexion;
            //string table = "testdetable";
             //MySqlCommand cmd;
            //recup des informations
            nom_utilisateur = TB_Connexion.Text;
            motdepasse = TB_Motdepasse.Text;
            //création d'un lecteur pour récup l'adresse de la base de données à partir du fichier texte dans appdata
            StreamReader lelecteur = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\adresse.txt");
            //lecture des infos 
            ladresse = lelecteur.ReadLine();
            //ici il faut degager
            //fermeture du lecteur
            lelecteur.Close();
            StreamReader lelecteur2 = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\config.txt");
            bdd = lelecteur2.ReadLine();
            bdd = lelecteur2.ReadLine();
            lelecteur2.Close();

            //création de la connexion
            laConnexion = @"server=" + ladresse + ";database=" + bdd + ";userid=" + nom_utilisateur + ";password=" + motdepasse + ";";
            MySqlConnection con = null;
            //ouverture de la connexion
            try//on fait un try catch si y'a erreur pour savoir d'ou ca vient
            {
                con = new MySqlConnection(laConnexion);// on crée la chaine de connexion
                con.Open();// on execute la connection
                //MessageBox.Show("Connexion reussie");
                StreamWriter lestylo = new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\infocon.txt");
                lestylo.WriteLine(nom_utilisateur);
                lestylo.WriteLine(motdepasse);
                lestylo.WriteLine(bdd);
                lestylo.WriteLine(ladresse);
                lestylo.Close();
                con.Close();
                Form_Infos Form_Infos = new Form_Infos();
                Form_Infos.Show();
                this.Close();
            }
            catch(MySqlException)
            {
                MessageBox.Show("Utilisateur ou mot de passe incorrect veuillez vérifier vos identifiants et recommencez");//display de l"err
                Thread.Sleep(30);
                Form_Connection Form_Connection = new Form_Connection();
                Form_Connection.Show();

            }
           
            

            
        }

        private void Form_Connection_Load(object sender, EventArgs e)
        {
            
        }
    }
}
