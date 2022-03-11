using desktop_tasks.Manager;
using desktop_tasks.Models;

namespace desktop_tasks
{
    public partial class TasksFrame : Form
    {
        public TasksFrame()
        {
            InitializeComponent();
        }

        GoalManager _goalManager = new GoalManager();
        ApplicationDbContext _dbContext = new ApplicationDbContext();


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxTitle.Text))
                {
                    MessageBox.Show("Le champ titre est vide", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxTitle.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(textBoxComment.Text))
                {
                    MessageBox.Show("Le champ commentaire est vide", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxComment.Focus();
                    return;
                }
                Goal goal = new Goal();
                goal.Title = textBoxTitle.Text;
                goal.Comment = textBoxComment.Text;
                goal.isDone = false;
                goal.isArchived = false;
                if(_goalManager.Add(goal))
                {
                    MessageBox.Show("La tâche a bien été crée !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    LoadData();
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

        private void Reset()
        {
            textBoxTitle.Clear();
            textBoxComment.Clear();
        }
            private void TasksFrame_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            var goals = _goalManager.GetAll();
            dataGridViewGoals.Rows.Clear();
            foreach (var goal in goals)
            {
                dataGridViewGoals.Rows.Add(goal.Id, goal.Title, goal.Comment);
            }
        }
    }
}