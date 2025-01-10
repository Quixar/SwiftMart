using System.Windows.Input;


/// <summary>
/// Represents a command that can be executed asynchronously within the SwiftMart system.
/// Implements the <see cref="ICommand"/> interface and allows asynchronous execution of a specified action.
/// </summary>
namespace SwiftMart.Commands
{


    public class AsyncRelayCommand : ICommand
    {
        private readonly Func<Task> execute;
        private readonly Func<bool> canExecute;

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncRelayCommand"/> class.
        /// </summary>
        /// <param name="execute">The asynchronous action to execute when the command is invoked.</param>
        /// <param name="canExecute">An optional function that determines if the command can be executed. Defaults to <c>null</c>.</param>
        public AsyncRelayCommand(Func<Task> execute, Func<bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Occurs when the <see cref="CanExecute"/> value changes.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Determines whether the command can be executed.
        /// If no <see cref="canExecute"/> function is provided, the command is always executable.
        /// </summary>
        /// <param name="parameter">The parameter passed to the command (unused in this case).</param>
        /// <returns><c>true</c> if the command can be executed; otherwise, <c>false</c>.</returns>
        public bool CanExecute(object parameter) => canExecute == null || canExecute();

        /// <summary>
        /// Executes the asynchronous action associated with the command.
        /// </summary>
        /// <param name="parameter">The parameter passed to the command (unused in this case).</param>
        public async void Execute(object parameter)
        {
            await execute();
        }

        /// <summary>
        /// Raises the <see cref="CanExecuteChanged"/> event to notify that the ability to execute the command has changed.
        /// This should be called when conditions that affect whether the command can be executed change.
        /// </summary>
        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    
    }
}
