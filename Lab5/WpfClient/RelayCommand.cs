﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfClient
{

    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
        }

        public bool CanExecute(object parameter = null)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter = null)
        {
            this.execute(parameter);
        }
    }
}
