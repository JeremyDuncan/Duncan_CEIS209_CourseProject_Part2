namespace Duncan_courseproject_part2
{
    partial class MainForm
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
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.DipsplayButton = new System.Windows.Forms.Button();
            this.PrintPaychecksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.ItemHeight = 20;
            this.EmployeesListBox.Location = new System.Drawing.Point(18, 78);
            this.EmployeesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(810, 284);
            this.EmployeesListBox.TabIndex = 0;
            this.EmployeesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EmployeesListBox_MouseDoubleClick);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(18, 12);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(112, 35);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(129, 12);
            this.Remove_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(112, 35);
            this.Remove_Button.TabIndex = 2;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // DipsplayButton
            // 
            this.DipsplayButton.Location = new System.Drawing.Point(240, 12);
            this.DipsplayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DipsplayButton.Name = "DipsplayButton";
            this.DipsplayButton.Size = new System.Drawing.Size(112, 35);
            this.DipsplayButton.TabIndex = 3;
            this.DipsplayButton.Text = "Display";
            this.DipsplayButton.UseVisualStyleBackColor = true;
            this.DipsplayButton.Click += new System.EventHandler(this.DipsplayButton_Click);
            // 
            // PrintPaychecksButton
            // 
            this.PrintPaychecksButton.Location = new System.Drawing.Point(351, 12);
            this.PrintPaychecksButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrintPaychecksButton.Name = "PrintPaychecksButton";
            this.PrintPaychecksButton.Size = new System.Drawing.Size(152, 35);
            this.PrintPaychecksButton.TabIndex = 4;
            this.PrintPaychecksButton.Text = "Print Paychecks";
            this.PrintPaychecksButton.UseVisualStyleBackColor = true;
            this.PrintPaychecksButton.Click += new System.EventHandler(this.PrintPaychecksButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 383);
            this.Controls.Add(this.PrintPaychecksButton);
            this.Controls.Add(this.DipsplayButton);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EmployeesListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Payroll System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeesListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Button DipsplayButton;
        private System.Windows.Forms.Button PrintPaychecksButton;
    }
}

