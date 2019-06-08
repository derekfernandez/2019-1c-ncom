namespace ncom
{
    partial class AdvancedOps
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
            this.label2 = new System.Windows.Forms.Label();
            this.pow_rad = new System.Windows.Forms.RadioButton();
            this.rt_rad = new System.Windows.Forms.RadioButton();
            this.roots_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.complex_entry = new System.Windows.Forms.TextBox();
            this.index_entry = new System.Windows.Forms.TextBox();
            this.res_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.res_entry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(209, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 575);
            this.label2.TabIndex = 1;
            // 
            // pow_rad
            // 
            this.pow_rad.AutoSize = true;
            this.pow_rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pow_rad.Location = new System.Drawing.Point(12, 114);
            this.pow_rad.Name = "pow_rad";
            this.pow_rad.Size = new System.Drawing.Size(183, 33);
            this.pow_rad.TabIndex = 2;
            this.pow_rad.TabStop = true;
            this.pow_rad.Text = "Potenciación";
            this.pow_rad.UseVisualStyleBackColor = true;
            // 
            // rt_rad
            // 
            this.rt_rad.AutoSize = true;
            this.rt_rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rt_rad.Location = new System.Drawing.Point(12, 189);
            this.rt_rad.Name = "rt_rad";
            this.rt_rad.Size = new System.Drawing.Size(164, 33);
            this.rt_rad.TabIndex = 3;
            this.rt_rad.TabStop = true;
            this.rt_rad.Text = "Radicación";
            this.rt_rad.UseVisualStyleBackColor = true;
            // 
            // roots_btn
            // 
            this.roots_btn.Location = new System.Drawing.Point(12, 326);
            this.roots_btn.Name = "roots_btn";
            this.roots_btn.Size = new System.Drawing.Size(183, 83);
            this.roots_btn.TabIndex = 4;
            this.roots_btn.Text = "Raíces n-simas\r\nde la unidad";
            this.roots_btn.UseVisualStyleBackColor = true;
            this.roots_btn.Click += new System.EventHandler(this.Roots_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 474);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(183, 82);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Regresar";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(241, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número Complejo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(241, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exponente / Índice";
            // 
            // complex_entry
            // 
            this.complex_entry.Location = new System.Drawing.Point(475, 118);
            this.complex_entry.Name = "complex_entry";
            this.complex_entry.Size = new System.Drawing.Size(313, 31);
            this.complex_entry.TabIndex = 8;
            // 
            // index_entry
            // 
            this.index_entry.Location = new System.Drawing.Point(475, 193);
            this.index_entry.Name = "index_entry";
            this.index_entry.Size = new System.Drawing.Size(313, 31);
            this.index_entry.TabIndex = 9;
            // 
            // res_btn
            // 
            this.res_btn.Location = new System.Drawing.Point(664, 266);
            this.res_btn.Name = "res_btn";
            this.res_btn.Size = new System.Drawing.Size(124, 63);
            this.res_btn.TabIndex = 10;
            this.res_btn.Text = "Consultar";
            this.res_btn.UseVisualStyleBackColor = true;
            this.res_btn.Click += new System.EventHandler(this.Res_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(253, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Resultado";
            // 
            // res_entry
            // 
            this.res_entry.Location = new System.Drawing.Point(258, 358);
            this.res_entry.Multiline = true;
            this.res_entry.Name = "res_entry";
            this.res_entry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.res_entry.Size = new System.Drawing.Size(530, 198);
            this.res_entry.TabIndex = 12;
            // 
            // AdvancedOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 576);
            this.Controls.Add(this.res_entry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.res_btn);
            this.Controls.Add(this.index_entry);
            this.Controls.Add(this.complex_entry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.roots_btn);
            this.Controls.Add(this.rt_rad);
            this.Controls.Add(this.pow_rad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdvancedOps";
            this.Text = "Operaciones Avanzadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton pow_rad;
        private System.Windows.Forms.RadioButton rt_rad;
        private System.Windows.Forms.Button roots_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox complex_entry;
        private System.Windows.Forms.TextBox index_entry;
        private System.Windows.Forms.Button res_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox res_entry;
    }
}