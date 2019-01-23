using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Letöltött MySQL package használata

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        private MySqlConnection kapcsolat;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form1 betöltésekor kapcsolódok az adatbázishoz, ha nem sikerül a kapcsolódás hibát jelez
            string szerver = "localhost";
            string felhasznalo = "root";
            string jelszo = "";
            string adatbazis = "cs_harcosok";

            string kapcs_string = "";
            

            kapcs_string = "server="+ szerver +";database="+ adatbazis +";uid="+ felhasznalo +";pwd="+ jelszo +";";
            this.kapcsolat = new MySqlConnection(kapcs_string);
            try
            {
                kapcsolat.Open();
                //MessageBox.Show("Kapcsolat létrejött.");

                //Harcosok tábla létrehozása
                MySqlCommand create_harcosok = new MySqlCommand(@"
                CREATE TABLE IF NOT EXISTS `harcosok` 
                (id INT AUTO_INCREMENT,
                nev VARCHAR(128), 
                letrehozas DATETIME,
                PRIMARY KEY (id), UNIQUE KEY (nev)) COLLATE='utf8_hungarian_ci' ENGINE=InnoDB;", kapcsolat);
                create_harcosok.ExecuteNonQuery();

                //Kepessegek tábla létrehozása
                MySqlCommand create_kepessegek = new MySqlCommand(@"
                CREATE TABLE IF NOT EXISTS `kepessegek` 
                (id INT AUTO_INCREMENT,
                nev VARCHAR(128), 
                leiras VARCHAR(128),
                harcos_id INT,
                PRIMARY KEY (id)) COLLATE='utf8_hungarian_ci' ENGINE=InnoDB;", kapcsolat);
                create_kepessegek.ExecuteNonQuery();

                hasznalo_frissites();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Az adatbázishoz való kapcsolódás sikertelen");
                Application.Exit();
            }
        }

        private void letrehozas_Click(object sender, EventArgs e)
        {
            string harcos = harcosNeveTextBox.Text;

            MySqlCommand leker = kapcsolat.CreateCommand();
            leker.CommandText = "SELECT id FROM harcosok WHERE nev ='" + harcos + "'";

            MySqlDataReader reader = leker.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Már van ilyen harcos.");
                reader.Close();
            }
            else
            {
                reader.Close();
                //MessageBox.Show("OK\nJelenlegi idő: " + jelenleg.ToString("yyyy-MM-dd HH:mm:ss"));
                DateTime jelenlegi_ido = DateTime.Now;
                string jelenleg = jelenlegi_ido.ToString("yyyy-MM-dd HH:mm:ss");

                MySqlCommand felvetel = kapcsolat.CreateCommand();
                felvetel.CommandText = "INSERT INTO harcosok(nev,letrehozas) VALUES('"+ harcos +"', '"+ jelenleg +"')";
                felvetel.ExecuteNonQuery();

                hasznalo_frissites();
                MessageBox.Show(harcos + " nevű harcos sikeresen létrehozva.");
            }

            
        }

        private void hasznalo_frissites()
        {
            harcosokListBox.Items.Clear();
            hasznaloComboBox.Items.Clear();
            string nev = "";
            string ido = "";
            MySqlCommand leker = kapcsolat.CreateCommand();
            leker.CommandText = "SELECT nev, letrehozas FROM harcosok";
            leker.ExecuteNonQuery();

            MySqlDataReader reader = leker.ExecuteReader();

            while (reader.Read())
            {
                nev = reader["nev"].ToString();
                ido = reader["letrehozas"].ToString();
                //string nevesido = nev + "-" + ido;
                harcosokListBox.Items.Add(nev);
                hasznaloComboBox.Items.Add(nev);
            }
            reader.Close();
        }

        private void hozzaad_Click_1(object sender, EventArgs e)
        {
            string harcos = hasznaloComboBox.Text;
            string kepesseg = kepessegNeveTextBox.Text;
            string leiras = leirasTextBox.Text;
            int harcos_id = 0;

            MySqlCommand leker = kapcsolat.CreateCommand();
            leker.CommandText = "SELECT id FROM harcosok WHERE nev = '" + harcos +"'";
            leker.ExecuteNonQuery();

            MySqlDataReader reader = leker.ExecuteReader();

            while (reader.Read())
            {
                harcos_id = Convert.ToInt32(reader["id"]);
            }
            reader.Close();

            MySqlCommand felvetel = kapcsolat.CreateCommand();
            felvetel.CommandText = "INSERT INTO kepessegek(nev,leiras,harcos_id) VALUES('" + kepesseg + "', '" + leiras + "', " + harcos_id + ")";
            felvetel.ExecuteNonQuery();
            
            MessageBox.Show(kepesseg +" nevű képesség sikeresen hozzárendelve "+ harcos +" harcoshoz.");
        }

        private void harcosokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string harcos = harcosokListBox.Text;
            int harcos_id = 0;

            MySqlCommand leker = kapcsolat.CreateCommand();
            leker.CommandText = "SELECT id FROM harcosok WHERE nev = '" + harcos + "'";
            leker.ExecuteNonQuery();

            MySqlDataReader reader = leker.ExecuteReader();

            while (reader.Read())
            {
                harcos_id = Convert.ToInt32(reader["id"]);
            }
            reader.Close();

            MySqlCommand leker2 = kapcsolat.CreateCommand();
            leker2.CommandText = "SELECT nev FROM kepessegek WHERE harcos_id = " + harcos_id + "";
            leker2.ExecuteNonQuery();

            MySqlDataReader reader2 = leker2.ExecuteReader();
            kepessegekListBox.Items.Clear();
            while (reader2.Read())
            {
                string nev = reader2["nev"].ToString();
                kepessegekListBox.Items.Add(nev);
            }
            reader2.Close();
        }

        private void kepessegekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kepesseg = kepessegekListBox.Text;
            int id = 0;

            MySqlCommand leker = kapcsolat.CreateCommand();
            leker.CommandText = "SELECT id FROM kepessegek WHERE nev = '" + kepesseg + "'";
            leker.ExecuteNonQuery();

            MySqlDataReader reader = leker.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["id"]);
            }
            reader.Close();

            
            MySqlCommand leker2 = kapcsolat.CreateCommand();
            leker2.CommandText = "SELECT leiras FROM kepessegek WHERE id = " + id + "";
            leker2.ExecuteNonQuery();

            MySqlDataReader reader2 = leker2.ExecuteReader();

            while (reader2.Read())
            {
                string leiras = reader2["leiras"].ToString();
                kepessegLeirasaTextBox.Text = leiras;
            }
            reader2.Close();
        }

        private void kepessegLeirasaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
