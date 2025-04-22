using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2024
{
    internal class NotificationController
    {
        public static void Saved()
        {
            Saved saved = new Saved();
            saved.ShowDialog();
        }

        public static void Deleted()
        {
            Deleted deleted = new Deleted();
            deleted.ShowDialog();
        }

        public static void Updated()
        {
            Updated updated = new Updated();
            updated.ShowDialog();
        }

        public static void SelectItem()
        {
            SelectEmployee selectItem = new SelectEmployee();
            selectItem.ShowDialog();
        }
    }
}
