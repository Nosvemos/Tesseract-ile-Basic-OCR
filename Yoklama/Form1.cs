using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace Yoklama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        Bitmap image = new Bitmap("Resources/empty.png");
        private void selectFiles1(object sender, EventArgs e)
        {
            var OpenFileDialog = new OpenFileDialog();
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                var image = new Bitmap(OpenFileDialog.FileName);
                var ocr = new TesseractEngine("./tessdata","eng");
                var sonuc = ocr.Process(image);
                textBox1.Text = sonuc.GetText();
            }
        }
    }
}
