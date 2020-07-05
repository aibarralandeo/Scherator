using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Scherator.Client.Desktop.ViewModels
{
    /// <summary>
    /// A basic command that runs an action
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Private members

        /// <summary>
        /// Action to execute
        /// </summary>
        private readonly Action action;

        #endregion

        #region Public events

        /// <summary>
        /// The event that fires when <see cref="CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => {};

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public RelayCommand(Action action)
        {
            this.action = action;
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// A relay command can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter) => true;

        /// <summary>
        /// Executes the command's Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            this.action();
        }

        #endregion
    }
}
