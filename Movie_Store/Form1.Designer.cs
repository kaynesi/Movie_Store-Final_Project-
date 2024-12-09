namespace Movie_Store
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
            checkedListBox1 = new CheckedListBox();
            groupBox1 = new GroupBox();
            btnCalculate = new Button();
            btnExit = new Button();
            txtSubtotal = new TextBox();
            txtOrderTotal = new TextBox();
            txtSalesTax = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "A League of Their Own", "American Psycho", "The Boy in the Striped Pajamas", "Men In Black", "The War", "Children of the Corn", "Spanglish", "Raya and the Last Dragon", "Yes Day", "Heavyweights", "The Age of Adaline", "Lara Croft: Tomb Raider", "Terminator 2: Judgment Day", "Battle Royale", "Crawl", "The Babadook", "MAXIMUM OVERDRIVE", "The Shining", "The Terminal", "Carrie" });
            checkedListBox1.Location = new Point(4, 22);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(190, 112);
            checkedListBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 146);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Movie Selection - $5 Each";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 182);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(230, 182);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(348, 23);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 4;
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(348, 135);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(100, 23);
            txtOrderTotal.TabIndex = 5;
            // 
            // txtSalesTax
            // 
            txtSalesTax.Location = new Point(348, 79);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new Size(100, 23);
            txtSalesTax.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 26);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Subtotal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 82);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Tax (9%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 138);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 9;
            label3.Text = "Order Total:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(119, 182);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 260);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSalesTax);
            Controls.Add(txtOrderTotal);
            Controls.Add(txtSubtotal);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Movie Store";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private GroupBox groupBox1;
        private Button btnCalculate;
        private Button btnExit;
        private TextBox txtSubtotal;
        private TextBox txtOrderTotal;
        private TextBox txtSalesTax;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnClear;
    }
}
