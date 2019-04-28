using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_conn
{
    public partial class formTP4 : Form
    {
        public formTP4()
        {
            InitializeComponent();
        }

        private void formTP4_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.Orange;
            this.Location = new Point(300, 300);
            this.MaximizeBox = true;
        }

        private void textBox_identifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_prenom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ajouter_button_Click(object sender, EventArgs e)
        {
            try {
                int id = int.Parse(textBox_identifiant.Text);
                etudiant e_ajouter = new etudiant
                (id, textBox_nom.Text, textBox_prenom.Text);
                gestionEtudiant ec = new gestionEtudiant();
                ec.ajouterEtudiant(e_ajouter);
            }


            catch (Exception ex){
    MessageBox.Show (ex.Message);
    MessageBox.Show("it's not a number");}
        }
        

        private void rechercher_button_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox_identifiant.Text);
                etudiant e_chercher = new etudiant(id);

                gestionEtudiant ec = new gestionEtudiant();
                ec.rechercherEtudiant(e_chercher);
                //  etudiant e_ch = ec.chercherEtudiant(e_chercher);
                textBox_nom.Text = e_chercher.NOM;
                textBox_prenom.Text = e_chercher.PRENOM;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("it's not a number");
            }
        }

        private void modifier_button_Click(object sender, EventArgs e)
        {

        }

        private void supprimer_button_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox_identifiant.Text);
                etudiant e_supprimer = new etudiant(id);
                gestionEtudiant em = new gestionEtudiant();
                em.supprimeEtudiant(e_supprimer);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("it's not a number");
            }
        }

        private void effacer_button_Click(object sender, EventArgs e)
        {
            textBox_identifiant.Clear();
            textBox_nom.Clear();
            textBox_prenom.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
