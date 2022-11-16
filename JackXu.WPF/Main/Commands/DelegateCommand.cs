using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JackXu.WPF.Main.Commands
{
    public class DelegateCommand : ICommand
    {
        private readonly Action _action;
        private readonly Func<bool> _canExecuteAct;

        public DelegateCommand(Action action, Func<bool> canExecuteAct )
        {
            _action = action;
            _canExecuteAct = canExecuteAct;
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return _canExecuteAct();
        }

        public void Execute(object? parameter)
        {
            _action();
        }

        public void RaiseCanExecuteChange()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
