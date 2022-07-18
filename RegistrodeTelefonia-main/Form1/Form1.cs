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
        List<clssCompa�ia> compa�iaList = new List<clssCompa�ia>();

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
            pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Compa�ias.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                compa�iaList = JsonConvert.DeserializeObject<List<clssCompa�ia>>(json);
                for (int i = 0; i < compa�iaList.Count; i++)
                {
                        auxList.Add(compa�iaList[i].Nombre);
                }
            }
            cbCompa�ia.DataSource = auxList;
        }
        private void BorradoCamposRellenables()
        {
            txtbNombre.Text = string.Empty;
            txtbTelefono.Text = string.Empty;
            txtbPosici�n.Text = string.Empty;
            cbCompa�ia.SelectedItem = null;
            pathImage = $"{AppDomain.CurrentDomain.BaseDirectory}\\usuario.png";
            pbImagen.Image = Image.FromFile(pathImage);
        }
        private void BorradoCamposRellenables2()
        {
            txtbNombre2.Text = string.Empty;
            txtbTelefono2.Text = string.Empty;
            txtbDirecci�n.Text = string.Empty;
            cbTipo.SelectedItem = null;
        }

        public class clssContactoEmpresarial
        {
            public Guid ID { get; set; }
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Compa�ia { get; set; }
            public string Posici�n { get; set; }
            public string Imagen { get; set; }
            public DateTime Fecha { get; set; }
        }
        public class clssCompa�ia
        {
            public Guid ID { get; set; }
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Direcci�n { get; set; }
            public string Tipo { get; set; }
            public DateTime Fecha { get; set; }
        }

        public void Editar_Guardar()
        {
            int j = 0;
            var vContactoEmpresarial = new clssContactoEmpresarial()
            {
                Compa�ia = cbCompa�ia.SelectedItem.ToString(),
                Fecha = DateTime.Now,
                Nombre = txtbNombre.Text,
                Telefono = txtbTelefono.Text,
                Posici�n=txtbPosici�n.Text,
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
            var vCompa�ia = new clssCompa�ia()
            {
                Tipo = cbTipo.SelectedItem.ToString(),
                Fecha = DateTime.Now,
                Nombre = txtbNombre2.Text,
                Telefono = txtbTelefono2.Text,
                Direcci�n = txtbDirecci�n.Text,
            };
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Compa�ias.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                compa�iaList = JsonConvert.DeserializeObject<List<clssCompa�ia>>(json);
                for (int i = 0; i < compa�iaList.Count; i++)
                {
                    if (compa�iaList[i].Nombre == txtbNombre2.Text)
                    {
                        compa�iaList.Remove(compa�iaList[i]);
                        compa�iaList.Add(vCompa�ia);
                        MessageBox.Show($"La compa�ia {txtbNombre2.Text} fue encontrado y actualizado.");
                        j = 1;
                        break;
                    }
                }
                if (j == 0)
                {
                    compa�iaList.Add(vCompa�ia);
                    MessageBox.Show($"La compa�ia {txtbNombre2.Text} ha sido agregada correctamente.");

                }
            }
            else
            {
                compa�iaList.Add(vCompa�ia);
                MessageBox.Show($"La Compa�ia {txtbNombre2.Text} ha sido agregada correctamente.");
            }
            json = JsonConvert.SerializeObject(compa�iaList);
            var sv = new StreamWriter(pathFile, false, Encoding.UTF8);
            sv.Write(json);
            sv.Close();
            dgvContactosEmpresariales.DataSource = null;
            dgvContactosEmpresariales.DataSource = compa�iaList;
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
            cbCompa�ia.Text = String.Empty;
            MessageBox.Show("Casillas limpiadas");
        }

        private void cboxCompa�ia_SelectedIndexChanged(object sender, EventArgs e)
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
                        cbCompa�ia.SelectedItem = contactoempresarialList[i].Compa�ia.ToString();
                        txtbTelefono.Text = contactoempresarialList[i].Telefono.ToString();
                        txtbPosici�n.Text = contactoempresarialList[i].Posici�n.ToString();
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
                MessageBox.Show($"A�n no ha ingresado ningun dato.");
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            int j = 0;
            var vContactoEmpresarial = new clssContactoEmpresarial()
            {
                Compa�ia = cbCompa�ia.SelectedItem.ToString(),
                Fecha = DateTime.Now,
                Nombre = txtbNombre.Text,
                Telefono = txtbTelefono.Text,
                Posici�n = txtbPosici�n.Text,
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
                MessageBox.Show($"A�n no se han ingresado gastos.");
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
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen v�lido");
            }

        }

        private void gbGesti�nCompa�ia_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BorradoCamposRellenables2();
            gbGesti�nCompa�ia.Visible = false;
            dgvContactosEmpresariales.DataSource = contactoempresarialList;
            var auxList = new List<string> { };
            var json = string.Empty;
            string pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Compa�ias.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                compa�iaList = JsonConvert.DeserializeObject<List<clssCompa�ia>>(json);
                for (int i = 0; i < compa�iaList.Count; i++)
                {
                    auxList.Add(compa�iaList[i].Nombre);
                }
            }
            cbCompa�ia.DataSource = auxList;

        }

        private void bttnCompa�ia_Click(object sender, EventArgs e)
        {
            gbGesti�nCompa�ia.Visible = true;
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Compa�ias.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                compa�iaList = JsonConvert.DeserializeObject<List<clssCompa�ia>>(json);
                dgvContactosEmpresariales.DataSource = compa�iaList;
            }
        }

        private void bttnBuscar2_Click(object sender, EventArgs e)
        {
            int j = 0;
            var vCompa�ia = new clssCompa�ia()
            {
                Nombre = txtbNombre2.Text,
            };
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Compa�ias.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                compa�iaList = JsonConvert.DeserializeObject<List<clssCompa�ia>>(json);
                for (int i = 0; i < compa�iaList.Count; i++)
                {
                    if (compa�iaList[i].Nombre.ToString() == txtbNombre2.Text)
                    {
                        bttnEliminar2.Enabled = true;
                        cbTipo.SelectedItem = compa�iaList[i].Tipo.ToString();
                        txtbTelefono2.Text = compa�iaList[i].Telefono.ToString();
                        txtbDirecci�n.Text = compa�iaList[i].Direcci�n.ToString();
                        txtbNombre2.Text = compa�iaList[i].Nombre.ToString();
                        j = 1;
                        break;
                    }
                }
                if (j == 0)
                {
                    MessageBox.Show($"La compa�ia referenciada como {txtbNombre2.Text}, no existe en la base de datos");
                }
            }
            else
            {
                MessageBox.Show($"A�n no ha ingresado ningun dato.");
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
            var vCompa�ia = new clssCompa�ia()
            {
                Tipo = cbTipo.SelectedItem.ToString(),
                Fecha = DateTime.Now,
                Nombre = txtbNombre.Text,
                Telefono = txtbTelefono.Text,
                Direcci�n = txtbDirecci�n.Text,
            };
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Compa�ias.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                compa�iaList = JsonConvert.DeserializeObject<List<clssCompa�ia>>(json);
                for (int i = 0; i < compa�iaList.Count; i++)
                {
                    if (compa�iaList[i].Nombre.ToString() == txtbNombre2.Text)
                    {
                        compa�iaList.Remove(compa�iaList[i]);
                        MessageBox.Show($"La compa�ia {txtbNombre2.Text} fue eliminada correctamente.");
                        j = 1;
                        break;
                    }
                }
                if (j == 0)
                {
                    MessageBox.Show($"No existe ninguna compa�iao con el nombre de {txtbNombre2.Text} que coincida en la lista.");
                }
            }
            else
            {
                MessageBox.Show($"A�n no se han ingresado gastos.");
            }
            json = JsonConvert.SerializeObject(compa�iaList);
            var sv = new StreamWriter(pathFile, false, Encoding.UTF8);
            sv.Write(json);
            sv.Close();
            dgvContactosEmpresariales.DataSource = null;
            dgvContactosEmpresariales.DataSource = compa�iaList;
            bttnEliminar.Enabled = false;
            BorradoCamposRellenables2();
        }

        private void txtbDirecci�n_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}