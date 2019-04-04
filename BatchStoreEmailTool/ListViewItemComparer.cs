using System;
using System.Windows.Forms;
using System.Collections;

namespace BatchStoreEmailTool
{
    // Implements the manual sorting of items by columns.
    class ListViewItemComparer : IComparer
    {
        private int col;

        public ListViewItemComparer()
        {
            col = 0;
        }

        public ListViewItemComparer(int column)
        {
            col = column;
        }

        public int Compare(object x, object y)
        {
            return string.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
        }
    }
}
