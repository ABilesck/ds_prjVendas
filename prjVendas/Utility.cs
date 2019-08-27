using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjVendas
{
    class Utility
    {
        public void LimpaCampos(Control control)
        {
            foreach (var item in control.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Text = "";
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Today;
                }
            }
        }

        public void HabilitaCampos(Control control, bool hab)
        {
            foreach (var item in control.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Enabled = hab;
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Enabled = hab;
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Enabled = hab;
                }
            }
        }

        public void HabilitaBotoes(Control control)
        {
            foreach (var item in control.Controls)
            {
                if (item is Button)
                    ((Button)item).Enabled = !((Button)item).Enabled;
            }

        }
    }

    public enum Operacao
    {
        incluir,
        alterar
    }
}
