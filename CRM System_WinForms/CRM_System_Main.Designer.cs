namespace CRM_System_WinForms
{
    partial class CRM_System_Main
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
            Name_lbl = new Label();
            Name_txtBox = new TextBox();
            Email_txtBox = new TextBox();
            Email_lbl = new Label();
            button1 = new Button();
            Customers_lstBox = new ListBox();
            SuspendLayout();
            // 
            // Name_lbl
            // 
            Name_lbl.AutoSize = true;
            Name_lbl.Location = new Point(203, 106);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(41, 15);
            Name_lbl.TabIndex = 0;
            Name_lbl.Text = "Name";
            // 
            // Name_txtBox
            // 
            Name_txtBox.Location = new Point(203, 124);
            Name_txtBox.Name = "Name_txtBox";
            Name_txtBox.Size = new Size(100, 21);
            Name_txtBox.TabIndex = 1;
            // 
            // Email_txtBox
            // 
            Email_txtBox.Location = new Point(309, 124);
            Email_txtBox.Name = "Email_txtBox";
            Email_txtBox.Size = new Size(100, 21);
            Email_txtBox.TabIndex = 3;
            // 
            // Email_lbl
            // 
            Email_lbl.AutoSize = true;
            Email_lbl.Location = new Point(309, 106);
            Email_lbl.Name = "Email_lbl";
            Email_lbl.Size = new Size(39, 15);
            Email_lbl.TabIndex = 2;
            Email_lbl.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(415, 124);
            button1.Name = "button1";
            button1.Size = new Size(50, 21);
            button1.TabIndex = 4;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // Customers_lstBox
            // 
            Customers_lstBox.FormattingEnabled = true;
            Customers_lstBox.ItemHeight = 15;
            Customers_lstBox.Location = new Point(77, 168);
            Customers_lstBox.Name = "Customers_lstBox";
            Customers_lstBox.Size = new Size(388, 259);
            Customers_lstBox.TabIndex = 5;
            // 
            // CRM_System_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(510, 450);
            Controls.Add(Customers_lstBox);
            Controls.Add(button1);
            Controls.Add(Email_txtBox);
            Controls.Add(Email_lbl);
            Controls.Add(Name_txtBox);
            Controls.Add(Name_lbl);
            Font = new Font("Arial", 9F);
            ForeColor = Color.Black;
            Name = "CRM_System_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crm System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name_lbl;
        private TextBox Name_txtBox;
        private TextBox Email_txtBox;
        private Label Email_lbl;
        private Button button1;
        private ListBox Customers_lstBox;
    }
}
