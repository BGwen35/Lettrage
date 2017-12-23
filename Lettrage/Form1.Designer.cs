namespace Lettrage
{
    partial class Form1
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
            this.txtListe = new System.Windows.Forms.TextBox();
            this.btnLettrage = new System.Windows.Forms.Button();
            this.txtCible = new System.Windows.Forms.NumericUpDown();
            this.lbltotalListe = new System.Windows.Forms.Label();
            this.txtTotalListe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAvancement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCible)).BeginInit();
            this.SuspendLayout();
            // 
            // txtListe
            // 
            this.txtListe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtListe.Location = new System.Drawing.Point(12, 46);
            this.txtListe.Multiline = true;
            this.txtListe.Name = "txtListe";
            this.txtListe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListe.Size = new System.Drawing.Size(170, 363);
            this.txtListe.TabIndex = 0;
            this.txtListe.TextChanged += new System.EventHandler(this.txtListe_TextChanged);
            // 
            // btnLettrage
            // 
            this.btnLettrage.Enabled = false;
            this.btnLettrage.Location = new System.Drawing.Point(319, 110);
            this.btnLettrage.Name = "btnLettrage";
            this.btnLettrage.Size = new System.Drawing.Size(151, 52);
            this.btnLettrage.TabIndex = 1;
            this.btnLettrage.Text = "Lettrer";
            this.btnLettrage.UseVisualStyleBackColor = true;
            this.btnLettrage.Click += new System.EventHandler(this.btnLettrage_Click);
            // 
            // txtCible
            // 
            this.txtCible.DecimalPlaces = 2;
            this.txtCible.Location = new System.Drawing.Point(319, 78);
            this.txtCible.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtCible.Name = "txtCible";
            this.txtCible.Size = new System.Drawing.Size(151, 20);
            this.txtCible.TabIndex = 2;
            this.txtCible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbltotalListe
            // 
            this.lbltotalListe.AutoSize = true;
            this.lbltotalListe.Location = new System.Drawing.Point(188, 64);
            this.lbltotalListe.Name = "lbltotalListe";
            this.lbltotalListe.Size = new System.Drawing.Size(31, 13);
            this.lbltotalListe.TabIndex = 3;
            this.lbltotalListe.Text = "Total";
            // 
            // txtTotalListe
            // 
            this.txtTotalListe.Location = new System.Drawing.Point(192, 80);
            this.txtTotalListe.Name = "txtTotalListe";
            this.txtTotalListe.ReadOnly = true;
            this.txtTotalListe.Size = new System.Drawing.Size(105, 20);
            this.txtTotalListe.TabIndex = 4;
            this.txtTotalListe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cible";
            // 
            // txtResultat
            // 
            this.txtResultat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultat.Location = new System.Drawing.Point(493, 46);
            this.txtResultat.Multiline = true;
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultat.Size = new System.Drawing.Size(181, 363);
            this.txtResultat.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Copier/coller ici les valeurs\r\n\r\nmettre un X devant ou derrière les valerus à exc" +
    "lure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Résultat";
            // 
            // lblAvancement
            // 
            this.lblAvancement.Location = new System.Drawing.Point(319, 165);
            this.lblAvancement.Name = "lblAvancement";
            this.lblAvancement.Size = new System.Drawing.Size(151, 24);
            this.lblAvancement.TabIndex = 9;
            this.lblAvancement.Text = "<- Ajouter des valeurs";
            this.lblAvancement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 421);
            this.Controls.Add(this.lblAvancement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalListe);
            this.Controls.Add(this.lbltotalListe);
            this.Controls.Add(this.txtCible);
            this.Controls.Add(this.btnLettrage);
            this.Controls.Add(this.txtListe);
            this.MinimumSize = new System.Drawing.Size(700, 0);
            this.Name = "Form1";
            this.Text = "Lettrage facile";
            ((System.ComponentModel.ISupportInitialize)(this.txtCible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListe;
        private System.Windows.Forms.Button btnLettrage;
        private System.Windows.Forms.NumericUpDown txtCible;
        private System.Windows.Forms.Label lbltotalListe;
        private System.Windows.Forms.TextBox txtTotalListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAvancement;
    }
}

