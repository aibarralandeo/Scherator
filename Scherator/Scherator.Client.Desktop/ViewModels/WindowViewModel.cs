using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Scherator.Client.Desktop.ViewModels
{
    /// <summary>
    /// The View Model for the custom flat window
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {
        #region Private Members

        /// <summary>
        /// The Window this View Model controls
        /// </summary>
        private Window window;

        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="window"></param>
        public WindowViewModel(Window window)
        {

        }
    }
}
