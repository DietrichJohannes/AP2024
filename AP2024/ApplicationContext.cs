using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AP2024
{
    public static class ApplicationContext
    {
        public static string GetConnectionString()
        {
            return "Data Source=data/AP2024.db";
        }

        public static string GetCurrentDate()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString("dd.mm.yyyy");
        }

        public static string GetCurrentTime()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString("HH:mm:ss");
        }

        public static string GetCurrentWindowsUser()
        {
            string user = Environment.UserName.ToLower();
            return user;
        }

        public static void InitFirstStart()
        {
            bool SuperAdminBox;

            DialogResult result = MessageBox.Show(
                "Es scheint der Erste Start von AP2024 zu sein.\nMöchten Sie das Setup starten um AP2024 einzurichten?",
                "AP2024 Setup starten",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            SuperAdminBox = result == DialogResult.Yes;

            if (SuperAdminBox)
            {
                SetupController.AtFirstStartAddSuperAdmin();
                SetupController.StartSetup();
            }
        }
    }
}
