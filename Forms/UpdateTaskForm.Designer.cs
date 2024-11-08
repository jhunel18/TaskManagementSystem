namespace TaskManagementSystem.Forms
{
    partial class UpdateTaskForm
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
            btnSaveTask = new Button();
            cboStatus = new ComboBox();
            rtxtDescription = new RichTextBox();
            txtTaskName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSaveTask
            // 
            btnSaveTask.BackColor = Color.DarkGreen;
            btnSaveTask.FlatStyle = FlatStyle.Flat;
            btnSaveTask.ForeColor = Color.Transparent;
            btnSaveTask.Location = new Point(443, 364);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(136, 41);
            btnSaveTask.TabIndex = 14;
            btnSaveTask.Text = "Update";
            btnSaveTask.UseVisualStyleBackColor = false;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "New", "On-going", "Done" });
            cboStatus.Location = new Point(306, 308);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(273, 33);
            cboStatus.TabIndex = 13;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(305, 139);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(274, 144);
            rtxtDescription.TabIndex = 12;
            rtxtDescription.Text = "";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(305, 81);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(274, 31);
            txtTaskName.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 312);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 10;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 139);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 9;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 84);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 8;
            label1.Text = "Task Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(168, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 426);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(171, 27);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 0;
            label4.Text = "UpdateTask";
            // 
            // UpdateTaskForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveTask);
            Controls.Add(cboStatus);
            Controls.Add(rtxtDescription);
            Controls.Add(txtTaskName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "UpdateTaskForm";
            Text = "UpdateTaskForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveTask;
        private ComboBox cboStatus;
        private RichTextBox rtxtDescription;
        private TextBox txtTaskName;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
    }
}