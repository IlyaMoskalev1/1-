using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Чат
{
    public partial class listOnline : UserControl
    {
        public listOnline()
        {
            InitializeComponent();
        }        

    private void listBox1_Click(object sender, EventArgs e)
    {      
      Sender frm = new Sender();
      frm.Show();
    }
  }
}
