﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleList
{
    public partial class FrmListeSimple : Form
    {
        public FrmListeSimple()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LstItems.Items.Add("Marie");
            this.LstItems.Items.Add("Jean");
            this.LstItems.Items.Add("Pierre");
            this.LstItems.Items.Add("Julien");
            this.LstItems.Items.Add("François");
            this.LstItems.Items.Add("Helène");


        
        

    }

        private void LstItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LstItems_SelectedIndexChanged_1(object sender, EventArgs e)
        {
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {


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
    }
}
