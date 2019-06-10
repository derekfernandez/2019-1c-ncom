namespace ncom
{
    partial class Roots
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
            this.rootsquantity_entry = new System.Windows.Forms.TextBox();
            this.res_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.primitives_entry = new System.Windows.Forms.TextBox();
            this.roots_entry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Raíces";
            // 
            // rootsquantity_entry
            // 
            this.rootsquantity_entry.Location = new System.Drawing.Point(241, 52);
            this.rootsquantity_entry.Name = "rootsquantity_entry";
            this.rootsquantity_entry.Size = new System.Drawing.Size(227, 31);
            this.rootsquantity_entry.TabIndex = 1;
            // 
            // res_btn
            // 
            this.res_btn.Location = new System.Drawing.Point(351, 110);
            this.res_btn.Name = "res_btn";
            this.res_btn.Size = new System.Drawing.Size(117, 49);
            this.res_btn.TabIndex = 2;
            this.res_btn.Text = "Calcular";
            this.res_btn.UseVisualStyleBackColor = true;
            this.res_btn.Click += new System.EventHandler(this.Res_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(74, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raíces";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(296, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Primitivas";
            // 
            // primitives_entry
            // 
            this.primitives_entry.Location = new System.Drawing.Point(241, 239);
            this.primitives_entry.Multiline = true;
            this.primitives_entry.Name = "primitives_entry";
            this.primitives_entry.ReadOnly = true;
            this.primitives_entry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.primitives_entry.Size = new System.Drawing.Size(228, 224);
            this.primitives_entry.TabIndex = 5;
            // 
            // roots_entry
            // 
            this.roots_entry.Location = new System.Drawing.Point(17, 239);
            this.roots_entry.Multiline = true;
            this.roots_entry.Name = "roots_entry";
            this.roots_entry.ReadOnly = true;
            this.roots_entry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.roots_entry.Size = new System.Drawing.Size(218, 224);
            this.roots_entry.TabIndex = 6;
            // 
            // Roots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 475);
            this.Controls.Add(this.roots_entry);
            this.Controls.Add(this.primitives_entry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.res_btn);
            this.Controls.Add(this.rootsquantity_entry);
            this.Controls.Add(this.label1);
            this.Name = "Roots";
            this.Text = "Raíces";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rootsquantity_entry;
        private System.Windows.Forms.Button res_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox primitives_entry;
        private System.Windows.Forms.TextBox roots_entry;
    }
}