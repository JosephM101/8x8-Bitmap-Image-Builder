using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using _8x8_Bitmap_Image_Builder.Help.Pi_Sense_HAT_Bitmap_Example;

namespace _8x8_Bitmap_Image_Builder
{
    public partial class Form1 : Form
    {
        string file = "";

        string message = "";
        int delay = 3000;

        public Form1()
        {
            InitializeComponent();
            ShowTimedMessage("Welcome!", 3000);
            this.Text = "8x8 Bitmap Image Builder - Version " + Properties.Resources.SoftwareVersion.ToString();
        }

        void ShowTimedMessage(string msg, int ms)
        {
            try
            {
                timer1.Interval = ms;
                timer1.Enabled = false;
                toolStripStatusLabel1.Text = msg;
                timer1.Enabled = true;
            }
            catch
            {
            }
        }

        void ShowMessage(string msg)
        {
            toolStripStatusLabel1.Text = msg;
        }

        void ClearMessage(string msg)
        {
            toolStripStatusLabel1.Text = msg;
        }

        void DrawBitmap(string filepath)
        {
            Bitmap bmp = new Bitmap(8, 8);
            bmp.SetPixel(0, 0, panel1.BackColor);
            bmp.SetPixel(1, 0, panel2.BackColor);
            bmp.SetPixel(2, 0, panel3.BackColor);
            bmp.SetPixel(3, 0, panel4.BackColor);
            bmp.SetPixel(4, 0, panel5.BackColor);
            bmp.SetPixel(5, 0, panel6.BackColor);
            bmp.SetPixel(6, 0, panel7.BackColor);
            bmp.SetPixel(7, 0, panel8.BackColor);
            bmp.SetPixel(0, 1, panel9.BackColor);
            bmp.SetPixel(1, 1, panel10.BackColor);
            bmp.SetPixel(2, 1, panel11.BackColor);
            bmp.SetPixel(3, 1, panel12.BackColor);
            bmp.SetPixel(4, 1, panel13.BackColor);
            bmp.SetPixel(5, 1, panel14.BackColor);
            bmp.SetPixel(6, 1, panel15.BackColor);
            bmp.SetPixel(7, 1, panel16.BackColor);
            bmp.SetPixel(0, 2, panel17.BackColor);
            bmp.SetPixel(1, 2, panel18.BackColor);
            bmp.SetPixel(2, 2, panel19.BackColor);
            bmp.SetPixel(3, 2, panel20.BackColor);
            bmp.SetPixel(4, 2, panel21.BackColor);
            bmp.SetPixel(5, 2, panel22.BackColor);
            bmp.SetPixel(6, 2, panel23.BackColor);
            bmp.SetPixel(7, 2, panel24.BackColor);
            bmp.SetPixel(0, 3, panel25.BackColor);
            bmp.SetPixel(1, 3, panel26.BackColor);
            bmp.SetPixel(2, 3, panel27.BackColor);
            bmp.SetPixel(3, 3, panel28.BackColor);
            bmp.SetPixel(4, 3, panel29.BackColor);
            bmp.SetPixel(5, 3, panel30.BackColor);
            bmp.SetPixel(6, 3, panel31.BackColor);
            bmp.SetPixel(7, 3, panel32.BackColor);
            bmp.SetPixel(0, 4, panel33.BackColor);
            bmp.SetPixel(1, 4, panel34.BackColor);
            bmp.SetPixel(2, 4, panel35.BackColor);
            bmp.SetPixel(3, 4, panel36.BackColor);
            bmp.SetPixel(4, 4, panel37.BackColor);
            bmp.SetPixel(5, 4, panel38.BackColor);
            bmp.SetPixel(6, 4, panel39.BackColor);
            bmp.SetPixel(7, 4, panel40.BackColor);
            bmp.SetPixel(0, 5, panel41.BackColor);
            bmp.SetPixel(1, 5, panel42.BackColor);
            bmp.SetPixel(2, 5, panel43.BackColor);
            bmp.SetPixel(3, 5, panel44.BackColor);
            bmp.SetPixel(4, 5, panel45.BackColor);
            bmp.SetPixel(5, 5, panel46.BackColor);
            bmp.SetPixel(6, 5, panel47.BackColor);
            bmp.SetPixel(7, 5, panel48.BackColor);
            bmp.SetPixel(0, 6, panel49.BackColor);
            bmp.SetPixel(1, 6, panel50.BackColor);
            bmp.SetPixel(2, 6, panel51.BackColor);
            bmp.SetPixel(3, 6, panel52.BackColor);
            bmp.SetPixel(4, 6, panel53.BackColor);
            bmp.SetPixel(5, 6, panel54.BackColor);
            bmp.SetPixel(6, 6, panel55.BackColor);
            bmp.SetPixel(7, 6, panel56.BackColor);
            bmp.SetPixel(0, 7, panel57.BackColor);
            bmp.SetPixel(1, 7, panel58.BackColor);
            bmp.SetPixel(2, 7, panel59.BackColor);
            bmp.SetPixel(3, 7, panel60.BackColor);
            bmp.SetPixel(4, 7, panel61.BackColor);
            bmp.SetPixel(5, 7, panel62.BackColor);
            bmp.SetPixel(6, 7, panel63.BackColor);
            bmp.SetPixel(7, 7, panel64.BackColor);
            bmp.Save(filepath);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void XPanelColor(Panel panel)
        {
            panel.BackColor = Color.Black;
        }

        void SetPanelColor(Panel panel)
        {
            if (radioButton1.Checked == true)
            {
                panel.BackColor = Color.White;
            }
            if (radioButton2.Checked == true)
            {
                panel.BackColor = Color.Red;
            }
            if (radioButton3.Checked == true)
            {
                panel.BackColor = Color.Green;
            }
            if (radioButton4.Checked == true)
            {
                panel.BackColor = Color.Blue;
            }
            if (radioButton5.Checked == true)
            {
                panel.BackColor = Color.Black;
            }
            if (radioButton6.Checked == true)
            {
                panel.BackColor = panel65.BackColor;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel65.BackColor = colorDialog1.Color;
                radioButton6.Checked = true;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel1);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel2);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel3);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel4);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel5);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel6);
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel7);
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel8);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel9);
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel10);
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel11);
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel12);
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel13);
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel14);
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel15);
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel16);
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel17);
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel18);
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel19);
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel20);
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel21);
        }

        private void panel22_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel22);
        }

        private void panel23_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel23);
        }

        private void panel24_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel24);
        }

        private void panel25_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel25);
        }

        private void panel26_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel26);
        }

        private void panel27_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel27);
        }

        private void panel28_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel28);
        }

        private void panel29_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel29);
        }

        private void panel30_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel30);
        }

        private void panel31_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel31);
        }

        private void panel32_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel32);
        }

        private void panel33_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel33);
        }

        private void panel34_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel34);
        }

        private void panel35_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel35);
        }

        private void panel36_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel36);
        }

        private void panel37_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel37);
        }

        private void panel38_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel38);
        }

        private void panel39_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel39);
        }

        private void panel40_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel40);
        }

        private void panel41_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel41);
        }

        private void panel42_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel42);
        }

        private void panel43_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel43);
        }

        private void panel44_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel44);
        }

        private void panel45_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel45);
        }

        private void panel46_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel46);
        }

        private void panel47_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel47);
        }

        private void panel48_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel48);
        }

        private void panel49_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel49);
        }

        private void panel50_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel50);
        }

        private void panel51_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel51);
        }

        private void panel52_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel52);
        }

        private void panel53_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel53);
        }

        private void panel54_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel54);
        }

        private void panel55_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel55);
        }

        private void panel56_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel56);
        }

        private void panel57_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel57);
        }

        private void panel58_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel58);
        }

        private void panel59_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel59);
        }

        private void panel60_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel60);
        }

        private void panel61_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel61);
        }

        private void panel62_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel62);
        }

        private void panel63_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel63);
        }

        private void panel64_Click(object sender, EventArgs e)
        {
            SetPanelColor(panel64);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Fill?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SetPanelColor(panel1);
                SetPanelColor(panel2);
                SetPanelColor(panel3);
                SetPanelColor(panel4);
                SetPanelColor(panel5);
                SetPanelColor(panel6);
                SetPanelColor(panel7);
                SetPanelColor(panel8);
                SetPanelColor(panel9);
                SetPanelColor(panel10);
                SetPanelColor(panel11);
                SetPanelColor(panel12);
                SetPanelColor(panel13);
                SetPanelColor(panel14);
                SetPanelColor(panel15);
                SetPanelColor(panel16);
                SetPanelColor(panel17);
                SetPanelColor(panel18);
                SetPanelColor(panel19);
                SetPanelColor(panel20);
                SetPanelColor(panel21);
                SetPanelColor(panel22);
                SetPanelColor(panel23);
                SetPanelColor(panel24);
                SetPanelColor(panel25);
                SetPanelColor(panel26);
                SetPanelColor(panel27);
                SetPanelColor(panel28);
                SetPanelColor(panel29);
                SetPanelColor(panel30);
                SetPanelColor(panel31);
                SetPanelColor(panel32);
                SetPanelColor(panel33);
                SetPanelColor(panel34);
                SetPanelColor(panel35);
                SetPanelColor(panel36);
                SetPanelColor(panel37);
                SetPanelColor(panel38);
                SetPanelColor(panel39);
                SetPanelColor(panel40);
                SetPanelColor(panel41);
                SetPanelColor(panel42);
                SetPanelColor(panel43);
                SetPanelColor(panel44);
                SetPanelColor(panel45);
                SetPanelColor(panel46);
                SetPanelColor(panel47);
                SetPanelColor(panel48);
                SetPanelColor(panel49);
                SetPanelColor(panel50);
                SetPanelColor(panel51);
                SetPanelColor(panel52);
                SetPanelColor(panel53);
                SetPanelColor(panel54);
                SetPanelColor(panel55);
                SetPanelColor(panel56);
                SetPanelColor(panel57);
                SetPanelColor(panel58);
                SetPanelColor(panel59);
                SetPanelColor(panel60);
                SetPanelColor(panel61);
                SetPanelColor(panel62);
                SetPanelColor(panel63);
                SetPanelColor(panel64);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = saveFileDialog1.FileName;
                DrawBitmap(file);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                Bitmap bmp = new Bitmap(file);
                panel1.BackColor = bmp.GetPixel(0, 0);
                panel2.BackColor = bmp.GetPixel(1, 0);
                panel3.BackColor = bmp.GetPixel(2, 0);
                panel4.BackColor = bmp.GetPixel(3, 0);
                panel5.BackColor = bmp.GetPixel(4, 0);
                panel6.BackColor = bmp.GetPixel(5, 0);
                panel7.BackColor = bmp.GetPixel(6, 0);
                panel8.BackColor = bmp.GetPixel(7, 0);
                panel9.BackColor = bmp.GetPixel(0, 1);
                panel10.BackColor = bmp.GetPixel(1, 1);
                panel11.BackColor = bmp.GetPixel(2, 1);
                panel12.BackColor = bmp.GetPixel(3, 1);
                panel13.BackColor = bmp.GetPixel(4, 1);
                panel14.BackColor = bmp.GetPixel(5, 1);
                panel15.BackColor = bmp.GetPixel(6, 1);
                panel16.BackColor = bmp.GetPixel(7, 1);
                panel17.BackColor = bmp.GetPixel(0, 2);
                panel18.BackColor = bmp.GetPixel(1, 2);
                panel19.BackColor = bmp.GetPixel(2, 2);
                panel20.BackColor = bmp.GetPixel(3, 2);
                panel21.BackColor = bmp.GetPixel(4, 2);
                panel22.BackColor = bmp.GetPixel(5, 2);
                panel23.BackColor = bmp.GetPixel(6, 2);
                panel24.BackColor = bmp.GetPixel(7, 2);
                panel25.BackColor = bmp.GetPixel(0, 3);
                panel26.BackColor = bmp.GetPixel(1, 3);
                panel27.BackColor = bmp.GetPixel(2, 3);
                panel28.BackColor = bmp.GetPixel(3, 3);
                panel29.BackColor = bmp.GetPixel(4, 3);
                panel30.BackColor = bmp.GetPixel(5, 3);
                panel31.BackColor = bmp.GetPixel(6, 3);
                panel32.BackColor = bmp.GetPixel(7, 3);
                panel33.BackColor = bmp.GetPixel(0, 4);
                panel34.BackColor = bmp.GetPixel(1, 4);
                panel35.BackColor = bmp.GetPixel(2, 4);
                panel36.BackColor = bmp.GetPixel(3, 4);
                panel37.BackColor = bmp.GetPixel(4, 4);
                panel38.BackColor = bmp.GetPixel(5, 4);
                panel39.BackColor = bmp.GetPixel(6, 4);
                panel40.BackColor = bmp.GetPixel(7, 4);
                panel41.BackColor = bmp.GetPixel(0, 5);
                panel42.BackColor = bmp.GetPixel(1, 5);
                panel43.BackColor = bmp.GetPixel(2, 5);
                panel44.BackColor = bmp.GetPixel(3, 5);
                panel45.BackColor = bmp.GetPixel(4, 5);
                panel46.BackColor = bmp.GetPixel(5, 5);
                panel47.BackColor = bmp.GetPixel(6, 5);
                panel48.BackColor = bmp.GetPixel(7, 5);
                panel49.BackColor = bmp.GetPixel(0, 6);
                panel50.BackColor = bmp.GetPixel(1, 6);
                panel51.BackColor = bmp.GetPixel(2, 6);
                panel52.BackColor = bmp.GetPixel(3, 6);
                panel53.BackColor = bmp.GetPixel(4, 6);
                panel54.BackColor = bmp.GetPixel(5, 6);
                panel55.BackColor = bmp.GetPixel(6, 6);
                panel56.BackColor = bmp.GetPixel(7, 6);
                panel57.BackColor = bmp.GetPixel(0, 7);
                panel58.BackColor = bmp.GetPixel(1, 7);
                panel59.BackColor = bmp.GetPixel(2, 7);
                panel60.BackColor = bmp.GetPixel(3, 7);
                panel61.BackColor = bmp.GetPixel(4, 7);
                panel62.BackColor = bmp.GetPixel(5, 7);
                panel63.BackColor = bmp.GetPixel(6, 7);
                panel64.BackColor = bmp.GetPixel(7, 7);
                ShowTimedMessage("Opened file: " + file, 3000);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file = saveFileDialog1.FileName;
                    DrawBitmap(file);
                    ShowTimedMessage("File saved at " + file, 3000);
                }
            }
            else
            {
                DrawBitmap(file);
                ShowTimedMessage("File saved at " + file, 3000);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = saveFileDialog1.FileName;
                DrawBitmap(file);
                ShowTimedMessage("File saved at " + file, 3000);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string body = "Start a new bitmap?";
            string name = "New";
            MessageBoxButtons mb = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            if (MessageBox.Show(body, name, mb, icon) == DialogResult.Yes)
            {
                file = "";
                XPanelColor(panel1);
                XPanelColor(panel2);
                XPanelColor(panel3);
                XPanelColor(panel4);
                XPanelColor(panel5);
                XPanelColor(panel6);
                XPanelColor(panel7);
                XPanelColor(panel8);
                XPanelColor(panel9);
                XPanelColor(panel10);
                XPanelColor(panel11);
                XPanelColor(panel12);
                XPanelColor(panel13);
                XPanelColor(panel14);
                XPanelColor(panel15);
                XPanelColor(panel16);
                XPanelColor(panel17);
                XPanelColor(panel18);
                XPanelColor(panel19);
                XPanelColor(panel20);
                XPanelColor(panel21);
                XPanelColor(panel22);
                XPanelColor(panel23);
                XPanelColor(panel24);
                XPanelColor(panel25);
                XPanelColor(panel26);
                XPanelColor(panel27);
                XPanelColor(panel28);
                XPanelColor(panel29);
                XPanelColor(panel30);
                XPanelColor(panel31);
                XPanelColor(panel32);
                XPanelColor(panel33);
                XPanelColor(panel34);
                XPanelColor(panel35);
                XPanelColor(panel36);
                XPanelColor(panel37);
                XPanelColor(panel38);
                XPanelColor(panel39);
                XPanelColor(panel40);
                XPanelColor(panel41);
                XPanelColor(panel42);
                XPanelColor(panel43);
                XPanelColor(panel44);
                XPanelColor(panel45);
                XPanelColor(panel46);
                XPanelColor(panel47);
                XPanelColor(panel48);
                XPanelColor(panel49);
                XPanelColor(panel50);
                XPanelColor(panel51);
                XPanelColor(panel52);
                XPanelColor(panel53);
                XPanelColor(panel54);
                XPanelColor(panel55);
                XPanelColor(panel56);
                XPanelColor(panel57);
                XPanelColor(panel58);
                XPanelColor(panel59);
                XPanelColor(panel60);
                XPanelColor(panel61);
                XPanelColor(panel62);
                XPanelColor(panel63);
                XPanelColor(panel64);
                ShowTimedMessage("Created a New Bitmap File", 3000);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createInkSplashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string body = "Clear current bitmap and create ink splash?";
            string name = "Inksplash";
            MessageBoxButtons mb = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            if (MessageBox.Show(body, name, mb, icon) == DialogResult.Yes)
            {
                XPanelColor(panel1);
                XPanelColor(panel2);
                XPanelColor(panel3);
                XPanelColor(panel4);
                XPanelColor(panel5);
                XPanelColor(panel6);
                XPanelColor(panel7);
                XPanelColor(panel8);
                XPanelColor(panel9);
                XPanelColor(panel10);
                XPanelColor(panel11);
                XPanelColor(panel12);
                XPanelColor(panel13);
                XPanelColor(panel14);
                XPanelColor(panel15);
                XPanelColor(panel16);
                XPanelColor(panel17);
                XPanelColor(panel18);
                XPanelColor(panel19);
                XPanelColor(panel20);
                XPanelColor(panel21);
                XPanelColor(panel22);
                XPanelColor(panel23);
                XPanelColor(panel24);
                XPanelColor(panel25);
                XPanelColor(panel26);
                XPanelColor(panel27);
                XPanelColor(panel28);
                XPanelColor(panel29);
                XPanelColor(panel30);
                XPanelColor(panel31);
                XPanelColor(panel32);
                XPanelColor(panel33);
                XPanelColor(panel34);
                XPanelColor(panel35);
                XPanelColor(panel36);
                XPanelColor(panel37);
                XPanelColor(panel38);
                XPanelColor(panel39);
                XPanelColor(panel40);
                XPanelColor(panel41);
                XPanelColor(panel42);
                XPanelColor(panel43);
                XPanelColor(panel44);
                XPanelColor(panel45);
                XPanelColor(panel46);
                XPanelColor(panel47);
                XPanelColor(panel48);
                XPanelColor(panel49);
                XPanelColor(panel50);
                XPanelColor(panel51);
                XPanelColor(panel52);
                XPanelColor(panel53);
                XPanelColor(panel54);
                XPanelColor(panel55);
                XPanelColor(panel56);
                XPanelColor(panel57);
                XPanelColor(panel58);
                XPanelColor(panel59);
                XPanelColor(panel60);
                XPanelColor(panel61);
                XPanelColor(panel62);
                XPanelColor(panel63);
                XPanelColor(panel64);
                Random r = new Random();
                panel1.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel2.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel3.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel4.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel5.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel6.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel7.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel8.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel9.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel10.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel11.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel12.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel13.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel14.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel15.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel16.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel17.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel18.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel19.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel20.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel21.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel22.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel23.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel24.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel25.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel26.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel27.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel28.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel29.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel30.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel31.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel32.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel33.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel34.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel35.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel36.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel37.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel38.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel39.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel40.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel41.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel42.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel43.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel44.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel45.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel46.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel47.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel48.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel49.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel50.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel51.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel52.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel53.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel54.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel55.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel56.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel57.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel58.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel59.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel60.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel61.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel62.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel63.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                panel64.BackColor = Color.FromArgb(r.Next(100, 255), r.Next(100, 255), r.Next(100, 255));
                ShowTimedMessage("Ink splash created.", 3000);
            }
        }

        private void piSenseHATBitmapExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Pi_Sense_HAT_Bitmap_Example().Show();
            }
            catch
            {
                MessageBox.Show("There was an error processing one or more requests.");
            }
        }

        private void webLinksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void raspberryPiHomePAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkViewer lv = new LinkViewer("https://www.raspberrypi.org/");
            lv.Show();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void generatePythonScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneratePyScript pyScript = new GeneratePyScript();
            DialogResult dr = pyScript.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    string path = pyScript.textBox1.Text + @"\" + pyScript.textBox2.Text;
                    string python = path + @"\" + pyScript.textBox2.Text + ".py";
                    string image = path + @"\" + pyScript.textBox2.Text + ".bmp";
                    Directory.CreateDirectory(path);
                    StreamWriter sw = new StreamWriter(python);
                    sw.WriteLine("from sense_hat import SenseHat");
                    sw.WriteLine("sense = SenseHat()");
                    sw.WriteLine();
                    sw.WriteLine("sense.load_image(" + pyScript.textBox2.Text + ".bmp)");
                    sw.Close();
                    DrawBitmap(image);
                    MessageBox.Show("Script was generated!");
                    Process.Start(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating script.\r\n" + ex.Message + "\r\n" + ex.Source);
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            timer1.Enabled = false;
        }
    }
}