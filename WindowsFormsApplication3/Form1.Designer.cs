namespace WindowsFormsApplication3
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
            this.txt11 = new System.Windows.Forms.TextBox();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.txt13 = new System.Windows.Forms.TextBox();
            this.txt23 = new System.Windows.Forms.TextBox();
            this.txt22 = new System.Windows.Forms.TextBox();
            this.txt21 = new System.Windows.Forms.TextBox();
            this.txt32 = new System.Windows.Forms.TextBox();
            this.txt31 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ans = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.txt33 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt11
            // 
            this.txt11.Location = new System.Drawing.Point(73, 36);
            this.txt11.Multiline = true;
            this.txt11.Name = "txt11";
            this.txt11.ReadOnly = true;
            this.txt11.Size = new System.Drawing.Size(35, 35);
            this.txt11.TabIndex = 0;
            this.txt11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt11.TextChanged += new System.EventHandler(this.txt11_TextChanged);
            // 
            // txt12
            // 
            this.txt12.Location = new System.Drawing.Point(156, 36);
            this.txt12.Multiline = true;
            this.txt12.Name = "txt12";
            this.txt12.ReadOnly = true;
            this.txt12.Size = new System.Drawing.Size(35, 35);
            this.txt12.TabIndex = 1;
            this.txt12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt12.TextChanged += new System.EventHandler(this.txt12_TextChanged);
            // 
            // txt13
            // 
            this.txt13.Location = new System.Drawing.Point(240, 36);
            this.txt13.Multiline = true;
            this.txt13.Name = "txt13";
            this.txt13.ReadOnly = true;
            this.txt13.Size = new System.Drawing.Size(35, 35);
            this.txt13.TabIndex = 2;
            this.txt13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt13.TextChanged += new System.EventHandler(this.txt13_TextChanged);
            // 
            // txt23
            // 
            this.txt23.Location = new System.Drawing.Point(240, 106);
            this.txt23.Multiline = true;
            this.txt23.Name = "txt23";
            this.txt23.ReadOnly = true;
            this.txt23.Size = new System.Drawing.Size(35, 35);
            this.txt23.TabIndex = 5;
            this.txt23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt23.TextChanged += new System.EventHandler(this.txt23_TextChanged);
            // 
            // txt22
            // 
            this.txt22.Location = new System.Drawing.Point(156, 106);
            this.txt22.Multiline = true;
            this.txt22.Name = "txt22";
            this.txt22.ReadOnly = true;
            this.txt22.Size = new System.Drawing.Size(35, 35);
            this.txt22.TabIndex = 4;
            this.txt22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt22.TextChanged += new System.EventHandler(this.txt22_TextChanged);
            // 
            // txt21
            // 
            this.txt21.Location = new System.Drawing.Point(73, 106);
            this.txt21.Multiline = true;
            this.txt21.Name = "txt21";
            this.txt21.ReadOnly = true;
            this.txt21.Size = new System.Drawing.Size(35, 35);
            this.txt21.TabIndex = 3;
            this.txt21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt21.TextChanged += new System.EventHandler(this.txt21_TextChanged);
            // 
            // txt32
            // 
            this.txt32.Location = new System.Drawing.Point(156, 176);
            this.txt32.Multiline = true;
            this.txt32.Name = "txt32";
            this.txt32.ReadOnly = true;
            this.txt32.Size = new System.Drawing.Size(35, 35);
            this.txt32.TabIndex = 7;
            this.txt32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt32.TextChanged += new System.EventHandler(this.txt32_TextChanged);
            // 
            // txt31
            // 
            this.txt31.Location = new System.Drawing.Point(73, 176);
            this.txt31.Multiline = true;
            this.txt31.Name = "txt31";
            this.txt31.ReadOnly = true;
            this.txt31.Size = new System.Drawing.Size(35, 35);
            this.txt31.TabIndex = 6;
            this.txt31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt31.TextChanged += new System.EventHandler(this.txt31_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "3x3 Matrix";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_ans
            // 
            this.txt_ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ans.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_ans.Location = new System.Drawing.Point(136, 228);
            this.txt_ans.Multiline = true;
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.Size = new System.Drawing.Size(76, 29);
            this.txt_ans.TabIndex = 10;
            this.txt_ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ans.TextChanged += new System.EventHandler(this.txt_ans_TextChanged);
            this.txt_ans.Enter += new System.EventHandler(this.txt_ans_Click);
            this.txt_ans.Leave += new System.EventHandler(this.txt_ans_Leave);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(107, 272);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(138, 42);
            this.button.TabIndex = 11;
            this.button.Text = "Calculate and Compare";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // txt33
            // 
            this.txt33.Location = new System.Drawing.Point(240, 176);
            this.txt33.Multiline = true;
            this.txt33.Name = "txt33";
            this.txt33.ReadOnly = true;
            this.txt33.Size = new System.Drawing.Size(35, 35);
            this.txt33.TabIndex = 12;
            this.txt33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt33.TextChanged += new System.EventHandler(this.txt33_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Attempt: 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.txt33);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt32);
            this.Controls.Add(this.txt31);
            this.Controls.Add(this.txt23);
            this.Controls.Add(this.txt22);
            this.Controls.Add(this.txt21);
            this.Controls.Add(this.txt13);
            this.Controls.Add(this.txt12);
            this.Controls.Add(this.txt11);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Determinant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.TextBox txt13;
        private System.Windows.Forms.TextBox txt23;
        private System.Windows.Forms.TextBox txt22;
        private System.Windows.Forms.TextBox txt21;
        private System.Windows.Forms.TextBox txt32;
        private System.Windows.Forms.TextBox txt31;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ans;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox txt33;
        private System.Windows.Forms.Label label2;
    }
}

