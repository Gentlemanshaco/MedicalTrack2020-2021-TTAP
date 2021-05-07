using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace co2
{
    class C_MySql
    {
        static DataSet data;//Déclaration Objet DataSet
        static MySqlConnection cn;//Déclaration Objet Connection
        static MySqlCommand cmd;//Déclaration Objet Command
        static MySqlDataAdapter da;//Ensemble de commande utilisée pour remplir le Dataset
        static MySqlParameter prm;//Déclaration Objet paramètre
        static MySqlDataReader reader;//Déclaration Objet Datareader
        private string cn_base;//chaine de connexion à la base
        private string cn_racine;//chaine de connexion à la racine du serveur
        public string Get_Adresse()
        {
            StreamReader lelecteur = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\adresse.txt");
            string adresse = lelecteur.ReadLine();
            lelecteur.Close();
            return adresse;
        }
        public string Get_Base()
        {
            StreamReader lelecteur = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\config.txt");
            string Base = lelecteur.ReadLine();
            Base = lelecteur.ReadLine();
            lelecteur.Close();
            return Base;
        }

        public string Get_User()
        {
            StreamReader lelecteur = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\config.txt");
            string user = lelecteur.ReadLine();
            user = lelecteur.ReadLine();
            user = lelecteur.ReadLine();
            lelecteur.Close();
            return user;
        }

        public string Get_Mdp()
        {
            StreamReader lelecteur = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\config.txt");
            string mdp = lelecteur.ReadLine();
            mdp = lelecteur.ReadLine();
            mdp = lelecteur.ReadLine();
            mdp = lelecteur.ReadLine();
            lelecteur.Close();
            return mdp;
        }
        public C_MySql()//constructeur
        {
            string Serveur = Get_Adresse();
            string User = Get_User();
            string Pass = Get_Mdp();
            string Base = Get_Base();
            cn_racine = "server=" + Serveur + "; user id=" + User + "; password=" + Pass + "; database=" + "" + "; pooling=false";
            cn_base = "server=" + Serveur + "; user id=" + User + "; password=" + Pass + "; database=" + Base + "; pooling=false";
        }
        public C_MySql(string Serveur, string Base, string User, string Pass)//constructeur
        {
            cn_racine = "server=" + Serveur + "; user id=" + User + "; password=" + Pass + "; database=" + "" + "; pooling=false";
            cn_base = "server=" + Serveur + "; user id=" + User + "; password=" + Pass + "; database=" + Base + "; pooling=false";
        }

        public bool BaseExiste(string Base)
        {
            cn = new MySqlConnection();//création objet connexion
            cn.ConnectionString = cn_racine; //chaine de connexion
            cn.Open();//établissement connexion

            cmd = cn.CreateCommand();//création commande sur la connexion (échoue si la base n'existe pas)
            cmd.CommandText = "SHOW DATABASES";

            reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                if (reader.GetString(0) == Base.ToLower()) { i = 1; break; }
            }
            reader.Close();

            cn.Close();
            if (i == 0) { return false; } else { return true; }
        }
        public bool BaseCreer(string Base)
        {
            try
            {
                cn = new MySqlConnection();//création objet connexion
                cn.ConnectionString = cn_racine; //chaine de connexion
                cn.Open();//établissement connexion

                cmd = cn.CreateCommand();//création commande sur la connexion (échoue si la base n'existe pas)
                cmd.CommandText = "CREATE DATABASE " + Base;
                cmd.ExecuteNonQuery();  //exécution sans retour
                cn.Close();
                return true;
            }
            catch { return false; }
        }
        public bool CreerUtilisateur(string Serveur, string Base, string User, string Pass)
        {
            try
            {
                cn = new MySqlConnection();//création objet connexion
                cn.ConnectionString = cn_racine; //chaine de connexion
                cn.Open();//établissement connexion

                cmd = cn.CreateCommand();//création commande sur la connexion (échoue si la base n'existe pas)
                if (Serveur == "127.0.0.1")
                    cmd.CommandText = "GRANT ALL PRIVILEGES ON *.* TO '" + User + "'@'localhost' IDENTIFIED BY '" + Pass + "' WITH GRANT OPTION";
                else
                    cmd.CommandText = "GRANT ALL PRIVILEGES ON *.* TO '" + User + "'@'" + Base + "' IDENTIFIED BY '" + Pass + "' WITH GRANT OPTION";
                cmd.ExecuteNonQuery();  //exécution sans retour

                cn.Close();
                return true;
            }
            catch { return false; }
        }
        public bool VerifUtilisateurExiste(string User, string Pass)
        {
            try
            {
                cn = new MySqlConnection();//création objet connexion
                cn.ConnectionString = cn_racine; //chaine de connexion
                cn.Open();//établissement connexion

                cmd = cn.CreateCommand();//création commande sur la connexion (échoue si la base n'existe pas)
                cmd.CommandText = "SELECT EXISTS(SELECT * FROM mysql.user WHERE user = '" + User + "')"; //  AND password = '" + Pass + "'
                string temp = cmd.ExecuteScalar().ToString();  //exécution avec retour
                cn.Close();

                if (temp == "1") // La requete retourne "1" si elle a trouvé un résultat.
                    return true;
                else            // Elle retourne "0" sinon.
                    return false;


            }
            catch { return false; }
        }
        public bool TableExiste(string Base, string Table)
        {
            cn = new MySqlConnection();//création objet connexion
            cn.ConnectionString = cn_base; //chaine de connexion
            cn.Open();//établissement connexion

            cmd = cn.CreateCommand();//création commande sur la connexion (échoue si la base n'existe pas)
            cmd.CommandText = "SHOW TABLES FROM " + Base;

            reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                if (reader.GetString(0) == Table.ToLower()) { i = 1; break; }
            }
            reader.Close();

            cn.Close();
            if (i == 0) { return false; } else { return true; }
        }
        public string TableRequetteQuery(string Requete)
        {
            try
            {
                cn = new MySqlConnection();//création objet connexion
                cn.ConnectionString = cn_base; //chaine de connexion
                cn.Open();//établissement connexion
                cmd = new MySqlCommand(Requete, cn);
                string data = cmd.ExecuteScalar().ToString();  //exécution avec retour

                cn.Close();
                return data;
            }
            catch { return ""; }
        }
        public bool TableRequetteNonQuery(string Requete)
        {
            try
            {
                cn = new MySqlConnection();//création objet connexion
                cn.ConnectionString = cn_base; //chaine de connexion
                cn.Open();//établissement connexion
                cmd = new MySqlCommand(Requete, cn);
                cmd.ExecuteNonQuery();  //exécution sans retour
                cn.Close();
                return true;
            }
            catch { return false; }
        }
        public DataSet TableLire(string Requette)
        {
            cn = new MySqlConnection();//création objet connexion
            cn.ConnectionString = cn_base; //chaine de connexion
            cn.Open();//établissement connexion

            da = new MySqlDataAdapter(Requette, cn);//On crée un nouvel objet da qui contiendra la requete et la connection 
            data = new DataSet(); //On crée un nouvel objet ds
            da.Fill(data);//On ajoute da dans le Dataset ds

            cn.Close(); //On se déconnecte de la BDDp
            return data; //On retourne le Dataset            
        }
        public bool InsertImage(string reference, string Image_file_path)//insertion image
        {
            try
            {
                cn = new MySqlConnection();//création objet connexion
                cn.ConnectionString = cn_base; //chaine de connexion
                cn.Open();//établissement connexion

                FileStream fs = new FileStream(Image_file_path, FileMode.Open, FileAccess.Read);
                byte[] ImageDB = new byte[fs.Length];
                fs.Read(ImageDB, 0, (int)fs.Length);

                cmd = cn.CreateCommand();//création commande sur la connexion (échoue si la base n'existe pas)
                cmd.CommandText = "UPDATE  Produits  SET Photo =?paramImg WHERE Ref_Produit = '" + reference + "'";

                prm = new MySqlParameter();
                prm = cmd.Parameters.Add("paramImg", MySqlDbType.LongBlob, (int)fs.Length);
                prm.Value = ImageDB;
                prm.Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                fs.Dispose();
                fs.Close();
                cn.Close();
                return true;
            }
            catch { return false; }
        }
        public Bitmap GetImage(string Table, string Champ, string Code_barre)//extraction image
        {
            try
            {
                cn = new MySqlConnection();//création objet connexion
                cn.ConnectionString = cn_base;//chaine de connexion
                cn.Open();//établissement connexion

                cmd = cn.CreateCommand();//création commande sur la connexion (échoue si la base n'existe pas)
                cmd.CommandText = "select " + Champ + " from " + Table + " where code_barre = '" + Code_barre + "'";

                reader = cmd.ExecuteReader();
                reader.Read();
                byte[] Byte_Image = (byte[])reader.GetValue(0);
                reader.Close();

                MemoryStream ms = new MemoryStream(Byte_Image, true);
                ms.Write(Byte_Image, 0, Byte_Image.Length);
                Bitmap Bmp_Image = new Bitmap(ms);
                ms.Close();

                cn.Close();
                return Bmp_Image;
            }
            catch { return null; }
        }
        public bool TestConnexionBDD()
        {
            try
            {
                cn = new MySqlConnection();//création objet connexion
                cn.ConnectionString = cn_base; //chaine de connexion
                cn.Open();//établissement connexion
                cn.Close();
                return true;

            }
            catch { return false; }
        }
        public bool SQl_ConnectionBDD()
        {
            string serveur;
            string basededonnee;
            string user;
            string mdp;
            string str;

            if (File.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\config.txt"))
            {
                StreamReader lelecteur = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\config.txt");
                serveur = lelecteur.ReadLine();
                basededonnee = lelecteur.ReadLine();
                user = lelecteur.ReadLine();
                mdp = lelecteur.ReadLine();
                lelecteur.Close();
                str = @"server=" + serveur + ";database=" + basededonnee + ";userid=" + user + ";password=" + mdp;
            }
            else
            {
                str = @"server=172.17.3.250;database=salleoperation1;userid=test;password=test;";//ici c'est la chaine de connection avec l'addresse le nom de la base le nom d'utilisateur et le mdp
            }
            MySqlConnection con = null;
            try//on fait un try catch si y'a erreur pour savoir d'ou ca vient
            {
                con = new MySqlConnection(str);// on crée la chaine de connexion
                con.Open();// on execute la connection
                           //MessageBox.Show("Connexion à la base de données réussie !");//si ca réussit
                           //écriture des données dans la bdd si le fichier existe pas

            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.ToString());//display de l"err

            }

            return false;
        }
        MySqlConnection conected = null;









    }
}