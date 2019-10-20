using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8x8_Bitmap_Image_Builder.Help.Pi_Sense_HAT_Bitmap_Example
{
    public partial class Pi_Sense_HAT_Bitmap_Example : Form
    {
        public Pi_Sense_HAT_Bitmap_Example()
        {
            InitializeComponent();
            try
            {
                richTextBox1.LoadFile(@"Data\Help Form Info\Pi Sense HAT Bitmap Example.txt",RichTextBoxStreamType.PlainText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry!\r\nOne or more data files are missing. You may need to reinstall this application. The error message is shown below. \r\n"+ex.Message, "Uh-oh!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
            }
        }

        private void Pi_Sense_HAT_Bitmap_Example_Load(object sender, EventArgs e)
        {

        }
    }
}
