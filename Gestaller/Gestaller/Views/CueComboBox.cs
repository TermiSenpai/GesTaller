using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestaller.Views
{
    class CueComboBox : ComboBox
    {
        /// <summary>
        /// The cue banner text.
        /// </summary>
        private string _cueText;

        /// <summary>
        /// Gets or sets the cue banner text.
        /// </summary>
        public string CueText
        {
            get
            {
                return _cueText;
            }

            set
            {
                _cueText = value;
                Invalidate();
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if(!String.IsNullOrEmpty(CueText) && String.IsNullOrEmpty(Text) && SelectedIndex == -1)
            {
                SetCueText(this, CueText);
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            ForeColor = SystemColors.ControlText;
        }
        // Código sacado de: https://stackoverflow.com/questions/30622994/c-sharp-winforms-add-an-select-from-list-placeholder-to-databound-combobox

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("user32.dll")]
        private static extern bool GetComboBoxInfo(IntPtr hwnd, ref COMBOBOXINFO pcbi);
        [StructLayout(LayoutKind.Sequential)]

        private struct COMBOBOXINFO
        {
            public int cbSize;
            public RECT rcItem;
            public RECT rcButton;
            public UInt32 stateButton;
            public IntPtr hwndCombo;
            public IntPtr hwndItem;
            public IntPtr hwndList;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public static void SetCueText(ComboBox control, string text)
        {
            COMBOBOXINFO info = GetComboBoxInfo(control);
            SendMessage(info.hwndItem, EM_SETCUEBANNER, 0, text);
        }

        private static COMBOBOXINFO GetComboBoxInfo(Control control)
        {
            COMBOBOXINFO info = new COMBOBOXINFO();
            //a combobox is made up of three controls, a button, a list and textbox;
            //we want the textbox
            info.cbSize = Marshal.SizeOf(info);
            GetComboBoxInfo(control.Handle, ref info);
            return info;
        }
    }
}
