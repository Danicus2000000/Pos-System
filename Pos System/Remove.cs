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
    public partial class Remove : Form
    {
        public List<List<string>> pass_order { get; set; }//used to pass the new cost of the list of items in the order back to the main form
        public double pass_total { get; set; }//used to pass the new total back to the main form
        public Remove(List<List<string>> ordered, double total_cost)//passes the list of the order and the current total cost in to the form
        {
            InitializeComponent();
            order = ordered;//inherits order passed from main form
            total = total_cost;//inherits total passed from main form
        }
        private static List<List<string>> order;//stores order items,cost and quantity
        private static double total;//stores total cost
        private void Cancel_btn_Click(object sender, EventArgs e)//closes computer science
        {
            this.Close();
        }

        private void Remove_Load(object sender, EventArgs e)
        {
            foreach (List<string> set in order) //loops through the items and appends their names to the drop down list
            {
                Item_combo.Items.Add(set[0]);
            }
            Item_combo.SelectedIndex = 0;//sets list index to 0 so it seems like the form automatically chooses the first item
        }
        private void Remove_btn_Click(object sender, EventArgs e)
        {
            foreach(List<string> item in order)//loops through each item in the order
            {
                if (item[0] == Item_combo.Text)//if the item is the one that needs to be removed
                {
                    if (Convert.ToInt64(Quantity_txt.Text) <= Convert.ToInt64(item[2]))//ensures code only runs when quantity is correct
                    {
                        total -= Math.Round((Convert.ToDouble(item[1].TrimStart('£')) * Convert.ToInt32(Quantity_txt.Text)), 2);//subtracts singular item cost times by quantity to remove from total
                        if (item[2] != Convert.ToInt32(Quantity_txt.Text).ToString())//if we don't need to remove all of the quantity of an item
                        {
                            item[2] = (Convert.ToInt32(item[2]) - Convert.ToInt32(Quantity_txt.Text)).ToString();//subtracts quanity to remove from current quantity
                        }
                        else//if we are removing everything
                        {
                            order.Remove(item);//removes entire item info from list
                        }
                        this.pass_order = order;//saves order to be passed back
                        this.pass_total = total;//saves total to be passed back
                        this.DialogResult = DialogResult.Yes;//returns dialog result and closes form
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Quantity to remove cannot be larger than orginal quantity", "Quantity error");//displays error
                    }
                }
            }
        }

        private void Quantity_txt_Click(object sender, EventArgs e)
        {
            using var d = new Concept_Keyboard();
            Quantity_txt.Text = "";
            Quantity_tick.Enabled = true;//opens keyboard data flow
            d.ShowDialog();
            Quantity_tick.Enabled = false;//closes keyboard data flow
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
                    Quantity_txt.Text = Quantity_txt.Text[..^1];//trim character off of string
                }
            }
            else if (Concept_Keyboard.btn_press == "Clear") //if clear is pressed
            {
                Quantity_txt.Text = "";//empty label
            }
            Concept_Keyboard.btn_press = "";//empty command 
        }
    }
}
