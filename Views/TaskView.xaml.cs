using System.Windows;
using WPFTaskList.ViewModels;

namespace WPFTaskList.Views
{
    public partial class TaskView : Window
    {
        private TaskViewModel _taskViewModel { get; }

        public TaskView(TaskListViewModel taskListViewModel)
        {
            InitializeComponent();

            _taskViewModel = new TaskViewModel(taskListViewModel);
            DataContext = _taskViewModel;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonFinish_Click(object sender, RoutedEventArgs e)
        {
            _taskViewModel.Task.Finish();
        }

        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
        {
            _taskViewModel.RemoveTask();
            Close();
        }
    }
}
