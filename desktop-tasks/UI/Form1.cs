using desktop_tasks.Models;

namespace desktop_tasks
{
    public partial class TasksFrame : Form
    {
        public TasksFrame()
        {
            InitializeComponent();
        }

        ApplicationDbContext _dbContext = new ApplicationDbContext();

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Goal goal = new Goal();
                goal.Title = textBoxTitle.Text;
                goal.Comment = textBoxComment.Text;
                goal.isDone = false;
                goal.isArchived = false;
                _dbContext.Goals.Add(goal);
                _dbContext.SaveChanges();
                MessageBox.Show("La tâche a bien été crée","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TasksFrame_Load(object sender, EventArgs e)
        {

        }

    }
}