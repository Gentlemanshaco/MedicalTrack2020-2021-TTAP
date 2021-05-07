using System;
using System.Text;
using System.Threading;
using System.Data;
using System.Windows.Forms;
using System.IO.Ports;

namespace co2
{
    public partial class Form_brancardiers : Form
    {
        SerialPort my_serie;
        string baudrate = "9600";
        
        public Form_brancardiers()
        {
            InitializeComponent();
        }

        private void Form_brancardiers_Load(object sender, EventArgs e)
        {
            //listing de tout les ports série à qui on peut se connecter
            foreach (string s in SerialPort.GetPortNames())
            {
                //ajout de tout les ports dans la combo box
                t_com.Items.Add(s);
            }
            t_com.SelectedIndex = 1;
            C_MySql sql = new C_MySql();
            string requete = "SELECT * FROM `utilisateur` WHERE `dispo` = '1' AND `fonction` = 'brancardier'";
            DataSet Lesnoms = sql.TableLire(requete);
            //on parcours le dataset de row en row (ligne en ligne ) 
            foreach(DataRow row in Lesnoms.Tables[0].Rows)
            {
                //et si le nom n'apparauit pas dans la cb alors on le rajoute 
                if (!cb_nom.Items.Contains(row["Nom"])) cb_nom.Items.Add(row["Nom"]);

            }
            //on affiche le premier brancardier qui est dispo 
            cb_nom.SelectedIndex = 0;
        }

        #region

        delegate void SetTextCallback(string text);
        private void ReceptionSerie(object sender, SerialDataReceivedEventArgs e)
        {

            Thread.Sleep(750);///attente si jamais on a des gros paquets de données
            string data = my_serie.ReadExisting();
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            SetText(data);

        }

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
        #endregion //la partie pour le port série

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
            catch
            {
                MessageBox.Show("it made a poo poo");
            }
        }

        private void b_sendalert_Click(object sender, EventArgs e)
        {
            string NumBadges = NumBadge.Text;
            C_MySql sql = new C_MySql();
            string Nom = "Select `nom` FROM `utilisateur` WHERE `Badge` = '" + NumBadges + "'";
            Nom = sql.TableRequetteQuery(Nom);
            string Prenom = "Select `prenom` FROM `utilisateur` WHERE `Badge` = '" + NumBadges + "'";
            Prenom = sql.TableRequetteQuery(Prenom);
            string Pathologie = "Select `pathologie` FROM `utilisateur` WHERE `Badge` = '" + NumBadges + "'";
            Pathologie = sql.TableRequetteQuery(Pathologie);
            //DELETE FROM `table` WHERE condition
            string requete = " UPDATE `utilisateur` SET `Drive_Bancardier`= 'jjjjjj' WHERE `Badge`= '" + NumBadges + "';";            
            sql.TableRequetteNonQuery(requete);
            string nom = cb_nom.Text;
            string req2 = "UPDATE `utilisateur` SET `Disponibilité`='0' WHERE `Nom`=" + nom + ";";
            MessageBox.Show(" requete envoyée avec succès");
            if (my_serie.IsOpen == true)
            {
                my_serie.Close();
            }
            else
            {

            }
            Form_Infos forminfo = new Form_Infos();
            forminfo.Show();
            Hide();

        }
    }
}
