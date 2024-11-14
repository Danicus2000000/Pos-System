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
    public partial class Ordering : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string foodcost { get; set; }//used to pass the cost of the food back to the form

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string quantity { get; set; }//used to pass quantity of food back to form

        public Ordering(string send_food_name)//passes food from last form into this one
        {
            InitializeComponent();
            food_name = send_food_name;
        }
        private static string food_name;
        private void Cancel_btn_Click(object sender, EventArgs e)//cancel button closes
        {
            this.Close();
        }

        private void Ordering_Load(object sender, EventArgs e)//on load fetches food description and cost
        {
            Database_Handling handle = new Database_Handling();
            List<string> data=handle.fetch_info("SELECT [Description],[Cost] FROM Item WHERE [Food Name]=@food", food_name);//gets the food name and description
            Description_lbl.Text = data[0];
            Cost_lbl.Text = "Cost: " + data[1];
        }

        private void Add_btn_Click(object sender, EventArgs e)//splices food cost to correct length and returns order requested result
        {
            bool contains_int=false;//ensures there is an actually valid number to read
            foreach(char character in Quantity_txt.Text)
            {
                if(character!='0')
                {
                    contains_int=true;
                }
            }
            if (Quantity_txt.Text.Length != 0 && contains_int==true)//ensures quantity is valid
            {
                this.foodcost = Cost_lbl.Text.Substring(7);
                this.quantity = Quantity_txt.Text;
                this.DialogResult = DialogResult.Yes;
            }
            else 
            {
                MessageBox.Show("Invalid Quantity", "Quantity Error");
            }
        }

        private void Quantity_txt_Click(object sender, EventArgs e)
        {
            using (var d = new Concept_Keyboard())
            {
                Quantity_txt.Text = "";
                Quantity_tick.Enabled = true;//opens keyboard data flow
                d.ShowDialog();
                Quantity_tick.Enabled = false;//closes keyboard data flow
            }
        }

        private void Quantity_tick_Tick(object sender, EventArgs e)
        {
            if (Concept_Keyboard.btn_press != "Del" && Concept_Keyboard.btn_press != "Clear")//if a number key is pressed
            {
                if (Quantity_txt.Text.Length != 4)//limmits quantity length
                {
                    Quantity_txt.Text += Concept_Keyboard.btn_press;//add number to label
                }
            }
            else if (Concept_Keyboard.btn_press == "Del") //if delete is pressed
            {
                if (Quantity_txt.Text.Length != 0)//if there is a character to remove
                {
                    Quantity_txt.Text = Quantity_txt.Text.Substring(0, Quantity_txt.Text.Length - 1);//trim character off of string
                }
            }
            else if(Concept_Keyboard.btn_press=="Clear") //if clear is pressed
            {
                Quantity_txt.Text = "";//empty label
            }
            Concept_Keyboard.btn_press = "";//empty command 
        }
    }
}
