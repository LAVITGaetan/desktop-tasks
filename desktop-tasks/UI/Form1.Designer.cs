﻿namespace desktop_tasks
{
    partial class TasksFrame
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
            System.Windows.Forms.GroupBox groupBoxManager;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksFrame));
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            groupBoxManager = new System.Windows.Forms.GroupBox();
            groupBoxManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxManager
            // 
            groupBoxManager.Controls.Add(this.textBoxComment);
            groupBoxManager.Controls.Add(this.textBoxTitle);
            groupBoxManager.Controls.Add(this.labelComment);
            groupBoxManager.Controls.Add(this.labelTitle);
            groupBoxManager.Controls.Add(this.buttonCreate);
            resources.ApplyResources(groupBoxManager, "groupBoxManager");
            groupBoxManager.Name = "groupBoxManager";
            groupBoxManager.TabStop = false;
            // 
            // textBoxComment
            // 
            resources.ApplyResources(this.textBoxComment, "textBoxComment");
            this.textBoxComment.Name = "textBoxComment";
            // 
            // textBoxTitle
            // 
            resources.ApplyResources(this.textBoxTitle, "textBoxTitle");
            this.textBoxTitle.Name = "textBoxTitle";
            // 
            // labelComment
            // 
            resources.ApplyResources(this.labelComment, "labelComment");
            this.labelComment.Name = "labelComment";
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.Name = "labelTitle";
            // 
            // buttonCreate
            // 
            resources.ApplyResources(this.buttonCreate, "buttonCreate");
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // TasksFrame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(groupBoxManager);
            this.Name = "TasksFrame";
            this.Load += new System.EventHandler(this.TasksFrame_Load);
            groupBoxManager.ResumeLayout(false);
            groupBoxManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxManager;
        private TextBox textBoxTitle;
        private Label labelComment;
        private Label labelTitle;
        private Button buttonCreate;
        private TextBox textBoxComment;
    }
}