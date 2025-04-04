namespace SMS.app
{
    partial class ProgramView
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
            txtBoxProgramName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBoxDescription = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            txtBoxID = new TextBox();
            btnCreate = new Button();
            btnRead = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridViewProgramList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramList).BeginInit();
            SuspendLayout();
            // 
            // txtBoxProgramName
            // 
            txtBoxProgramName.Location = new Point(32, 101);
            txtBoxProgramName.Name = "txtBoxProgramName";
            txtBoxProgramName.Size = new Size(183, 23);
            txtBoxProgramName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 83);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Program Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 127);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(32, 145);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(183, 23);
            txtBoxDescription.TabIndex = 2;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 39);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 5;
            label4.Text = "ID";
            // 
            // txtBoxID
            // 
            txtBoxID.Location = new Point(32, 57);
            txtBoxID.Name = "txtBoxID";
            txtBoxID.Size = new Size(183, 23);
            txtBoxID.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(32, 209);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(183, 23);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(32, 238);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(183, 23);
            btnRead.TabIndex = 7;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(32, 267);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(183, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(32, 296);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(183, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewProgramList
            // 
            dataGridViewProgramList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProgramList.Location = new Point(258, 39);
            dataGridViewProgramList.Name = "dataGridViewProgramList";
            dataGridViewProgramList.Size = new Size(439, 280);
            dataGridViewProgramList.TabIndex = 10;
            // 
            // ProgramView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 339);
            Controls.Add(dataGridViewProgramList);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRead);
            Controls.Add(btnCreate);
            Controls.Add(label4);
            Controls.Add(txtBoxID);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtBoxDescription);
            Controls.Add(label1);
            Controls.Add(txtBoxProgramName);
            Name = "ProgramView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Program Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxProgramName;
        private Label label1;
        private Label label2;
        private TextBox txtBoxDescription;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox txtBoxID;
        private Button btnCreate;
        private Button btnRead;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridViewProgramList;
    }
}