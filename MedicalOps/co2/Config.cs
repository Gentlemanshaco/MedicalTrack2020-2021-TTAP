using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace co2
{
    class Config
    {
        public string get_ip()
        {
            string ip;
            StreamReader lire = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\config.txt");
            ip = lire.ReadLine();
            lire.Close();
            return ip;
        }

          public string  get_user()
        {
            string user;
            StreamReader lire = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\config.txt");
            user = lire.ReadLine();
            user = lire.ReadLine();
            lire.Close();
            return user;


        }
        public string get_mdp()
        {
            string mdp;
            StreamReader lire = new StreamReader(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MedicalTrack\config.txt");
            mdp = lire.ReadLine();
            mdp = lire.ReadLine();
            mdp = lire.ReadLine();
            lire.Close();
            return mdp;
        }
        
    }
}
