using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWareHourse.Helpers
{
   public static class ControlHelpers
    {
        public static void EmptyGroupBox(GroupBox box)
        {
            foreach (Control item in box.Controls)
            {
                if (item is TextBox)
                {
                    ((Control)item).Text = string.Empty;
                }
            }
        }

    }
}
