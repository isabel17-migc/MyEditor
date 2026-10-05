namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ficheroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Archivos de texto (*.txt)|*.txt|HTML (*.html)|*.html|Todos los archivos (*.*)|*.*";
            save.Title = "Guardar Archivo";
            save.CheckPathExists = true;

            if (save.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(save.FileName))
                    {
                        writer.Write(richTextBox1.Text);
                    }

                    MessageBox.Show("Archivo guardado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cascadiaMonoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            open.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.* ";
            open.CheckFileExists = true;
            open.Title = "Abrir Archivo";
            open.ShowDialog(this);
            try
            {
                open.OpenFile();
                myStreamReader = System.IO.File.OpenText(open.FileName);
                richTextBox1.Text = myStreamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message);
            }
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void fuenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.Font = richTextBox1.Font;

            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }
        }

        private void colorFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.ForeColor = color.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fondo = new ColorDialog();
            if (fondo.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = fondo.Color;
            } 
            //fin
        }
    }
}