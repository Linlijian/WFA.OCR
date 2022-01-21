using System.Windows.Forms;

namespace Helper
{
    class UserControlHelper
    {
        public static void SetUserControl(Panel panel, UserControl userControl)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
        }
        public static void SetUserControl(Panel panel, UserControl userControl, string dockStyle)
        {
            panel.Controls.Clear();
            if (dockStyle == UserControlDockStyle.DockStyleFill)
            {
                userControl.Dock = DockStyle.Fill;
            }
            else if (dockStyle == UserControlDockStyle.DockStyleBottom)
            {
                userControl.Dock = DockStyle.Bottom;
            }
            else if (dockStyle == UserControlDockStyle.DockStyleLeft)
            {
                userControl.Dock = DockStyle.Left;
            }
            else if (dockStyle == UserControlDockStyle.DockStyleNone)
            {
                userControl.Dock = DockStyle.None;
            }
            else if (dockStyle == UserControlDockStyle.DockStyleRight)
            {
                userControl.Dock = DockStyle.Right;
            }
            else if (dockStyle == UserControlDockStyle.DockStyleTop)
            {
                userControl.Dock = DockStyle.Top;
            }
            panel.Controls.Add(userControl);
        }
        public static void SetControlSizePanel(Panel panel, int widthBefore = 0, int widthAfter = 0)
        {
            if (widthBefore != 0)
            {
                if (widthAfter != 0)
                {
                    if (panel.Width == widthBefore)
                    {
                        panel.Width = widthAfter;
                    }
                    else
                    {
                        panel.Width = widthBefore;
                    }
                }
                else
                {
                    panel.Width = widthBefore;
                }
            }
            else
            {
                panel.Width = widthBefore;
            }
        }

    }
}
