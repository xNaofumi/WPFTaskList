using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFTaskList.Models
{
    public class TaskBase : INotifyPropertyChanged
    {
        public string Name { get; }
        public string Description { get; }
        public bool IsDone {
            get => _isDone;
            private set
            {
                _isDone = value;
                OnPropertyChanged("IsDone");
            } 
        }

        private bool _isDone;

        public TaskBase(string name, string description)
        {
            Name = name;
            Description = description;
            _isDone = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            if (PropertyChanged == null) return;
            
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void Finish()
        {
            IsDone = true;
        }
    }
}
