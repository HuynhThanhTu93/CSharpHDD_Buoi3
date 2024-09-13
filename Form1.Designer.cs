namespace CSharpHDD_Buoi3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_cd = new TextBox();
            label2 = new Label();
            txt_cr = new TextBox();
            btn_nhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 51);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 0;
            label1.Text = "Chiều dài:";
            // 
            // txt_cd
            // 
            txt_cd.Location = new Point(165, 43);
            txt_cd.Name = "txt_cd";
            txt_cd.Size = new Size(126, 32);
            txt_cd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 89);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 0;
            label2.Text = "Chiều rộng:";
            // 
            // txt_cr
            // 
            txt_cr.Location = new Point(165, 81);
            txt_cr.Name = "txt_cr";
            txt_cr.Size = new Size(126, 32);
            txt_cr.TabIndex = 1;
            // 
            // btn_nhap
            // 
            btn_nhap.Location = new Point(325, 61);
            btn_nhap.Name = "btn_nhap";
            btn_nhap.Size = new Size(117, 37);
            btn_nhap.TabIndex = 2;
            btn_nhap.Text = "Nhập";
            btn_nhap.UseVisualStyleBackColor = true;
            btn_nhap.Click += btn_nhap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 548);
            Controls.Add(btn_nhap);
            Controls.Add(txt_cr);
            Controls.Add(label2);
            Controls.Add(txt_cd);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_cd;
        private Label label2;
        private TextBox txt_cr;
        private Button btn_nhap;
    }
}
