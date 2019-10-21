using SureVersion.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SureVersion.Util
{
    public class FormUtil
    {
        public static void CleanForm(GroupBox pGroupBox)
        {
            foreach (var Control in pGroupBox.Controls)
            {
                if (Control.GetType() == typeof(TextBox))
                {
                    var TextBox = Control as TextBox;

                    if (TextBox.Enabled)
                    {
                        TextBox.Text = string.Empty;
                    }
                }
                else if (Control.GetType() == typeof(ComboBox))
                {
                    var ComboBox = Control as ComboBox;

                    if (ComboBox.Enabled)
                    {
                        ComboBox.SelectedIndex = 0;
                    }
                }
                else if (Control.GetType() == typeof(CheckBox))
                {
                    var CheckBox = Control as CheckBox;

                    if (CheckBox.Enabled)
                    {
                        CheckBox.Checked = false;
                    }
                }
            }
        }

        public static void Update_List(
            ComboBox comboBox, 
            IEnumerable<KeyValuePair<string, string>> list, 
            string ValueMember = "Key", 
            string DisplayMember = "Value",
            string DefaultOption = "[SELECCIONE]")
        {
            if (list != null)
            {
                BindingList<KeyValuePair<string, string>> BindingList = 
                    new BindingList<KeyValuePair<string, string>>(DefaultList(list, DefaultOption));

                BindingSource BSource = new BindingSource
                {
                    DataSource = BindingList
                };
                comboBox.DataSource = BSource;
                comboBox.ValueMember = ValueMember;
                comboBox.DisplayMember = DisplayMember;
                //pComboBox.Refresh();
            }
        }

        public static void SetFocusFirstInput(GroupBox pGroupBox)
        {
            foreach (var Control in pGroupBox.Controls)
            {
                if (Control.GetType() == typeof(TextBox))
                {
                    var TextBox = Control as TextBox;

                    if (TextBox.TabIndex == 1)
                    {
                        TextBox.Focus();

                        return;
                    }
                }
            }
        }

        private static List<KeyValuePair<string, string>> DefaultList(IEnumerable<KeyValuePair<string, string>> pInitList, string defaultOption)
        {
            var InitList = new List<KeyValuePair<string, string>>(pInitList);

            InitList.Insert(0, new KeyValuePair<string, string>(null, defaultOption));

            return InitList;
        }
    }
}
