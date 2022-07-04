namespace New_Employee_Information_ToTextFile
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
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxLastname = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelLastname = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonAddNewPerson = new System.Windows.Forms.Button();
            this.ButtonShowPeople = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(12, 38);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(200, 22);
            this.TextBoxId.TabIndex = 1;
            this.TextBoxId.TextChanged += new System.EventHandler(this.TextBoxId_TextChanged);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(12, 66);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(200, 22);
            this.TextBoxName.TabIndex = 2;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // TextBoxLastname
            // 
            this.TextBoxLastname.Location = new System.Drawing.Point(12, 94);
            this.TextBoxLastname.Name = "TextBoxLastname";
            this.TextBoxLastname.Size = new System.Drawing.Size(200, 22);
            this.TextBoxLastname.TabIndex = 3;
            this.TextBoxLastname.TextChanged += new System.EventHandler(this.TextBoxLastname_TextChanged);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(12, 122);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(200, 22);
            this.TextBoxEmail.TabIndex = 4;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(218, 41);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(20, 16);
            this.LabelId.TabIndex = 5;
            this.LabelId.Text = "ID";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(218, 69);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(44, 16);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "Name";
            // 
            // LabelLastname
            // 
            this.LabelLastname.AutoSize = true;
            this.LabelLastname.Location = new System.Drawing.Point(218, 97);
            this.LabelLastname.Name = "LabelLastname";
            this.LabelLastname.Size = new System.Drawing.Size(66, 16);
            this.LabelLastname.TabIndex = 7;
            this.LabelLastname.Text = "Lastname";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(218, 125);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(41, 16);
            this.LabelEmail.TabIndex = 8;
            this.LabelEmail.Text = "Email";
            // 
            // RichTextBox
            // 
            this.RichTextBox.DetectUrls = false;
            this.RichTextBox.Location = new System.Drawing.Point(12, 229);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.ReadOnly = true;
            this.RichTextBox.Size = new System.Drawing.Size(312, 209);
            this.RichTextBox.TabIndex = 0;
            this.RichTextBox.TabStop = false;
            this.RichTextBox.Text = "";
            // 
            // ButtonAddNewPerson
            // 
            this.ButtonAddNewPerson.Location = new System.Drawing.Point(12, 177);
            this.ButtonAddNewPerson.Name = "ButtonAddNewPerson";
            this.ButtonAddNewPerson.Size = new System.Drawing.Size(129, 23);
            this.ButtonAddNewPerson.TabIndex = 9;
            this.ButtonAddNewPerson.Text = "Add New Person";
            this.ButtonAddNewPerson.UseVisualStyleBackColor = true;
            this.ButtonAddNewPerson.Click += new System.EventHandler(this.ButtonAddNewPerson_Click);
            // 
            // ButtonShowPeople
            // 
            this.ButtonShowPeople.Location = new System.Drawing.Point(181, 177);
            this.ButtonShowPeople.Name = "ButtonShowPeople";
            this.ButtonShowPeople.Size = new System.Drawing.Size(107, 23);
            this.ButtonShowPeople.TabIndex = 10;
            this.ButtonShowPeople.Text = "Show People";
            this.ButtonShowPeople.UseVisualStyleBackColor = true;
            this.ButtonShowPeople.Click += new System.EventHandler(this.ButtonShowPeople_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 458);
            this.Controls.Add(this.ButtonShowPeople);
            this.Controls.Add(this.ButtonAddNewPerson);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelLastname);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxLastname);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxId);
            this.Name = "Form1";
            this.Text = "Save Employee Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxLastname;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelLastname;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button ButtonAddNewPerson;
        private System.Windows.Forms.Button ButtonShowPeople;
    }
}

