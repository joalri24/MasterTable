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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 54);
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
            this.textBoxRRHH.Location = new System.Drawing.Point(90, 47);
            this.textBoxRRHH.Name = "textBoxRRHH";
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
            this.ButtonCorrer.Location = new System.Drawing.Point(385, 184);
            this.ButtonCorrer.Name = "ButtonCorrer";
            this.ButtonCorrer.Size = new System.Drawing.Size(75, 23);
            this.ButtonCorrer.TabIndex = 3;
            this.ButtonCorrer.Text = "Obtener csv";
            this.ButtonCorrer.UseVisualStyleBackColor = true;
            this.ButtonCorrer.Click += new System.EventHandler(this.ButtonCorrer_Click);
            // 
            // buttonCargarFS
            // 
            this.buttonCargarFS.Location = new System.Drawing.Point(268, 70);
            this.buttonCargarFS.Name = "buttonCargarFS";
            this.buttonCargarFS.Size = new System.Drawing.Size(75, 23);
            this.buttonCargarFS.TabIndex = 6;
            this.buttonCargarFS.Text = "Cargar";
            this.buttonCargarFS.UseVisualStyleBackColor = true;
            this.buttonCargarFS.Click += new System.EventHandler(this.buttonCargarFS_Click);
            // 
            // textBoxFS
            // 
            this.textBoxFS.Location = new System.Drawing.Point(90, 73);
            this.textBoxFS.Name = "textBoxFS";
            this.textBoxFS.Size = new System.Drawing.Size(163, 20);
            this.textBoxFS.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD-FS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 261);
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
    }
}

