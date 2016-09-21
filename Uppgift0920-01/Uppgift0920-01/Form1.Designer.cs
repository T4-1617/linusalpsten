namespace Uppgift0920_01
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
            this.registerLabel = new System.Windows.Forms.Label();
            this.registrationChoices = new System.Windows.Forms.ComboBox();
            this.regPanel = new System.Windows.Forms.Panel();
            this.regCancelButton = new System.Windows.Forms.Button();
            this.regSaveButton = new System.Windows.Forms.Button();
            this.titleTBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.salaryTBox = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.dynamicTBox = new System.Windows.Forms.TextBox();
            this.dynamicLabel = new System.Windows.Forms.Label();
            this.phoneNrTBox = new System.Windows.Forms.TextBox();
            this.phoneNrLabel = new System.Windows.Forms.Label();
            this.lastNameTBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.personListBox = new System.Windows.Forms.ListBox();
            this.regAmountLabel = new System.Windows.Forms.Label();
            this.regPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Location = new System.Drawing.Point(84, 54);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(120, 13);
            this.registerLabel.TabIndex = 0;
            this.registerLabel.Text = "I want to register a new:";
            // 
            // registrationChoices
            // 
            this.registrationChoices.FormattingEnabled = true;
            this.registrationChoices.Location = new System.Drawing.Point(226, 54);
            this.registrationChoices.Name = "registrationChoices";
            this.registrationChoices.Size = new System.Drawing.Size(426, 21);
            this.registrationChoices.TabIndex = 1;
            // 
            // regPanel
            // 
            this.regPanel.Controls.Add(this.regCancelButton);
            this.regPanel.Controls.Add(this.regSaveButton);
            this.regPanel.Controls.Add(this.titleTBox);
            this.regPanel.Controls.Add(this.titleLabel);
            this.regPanel.Controls.Add(this.salaryTBox);
            this.regPanel.Controls.Add(this.salaryLabel);
            this.regPanel.Controls.Add(this.dynamicTBox);
            this.regPanel.Controls.Add(this.dynamicLabel);
            this.regPanel.Controls.Add(this.phoneNrTBox);
            this.regPanel.Controls.Add(this.phoneNrLabel);
            this.regPanel.Controls.Add(this.lastNameTBox);
            this.regPanel.Controls.Add(this.lastNameLabel);
            this.regPanel.Controls.Add(this.firstNameTBox);
            this.regPanel.Controls.Add(this.firstNameLabel);
            this.regPanel.Location = new System.Drawing.Point(87, 93);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(565, 241);
            this.regPanel.TabIndex = 2;
            // 
            // regCancelButton
            // 
            this.regCancelButton.Location = new System.Drawing.Point(409, 195);
            this.regCancelButton.Name = "regCancelButton";
            this.regCancelButton.Size = new System.Drawing.Size(75, 23);
            this.regCancelButton.TabIndex = 13;
            this.regCancelButton.Text = "Cancel";
            this.regCancelButton.UseVisualStyleBackColor = true;
            this.regCancelButton.Click += new System.EventHandler(this.regCancelButton_Click);
            // 
            // regSaveButton
            // 
            this.regSaveButton.Location = new System.Drawing.Point(309, 196);
            this.regSaveButton.Name = "regSaveButton";
            this.regSaveButton.Size = new System.Drawing.Size(75, 23);
            this.regSaveButton.TabIndex = 12;
            this.regSaveButton.Text = "Save";
            this.regSaveButton.UseVisualStyleBackColor = true;
            this.regSaveButton.Click += new System.EventHandler(this.regSaveButton_Click);
            // 
            // titleTBox
            // 
            this.titleTBox.Location = new System.Drawing.Point(139, 152);
            this.titleTBox.Name = "titleTBox";
            this.titleTBox.Size = new System.Drawing.Size(407, 20);
            this.titleTBox.TabIndex = 11;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(18, 152);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Title:";
            // 
            // salaryTBox
            // 
            this.salaryTBox.Location = new System.Drawing.Point(139, 126);
            this.salaryTBox.Name = "salaryTBox";
            this.salaryTBox.Size = new System.Drawing.Size(407, 20);
            this.salaryTBox.TabIndex = 9;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(18, 126);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(39, 13);
            this.salaryLabel.TabIndex = 8;
            this.salaryLabel.Text = "Salary:";
            // 
            // dynamicTBox
            // 
            this.dynamicTBox.Location = new System.Drawing.Point(139, 100);
            this.dynamicTBox.Name = "dynamicTBox";
            this.dynamicTBox.Size = new System.Drawing.Size(407, 20);
            this.dynamicTBox.TabIndex = 7;
            // 
            // dynamicLabel
            // 
            this.dynamicLabel.AutoSize = true;
            this.dynamicLabel.Location = new System.Drawing.Point(18, 100);
            this.dynamicLabel.Name = "dynamicLabel";
            this.dynamicLabel.Size = new System.Drawing.Size(46, 13);
            this.dynamicLabel.TabIndex = 6;
            this.dynamicLabel.Text = "dynamic";
            // 
            // phoneNrTBox
            // 
            this.phoneNrTBox.Location = new System.Drawing.Point(139, 74);
            this.phoneNrTBox.Name = "phoneNrTBox";
            this.phoneNrTBox.Size = new System.Drawing.Size(407, 20);
            this.phoneNrTBox.TabIndex = 5;
            // 
            // phoneNrLabel
            // 
            this.phoneNrLabel.AutoSize = true;
            this.phoneNrLabel.Location = new System.Drawing.Point(18, 74);
            this.phoneNrLabel.Name = "phoneNrLabel";
            this.phoneNrLabel.Size = new System.Drawing.Size(79, 13);
            this.phoneNrLabel.TabIndex = 4;
            this.phoneNrLabel.Text = "Phone number:";
            // 
            // lastNameTBox
            // 
            this.lastNameTBox.Location = new System.Drawing.Point(139, 48);
            this.lastNameTBox.Name = "lastNameTBox";
            this.lastNameTBox.Size = new System.Drawing.Size(407, 20);
            this.lastNameTBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(18, 48);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last name:";
            // 
            // firstNameTBox
            // 
            this.firstNameTBox.Location = new System.Drawing.Point(139, 22);
            this.firstNameTBox.Name = "firstNameTBox";
            this.firstNameTBox.Size = new System.Drawing.Size(407, 20);
            this.firstNameTBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(18, 22);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name:";
            // 
            // personListBox
            // 
            this.personListBox.FormattingEnabled = true;
            this.personListBox.Location = new System.Drawing.Point(87, 425);
            this.personListBox.Name = "personListBox";
            this.personListBox.Size = new System.Drawing.Size(143, 264);
            this.personListBox.TabIndex = 3;
            // 
            // regAmountLabel
            // 
            this.regAmountLabel.AutoSize = true;
            this.regAmountLabel.Location = new System.Drawing.Point(87, 361);
            this.regAmountLabel.Name = "regAmountLabel";
            this.regAmountLabel.Size = new System.Drawing.Size(35, 13);
            this.regAmountLabel.TabIndex = 4;
            this.regAmountLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 759);
            this.Controls.Add(this.regAmountLabel);
            this.Controls.Add(this.personListBox);
            this.Controls.Add(this.regPanel);
            this.Controls.Add(this.registrationChoices);
            this.Controls.Add(this.registerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.ComboBox registrationChoices;
        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.TextBox titleTBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox salaryTBox;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox dynamicTBox;
        private System.Windows.Forms.Label dynamicLabel;
        private System.Windows.Forms.TextBox phoneNrTBox;
        private System.Windows.Forms.Label phoneNrLabel;
        private System.Windows.Forms.TextBox lastNameTBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button regCancelButton;
        private System.Windows.Forms.Button regSaveButton;
        private System.Windows.Forms.ListBox personListBox;
        private System.Windows.Forms.Label regAmountLabel;
    }
}

