using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace co2
{
    public partial class Form_BaseDeDonnées : Form
    {
        public Form_BaseDeDonnées()
        {
            InitializeComponent();
        }
        string adresse;
        string nombase;
        string user;
        string mdp;
        string ledossier = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\";
        string lefichier = "config.txt";
        string ledeuxieme = "adresse.txt";
        string letroisieme = "infocon.txt";

        private void B_Sauvegarde_Click(object sender, EventArgs e)
        {
            //création du dossier dans appdata
            Directory.CreateDirectory(ledossier);
            //MessageBox.Show("écriture des champs");
            //passage des données dans les variables
            adresse = TB_adresse.Text;
            nombase = TB_nombase.Text;
            user = TB_user.Text;
            mdp = TB_mdp.Text;
            //création d'un stream writter pour écrire dans le fichier 
            StreamWriter lestylo = new StreamWriter(ledossier + lefichier);
            //écriture dans le fichier
            lestylo.WriteLine(adresse);
            lestylo.WriteLine(nombase);
            lestylo.WriteLine(user);
            lestylo.WriteLine(mdp);
            //MessageBox.Show("écriture terminée, fermeture du fichier");
            //fermeture du streamwritter
            lestylo.Close();
            StreamWriter lestylo2 = new StreamWriter(ledossier + ledeuxieme);
            lestylo2.WriteLine(adresse);
            lestylo2.Close();
            StreamWriter lestylo3 = new StreamWriter(ledossier + letroisieme);
            lestylo3.WriteLine(user);
            lestylo3.WriteLine(mdp);
            lestylo3.WriteLine(nombase);
            lestylo3.WriteLine(adresse);
            lestylo3.Close();
            //MessageBox.Show("opération terminée avec succès");
            Form_Acceuil Form_Aceuil = new Form_Acceuil();
            Form_Aceuil.Show();
            this.Hide();
        }

        private void Form_BaseDeDonnées_Load(object sender, EventArgs e)
        {
            try
            {
                //création nouvelle instance de lecteur 
                StreamReader Lelecteur = new StreamReader(ledossier + lefichier);
                //lecture des lignes pour récup les données 
                adresse = Lelecteur.ReadLine();
                nombase = Lelecteur.ReadLine();
                user = Lelecteur.ReadLine();
                mdp = Lelecteur.ReadLine();
                //fermeture du lecteur pour libérer le fichier
                Lelecteur.Close();
                //remplissage auto des champs
                TB_adresse.Text = adresse;
                TB_nombase.Text = nombase;
                //TB_user.Text = user  ;
                //TB_mdp.Text = mdp  ;
            }
            catch
            {

            }
           
           
        }


    }
}
