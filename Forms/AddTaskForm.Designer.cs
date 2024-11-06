namespace TaskManagementSystem.Forms
{
    partial class AddTaskForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTaskName = new TextBox();
            rtxtDescription = new RichTextBox();
            cboStatus = new ComboBox();
            btnSaveTask = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 84);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Task Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 139);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 312);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(165, 81);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(274, 31);
            txtTaskName.TabIndex = 3;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(165, 139);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(274, 144);
            rtxtDescription.TabIndex = 4;
            rtxtDescription.Text = "";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "New", "On-going", "Done" });
            cboStatus.Location = new Point(166, 308);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(273, 33);
            cboStatus.TabIndex = 5;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // btnSaveTask
            // 
            btnSaveTask.BackColor = Color.DarkGreen;
            btnSaveTask.FlatStyle = FlatStyle.Flat;
            btnSaveTask.ForeColor = Color.Transparent;
            btnSaveTask.Location = new Point(303, 364);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(136, 41);
            btnSaveTask.TabIndex = 6;
            btnSaveTask.Text = "Save";
            btnSaveTask.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(28, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 426);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(171, 27);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 0;
            label4.Text = "Add New Task";
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(btnSaveTask);
            Controls.Add(cboStatus);
            Controls.Add(rtxtDescription);
            Controls.Add(txtTaskName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddTaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTaskForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTaskName;
        private RichTextBox rtxtDescription;
        private ComboBox cboStatus;
        private Button btnSaveTask;
        private GroupBox groupBox1;
        private Label label4;
    }
}