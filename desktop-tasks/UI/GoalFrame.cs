using desktop_tasks.Manager;
using desktop_tasks.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_tasks.UI
{
    public partial class GoalFrame : Form
    {
        TasksFrame frm;
        public GoalFrame(TasksFrame frm)
        {
            InitializeComponent();
            this.frm = frm;
        }


        GoalManager _goalManager = new GoalManager();
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxTitleDetail.Text))
                {
                    MessageBox.Show("Le champ titre est vide", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxTitleDetail.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(textBoxCommentDetail.Text))
                {
                    MessageBox.Show("Le champ commentaire est vide", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxCommentDetail.Focus();
                    return;
                }
                Goal goal = new Goal();
                goal.Id = Convert.ToInt32(IdLabelGoal.Text);
                goal.Title = textBoxTitleDetail.Text;
                goal.Comment = textBoxCommentDetail.Text;
                if (_goalManager.Update(goal))
                {
                    MessageBox.Show("La tâche a bien été modifiée !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frm.LoadData();
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
