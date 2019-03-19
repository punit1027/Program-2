namespace Program2
{
    partial class program2
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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.classGroupBox = new System.Windows.Forms.GroupBox();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.sophomoreRadioButton = new System.Windows.Forms.RadioButton();
            this.freshmanRadioButton = new System.Windows.Forms.RadioButton();
            this.registrationDateButton = new System.Windows.Forms.Button();
            this.classGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 20);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(232, 20);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Enter Last Name (Letters Only):";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(265, 17);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(148, 26);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // classGroupBox
            // 
            this.classGroupBox.Controls.Add(this.seniorRadioButton);
            this.classGroupBox.Controls.Add(this.juniorRadioButton);
            this.classGroupBox.Controls.Add(this.sophomoreRadioButton);
            this.classGroupBox.Controls.Add(this.freshmanRadioButton);
            this.classGroupBox.Location = new System.Drawing.Point(123, 83);
            this.classGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.classGroupBox.Name = "classGroupBox";
            this.classGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.classGroupBox.Size = new System.Drawing.Size(150, 177);
            this.classGroupBox.TabIndex = 2;
            this.classGroupBox.TabStop = false;
            this.classGroupBox.Text = "Select Class:";
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(16, 135);
            this.seniorRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(80, 24);
            this.seniorRadioButton.TabIndex = 3;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.Location = new System.Drawing.Point(16, 100);
            this.juniorRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(77, 24);
            this.juniorRadioButton.TabIndex = 2;
            this.juniorRadioButton.TabStop = true;
            this.juniorRadioButton.Text = "Junior";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreRadioButton
            // 
            this.sophomoreRadioButton.AutoSize = true;
            this.sophomoreRadioButton.Location = new System.Drawing.Point(16, 65);
            this.sophomoreRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sophomoreRadioButton.Name = "sophomoreRadioButton";
            this.sophomoreRadioButton.Size = new System.Drawing.Size(117, 24);
            this.sophomoreRadioButton.TabIndex = 1;
            this.sophomoreRadioButton.TabStop = true;
            this.sophomoreRadioButton.Text = "Sophomore";
            this.sophomoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // freshmanRadioButton
            // 
            this.freshmanRadioButton.AutoSize = true;
            this.freshmanRadioButton.Checked = true;
            this.freshmanRadioButton.Location = new System.Drawing.Point(16, 30);
            this.freshmanRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.freshmanRadioButton.Name = "freshmanRadioButton";
            this.freshmanRadioButton.Size = new System.Drawing.Size(106, 24);
            this.freshmanRadioButton.TabIndex = 0;
            this.freshmanRadioButton.TabStop = true;
            this.freshmanRadioButton.Text = "Freshman";
            this.freshmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // registrationDateButton
            // 
            this.registrationDateButton.Location = new System.Drawing.Point(98, 287);
            this.registrationDateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registrationDateButton.Name = "registrationDateButton";
            this.registrationDateButton.Size = new System.Drawing.Size(194, 45);
            this.registrationDateButton.TabIndex = 3;
            this.registrationDateButton.Text = "Show Registration Time";
            this.registrationDateButton.UseVisualStyleBackColor = true;
            this.registrationDateButton.Click += new System.EventHandler(this.registrationDateButton_Click);
            // 
            // program2
            // 
            this.AcceptButton = this.registrationDateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.registrationDateButton);
            this.Controls.Add(this.classGroupBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "program2";
            this.Text = "Program 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.classGroupBox.ResumeLayout(false);
            this.classGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox classGroupBox;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton sophomoreRadioButton;
        private System.Windows.Forms.RadioButton freshmanRadioButton;
        private System.Windows.Forms.Button registrationDateButton;
    }
}

