namespace TP4_conn
{
    partial class formTP4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_identifiant = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.textBox_identifiant = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.supprimer_button = new System.Windows.Forms.Button();
            this.modifier_button = new System.Windows.Forms.Button();
            this.rechercher_button = new System.Windows.Forms.Button();
            this.effacer_button = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_identifiant
            // 
            this.label_identifiant.AutoSize = true;
            this.label_identifiant.Location = new System.Drawing.Point(12, 9);
            this.label_identifiant.Name = "label_identifiant";
            this.label_identifiant.Size = new System.Drawing.Size(53, 13);
            this.label_identifiant.TabIndex = 0;
            this.label_identifiant.Text = "Identifiant";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(178, 9);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(29, 13);
            this.label_nom.TabIndex = 1;
            this.label_nom.Text = "Nom";
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Location = new System.Drawing.Point(342, 9);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(43, 13);
            this.label_prenom.TabIndex = 2;
            this.label_prenom.Text = "Prenom";
            // 
            // textBox_identifiant
            // 
            this.textBox_identifiant.Location = new System.Drawing.Point(70, 6);
            this.textBox_identifiant.Name = "textBox_identifiant";
            this.textBox_identifiant.Size = new System.Drawing.Size(100, 20);
            this.textBox_identifiant.TabIndex = 3;
            this.textBox_identifiant.TextChanged += new System.EventHandler(this.textBox_identifiant_TextChanged);
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(219, 6);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_nom.TabIndex = 4;
            this.textBox_nom.TextChanged += new System.EventHandler(this.textBox_nom_TextChanged);
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(392, 6);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(100, 20);
            this.textBox_prenom.TabIndex = 5;
            this.textBox_prenom.TextChanged += new System.EventHandler(this.textBox_prenom_TextChanged);
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(15, 80);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(75, 23);
            this.ajouter_button.TabIndex = 6;
            this.ajouter_button.Text = "Ajouter ";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.ajouter_button_Click);
            // 
            // supprimer_button
            // 
            this.supprimer_button.Location = new System.Drawing.Point(417, 80);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(75, 23);
            this.supprimer_button.TabIndex = 7;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = true;
            this.supprimer_button.Click += new System.EventHandler(this.supprimer_button_Click);
            // 
            // modifier_button
            // 
            this.modifier_button.Location = new System.Drawing.Point(291, 80);
            this.modifier_button.Name = "modifier_button";
            this.modifier_button.Size = new System.Drawing.Size(75, 23);
            this.modifier_button.TabIndex = 8;
            this.modifier_button.Text = "Modifier ";
            this.modifier_button.UseVisualStyleBackColor = true;
            this.modifier_button.Click += new System.EventHandler(this.modifier_button_Click);
            // 
            // rechercher_button
            // 
            this.rechercher_button.Location = new System.Drawing.Point(159, 80);
            this.rechercher_button.Name = "rechercher_button";
            this.rechercher_button.Size = new System.Drawing.Size(75, 23);
            this.rechercher_button.TabIndex = 9;
            this.rechercher_button.Text = "Rechercher ";
            this.rechercher_button.UseVisualStyleBackColor = true;
            this.rechercher_button.Click += new System.EventHandler(this.rechercher_button_Click);
            // 
            // effacer_button
            // 
            this.effacer_button.Location = new System.Drawing.Point(139, 172);
            this.effacer_button.Name = "effacer_button";
            this.effacer_button.Size = new System.Drawing.Size(254, 23);
            this.effacer_button.TabIndex = 10;
            this.effacer_button.Text = "Effacer";
            this.effacer_button.UseVisualStyleBackColor = true;
            this.effacer_button.Click += new System.EventHandler(this.effacer_button_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(452, 178);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(49, 24);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // formTP4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 214);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.effacer_button);
            this.Controls.Add(this.rechercher_button);
            this.Controls.Add(this.modifier_button);
            this.Controls.Add(this.supprimer_button);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.textBox_identifiant);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_identifiant);
            this.Name = "formTP4";
            this.Text = "formTP4";
            this.Load += new System.EventHandler(this.formTP4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_identifiant;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.TextBox textBox_identifiant;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.Button supprimer_button;
        private System.Windows.Forms.Button modifier_button;
        private System.Windows.Forms.Button rechercher_button;
        private System.Windows.Forms.Button effacer_button;
        private System.Windows.Forms.Button exitButton;
    }
}

