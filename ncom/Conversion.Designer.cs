namespace ncom
{
    partial class Conversion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.binompolar_btn = new System.Windows.Forms.Button();
            this.backbinompolar_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.resbinompolar_entry = new System.Windows.Forms.TextBox();
            this.im_entry = new System.Windows.Forms.TextBox();
            this.real_entry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.polarbinom_btn = new System.Windows.Forms.Button();
            this.backpolarbinom_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.respolarbinom_entry = new System.Windows.Forms.TextBox();
            this.arg_entry = new System.Windows.Forms.TextBox();
            this.mod_entry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.binompolar_btn);
            this.tabPage1.Controls.Add(this.backbinompolar_btn);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.resbinompolar_entry);
            this.tabPage1.Controls.Add(this.im_entry);
            this.tabPage1.Controls.Add(this.real_entry);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Binómica a Polar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // binompolar_btn
            // 
            this.binompolar_btn.Location = new System.Drawing.Point(486, 68);
            this.binompolar_btn.Name = "binompolar_btn";
            this.binompolar_btn.Size = new System.Drawing.Size(169, 46);
            this.binompolar_btn.TabIndex = 17;
            this.binompolar_btn.Text = "Convertir";
            this.binompolar_btn.UseVisualStyleBackColor = true;
            this.binompolar_btn.Click += new System.EventHandler(this.Binompolar_btn_Click);
            // 
            // backbinompolar_btn
            // 
            this.backbinompolar_btn.Location = new System.Drawing.Point(46, 188);
            this.backbinompolar_btn.Name = "backbinompolar_btn";
            this.backbinompolar_btn.Size = new System.Drawing.Size(169, 46);
            this.backbinompolar_btn.TabIndex = 16;
            this.backbinompolar_btn.Text = "Regresar";
            this.backbinompolar_btn.UseVisualStyleBackColor = true;
            this.backbinompolar_btn.Click += new System.EventHandler(this.Backbinompolar_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(481, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Resultado";
            // 
            // resbinompolar_entry
            // 
            this.resbinompolar_entry.Location = new System.Drawing.Point(486, 203);
            this.resbinompolar_entry.Name = "resbinompolar_entry";
            this.resbinompolar_entry.Size = new System.Drawing.Size(194, 31);
            this.resbinompolar_entry.TabIndex = 14;
            // 
            // im_entry
            // 
            this.im_entry.Location = new System.Drawing.Point(260, 83);
            this.im_entry.Name = "im_entry";
            this.im_entry.Size = new System.Drawing.Size(169, 31);
            this.im_entry.TabIndex = 13;
            // 
            // real_entry
            // 
            this.real_entry.Location = new System.Drawing.Point(46, 83);
            this.real_entry.Name = "real_entry";
            this.real_entry.Size = new System.Drawing.Size(169, 31);
            this.real_entry.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(255, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Parte Imaginaria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(41, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Parte Real";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.polarbinom_btn);
            this.tabPage2.Controls.Add(this.backpolarbinom_btn);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.respolarbinom_entry);
            this.tabPage2.Controls.Add(this.arg_entry);
            this.tabPage2.Controls.Add(this.mod_entry);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Polar a Binómica";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // polarbinom_btn
            // 
            this.polarbinom_btn.Location = new System.Drawing.Point(495, 75);
            this.polarbinom_btn.Name = "polarbinom_btn";
            this.polarbinom_btn.Size = new System.Drawing.Size(169, 46);
            this.polarbinom_btn.TabIndex = 8;
            this.polarbinom_btn.Text = "Convertir";
            this.polarbinom_btn.UseVisualStyleBackColor = true;
            this.polarbinom_btn.Click += new System.EventHandler(this.Polarbinom_btn_Click);
            // 
            // backpolarbinom_btn
            // 
            this.backpolarbinom_btn.Location = new System.Drawing.Point(29, 183);
            this.backpolarbinom_btn.Name = "backpolarbinom_btn";
            this.backpolarbinom_btn.Size = new System.Drawing.Size(169, 46);
            this.backpolarbinom_btn.TabIndex = 7;
            this.backpolarbinom_btn.Text = "Regresar";
            this.backpolarbinom_btn.UseVisualStyleBackColor = true;
            this.backpolarbinom_btn.Click += new System.EventHandler(this.Backpolarbinom_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(490, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // respolarbinom_entry
            // 
            this.respolarbinom_entry.Location = new System.Drawing.Point(495, 198);
            this.respolarbinom_entry.Name = "respolarbinom_entry";
            this.respolarbinom_entry.Size = new System.Drawing.Size(194, 31);
            this.respolarbinom_entry.TabIndex = 5;
            // 
            // arg_entry
            // 
            this.arg_entry.Location = new System.Drawing.Point(243, 83);
            this.arg_entry.Name = "arg_entry";
            this.arg_entry.Size = new System.Drawing.Size(169, 31);
            this.arg_entry.TabIndex = 3;
            // 
            // mod_entry
            // 
            this.mod_entry.Location = new System.Drawing.Point(29, 83);
            this.mod_entry.Name = "mod_entry";
            this.mod_entry.Size = new System.Drawing.Size(169, 31);
            this.mod_entry.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(238, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Argumento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Módulo";
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.tabControl1);
            this.Name = "Conversion";
            this.Text = "Conversion";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button binompolar_btn;
        private System.Windows.Forms.Button backbinompolar_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resbinompolar_entry;
        private System.Windows.Forms.TextBox im_entry;
        private System.Windows.Forms.TextBox real_entry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button polarbinom_btn;
        private System.Windows.Forms.Button backpolarbinom_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox respolarbinom_entry;
        private System.Windows.Forms.TextBox arg_entry;
        private System.Windows.Forms.TextBox mod_entry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}