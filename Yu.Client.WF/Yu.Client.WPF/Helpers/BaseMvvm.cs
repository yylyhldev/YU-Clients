using System.ComponentModel;
using System.Windows.Input;

namespace Yu.Client.WPF.Helpers
{
    #region 继承 INotifyPropertyChanged，实现 OnPropertyChanged(string propertityName)
    /// <summary>
    /// 继承 INotifyPropertyChanged，实现 OnPropertyChanged
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertityName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertityName));
            }
        }
    }
    #endregion

    #region CommandBase：继承 ICommand
    /// <summary>
    /// CommandBase：继承 ICommand
    /// </summary>
    public class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;
        public RelayCommand(Action<object> execute)
        {
            _execute = execute;
        }
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            //return this.canExecute?.Invoke() != false;
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke(parameter);
        }
    }
    #endregion
}
