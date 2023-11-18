using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tesste2
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            voltar.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            voltar.FlatStyle = FlatStyle.Flat;
            voltar.FlatAppearance.BorderSize = 0;
            voltar.BackColor = Color.Transparent;
            voltar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            voltar.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
    }
}
