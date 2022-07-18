using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Newtonsoft.Json;

namespace Form1
{
    public partial class Form1 : Form
    {
        string pathImage=$"{AppDomain.CurrentDomain.BaseDirectory}\\usuario.png";
        int a = 1;
        int b = 1;
        List<clssContactoEmpresarial> contactoempresarialList = new List<clssContactoEmpresarial>();
        List<clssCompañia> compañiaList = new List<clssCompañia>();

        public Form1()
        {
            InitializeComponent();
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\ContactosEmpresariales.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                contactoempresarialList = JsonConvert.DeserializeObject<List<clssContactoEmpresarial>>(json);
                dgvContactosEmpresariales.DataSource = contactoempresarialList;
            }
            pbImagen.Image=Image.FromFile(pathImage);

            var auxList = new List<string> { };
            json = string.Empty;
            pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Compañias.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                compañiaList = JsonConvert.DeserializeObject<List<clssCompañia>>(json);
                for (int i = 0; i < compañiaList.Count; i++)
                {
                        auxList.Add(compañiaList[i].Nombre);
                }
            }
            cbCompañia.DataSource = auxList;
        }
        private void BorradoCamposRellenables()
        {
            txtbNombre.Text = string.Empty;
            txtbTelefono.Text = string.Empty;
            txtbPosición.Text = string.Empty;
            cbCompañia.SelectedItem = null;
            pathImage = $"{AppDomain.CurrentDomain.BaseDirectory}\\usuario.png";
            pbImagen.Image = Image.FromFile(pathImage);
        }
        private void BorradoCamposRellenables2()
        {
            txtbNombre2.Text = string.Empty;
            txtbTelefono2.Text = string.Empty;
            txtbDirección.Text = string.Empty;
            cbTipo.SelectedItem = null;
        }

        public class clssContactoEmpresarial
        {
            public Guid ID { get; set; }
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Compañia { get; set; }
            public string Posición { get; set; }
            public string Imagen { get; set; }
            public DateTime Fecha { get; set; }
        }
        public class clssCompañia
        {
            public Guid ID { get; set; }
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Dirección { get; set; }
            public string Tipo { get; set; }
            public DateTime Fecha { get; set; }
        }

        public void Editar_Guardar()
        {
            int j = 0;
            var vContactoEmpresarial = new clssContactoEmpresarial()
            {
                Compañia = cbCompañia.SelectedItem.ToString(),
                Fecha = DateTime.Now,
                Nombre = txtbNombre.Text,
                Telefono = txtbTelefono.Text,
                Posición=txtbPosición.Text,
                Imagen=pathImage.ToString(),
            };
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\ContactosEmpresariales.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                contactoempresarialList = JsonConvert.DeserializeObject<List<clssContactoEmpresarial>>(json);
                for (int i = 0; i < contactoempresarialList.Count; i++)
                {
                    if (contactoempresarialList[i].Nombre == vContactoEmpresarial.Nombre)
                    {
                        contactoempresarialList.Remove(contactoempresarialList[i]);
                        contactoempresarialList.Add(vContactoEmpresarial);
                        MessageBox.Show($"El contacto {txtbNombre.Text} fue encontrado y actualizado.");
                        j = 1;
                        break;
                    }
                }
                if (j == 0)
                {
                    contactoempresarialList.Add(vContactoEmpresarial);
                    MessageBox.Show($"El contacto {txtbNombre.Text} agregado correctamente.");

                }
            }
            else
            {
                contactoempresarialList.Add(vContactoEmpresarial);
                MessageBox.Show($"El contacto {txtbNombre.Text} agregado correctamente.");
            }
            json = JsonConvert.SerializeObject(contactoempresarialList);
            var sv = new StreamWriter(pathFile, false, Encoding.UTF8);
            sv.Write(json);
            sv.Close();
            dgvContactosEmpresariales.DataSource = null;
            dgvContactosEmpresariales.DataSource = contactoempresarialList;
        }
        public void Editar_Guardar2()
        {
            int j = 0;
            var vCompañia = new clssCompañia()
            {
                Tipo = cbTipo.SelectedItem.ToString(),
                Fecha = DateTime.Now,
                Nombre = txtbNombre2.Text,
                Telefono = txtbTelefono2.Text,
                Dirección = txtbDirección.Text,
            };
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Compañias.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                compañiaList = JsonConvert.DeserializeObject<List<clssCompañia>>(json);
                for (int i = 0; i < compañiaList.Count; i++)
                {
                    if (compañiaList[i].Nombre == txtbNombre2.Text)
                    {
                        compañiaList.Remove(compañiaList[i]);
                        compañiaList.Add(vCompañia);
                        MessageBox.Show($"La compañia {txtbNombre2.Text} fue encontrado y actualizado.");
                        j = 1;
                        break;
                    }
                }
                if (j == 0)
                {
                    compañiaList.Add(vCompañia);
                    MessageBox.Show($"La compañia {txtbNombre2.Text} ha sido agregada correctamente.");

                }
            }
            else
            {
                compañiaList.Add(vCompañia);
                MessageBox.Show($"La Compañia {txtbNombre2.Text} ha sido agregada correctamente.");
            }
            json = JsonConvert.SerializeObject(compañiaList);
            var sv = new StreamWriter(pathFile, false, Encoding.UTF8);
            sv.Write(json);
            sv.Close();
            dgvContactosEmpresariales.DataSource = null;
            dgvContactosEmpresariales.DataSource = compañiaList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            BorradoCamposRellenables();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Editar_Guardar();
            BorradoCamposRellenables();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void tboxTelefono_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtbNombre.Clear();
            txtbTelefono.Clear();
            cbCompañia.Text = String.Empty;
            MessageBox.Show("Casillas limpiadas");
        }

        private void cboxCompañia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            int j = 0;
            var vContactoEmpresarial = new clssContactoEmpresarial()
            {
                Nombre = txtbNombre.Text,
            };
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\ContactosEmpresariales.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                contactoempresarialList = JsonConvert.DeserializeObject<List<clssContactoEmpresarial>>(json);
                for (int i = 0; i < contactoempresarialList.Count; i++)
                {
                    if (contactoempresarialList[i].Nombre.ToString() == txtbNombre.Text)
                    {
                        bttnEliminar.Enabled = true;
                        cbCompañia.SelectedItem = contactoempresarialList[i].Compañia.ToString();
                        txtbTelefono.Text = contactoempresarialList[i].Telefono.ToString();
                        txtbPosición.Text = contactoempresarialList[i].Posición.ToString();
                        txtbNombre.Text = contactoempresarialList[i].Nombre.ToString();
                        pbImagen.Image = Image.FromFile(contactoempresarialList[i].Imagen.ToString());
                        j = 1;
                        break;
                    }
                }
                if (j == 0)
                {
                    MessageBox.Show($"El contacto referenciado como {txtbNombre.Text}, No existe");
                }
            }
            else
            {
                MessageBox.Show($"Aún no ha ingresado ningun dato.");
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            int j = 0;
            var vContactoEmpresarial = new clssContactoEmpresarial()
            {
                Compañia = cbCompañia.SelectedItem.ToString(),
                Fecha = DateTime.Now,
                Nombre = txtbNombre.Text,
                Telefono = txtbTelefono.Text,
                Posición = txtbPosición.Text,
                Imagen = pathImage.ToString(),
            };
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\ContactosEmpresariales.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                contactoempresarialList = JsonConvert.DeserializeObject<List<clssContactoEmpresarial>>(json);
                for (int i = 0; i < contactoempresarialList.Count; i++)
                {
                    if (contactoempresarialList[i].Nombre.ToString() == txtbNombre.Text)
                    {
                        contactoempresarialList.Remove(contactoempresarialList[i]);
                        MessageBox.Show($"El contacto {txtbNombre.Text} fue eliminado correctamente.");
                        j = 1;
                        break;
                    }
                }
                if (j == 0)
                {
                    MessageBox.Show($"No existe ningun contacto con el nombre de {txtbNombre.Text} que coincida en la lista.");
                }
            }
            else
            {
                MessageBox.Show($"Aún no se han ingresado gastos.");
            }
            json = JsonConvert.SerializeObject(contactoempresarialList);
            var sv = new StreamWriter(pathFile, false, Encoding.UTF8);
            sv.Write(json);
            sv.Close();
            dgvContactosEmpresariales.DataSource = null;
            dgvContactosEmpresariales.DataSource = contactoempresarialList;
            bttnEliminar.Enabled = false;
            BorradoCamposRellenables();
        }

        private void bttnCargarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pathImage = openFileDialog1.FileName;
                    pbImagen.Image= Image.FromFile(pathImage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }

        }

        private void gbGestiónCompañia_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BorradoCamposRellenables2();
            gbGestiónCompañia.Visible = false;
            dgvContactosEmpresariales.DataSource = contactoempresarialList;
            var auxList = new List<string> { };
            var json = string.Empty;
            string pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Compañias.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                compañiaList = JsonConvert.DeserializeObject<List<clssCompañia>>(json);
                for (int i = 0; i < compañiaList.Count; i++)
                {
                    auxList.Add(compañiaList[i].Nombre);
                }
            }
            cbCompañia.DataSource = auxList;

        }

        private void bttnCompañia_Click(object sender, EventArgs e)
        {
            gbGestiónCompañia.Visible = true;
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Compañias.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                compañiaList = JsonConvert.DeserializeObject<List<clssCompañia>>(json);
                dgvContactosEmpresariales.DataSource = compañiaList;
            }
        }

        private void bttnBuscar2_Click(object sender, EventArgs e)
        {
            int j = 0;
            var vCompañia = new clssCompañia()
            {
                Nombre = txtbNombre2.Text,
            };
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Compañias.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                compañiaList = JsonConvert.DeserializeObject<List<clssCompañia>>(json);
                for (int i = 0; i < compañiaList.Count; i++)
                {
                    if (compañiaList[i].Nombre.ToString() == txtbNombre2.Text)
                    {
                        bttnEliminar2.Enabled = true;
                        cbTipo.SelectedItem = compañiaList[i].Tipo.ToString();
                        txtbTelefono2.Text = compañiaList[i].Telefono.ToString();
                        txtbDirección.Text = compañiaList[i].Dirección.ToString();
                        txtbNombre2.Text = compañiaList[i].Nombre.ToString();
                        j = 1;
                        break;
                    }
                }
                if (j == 0)
                {
                    MessageBox.Show($"La compañia referenciada como {txtbNombre2.Text}, no existe en la base de datos");
                }
            }
            else
            {
                MessageBox.Show($"Aún no ha ingresado ningun dato.");
            }
        }

        private void bttnGuardar2_Click(object sender, EventArgs e)
        {
            Editar_Guardar2();
            BorradoCamposRellenables2();
        }

        private void bttnEliminar2_Click(object sender, EventArgs e)
        {
            int j = 0;
            var vCompañia = new clssCompañia()
            {
                Tipo = cbTipo.SelectedItem.ToString(),
                Fecha = DateTime.Now,
                Nombre = txtbNombre.Text,
                Telefono = txtbTelefono.Text,
                Dirección = txtbDirección.Text,
            };
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Compañias.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                compañiaList = JsonConvert.DeserializeObject<List<clssCompañia>>(json);
                for (int i = 0; i < compañiaList.Count; i++)
                {
                    if (compañiaList[i].Nombre.ToString() == txtbNombre2.Text)
                    {
                        compañiaList.Remove(compañiaList[i]);
                        MessageBox.Show($"La compañia {txtbNombre2.Text} fue eliminada correctamente.");
                        j = 1;
                        break;
                    }
                }
                if (j == 0)
                {
                    MessageBox.Show($"No existe ninguna compañiao con el nombre de {txtbNombre2.Text} que coincida en la lista.");
                }
            }
            else
            {
                MessageBox.Show($"Aún no se han ingresado gastos.");
            }
            json = JsonConvert.SerializeObject(compañiaList);
            var sv = new StreamWriter(pathFile, false, Encoding.UTF8);
            sv.Write(json);
            sv.Close();
            dgvContactosEmpresariales.DataSource = null;
            dgvContactosEmpresariales.DataSource = compañiaList;
            bttnEliminar.Enabled = false;
            BorradoCamposRellenables2();
        }

        private void txtbDirección_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}