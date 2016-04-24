namespace simpleList
{
    partial class FrmListeSimple
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnMultiple = new System.Windows.Forms.RadioButton();
            this.radioBtnEtendue = new System.Windows.Forms.RadioButton();
            this.radioBtnSimple = new System.Windows.Forms.RadioButton();
            this.ChkLocked = new System.Windows.Forms.CheckBox();
            this.BtnAffiche = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtSaisie = new System.Windows.Forms.TextBox();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.LstItems = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnMultiple);
            this.groupBox1.Controls.Add(this.radioBtnEtendue);
            this.groupBox1.Controls.Add(this.radioBtnSimple);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de sélection";
            // 
            // radioBtnMultiple
            // 
            this.radioBtnMultiple.AutoSize = true;
            this.radioBtnMultiple.Location = new System.Drawing.Point(20, 65);
            this.radioBtnMultiple.Name = "radioBtnMultiple";
            this.radioBtnMultiple.Size = new System.Drawing.Size(77, 21);
            this.radioBtnMultiple.TabIndex = 2;
            this.radioBtnMultiple.TabStop = true;
            this.radioBtnMultiple.Text = "Multiple";
            this.radioBtnMultiple.UseVisualStyleBackColor = true;
            this.radioBtnMultiple.Click += new System.EventHandler(this.RadioBtnStatus);
            // 
            // radioBtnEtendue
            // 
            this.radioBtnEtendue.AutoSize = true;
            this.radioBtnEtendue.Location = new System.Drawing.Point(20, 92);
            this.radioBtnEtendue.Name = "radioBtnEtendue";
            this.radioBtnEtendue.Size = new System.Drawing.Size(82, 21);
            this.radioBtnEtendue.TabIndex = 1;
            this.radioBtnEtendue.TabStop = true;
            this.radioBtnEtendue.Text = "Etendue";
            this.radioBtnEtendue.UseVisualStyleBackColor = true;
            this.radioBtnEtendue.Click += new System.EventHandler(this.RadioBtnStatus);
            // 
            // radioBtnSimple
            // 
            this.radioBtnSimple.AutoSize = true;
            this.radioBtnSimple.Location = new System.Drawing.Point(20, 38);
            this.radioBtnSimple.Name = "radioBtnSimple";
            this.radioBtnSimple.Size = new System.Drawing.Size(71, 21);
            this.radioBtnSimple.TabIndex = 0;
            this.radioBtnSimple.TabStop = true;
            this.radioBtnSimple.Text = "Simple";
            this.radioBtnSimple.UseVisualStyleBackColor = true;
            this.radioBtnSimple.Click += new System.EventHandler(this.RadioBtnStatus);
            // 
            // ChkLocked
            // 
            this.ChkLocked.AutoSize = true;
            this.ChkLocked.Location = new System.Drawing.Point(33, 191);
            this.ChkLocked.Name = "ChkLocked";
            this.ChkLocked.Size = new System.Drawing.Size(132, 21);
            this.ChkLocked.TabIndex = 1;
            this.ChkLocked.Text = "Liste Verrouillée";
            this.ChkLocked.UseVisualStyleBackColor = true;
            this.ChkLocked.CheckedChanged += new System.EventHandler(this.ChkLocked_CheckedChanged);
            // 
            // BtnAffiche
            // 
            this.BtnAffiche.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAffiche.Enabled = false;
            this.BtnAffiche.Location = new System.Drawing.Point(33, 241);
            this.BtnAffiche.Name = "BtnAffiche";
            this.BtnAffiche.Size = new System.Drawing.Size(174, 30);
            this.BtnAffiche.TabIndex = 2;
            this.BtnAffiche.Text = "Afficher la sélection";
            this.BtnAffiche.UseVisualStyleBackColor = false;
            this.BtnAffiche.Click += new System.EventHandler(this.BtnAffiche_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Location = new System.Drawing.Point(33, 291);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(174, 30);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Supprimer la séléction";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtSaisie
            // 
            this.TxtSaisie.Location = new System.Drawing.Point(325, 291);
            this.TxtSaisie.Name = "TxtSaisie";
            this.TxtSaisie.Size = new System.Drawing.Size(314, 22);
            this.TxtSaisie.TabIndex = 5;
            this.TxtSaisie.TextChanged += new System.EventHandler(this.TxtSaisie_TextChanged);
            this.TxtSaisie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSaisie_KeyUp);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Enabled = false;
            this.BtnAjouter.ForeColor = System.Drawing.Color.Black;
            this.BtnAjouter.Location = new System.Drawing.Point(391, 319);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(163, 23);
            this.BtnAjouter.TabIndex = 6;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // LstItems
            // 
            this.LstItems.FormattingEnabled = true;
            this.LstItems.ItemHeight = 16;
            this.LstItems.Location = new System.Drawing.Point(325, 11);
            this.LstItems.Name = "LstItems";
            this.LstItems.Size = new System.Drawing.Size(314, 260);
            this.LstItems.TabIndex = 7;
            this.LstItems.SelectedIndexChanged += new System.EventHandler(this.disableAfficher);
            this.LstItems.SelectedValueChanged += new System.EventHandler(this.LstItems_SelectedValueChanged);
            // 
            // FrmListeSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(650, 373);
            this.Controls.Add(this.LstItems);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.TxtSaisie);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAffiche);
            this.Controls.Add(this.ChkLocked);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmListeSimple";
            this.Text = "FrmListeSimple";
            this.Load += new System.EventHandler(this.FrmListe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnMultiple;
        private System.Windows.Forms.RadioButton radioBtnEtendue;
        private System.Windows.Forms.RadioButton radioBtnSimple;
        private System.Windows.Forms.CheckBox ChkLocked;
        private System.Windows.Forms.Button BtnAffiche;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtSaisie;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LstItems;
    }
}

