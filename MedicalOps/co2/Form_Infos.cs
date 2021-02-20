using System;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using System.IO;
using MySql.Data.MySqlClient;

namespace co2
{
    public partial class Form_Infos : Form
    {
        SerialPort my_serie;
        string baudrate = "9600";
        public Form_Infos()
        {
            InitializeComponent();
        }

        private void Form_Infos_Load(object sender, EventArgs e)
        {
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                t_com.Items.Add(s);
            }
            string laConnexion;
            string ladresse;
            string labdd;
            string nom_utilisateur;
            string motdepasse;

            StreamReader lelecteur = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\infocon.txt");
            nom_utilisateur = lelecteur.ReadLine();
            motdepasse = lelecteur.ReadLine();
            labdd = lelecteur.ReadLine();
            ladresse = lelecteur.ReadLine();
            laConnexion = @"server=" + ladresse + ";database="+ labdd + ";userid=" + nom_utilisateur + ";password=" + motdepasse + ";";
            lelecteur.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                my_serie = new System.IO.Ports.SerialPort(t_com.Text);
                my_serie.BaudRate = Convert.ToInt32(baudrate);
                my_serie.DataBits = 8;
                my_serie.StopBits = StopBits.One;
                my_serie.Parity = Parity.None;
                my_serie.Handshake = Handshake.None;
                my_serie.Open();
                my_serie.DataReceived += new SerialDataReceivedEventHandler(ReceptionSerie);
                //"Ouverture du port " + portCom;
                if (my_serie.IsOpen) MessageBox.Show("Vous êtes connecté !");
            }
            catch { }
        }

        delegate void SetTextCallback(string text);
        private void ReceptionSerie(object sender, SerialDataReceivedEventArgs e)
        {

            Thread.Sleep(750);///attente pour les gros paquets de données
            string data = my_serie.ReadExisting();
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            SetText(data);

        }

        private void SetText(string textCOM)
        {

            if (labeldata.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(SetText);
                labeldata.Invoke(d, new object[] { textCOM });

                string input = this.labeldata.Text;
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
                labeldata.Text = "";
                labeldata.Text += textCOM;

            }
        }

        private void Button_sortiepatient_Click(object sender, EventArgs e)
        {
            string laConnexion;
            string ladresse;
            string labdd;
            string nom_utilisateur;
            string motdepasse;

            StreamReader lelecteur = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\infocon.txt");
            nom_utilisateur = lelecteur.ReadLine();
            motdepasse = lelecteur.ReadLine();
            labdd = lelecteur.ReadLine();
            ladresse = lelecteur.ReadLine();
            laConnexion = @"server=" + ladresse + ";database=" + labdd + ";userid=" + nom_utilisateur + ";password=" + motdepasse + ";";
            lelecteur.Close();
            var cn = new MySqlConnection(laConnexion);
            cn.Open();
            var cmd = cn.CreateCommand();//création commande sur la connexion (échoue si la base n'existe pas)
            cmd.CommandText = "INSERT INTO `patient`(ID, nom,prenom,badge,pathologie) VALUES ('1', 'Poinsignon','Thierry','666.555.444.333','Parkinson')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("succès du patient");
        }
    }
}
