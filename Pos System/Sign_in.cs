using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Pos_System
{
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
        }
        private void InNumButton_Click(object sender, EventArgs e)
        {
            if (PIN_txt.Text.Length != 4)//Adds whatever number is pressed to the PIN container unless max length is reached
            {
                var button = (Button)sender;
                PIN_txt.Text += button.Text;
                if (PIN_txt.Text.Length == 4)
                {
                    List<string> PINs = DatabaseHandling.GetPINs("SELECT [PIN] FROM Employees WHERE [PIN]=@PIN",PIN_txt.Text);//gets all PINs that correspond to entered PIN
                    if (PINs.Count != 0)
                    {
                        this.Hide();
                        Form POS = new POS_system(PIN_txt.Text);
                        POS.Closed += (s, args) => this.Close();
                        POS.Show();
                    }
                    else//catch for incorrect PIN
                    {
                        PIN_txt.Text = "";
                        MessageBox.Show("That PIN is incorrect!", "PIN error");
                    }
                }
            }

        }
        private void InClear_btn_Click(object sender, EventArgs e)//resets the PIN container
        {
            PIN_txt.Text = "";
        }
    }
}
