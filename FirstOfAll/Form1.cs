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
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            
        }

	


        private void firin_Click(object sender, EventArgs e)
        {
            Firin firin = new Firin();
            
            
            firin.Show();
        }

        private void kasa_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.Show();
        }

        private void mutfak_Click(object sender, EventArgs e)
        {
            Mutfak mutfak = new Mutfak();
            mutfak.Show();
        }
    }
}
