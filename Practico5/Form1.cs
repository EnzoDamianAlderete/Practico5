using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BTNFoto_Click(object sender, EventArgs e)
        {
            // Configurar las propiedades del OpenFileDialog
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Title = "Seleccione una imagen";

            // Mostrar el OpenFileDialog y verificar si el usuario seleccionó un archivo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivo = openFileDialog1.FileName;

                // Mostrar la imagen seleccionada en el PictureBox
                pictureBox1.Image = Image.FromFile(rutaArchivo);

                // Mostrar la ruta del archivo en el TextBox
                TBFoto.Text = rutaArchivo;
            }
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            FormatearTexto(TBNombre);
        }

        private void FormatearTexto(TextBox textBox)
        {
            if (textBox.Text.Length > 0)
            {
                // Convertir la primera letra a mayúscula y el resto a minúscula
                string textoFormateado = char.ToUpper(textBox.Text[0]) + textBox.Text.Substring(1).ToLower();

                // Desactivar el evento temporalmente para evitar bucles
                textBox.TextChanged -= TBNombre_TextChanged;

                // Establecer el texto formateado
                textBox.Text = textoFormateado;

                // Volver a activar el evento
                textBox.TextChanged += TBNombre_TextChanged;

                // Mover el cursor al final del texto
                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;
            }
        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {
            FormatearTexto(TBApellido);
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(TBNombre.Text) ||
                string.IsNullOrWhiteSpace(TBApellido.Text) ||
                string.IsNullOrWhiteSpace(TBSaldo.Text) ||
                (!CBHombre.Checked && !CBMujer.Checked))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validar que el saldo solo contenga números
            if (!decimal.TryParse(TBSaldo.Text, out decimal saldo))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el saldo.");
                return;
            }

            // Obtener los valores de los campos
            string nombre = TBNombre.Text;
            string apellido = TBApellido.Text;
            string sexo = CBHombre.Checked ? "Hombre" : "Mujer";
            DateTime fecha = DTPFecha.Value;

            // Crear la fila
            int rowIndex = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            // Asignar valores a las celdas
            row.Cells["Nombre"].Value = nombre;
            row.Cells["Apellido"].Value = apellido;
            row.Cells["Sexo"].Value = sexo;
            row.Cells["FechaNacimiento"].Value = fecha.ToShortDateString();
            row.Cells["Saldo"].Value = saldo;

            // Agregar el botón Eliminar
            DataGridViewButtonCell eliminarButton = new DataGridViewButtonCell();
            eliminarButton.Value = "Eliminar";
            row.Cells["Eliminar"] = eliminarButton;

            // Cambiar el fondo de la fila si el saldo es menor a $50
            if (saldo < 50)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
            }
            // Vaciar los campos después de agregar
            TBNombre.Clear();
            TBApellido.Clear();
            TBSaldo.Clear();
            TBFoto.Clear();
            CBHombre.Checked = false;
            CBMujer.Checked = false;
            DTPFecha.Value = DateTime.Now;
            pictureBox1.Image = null; // Vaciar el PictureBox
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en el botón Eliminar
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                // Mostrar un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si el usuario confirma, eliminar la fila
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void TBSaldo_TextChanged(object sender, EventArgs e)
        {
            // Guardar la posición actual del cursor
            int cursorPosition = TBSaldo.SelectionStart;

            // Filtrar caracteres no numéricos
            string textoFiltrado = string.Concat(TBSaldo.Text.Where(char.IsDigit));

            // Actualizar el texto del TextBox solo si hubo un cambio
            if (textoFiltrado != TBSaldo.Text)
            {
                TBSaldo.Text = textoFiltrado;

                // Restaurar la posición del cursor
                TBSaldo.SelectionStart = cursorPosition - 1 >= 0 ? cursorPosition - 1 : 0;
            }
        }
    }
}
