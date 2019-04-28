using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TP4_conn
{
    class gestionEtudiant : interfaceGestionEtudiant
    {
        MySqlConnection conn;
        MySqlConnection connexion()
        {
            conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=mouheb;");
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                    MessageBox.Show("Connection établie");
                    return conn;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Probleme de connexion");
                return null;
            }
            //-----------------------
            return conn;
        }
        //----------------------------------------------------------------------
        public void ajouterEtudiant(etudiant e)
        {
            conn = connexion();
            MySqlCommand cmd = new MySqlCommand("insert into myTable (id,nom,prenom) values (@id , @nom, @prenom)", conn);

            cmd.Parameters.AddWithValue("@id", e.ID);
            cmd.Parameters.AddWithValue("@nom", e.NOM);
            cmd.Parameters.AddWithValue("@prenom", e.PRENOM);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Ajouter");
            conn.Close();
        }
        //----------------------------------------------------------------
        public void supprimeEtudiant(etudiant e)
        {
            conn = connexion();
            MySqlCommand cmd = new MySqlCommand("delet form myTable wher id=@id ", conn);
            cmd.Parameters.AddWithValue("@id", e.ID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("supprimer");
            conn.Close();
        }

        //-----------------------------------------------------------------------------
        public void rechercherEtudiant(etudiant e)
        {
            etudiant e_ch = new etudiant();
            conn = connexion();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM myTable where id=@id ", conn);
            cmd.Parameters.AddWithValue("@id", e.ID);
            using (MySqlDataReader lire = cmd.ExecuteReader())
            {
                if (lire.HasRows)
                {
                    while (lire.Read())
                    {
                        e_ch.NOM = lire["nom"].ToString();
                        e_ch.PRENOM = lire["prenom"].ToString();
                    }
                    lire.Close();
                }
                else
                {
                    MessageBox.Show("l'etudiant n'existe pas dans la base");
                }
                conn.Close();

            }
        }
        //-----------------------------------------------------------------------------




        public void supprimerEtudiant(etudiant e)
        {
            throw new NotImplementedException();
        }
    }
}