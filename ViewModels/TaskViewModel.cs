using WPFTaskList.Models;

namespace WPFTaskList.ViewModels
{
    class TaskViewModel
    {
        public TaskBase Task { get; }

        private TaskListViewModel _taskListViewModel { get; }

        public TaskViewModel(TaskListViewModel taskListViewModel)
        {
            _taskListViewModel = taskListViewModel;
            Task = taskListViewModel.SelectedTask;
        }

        public void RemoveTask()
        {
            _taskListViewModel.RemoveTask(Task);
        }
    }
}
