using System.Windows.Forms;
using System.Text.RegularExpressions;
using System;

namespace Helper
{
    class Global
    {
        #region Panel
        /// <summary>
        /// To hide PActive control.
        /// </summary>
        /// <param name="_control">Panel to hine PActive</param>
        public static void PActiveHide(Control  _control)
        {
            foreach (Control panel in _control.Controls)
            {
                PAFindControl(panel.Controls);
            }

        }

        /// <summary>
        /// To hide PActive control and show one panel.
        /// </summary>
        /// <param name="_control">Panel to hine PActive</param>
        /// <param name="_panel">Panel to show PActive</param>
        public static void PActiveHide(Control _control, Control _panel)
        {
            foreach (Control panel in _control.Controls)
            {
                PAFindControl(panel.Controls);
            }

            _panel.Show();
        }

        /// <summary>
        /// To show PActive control.
        /// </summary>
        /// <param name="_control">Panel to show PActive</param>
        public static void PActiveShow(Control _control)
        {
            _control.Show();
        }

        /// <summary>
        /// To hide PSActive control.
        /// </summary>
        /// <param name="_control">Panel to hide PSActive</param>
        public static void PSActiveHide(Control _control)
        {
            foreach (Control panel in _control.Controls)
            {
                PSAFindControl(panel.Controls);
            }
        }

        /// <summary>
        /// To show PSActive control.
        /// </summary>
        /// <param name="_control">Panel to show PSActive</param>
        public static void PSActiveShow(Control _control)
        {
            _control.Show();
        }

        /// <summary>
        /// To show sub menu in control.
        /// </summary>
        /// <param name="_control">Main menu to show sub menu in it</param>
        public static void PShowMenu(Control _control)
        {
            _control.Show();
        }

        /// <summary>
        /// To hide sub menu in control.
        /// </summary>
        /// <param name="_control">Main menu to hide sub menu in it</param>
        public static void PHideMenu(Control _control)
        {
            _control.Hide();
        }

		/// <summary>
		/// Panel Dispose
		/// </summary>
		/// <param name="_control"></param>
		public static void PDispose(Control _control)
		{
			_control.Dispose();
		}
		#endregion

		#region Method
		/// <summary>
		/// find children in control
		/// </summary>
		/// <param name="controls"></param>
		private static void PAFindControl(Control.ControlCollection controls)
        {
            var regex = new Regex("(PA)");
            foreach (Control control in controls)
            {
                if (control.Controls.Count > 0)
                {
                    PAFindControl(control.Controls);
                }
                else
                {
                    if (regex.IsMatch(control.Name))
                        control.Hide();
                }
            }
        }

        /// <summary>
        /// find children in control
        /// </summary>
        /// <param name="controls"></param>
        private static void PSAFindControl(Control.ControlCollection controls)
        {
            var regex = new Regex("(PSA)");
            foreach (Control control in controls)
            {
                if (control.Controls.Count > 0)
                {
                    PSAFindControl(control.Controls);
                }
                else
                {
                    if (regex.IsMatch(control.Name))
                        control.Hide();
                }
            }
        }
		#endregion

	}
}
