namespace SectionC
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
            lblOutput = new Label();
            txtCode = new TextBox();
            txtMake = new TextBox();
            txtQuantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            tblMobilePhones = new ListBox();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(168, 18);
            lblOutput.Margin = new Padding(4, 0, 4, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 28);
            lblOutput.TabIndex = 0;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(296, 109);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(125, 34);
            txtCode.TabIndex = 1;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(296, 170);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 34);
            txtMake.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(296, 236);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 34);
            txtQuantity.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 115);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 4;
            label1.Text = "Mobile Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 176);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 5;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 242);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 6;
            label3.Text = "Quantity";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(42, 307);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 50);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(244, 307);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 50);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(449, 307);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(117, 50);
            btnFind.TabIndex = 9;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // tblMobilePhones
            // 
            tblMobilePhones.FormattingEnabled = true;
            tblMobilePhones.Location = new Point(42, 379);
            tblMobilePhones.Name = "tblMobilePhones";
            tblMobilePhones.Size = new Size(524, 200);
            tblMobilePhones.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 610);
            Controls.Add(tblMobilePhones);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(txtMake);
            Controls.Add(txtCode);
            Controls.Add(lblOutput);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtQuantity;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
        private ListBox tblMobilePhones;
    }
}
