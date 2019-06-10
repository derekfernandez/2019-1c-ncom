namespace ncom
{
    partial class BasicOps
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
            this.add_rad = new System.Windows.Forms.RadioButton();
            this.sub_rad = new System.Windows.Forms.RadioButton();
            this.prod_rad = new System.Windows.Forms.RadioButton();
            this.div_rad = new System.Windows.Forms.RadioButton();
            this.back_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.complex1_entry = new System.Windows.Forms.TextBox();
            this.complex2_entry = new System.Windows.Forms.TextBox();
            this.res_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.res_entry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una operación";
            // 
            // add_rad
            // 
            this.add_rad.AutoSize = true;
            this.add_rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.add_rad.Location = new System.Drawing.Point(17, 107);
            this.add_rad.Name = "add_rad";
            this.add_rad.Size = new System.Drawing.Size(106, 33);
            this.add_rad.TabIndex = 1;
            this.add_rad.TabStop = true;
            this.add_rad.Text = "Suma";
            this.add_rad.UseVisualStyleBackColor = true;
            // 
            // sub_rad
            // 
            this.sub_rad.AutoSize = true;
            this.sub_rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sub_rad.Location = new System.Drawing.Point(17, 158);
            this.sub_rad.Name = "sub_rad";
            this.sub_rad.Size = new System.Drawing.Size(106, 33);
            this.sub_rad.TabIndex = 2;
            this.sub_rad.TabStop = true;
            this.sub_rad.Text = "Resta";
            this.sub_rad.UseVisualStyleBackColor = true;
            // 
            // prod_rad
            // 
            this.prod_rad.AutoSize = true;
            this.prod_rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.prod_rad.Location = new System.Drawing.Point(17, 213);
            this.prod_rad.Name = "prod_rad";
            this.prod_rad.Size = new System.Drawing.Size(191, 33);
            this.prod_rad.TabIndex = 3;
            this.prod_rad.TabStop = true;
            this.prod_rad.Text = "Multiplicación";
            this.prod_rad.UseVisualStyleBackColor = true;
            // 
            // div_rad
            // 
            this.div_rad.AutoSize = true;
            this.div_rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.div_rad.Location = new System.Drawing.Point(17, 268);
            this.div_rad.Name = "div_rad";
            this.div_rad.Size = new System.Drawing.Size(129, 33);
            this.div_rad.TabIndex = 4;
            this.div_rad.TabStop = true;
            this.div_rad.Text = "División";
            this.div_rad.UseVisualStyleBackColor = true;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(8, 368);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(297, 46);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Regresar";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(311, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 465);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(319, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingrese un número complejo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(319, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ingrese otro número complejo";
            // 
            // complex1_entry
            // 
            this.complex1_entry.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.complex1_entry.Location = new System.Drawing.Point(319, 85);
            this.complex1_entry.Name = "complex1_entry";
            this.complex1_entry.Size = new System.Drawing.Size(464, 31);
            this.complex1_entry.TabIndex = 9;
            this.complex1_entry.Text = "Ejemplo: (1 ; 0)";
            this.complex1_entry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.complex1_entry.Enter += new System.EventHandler(this.Complex1_entry_Enter);
            // 
            // complex2_entry
            // 
            this.complex2_entry.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.complex2_entry.Location = new System.Drawing.Point(319, 203);
            this.complex2_entry.Name = "complex2_entry";
            this.complex2_entry.Size = new System.Drawing.Size(464, 31);
            this.complex2_entry.TabIndex = 10;
            this.complex2_entry.Text = "Ejemplo: [1 ; 0]";
            this.complex2_entry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.complex2_entry.Enter += new System.EventHandler(this.Complex2_entry_Enter);
            // 
            // res_btn
            // 
            this.res_btn.Location = new System.Drawing.Point(324, 294);
            this.res_btn.Name = "res_btn";
            this.res_btn.Size = new System.Drawing.Size(459, 45);
            this.res_btn.TabIndex = 11;
            this.res_btn.Text = "Consultar";
            this.res_btn.UseVisualStyleBackColor = true;
            this.res_btn.Click += new System.EventHandler(this.Res_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(319, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Resultado:";
            // 
            // res_entry
            // 
            this.res_entry.Location = new System.Drawing.Point(447, 385);
            this.res_entry.Name = "res_entry";
            this.res_entry.ReadOnly = true;
            this.res_entry.Size = new System.Drawing.Size(336, 31);
            this.res_entry.TabIndex = 13;
            // 
            // BasicOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.res_entry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.res_btn);
            this.Controls.Add(this.complex2_entry);
            this.Controls.Add(this.complex1_entry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.div_rad);
            this.Controls.Add(this.prod_rad);
            this.Controls.Add(this.sub_rad);
            this.Controls.Add(this.add_rad);
            this.Controls.Add(this.label1);
            this.Name = "BasicOps";
            this.Text = "Operaciones Básicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton add_rad;
        private System.Windows.Forms.RadioButton sub_rad;
        private System.Windows.Forms.RadioButton prod_rad;
        private System.Windows.Forms.RadioButton div_rad;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox complex1_entry;
        private System.Windows.Forms.TextBox complex2_entry;
        private System.Windows.Forms.Button res_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox res_entry;
    }
}