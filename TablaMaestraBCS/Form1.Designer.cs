namespace TablaMaestraBCS
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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxRRHH = new System.Windows.Forms.TextBox();
            this.buttonCargarRRHH = new System.Windows.Forms.Button();
            this.ButtonCorrer = new System.Windows.Forms.Button();
            this.buttonCargarFS = new System.Windows.Forms.Button();
            this.textBoxFS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCargarOFBCSC = new System.Windows.Forms.Button();
            this.textBoxOFCBC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxARP = new System.Windows.Forms.TextBox();
            this.buttonCargarARP = new System.Windows.Forms.Button();
            this.buttonCargarTemps = new System.Windows.Forms.Button();
            this.textBoxTemps = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RRHH";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxRRHH
            // 
            this.textBoxRRHH.Enabled = false;
            this.textBoxRRHH.Location = new System.Drawing.Point(90, 47);
            this.textBoxRRHH.Name = "textBoxRRHH";
            this.textBoxRRHH.ReadOnly = true;
            this.textBoxRRHH.Size = new System.Drawing.Size(163, 20);
            this.textBoxRRHH.TabIndex = 1;
            // 
            // buttonCargarRRHH
            // 
            this.buttonCargarRRHH.Location = new System.Drawing.Point(268, 44);
            this.buttonCargarRRHH.Name = "buttonCargarRRHH";
            this.buttonCargarRRHH.Size = new System.Drawing.Size(75, 23);
            this.buttonCargarRRHH.TabIndex = 2;
            this.buttonCargarRRHH.Text = "Cargar";
            this.buttonCargarRRHH.UseVisualStyleBackColor = true;
            this.buttonCargarRRHH.Click += new System.EventHandler(this.buttonCargarRRHH_Click);
            // 
            // ButtonCorrer
            // 
            this.ButtonCorrer.Location = new System.Drawing.Point(148, 207);
            this.ButtonCorrer.Name = "ButtonCorrer";
            this.ButtonCorrer.Size = new System.Drawing.Size(75, 23);
            this.ButtonCorrer.TabIndex = 3;
            this.ButtonCorrer.Text = "Obtener csv";
            this.ButtonCorrer.UseVisualStyleBackColor = true;
            this.ButtonCorrer.Click += new System.EventHandler(this.ButtonCorrer_Click);
            // 
            // buttonCargarFS
            // 
            this.buttonCargarFS.Location = new System.Drawing.Point(268, 96);
            this.buttonCargarFS.Name = "buttonCargarFS";
            this.buttonCargarFS.Size = new System.Drawing.Size(75, 23);
            this.buttonCargarFS.TabIndex = 6;
            this.buttonCargarFS.Text = "Cargar";
            this.buttonCargarFS.UseVisualStyleBackColor = true;
            this.buttonCargarFS.Click += new System.EventHandler(this.buttonCargarFS_Click);
            // 
            // textBoxFS
            // 
            this.textBoxFS.Enabled = false;
            this.textBoxFS.Location = new System.Drawing.Point(90, 99);
            this.textBoxFS.Name = "textBoxFS";
            this.textBoxFS.ReadOnly = true;
            this.textBoxFS.Size = new System.Drawing.Size(163, 20);
            this.textBoxFS.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD-FS";
            // 
            // buttonCargarOFBCSC
            // 
            this.buttonCargarOFBCSC.Location = new System.Drawing.Point(268, 122);
            this.buttonCargarOFBCSC.Name = "buttonCargarOFBCSC";
            this.buttonCargarOFBCSC.Size = new System.Drawing.Size(75, 23);
            this.buttonCargarOFBCSC.TabIndex = 9;
            this.buttonCargarOFBCSC.Text = "Cargar";
            this.buttonCargarOFBCSC.UseVisualStyleBackColor = true;
            this.buttonCargarOFBCSC.Click += new System.EventHandler(this.buttonCargarOFBCSC_Click);
            // 
            // textBoxOFCBC
            // 
            this.textBoxOFCBC.Enabled = false;
            this.textBoxOFCBC.Location = new System.Drawing.Point(90, 125);
            this.textBoxOFCBC.Name = "textBoxOFCBC";
            this.textBoxOFCBC.ReadOnly = true;
            this.textBoxOFCBC.Size = new System.Drawing.Size(163, 20);
            this.textBoxOFCBC.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "AD-OFBCSC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "AD-ARP";
            // 
            // textBoxARP
            // 
            this.textBoxARP.Enabled = false;
            this.textBoxARP.Location = new System.Drawing.Point(90, 154);
            this.textBoxARP.Name = "textBoxARP";
            this.textBoxARP.ReadOnly = true;
            this.textBoxARP.Size = new System.Drawing.Size(163, 20);
            this.textBoxARP.TabIndex = 8;
            // 
            // buttonCargarARP
            // 
            this.buttonCargarARP.Location = new System.Drawing.Point(268, 151);
            this.buttonCargarARP.Name = "buttonCargarARP";
            this.buttonCargarARP.Size = new System.Drawing.Size(75, 23);
            this.buttonCargarARP.TabIndex = 9;
            this.buttonCargarARP.Text = "Cargar";
            this.buttonCargarARP.UseVisualStyleBackColor = true;
            this.buttonCargarARP.Click += new System.EventHandler(this.buttonCargarARP_Click);
            // 
            // buttonCargarTemps
            // 
            this.buttonCargarTemps.Location = new System.Drawing.Point(268, 70);
            this.buttonCargarTemps.Name = "buttonCargarTemps";
            this.buttonCargarTemps.Size = new System.Drawing.Size(75, 23);
            this.buttonCargarTemps.TabIndex = 12;
            this.buttonCargarTemps.Text = "Cargar";
            this.buttonCargarTemps.UseVisualStyleBackColor = true;
            this.buttonCargarTemps.Click += new System.EventHandler(this.buttonCargarTemps_Click);
            // 
            // textBoxTemps
            // 
            this.textBoxTemps.Enabled = false;
            this.textBoxTemps.Location = new System.Drawing.Point(90, 73);
            this.textBoxTemps.Name = "textBoxTemps";
            this.textBoxTemps.ReadOnly = true;
            this.textBoxTemps.Size = new System.Drawing.Size(163, 20);
            this.textBoxTemps.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "TEMPORALES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 261);
            this.Controls.Add(this.buttonCargarTemps);
            this.Controls.Add(this.textBoxTemps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCargarARP);
            this.Controls.Add(this.textBoxARP);
            this.Controls.Add(this.buttonCargarOFBCSC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOFCBC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCargarFS);
            this.Controls.Add(this.textBoxFS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonCorrer);
            this.Controls.Add(this.buttonCargarRRHH);
            this.Controls.Add(this.textBoxRRHH);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxRRHH;
        private System.Windows.Forms.Button buttonCargarRRHH;
        private System.Windows.Forms.Button ButtonCorrer;
        private System.Windows.Forms.Button buttonCargarFS;
        private System.Windows.Forms.TextBox textBoxFS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCargarOFBCSC;
        private System.Windows.Forms.TextBox textBoxOFCBC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxARP;
        private System.Windows.Forms.Button buttonCargarARP;
        private System.Windows.Forms.Button buttonCargarTemps;
        private System.Windows.Forms.TextBox textBoxTemps;
        private System.Windows.Forms.Label label5;
    }
}

