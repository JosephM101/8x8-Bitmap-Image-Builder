using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8x8_Bitmap_Image_Builder
{
    public partial class GeneratePyScript : Form
    {
        public GeneratePyScript()
        {
            InitializeComponent();
        }

        private void GeneratePyScript_Load(object sender, EventArgs e)
        {
            textBox1.Text=Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text.Replace('\\', '/');
        }
    }
}
