namespace BackOfficeCommercial
{
    partial class BackOfficeCommercial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackOfficeCommercial));
            this.lbl_BackOfficeCommercial = new System.Windows.Forms.Label();
            this.pct_BackOfficeCommercial = new System.Windows.Forms.PictureBox();
            this.grb_BOCommercial = new System.Windows.Forms.GroupBox();
            this.btn_GestionComm = new System.Windows.Forms.Button();
            this.btn_GestionCli = new System.Windows.Forms.Button();
            this.btn_GestionProd = new System.Windows.Forms.Button();
            this.lbl_BOCommercialAuteurs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_BackOfficeCommercial)).BeginInit();
            this.grb_BOCommercial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_BackOfficeCommercial
            // 
            this.lbl_BackOfficeCommercial.AutoSize = true;
            this.lbl_BackOfficeCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BackOfficeCommercial.Location = new System.Drawing.Point(69, 9);
            this.lbl_BackOfficeCommercial.Name = "lbl_BackOfficeCommercial";
            this.lbl_BackOfficeCommercial.Size = new System.Drawing.Size(426, 29);
            this.lbl_BackOfficeCommercial.TabIndex = 0;
            this.lbl_BackOfficeCommercial.Text = "Gestion du Back Office Commercial";
            // 
            // pct_BackOfficeCommercial
            // 
            this.pct_BackOfficeCommercial.Image = ((System.Drawing.Image)(resources.GetObject("pct_BackOfficeCommercial.Image")));
            this.pct_BackOfficeCommercial.Location = new System.Drawing.Point(137, 51);
            this.pct_BackOfficeCommercial.Name = "pct_BackOfficeCommercial";
            this.pct_BackOfficeCommercial.Size = new System.Drawing.Size(301, 190);
            this.pct_BackOfficeCommercial.TabIndex = 1;
            this.pct_BackOfficeCommercial.TabStop = false;
            // 
            // grb_BOCommercial
            // 
            this.grb_BOCommercial.Controls.Add(this.btn_GestionProd);
            this.grb_BOCommercial.Controls.Add(this.btn_GestionCli);
            this.grb_BOCommercial.Controls.Add(this.btn_GestionComm);
            this.grb_BOCommercial.Location = new System.Drawing.Point(12, 258);
            this.grb_BOCommercial.Name = "grb_BOCommercial";
            this.grb_BOCommercial.Size = new System.Drawing.Size(529, 113);
            this.grb_BOCommercial.TabIndex = 2;
            this.grb_BOCommercial.TabStop = false;
            this.grb_BOCommercial.Text = "Opération à effectuer :";
            // 
            // btn_GestionComm
            // 
            this.btn_GestionComm.Location = new System.Drawing.Point(336, 34);
            this.btn_GestionComm.Name = "btn_GestionComm";
            this.btn_GestionComm.Size = new System.Drawing.Size(137, 45);
            this.btn_GestionComm.TabIndex = 2;
            this.btn_GestionComm.Text = "Gestion des commandes";
            this.btn_GestionComm.UseVisualStyleBackColor = true;
            this.btn_GestionComm.Click += new System.EventHandler(this.btn_GestionComm_Click);
            // 
            // btn_GestionCli
            // 
            this.btn_GestionCli.Location = new System.Drawing.Point(52, 34);
            this.btn_GestionCli.Name = "btn_GestionCli";
            this.btn_GestionCli.Size = new System.Drawing.Size(137, 45);
            this.btn_GestionCli.TabIndex = 3;
            this.btn_GestionCli.Text = "Gestion des produits";
            this.btn_GestionCli.UseVisualStyleBackColor = true;
            this.btn_GestionCli.Click += new System.EventHandler(this.btn_GestionCli_Click);
            // 
            // btn_GestionProd
            // 
            this.btn_GestionProd.Location = new System.Drawing.Point(193, 34);
            this.btn_GestionProd.Name = "btn_GestionProd";
            this.btn_GestionProd.Size = new System.Drawing.Size(137, 45);
            this.btn_GestionProd.TabIndex = 4;
            this.btn_GestionProd.Text = "Gestion des clients";
            this.btn_GestionProd.UseVisualStyleBackColor = true;
            this.btn_GestionProd.Click += new System.EventHandler(this.btn_GestionProd_Click);
            // 
            // lbl_BOCommercialAuteurs
            // 
            this.lbl_BOCommercialAuteurs.AutoSize = true;
            this.lbl_BOCommercialAuteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BOCommercialAuteurs.Location = new System.Drawing.Point(320, 397);
            this.lbl_BOCommercialAuteurs.Name = "lbl_BOCommercialAuteurs";
            this.lbl_BOCommercialAuteurs.Size = new System.Drawing.Size(222, 13);
            this.lbl_BOCommercialAuteurs.TabIndex = 3;
            this.lbl_BOCommercialAuteurs.Text = "Réalisé par François, Jérémy et Robin";
            // 
            // BackOfficeCommercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 414);
            this.Controls.Add(this.lbl_BOCommercialAuteurs);
            this.Controls.Add(this.grb_BOCommercial);
            this.Controls.Add(this.pct_BackOfficeCommercial);
            this.Controls.Add(this.lbl_BackOfficeCommercial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(570, 453);
            this.Name = "BackOfficeCommercial";
            this.Text = "Back Office Commercial";
            ((System.ComponentModel.ISupportInitialize)(this.pct_BackOfficeCommercial)).EndInit();
            this.grb_BOCommercial.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BackOfficeCommercial;
        private System.Windows.Forms.PictureBox pct_BackOfficeCommercial;
        private System.Windows.Forms.GroupBox grb_BOCommercial;
        private System.Windows.Forms.Button btn_GestionProd;
        private System.Windows.Forms.Button btn_GestionCli;
        private System.Windows.Forms.Button btn_GestionComm;
        private System.Windows.Forms.Label lbl_BOCommercialAuteurs;
    }
}

