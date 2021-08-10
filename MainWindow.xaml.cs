using System.Windows;
using System.Windows.Input;
using WPFTaskList.ViewModels;

namespace WPFTaskList
{
    public partial class MainWindow : Window
    {
        private TaskListViewModel taskListViewModel;

        public MainWindow()
        {
            InitializeComponent();

            taskListViewModel = new TaskListViewModel();
            DataContext = taskListViewModel;
        }

        private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            taskListViewModel.ShowSelectedTaskView();
        }
    }
}
