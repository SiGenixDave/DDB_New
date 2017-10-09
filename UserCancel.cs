using System;
using System.Windows.Forms;

namespace DDB
{
    /// <summary>
    /// Standard static class that presents a consistent user experience for canceling an operation.
    /// </summary>
    internal class UserCancel
    {
        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        private UserCancel()
        { }

        ////////////////////////////////////////////////////////////
        // Public methods
        ////////////////////////////////////////////////////////////
        public static Boolean Query(String info)
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to abort the changes that you made to the " + info + "?", "Cancel Operation",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean Query(String item, String name)
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to abort the changes that you made to the " + item
                                              + " \"" + name + "\" ?", "Cancel Operation",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}