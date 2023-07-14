using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskWithUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UniqunessFinder.GetFirstUnique(tBUserText.Text).ToString(),
                "First the most unique letter is",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
