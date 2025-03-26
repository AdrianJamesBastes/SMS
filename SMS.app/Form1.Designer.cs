namespace SMS.app
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
            textBoxID = new TextBox();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonShow = new Button();
            labelAddedInformation = new Label();
            SuspendLayout();
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(201, 204);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(275, 23);
            textBoxID.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(201, 251);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(275, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(201, 298);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(275, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 207);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 254);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 301);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(143, 111);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(333, 59);
            buttonShow.TabIndex = 6;
            buttonShow.Text = "Show Information";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // labelAddedInformation
            // 
            labelAddedInformation.AutoSize = true;
            labelAddedInformation.Location = new Point(201, 360);
            labelAddedInformation.Name = "labelAddedInformation";
            labelAddedInformation.Size = new Size(108, 15);
            labelAddedInformation.TabIndex = 7;
            labelAddedInformation.Text = "Added Information";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 577);
            Controls.Add(labelAddedInformation);
            Controls.Add(buttonShow);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(textBoxID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxID;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonShow;
        private Label labelAddedInformation;
    }
}
