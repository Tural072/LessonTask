using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace LessonTask
{
    public partial class Form1 : Form
    {
        public string FileName { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ovalPictureBox1.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StringReader reader = new StringReader(openFileDialog.FileName))
                {
                    textBox1.Text = reader.ReadToEnd();
                    FileName = openFileDialog.FileName;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            using (StreamWriter streamWriter = new StreamWriter(FileName))
            {
                streamWriter.Write(textBox1.Text);
            }
        }
    }


}
