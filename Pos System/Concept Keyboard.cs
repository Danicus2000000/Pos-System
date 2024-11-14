using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_System
{
    public partial class Concept_Keyboard : Form
    {
        public Concept_Keyboard()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static string btn_press {get; set;}//stores command

        private void Num_btn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;//passes button number as command to add
            btn_press = btn.Text;
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            btn_press = "Clear";//sends clear textbox command
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            btn_press = "Del";//sends delete 1 character command
        }

        private void Enter_btn_Click(object sender, EventArgs e)
        {
            this.Close();//close keyboard
        }
    }
}
