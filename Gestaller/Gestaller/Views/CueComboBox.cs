using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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


        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            createCue();
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            deleteCue(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnEnter(e);
            createCue();
        }

        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
            //when we click to open the dropdown, we remove that item
            deleteCue(e);
        }

        protected override void OnDropDownClosed(EventArgs e)
        {
            base.OnDropDownClosed(e);

            //when we close the dropdown, if we select an item the dropdown
            //displays that item, if now we set back to our text.
            if (!base.Focused && base.SelectedIndex == -1)
            {
                createCue();
            }
        }

        private void createCue()
        {
            if (!String.IsNullOrEmpty(CueText) && String.IsNullOrEmpty(base.Text))
            {
                //add an item to the combobox at the top
                base.Items.Insert(0, CueText);
                //set the text
                base.Text = CueText;
                base.ForeColor = SystemColors.GrayText;
            }
        }

        private void deleteCue(EventArgs e)
        {
            if (base.Text == CueText)
            {
                base.Text = "";
                base.ForeColor = SystemColors.WindowText;
            }
            if (base.Items.Contains(CueText))
                base.Items.RemoveAt(0);
        }
    }
}
