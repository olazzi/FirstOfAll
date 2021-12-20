using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstOfAll
{
    public partial class Mutfak : Form
    {
        
        public Mutfak()
        {
            InitializeComponent();
        }

        public  void mutfakdeneme_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(mutfakdeneme.Text);
            
        }

        private void eklekasa_Click(object sender, EventArgs e)
        {

        }
    }
}
