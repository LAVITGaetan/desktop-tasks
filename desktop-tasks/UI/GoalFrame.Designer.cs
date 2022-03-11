namespace desktop_tasks.UI
{
    partial class GoalFrame
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCommentDetail = new System.Windows.Forms.TextBox();
            this.textBoxTitleDetail = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.IdLabelGoal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IdLabelGoal);
            this.groupBox1.Controls.Add(this.textBoxCommentDetail);
            this.groupBox1.Controls.Add(this.textBoxTitleDetail);
            this.groupBox1.Controls.Add(this.labelComment);
            this.groupBox1.Controls.Add(this.labelTitle);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails de la tâche";
            // 
            // textBoxCommentDetail
            // 
            this.textBoxCommentDetail.Location = new System.Drawing.Point(189, 115);
            this.textBoxCommentDetail.Name = "textBoxCommentDetail";
            this.textBoxCommentDetail.Size = new System.Drawing.Size(223, 27);
            this.textBoxCommentDetail.TabIndex = 9;
            // 
            // textBoxTitleDetail
            // 
            this.textBoxTitleDetail.Location = new System.Drawing.Point(189, 62);
            this.textBoxTitleDetail.Name = "textBoxTitleDetail";
            this.textBoxTitleDetail.Size = new System.Drawing.Size(223, 27);
            this.textBoxTitleDetail.TabIndex = 8;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelComment.Location = new System.Drawing.Point(64, 115);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(99, 20);
            this.labelComment.TabIndex = 7;
            this.labelComment.Text = "Commentaire";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitle.Location = new System.Drawing.Point(64, 62);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 20);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Titre";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonUpdate.Location = new System.Drawing.Point(231, 179);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(121, 33);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // IdLabelGoal
            // 
            this.IdLabelGoal.AutoSize = true;
            this.IdLabelGoal.Location = new System.Drawing.Point(479, 31);
            this.IdLabelGoal.Name = "IdLabelGoal";
            this.IdLabelGoal.Size = new System.Drawing.Size(0, 20);
            this.IdLabelGoal.TabIndex = 10;
            // 
            // GoalFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 274);
            this.Controls.Add(this.groupBox1);
            this.Name = "GoalFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GoalFrame";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        public TextBox textBoxCommentDetail;
        public TextBox textBoxTitleDetail;
        public Label labelComment;
        public Label labelTitle;
        public Button buttonUpdate;
        public Label IdLabelGoal;
    }
}