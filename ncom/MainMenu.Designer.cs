namespace ncom
{
    partial class MainMenu
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
            this.conv_btn = new System.Windows.Forms.Button();
            this.basicops_btn = new System.Windows.Forms.Button();
            this.advops_btn = new System.Windows.Forms.Button();
            this.armfunc_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // conv_btn
            // 
            this.conv_btn.Location = new System.Drawing.Point(37, 103);
            this.conv_btn.Name = "conv_btn";
            this.conv_btn.Size = new System.Drawing.Size(189, 66);
            this.conv_btn.TabIndex = 0;
            this.conv_btn.Text = "Conversión";
            this.conv_btn.UseVisualStyleBackColor = true;
            this.conv_btn.Click += new System.EventHandler(this.Conv_btn_Click);
            // 
            // basicops_btn
            // 
            this.basicops_btn.Location = new System.Drawing.Point(37, 191);
            this.basicops_btn.Name = "basicops_btn";
            this.basicops_btn.Size = new System.Drawing.Size(189, 70);
            this.basicops_btn.TabIndex = 1;
            this.basicops_btn.Text = "Operaciones Básicas";
            this.basicops_btn.UseVisualStyleBackColor = true;
            this.basicops_btn.Click += new System.EventHandler(this.Basicops_btn_Click);
            // 
            // advops_btn
            // 
            this.advops_btn.Location = new System.Drawing.Point(37, 280);
            this.advops_btn.Name = "advops_btn";
            this.advops_btn.Size = new System.Drawing.Size(189, 66);
            this.advops_btn.TabIndex = 2;
            this.advops_btn.Text = "Operaciones Avanzadas";
            this.advops_btn.UseVisualStyleBackColor = true;
            this.advops_btn.Click += new System.EventHandler(this.Advops_btn_Click);
            // 
            // armfunc_btn
            // 
            this.armfunc_btn.Location = new System.Drawing.Point(37, 367);
            this.armfunc_btn.Name = "armfunc_btn";
            this.armfunc_btn.Size = new System.Drawing.Size(189, 66);
            this.armfunc_btn.TabIndex = 3;
            this.armfunc_btn.Text = "Funciones Armónicas";
            this.armfunc_btn.UseVisualStyleBackColor = true;
            this.armfunc_btn.Click += new System.EventHandler(this.Armfunc_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(37, 504);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(189, 66);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Salir";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(78, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menú";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(37, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 2);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(265, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 580);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(421, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bienvenido a NCOM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(281, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(517, 87);
            this.label5.TabIndex = 9;
            this.label5.Text = "Para continuar, seleccione la funcionalidad que\r\ndesee utilizar en el menú ubicad" +
    "o al\r\nextremo izquierdo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 582);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.armfunc_btn);
            this.Controls.Add(this.advops_btn);
            this.Controls.Add(this.basicops_btn);
            this.Controls.Add(this.conv_btn);
            this.Name = "MainMenu";
            this.Text = "NCOM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conv_btn;
        private System.Windows.Forms.Button basicops_btn;
        private System.Windows.Forms.Button advops_btn;
        private System.Windows.Forms.Button armfunc_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}