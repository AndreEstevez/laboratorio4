
using System.IO;
namespace laboratorio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //fuera de la funcion es global 
        private string path = @"C:\directorio/archivo.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            // dentro de la funcion es local 
            try
            {

                //abrimos el archivo para su lectura 
                FileStream archivo = new FileStream(this.path, FileMode.Open, FileAccess.Read);
                StreamReader lector = new StreamReader(archivo);
                this.label1.Text = lector.ReadToEnd();
                lector.Close();
                archivo.Close();

            }
            catch (IOException ex)
            {

                MessageBox.Show(ex.Message);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                //abrimos el archivo donde sera guardada la escritura
                FileStream archivo = new FileStream(this.path, FileMode.Open,FileAccess.Write);
                StreamWriter escritor = new StreamWriter(archivo);
                escritor.WriteLine(this.textBox1.Text);
                escritor.Close();
                archivo.Close();

            }
            catch (IOException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}