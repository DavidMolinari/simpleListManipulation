using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using System.Windows.Forms;

namespace simpleList
{
    public partial class FrmListeSimple : Form
    {
        string Meh;

        public FrmListeSimple()
        {
            InitializeComponent();
        }

        private void FrmListe_Load(object sender, EventArgs e)
        {
            this.LstItems.Items.Add("Marie");
            this.LstItems.Items.Add("Jean");
            this.LstItems.Items.Add("Pierre");
            this.LstItems.Items.Add("Julien");
            this.LstItems.Items.Add("François");
            this.LstItems.Items.Add("Helène");
            this.ActiveControl = TxtSaisie;

           
        }


        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TxtSaisie.Text))
                MessageBox.Show("Veuillez renseigner le champ avant d'ajouter !!");
            else
            {
                this.LstItems.Items.Add(this.TxtSaisie.Text);
                this.TxtSaisie.Clear();
            }
        }




        private void RadioBtnStatus(object sender, EventArgs e)
        {


            if (this.radioBtnEtendue.Checked)
            {
                this.LstItems.ClearSelected();
                this.LstItems.SelectionMode = SelectionMode.MultiExtended;
            }
            if (this.radioBtnMultiple.Checked)
            {
                this.LstItems.ClearSelected();
                this.LstItems.SelectionMode = SelectionMode.MultiSimple;
            }
            if (this.radioBtnSimple.Checked)
            {
                this.LstItems.ClearSelected();
                this.LstItems.SelectionMode = SelectionMode.One;
            }

        }

        private void ChkLocked_CheckedChanged(object sender, EventArgs e)
        {
            bool btnChecked = ChkLocked.CheckState == CheckState.Checked;
            // Si Le Chk est Checked, je verouille, autrement, je laisse en normal.
            if (!(btnChecked))
            {
                this.LstItems.SelectionMode = SelectionMode.One;
            }
            else this.LstItems.SelectionMode = SelectionMode.None;
        }

        private void BtnAffiche_Click(object sender, EventArgs e)
        {

            // Parcours des Items Selectionnés , et affichage dans une messageBox
            // Assez Inutile, mais Meh
            foreach (var item in LstItems.SelectedItems)
            {
                Meh += item.ToString() + " ";
            }
            MessageBox.Show(Meh);

        }
        /// <summary>
        /// Méthode pour supprimer tous les items séléctionnés 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {

            while (LstItems.SelectedItems.Count > 0)
            {
                LstItems.Items.Remove(LstItems.SelectedItems[0]);
            }
        }
        /// <summary>
        /// Fonction perso Pour Changer le status des boutons en fonction des éléments selectionnés.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void disableAfficher(object sender, EventArgs e)
        {
            if (LstItems.SelectedItems.Count > 0)
            {
                this.BtnAffiche.Enabled = true;
                this.BtnDelete.Enabled = true;
            }
            else {
                this.BtnAffiche.Enabled = false;
                this.BtnDelete.Enabled = false;
            }

        }

        /// <summary>
        /// Evênements Shortcuts
        /// KeyUp Entrer renvoie sur BtnAjouter
        /// KeyUp Delete renvoie sur BtnDelete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSaisie_KeyUp(object sender, KeyEventArgs e)
        {

            // Si j'appuie sur Entrer, j'ajoute un élément dans la liste.
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnAjouter_Click(null, null);
                                this.BtnDelete_Click(null, null);

            }

            // Raccourcit Supprimer


            
        }

        private void TxtSaisie_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TxtSaisie.Text))
            {
                this.BtnAjouter.Enabled = false;
            }
            else this.BtnAjouter.Enabled = true;


        }

        private void LstItems_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
