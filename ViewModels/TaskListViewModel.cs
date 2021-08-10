using System.Collections.ObjectModel;
using System.Windows.Input;
using WPFTaskList.Models;
using WPFTaskList.Utility;
using WPFTaskList.Views;

namespace WPFTaskList.ViewModels
{
    public class TaskListViewModel
    {
        public ICommand NewTaskCommand { get; }
        public ICommand ClearAllTasksCommand { get; }

        public ObservableCollection<TaskBase> TaskList { get; }
        public TaskBase SelectedTask { get; set; }

        public TaskListViewModel()
        {
            TaskList = new ObservableCollection<TaskBase>();

            NewTaskCommand = new RelayCommand(_ => ShowNewTaskWindow());
            ClearAllTasksCommand = new RelayCommand(_ => ClearAllTasks());
        }

        public void ShowSelectedTaskView()
        {
            var taskView = new TaskView(this);
            taskView.Show();
        }

        public void AddTask(TaskBase task)
        {
            TaskList.Insert(0, task);
        }

        public void RemoveTask(TaskBase task)
        {
            TaskList.Remove(task);
        }

        private void ClearAllTasks()
        {
            TaskList.Clear();
        }

        private void ShowNewTaskWindow()
        {
            var newTaskView = new NewTaskView(this);
            newTaskView.Show();
        }
    }
}
