using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Coordinates2NetherBlocks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num_dest_x.Maximum = decimal.MaxValue;
            num_dest_z.Maximum = decimal.MaxValue;
            num_org_x.Maximum = decimal.MaxValue;
            num_org_z.Maximum = decimal.MaxValue;
            num_dest_x.Minimum = decimal.MaxValue * -1;
            num_dest_z.Minimum = decimal.MaxValue * -1;
            num_org_x.Minimum = decimal.MaxValue * -1;
            num_org_z.Minimum = decimal.MaxValue * -1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal num_blocks_nether_x = (num_dest_x.Value - num_org_x.Value) / 8;
            decimal num_blocks_nether_z = (num_dest_z.Value - num_org_z.Value) / 8;
            string msg = "You have to walk " + num_blocks_nether_x.ToString() + " Blocks in X,"
                + "\n"
                +" and " + num_blocks_nether_z + " Blocks in Z in the nether.";
            lbl_result.Text = msg;
        }
    }
}
