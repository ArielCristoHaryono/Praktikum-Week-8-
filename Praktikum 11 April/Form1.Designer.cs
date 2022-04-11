namespace Praktikum_11_April
{
    partial class Form1
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
            this.labelVS = new System.Windows.Forms.Label();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.comboBoxHome = new System.Windows.Forms.ComboBox();
            this.lblManagerHome = new System.Windows.Forms.Label();
            this.lblMangerTeam = new System.Windows.Forms.Label();
            this.lblCaptainHome = new System.Windows.Forms.Label();
            this.lblCaptainTeam = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblKapasitas = new System.Windows.Forms.Label();
            this.lblManagerKiri = new System.Windows.Forms.Label();
            this.lblCaptainKiri = new System.Windows.Forms.Label();
            this.lblManagerKanan = new System.Windows.Forms.Label();
            this.lblCaptainKanan = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelKapasitas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVS
            // 
            this.labelVS.AutoSize = true;
            this.labelVS.Location = new System.Drawing.Point(363, 89);
            this.labelVS.Name = "labelVS";
            this.labelVS.Size = new System.Drawing.Size(31, 20);
            this.labelVS.TabIndex = 0;
            this.labelVS.Text = "VS";
            this.labelVS.Click += new System.EventHandler(this.labelVS_Click);
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(459, 81);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(204, 28);
            this.comboBoxTeam.TabIndex = 1;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            // 
            // comboBoxHome
            // 
            this.comboBoxHome.FormattingEnabled = true;
            this.comboBoxHome.Location = new System.Drawing.Point(66, 81);
            this.comboBoxHome.Name = "comboBoxHome";
            this.comboBoxHome.Size = new System.Drawing.Size(228, 28);
            this.comboBoxHome.TabIndex = 2;
            this.comboBoxHome.SelectedIndexChanged += new System.EventHandler(this.comboBoxHome_SelectedIndexChanged);
            // 
            // lblManagerHome
            // 
            this.lblManagerHome.AutoSize = true;
            this.lblManagerHome.Location = new System.Drawing.Point(62, 149);
            this.lblManagerHome.Name = "lblManagerHome";
            this.lblManagerHome.Size = new System.Drawing.Size(76, 20);
            this.lblManagerHome.TabIndex = 3;
            this.lblManagerHome.Text = "Manager:";
            // 
            // lblMangerTeam
            // 
            this.lblMangerTeam.AutoSize = true;
            this.lblMangerTeam.Location = new System.Drawing.Point(455, 149);
            this.lblMangerTeam.Name = "lblMangerTeam";
            this.lblMangerTeam.Size = new System.Drawing.Size(76, 20);
            this.lblMangerTeam.TabIndex = 4;
            this.lblMangerTeam.Text = "Manager:";
            // 
            // lblCaptainHome
            // 
            this.lblCaptainHome.AutoSize = true;
            this.lblCaptainHome.Location = new System.Drawing.Point(62, 200);
            this.lblCaptainHome.Name = "lblCaptainHome";
            this.lblCaptainHome.Size = new System.Drawing.Size(68, 20);
            this.lblCaptainHome.TabIndex = 5;
            this.lblCaptainHome.Text = "Captain:";
            // 
            // lblCaptainTeam
            // 
            this.lblCaptainTeam.AutoSize = true;
            this.lblCaptainTeam.Location = new System.Drawing.Point(455, 200);
            this.lblCaptainTeam.Name = "lblCaptainTeam";
            this.lblCaptainTeam.Size = new System.Drawing.Size(68, 20);
            this.lblCaptainTeam.TabIndex = 6;
            this.lblCaptainTeam.Text = "Captain:";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(271, 263);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(72, 20);
            this.lblStadium.TabIndex = 7;
            this.lblStadium.Text = "Stadium:";
            // 
            // lblKapasitas
            // 
            this.lblKapasitas.AutoSize = true;
            this.lblKapasitas.Location = new System.Drawing.Point(271, 311);
            this.lblKapasitas.Name = "lblKapasitas";
            this.lblKapasitas.Size = new System.Drawing.Size(83, 20);
            this.lblKapasitas.TabIndex = 8;
            this.lblKapasitas.Text = "Kapasitas:";
            // 
            // lblManagerKiri
            // 
            this.lblManagerKiri.AutoSize = true;
            this.lblManagerKiri.Location = new System.Drawing.Point(144, 149);
            this.lblManagerKiri.Name = "lblManagerKiri";
            this.lblManagerKiri.Size = new System.Drawing.Size(21, 20);
            this.lblManagerKiri.TabIndex = 9;
            this.lblManagerKiri.Text = "...";
            // 
            // lblCaptainKiri
            // 
            this.lblCaptainKiri.AutoSize = true;
            this.lblCaptainKiri.Location = new System.Drawing.Point(144, 200);
            this.lblCaptainKiri.Name = "lblCaptainKiri";
            this.lblCaptainKiri.Size = new System.Drawing.Size(21, 20);
            this.lblCaptainKiri.TabIndex = 10;
            this.lblCaptainKiri.Text = "...";
            // 
            // lblManagerKanan
            // 
            this.lblManagerKanan.AutoSize = true;
            this.lblManagerKanan.Location = new System.Drawing.Point(565, 149);
            this.lblManagerKanan.Name = "lblManagerKanan";
            this.lblManagerKanan.Size = new System.Drawing.Size(21, 20);
            this.lblManagerKanan.TabIndex = 11;
            this.lblManagerKanan.Text = "...";
            // 
            // lblCaptainKanan
            // 
            this.lblCaptainKanan.AutoSize = true;
            this.lblCaptainKanan.Location = new System.Drawing.Point(565, 200);
            this.lblCaptainKanan.Name = "lblCaptainKanan";
            this.lblCaptainKanan.Size = new System.Drawing.Size(21, 20);
            this.lblCaptainKanan.TabIndex = 12;
            this.lblCaptainKanan.Text = "...";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(363, 263);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(21, 20);
            this.labelStadium.TabIndex = 13;
            this.labelStadium.Text = "...";
            // 
            // labelKapasitas
            // 
            this.labelKapasitas.AutoSize = true;
            this.labelKapasitas.Location = new System.Drawing.Point(363, 311);
            this.labelKapasitas.Name = "labelKapasitas";
            this.labelKapasitas.Size = new System.Drawing.Size(21, 20);
            this.labelKapasitas.TabIndex = 14;
            this.labelKapasitas.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKapasitas);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.lblCaptainKanan);
            this.Controls.Add(this.lblManagerKanan);
            this.Controls.Add(this.lblCaptainKiri);
            this.Controls.Add(this.lblManagerKiri);
            this.Controls.Add(this.lblKapasitas);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblCaptainTeam);
            this.Controls.Add(this.lblCaptainHome);
            this.Controls.Add(this.lblMangerTeam);
            this.Controls.Add(this.lblManagerHome);
            this.Controls.Add(this.comboBoxHome);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.labelVS);
            this.Name = "Form1";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVS;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.ComboBox comboBoxHome;
        private System.Windows.Forms.Label lblManagerHome;
        private System.Windows.Forms.Label lblMangerTeam;
        private System.Windows.Forms.Label lblCaptainHome;
        private System.Windows.Forms.Label lblCaptainTeam;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblKapasitas;
        private System.Windows.Forms.Label lblManagerKiri;
        private System.Windows.Forms.Label lblCaptainKiri;
        private System.Windows.Forms.Label lblManagerKanan;
        private System.Windows.Forms.Label lblCaptainKanan;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelKapasitas;
    }
}

