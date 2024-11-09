using System.Windows.Forms;

namespace Graphic_Layer
{
    public static class ValidacionesForm
    {
        public static bool ValidarCamposLlenos(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                {
                    MessageBox.Show($"El campo {control.Name} no puede estar vacío.");
                    return false;
                }

                if (control is ComboBox comboBox && comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show($"Debe seleccionar una opción para {control.Name}.");
                    return false;
                }

                if (control is DateTimePicker datePicker && datePicker.Value == null)
                {
                    MessageBox.Show($"Debe seleccionar una fecha para {control.Name}.");
                    return false;
                }
            }
            return true;
        }
    }
}
