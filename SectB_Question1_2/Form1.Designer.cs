namespace SectB_Question1_2
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
            txtName = new TextBox();
            lblName = new Label();
            btnGreet = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(373, 221);
            txtName.Name = "txtName";
            txtName.Size = new Size(184, 27);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(247, 224);
            lblName.Name = "lblName";
            lblName.Size = new Size(120, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Enter your name:";
            // 
            // btnGreet
            // 
            btnGreet.Location = new Point(438, 254);
            btnGreet.Name = "btnGreet";
            btnGreet.Size = new Size(119, 38);
            btnGreet.TabIndex = 2;
            btnGreet.Text = "Greeting";
            btnGreet.UseVisualStyleBackColor = true;
            btnGreet.Click += btnGreet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGreet);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Button btnGreet;
    }
}
