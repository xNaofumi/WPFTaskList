using System.Windows;
using WPFTaskList.Models;
using WPFTaskList.ViewModels;

namespace WPFTaskList.Views
{
    public partial class NewTaskView : Window
    {
        private TaskListViewModel _taskListViewModel { get; }

        public NewTaskView(TaskListViewModel taskListViewModel)
        {
            InitializeComponent();
            _taskListViewModel = taskListViewModel;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            var task = new TaskBase(nameText.Text, descriptionText.Text);
            _taskListViewModel.AddTask(task);

            Close();
        }
    }
}
