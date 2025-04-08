using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AP2024
{
    public static class ThemeManager
    {
        public static void ApplyTheme(Form form)
        {
            if (!ApplicationContext.LIGHT_MODE)
            {
                EnableDarkTitleBar(form.Handle); // Titelleiste dunkel
                ApplyDarkTheme(form);
            }
            else
            {
                // Optional: Light-Theme implementieren
            }
        }

        private static void ApplyDarkTheme(Form form)
        {
            form.BackColor = Color.FromArgb(30, 30, 30);
            form.ForeColor = Color.White;

            ToolTip tooltip = new ToolTip();

            foreach (Control control in form.Controls)
            {
                ApplyDarkStyleToControl(control, tooltip);
            }

            // Menüleisten manuell anpassen (falls vorhanden)
            if (form.MainMenuStrip != null)
            {
                ApplyDarkMenuStrip(form.MainMenuStrip);
            }
        }

        private static void ApplyDarkStyleToControl(Control control, ToolTip tooltip = null)
        {
            if (control is Button btn)
            {
                btn.BackColor = Color.FromArgb(45, 45, 48);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.DimGray;

                // Hover-Effekt
                btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(60, 60, 60);
                btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(45, 45, 48);

                // ToolTip (optional, bei Bildbuttons sinnvoll)
                if (tooltip != null && string.IsNullOrEmpty(tooltip.GetToolTip(btn)))
                {
                    tooltip.SetToolTip(btn, btn.Text);
                }
            }
            else if (control is TextBox tb)
            {
                tb.BackColor = Color.FromArgb(40, 40, 40);
                tb.ForeColor = Color.White;
                tb.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (control is Label lbl)
            {
                lbl.ForeColor = Color.White;
                lbl.BackColor = Color.Transparent;
            }
            else if (control is DataGridView dgv)
            {
                dgv.BackgroundColor = Color.FromArgb(30, 30, 30);
                dgv.ForeColor = Color.White;
                dgv.GridColor = Color.Gray;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.EnableHeadersVisualStyles = false;

                
                dgv.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
                dgv.DefaultCellStyle.ForeColor = Color.White;
                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
                dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else if (control is ComboBox cb)
            {
                cb.BackColor = Color.FromArgb(40, 40, 40);
                cb.ForeColor = Color.White;
                cb.FlatStyle = FlatStyle.Flat;
            }
            else if (control is CheckBox chk)
            {
                chk.ForeColor = Color.White;
                chk.BackColor = Color.Transparent;
            }
            else if (control is MenuStrip)
            {
                ApplyDarkMenuStrip((MenuStrip)control);
            }
            else if (control is ListView lv)
            {
                lv.BackColor = Color.FromArgb(40, 40, 40);
                lv.ForeColor = Color.White;
                lv.BorderStyle = BorderStyle.FixedSingle;
                lv.FullRowSelect = true;
                lv.HideSelection = false;

                lv.OwnerDraw = false; // optional: true, wenn du Header oder Zeilen komplett selbst zeichnen willst
                lv.HeaderStyle = ColumnHeaderStyle.Clickable;

                lv.Font = new Font("Segoe UI", 9); // optional: Font vereinheitlichen

                // Auswahlfarben
                lv.ForeColor = Color.White;
                lv.BackColor = Color.FromArgb(40, 40, 40);
            }


            // Rekursion für Untercontrols
            foreach (Control child in control.Controls)
            {
                ApplyDarkStyleToControl(child, tooltip);
            }
        }

        private static void ApplyDarkMenuStrip(MenuStrip menuStrip)
        {
            menuStrip.BackColor = Color.FromArgb(45, 45, 45);
            menuStrip.ForeColor = Color.White;
            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                ApplyDarkStyleToMenuItem(item);
            }
        }

        private static void ApplyDarkStyleToMenuItem(ToolStripMenuItem menuItem)
        {
            menuItem.BackColor = Color.FromArgb(45, 45, 45);
            menuItem.ForeColor = Color.White;

            foreach (ToolStripItem subItem in menuItem.DropDownItems)
            {
                if (subItem is ToolStripMenuItem subMenuItem)
                {
                    ApplyDarkStyleToMenuItem(subMenuItem);
                }
                else
                {
                    subItem.BackColor = Color.FromArgb(45, 45, 45);
                    subItem.ForeColor = Color.White;
                }
            }
        }

        private static void EnableDarkTitleBar(IntPtr handle)
        {
            if (Environment.OSVersion.Version.Build >= 17763) // Windows 10 1809+
            {
                int useDarkMode = 1;
                DwmSetWindowAttribute(handle, DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, ref useDarkMode, sizeof(int));
            }
        }

        private enum DWMWINDOWATTRIBUTE
        {
            DWMWA_USE_IMMERSIVE_DARK_MODE = 20
        }

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE attribute, ref int pvAttribute, int cbAttribute);
    }
}
