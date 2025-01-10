using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

/// <summary>
/// Represents a command that can be executed synchronously within the SwiftMart system.
/// Implements the <see cref="ICommand"/> interface and allows execution of a specified action.
/// </summary>
namespace SwiftMart.Commands
{

    public class RelayCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="execute">The action to execute when the command is invoked.</param>
        /// <param name="canExecute">An optional function that determines if the command can be executed. Defaults to <c>null</c>.</param>

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Determines whether the command can be executed.
        /// If no <see cref="canExecute"/> function is provided, the command is always executable.
        /// </summary>
        /// <param name="parameter">The parameter passed to the command.</param>
        /// <returns><c>true</c> if the command can be executed; otherwise, <c>false</c>.</returns>

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        /// <summary>
        /// Executes the action associated with the command.
        /// </summary>
        /// <param name="parameter">The parameter passed to the command.</param>

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        /// <summary>
        /// Occurs when the <see cref="CanExecute"/> value changes.
        /// This event is triggered when the state of the command changes, such as when <see cref="CanExecute"/> changes.
        /// </summary>

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
