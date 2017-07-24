using System;
using System.Windows.Forms;

namespace DDB
{
    internal class Cancel
    {
        private Cancel()
        { }

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
    }
}