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
            saved.Show();
        }
    }
}
