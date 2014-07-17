using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Notebook
{
    class ButtonUse
    {
        #region public methods

        /// <summary>
        /// Changes windows visibility after use a button
        /// </summary>
        /// <param name="oldWnd">Window to hide</param>
        /// <param name="newWnd">Window to show</param>
        public void ChangeWindow(Window oldWnd, Window newWnd)
        {
            oldWnd.Hide();
            newWnd.Show();
        }

        /// <summary>
        /// Close the application
        /// </summary>
        public void ExitBtn()
        {
            Environment.Exit(0);
        }

        #endregion
    }
}
