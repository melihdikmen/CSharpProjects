using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace sayi_bulma_oyunu
{
    public partial class skor : Form
    {
        public skor()
        {
            InitializeComponent();
        }

        private void skor_Load(object sender, EventArgs e)
        {
            skor_oku();   
        }

        public void skor_oku()
        {
            FileStream fs = new FileStream("skor.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            string okunan=sr.ReadLine();

            while(okunan!=null)
            {
                listBox1.Items.Add(okunan);
                okunan = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            skor_oku();
        }
    }
}
