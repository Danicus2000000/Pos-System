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
using System.Drawing.Printing;
namespace Pos_System
{
    //To do:
    //Add completed order to Access database
    public partial class POS_system : Form
    {
        public POS_system(string PIN_retrive)
        {
            InitializeComponent();
            PIN = PIN_retrive;//passes pin into this form from the sign in form
        }
        private static string PIN;//stores PIN
        private static string employee_name;//stores employee name for status label
        private static string job_name;//stores the employees job title
        private static List<List<string>> ordered = [];//stores the current order 
        private static string current_cat=string.Empty;//stores current catagory
        private static double total_cost = 0;
        private void POS_system_Load(object sender, EventArgs e)
        {
            Button_flow.Location = new Point(136, 0);//sets default location for flow pannel
            Button_flow.Size = new Size(this.Width-1040, this.Height-42); //sets size of flow pannel based on form size which is based on screen resolution
            order_txt.Location = new Point(this.Width - 900, 0);
            order_txt.Size = new Size(900-92, this.Height-121);
            order_flow.Location = new Point(this.Width - 900, 0);
            order_flow.Size = new Size(900, this.Height);
            Size buttonsize = new(136, 46); //creates a button size 'default'
            #region Button Size and Location Config
            Starters_btn.Location = new Point(0, (this.Height / 2)-100);
            Starters_btn.Size = buttonsize;

            Mains_btn.Location = new Point(0, (this.Height / 2)-100+46);
            Mains_btn.Size=buttonsize;

            Desserts_btn.Location = new Point(0, (this.Height / 2)-100 + (46 * 2));
            Desserts_btn.Size = buttonsize;

            Drinks_btn.Location = new Point(0, (this.Height / 2)-100+ (46 * 3));
            Drinks_btn.Size = buttonsize;
            #endregion//creates a configuration for each button that caluclates its size and spacing
            List<string> employee_data = DatabaseHandling.GetJobName("SELECT [Job Name] FROM Jobs WHERE [Job ID]=@jobid", PIN);//fetches employee data
            employee_name = employee_data[1];//sets employee data
            job_name = employee_data[2];//also fetches job id
            Status_lbl.Text = "POS Status: Online        " + job_name + ": " + employee_name+"    Time: "+DateTime.Now.ToString("h:mm:ss tt");//sets up the status label with default values that gets updated via the timer
        }
        public void FoodButton_click(object sender, EventArgs e)
        {
            Button food = (Button)sender;//inherits buttons values and details temporarly for method use
            using (var d = new Ordering(food.Text))//initalises a form as a dialog box 
            {
                DialogResult result = d.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    bool already_in = false;
                    foreach (List<string> currentorder in ordered)//grabs form result and adds nessasary foods to the form if already present increases quanitity
                    {
                        if (currentorder[0] == food.Text)
                        {
                            currentorder[2] = (Convert.ToInt32(currentorder[2]) + Convert.ToInt32(d.Quantity)).ToString();
                            already_in = true;
                            total_cost += Math.Round(Convert.ToDouble(d.FoodCost)*Convert.ToInt32(d.Quantity),2);//ensures input is in correct form
                            break;
                        }
                    }
                    if (!already_in)
                    {
                        ordered.Add([food.Text, d.FoodCost,d.Quantity]);//adds the data to the order
                        total_cost += Math.Round(Convert.ToDouble(d.FoodCost) * Convert.ToInt32(d.Quantity), 2);
                    }
                }
            }
            order_txt.Text = "Order\r\n)------(";//updates the order textbox with all current information
            foreach (List<string> item in ordered)
            {
                order_txt.Text += "\r\n" + item[0] + " " + item[1] + " X" + item[2];
            }
            total_lbl.Text = "Total: £" + Math.Round(total_cost, 2);//updates total cost label with the current total
            try
            {
                if (total_lbl.Text.Split('.')[1].Length != 2)//ensures the total remains 2 dp long
                {
                    total_lbl.Text += "0";
                }
            }
            catch (Exception)
            {
                total_lbl.Text += ".00";//adds decimals to the end of the total when none are present
            }
        }
        private void Time_update_Tick(object sender, EventArgs e)//updates the time each second mom found the pp
        {
            Status_lbl.Text = "POS Status: Online        " + job_name + ": " + employee_name + "        Time: " + DateTime.Now.ToString("h:mm:ss tt");
        }
        private void FoodSelection_btn_click(object sender, EventArgs e)
        {
            Button pressed = (Button)sender;
            if (current_cat != pressed.Text)//ensures code is not unnesesaraly repeated
            {
                Button_flow.Controls.Clear();//clears flow panel
                foreach(Button btn in DatabaseHandling.GetFoodButtons("SELECT [Food Name] FROM Item WHERE [Food Type]=@type",pressed))//fetches all buttons needed and adds them to the control
                {
                    Button_flow.Controls.Add(btn);
                }
                current_cat = pressed.Text;
            }
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();//jumps back to sign in screen
            Form sign_in = new Sign_in();
            sign_in.Closed += (s, args) => this.Close();
            sign_in.Show();
        }

        private void Itemremove_btn_Click(object sender, EventArgs e)
        {
            if (ordered.Count != 0)//ensures there is items to remove
            {
                using var d = new Remove(ordered, total_cost);//initalises a form as a dialog box 
                var result = d.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    ordered = d.pass_order;
                    total_cost = d.pass_total;
                    order_txt.Text = "Order\r\n)------(";//updates the order textbox with all current information
                    foreach (List<string> item in ordered)
                    {
                        order_txt.Text += "\r\n" + item[0] + " " + item[1] + " X" + item[2];
                    }
                    total_lbl.Text = "Total: £" + Math.Round(total_cost, 2);//updates total cost label with the current total
                    try
                    {
                        if (total_lbl.Text.Split('.')[1].Length != 2)//ensures the total remains 2 dp long
                        {
                            total_lbl.Text += "0";
                        }
                    }
                    catch (Exception)
                    {
                        total_lbl.Text += ".00";//adds decimals to the end of the total when none are present
                    }
                }
            }
        }

        private void Complete_btn_Click(object sender, EventArgs e)
        {
            if (ordered.Count != 0)//ensures order isn't empty
            {
                DialogResult print = MessageBox.Show("Would the customer like a receipt?", "Print receipt?", MessageBoxButtons.YesNoCancel);//checks if customer wants reciept
                if (print != DialogResult.Cancel)
                {
                    if (print == DialogResult.Yes)//if they do
                    {
                        PrintDialog printDialog = new();//intialises printing prerequizits
                        PrintDocument printDocument = new();
                        printDocument.PrintPage += new PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing and calls event
                        printDocument.PrinterSettings.PrintFileName = "Receipt.pdf";//sets the name of the printed file
                        printDialog.Document = printDocument; //add the document to the dialog box...
                        DialogResult result = printDialog.ShowDialog();//shows print dialog
                        if (result == DialogResult.OK)
                        {
                            printDocument.Print();
                        }
                    }
                    DatabaseHandling.SendData("insert into Orders ([Order ID], [Food ID], [Quantity Ordered]) values(@first,@second,@last)", ordered);//uses the send data function
                    ordered = [];//resets order
                    total_cost = 0;//resets total cost
                    total_lbl.Text = "Total: £0.00";//updates label
                    order_txt.Text = "Order" + "\r\n" + ")------(";//updates label
                }
            }
        }
        public void CreateReceipt(object sender,PrintPageEventArgs e) 
        {
            Graphics graphic = e.Graphics;//creates drawing surface
            Font font= new("Courier New", 12);//sets font to draw with
            float fontheight = font.GetHeight();//gets height of font
            int startx = 10;//starting x coordinate
            int starty = 10;//starting y coordinate
            int offset = 20;//offset from left side of reciept
            graphic.DrawString("Infinity Restaurants", new Font("Courier New", 18), new SolidBrush(Color.Black), startx, starty);//draws receipt out
            offset += 14;
            string staff = "Cashier: " + employee_name.PadRight(31) + "Time: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            graphic.DrawString(staff, font, new SolidBrush(Color.Black), startx, starty+offset);
            offset = offset + (int)fontheight+14;
            string top = "Item Name".PadRight(40) + "Price".PadRight(10)+"Quantity".PadRight(15)+"Subtotal";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset += (int)fontheight; //make the spacing consistent
            graphic.DrawString("---------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)fontheight + 5; //make the spacing consistent
            foreach(List<string> item in ordered) 
            {
                string subtotal =string.Format("{0:c}",("£"+(Convert.ToDouble(item[2]) * Convert.ToDouble(item[1])).ToString()));
                string todraw = item[0].PadRight(40) + "£" + item[1].PadRight(14)+item[2].PadRight(7)+"@".PadRight(4)+subtotal;
                graphic.DrawString(todraw, font, new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + (int)fontheight+5;
            }
            offset += 20; //make some room so that the total stands out.
            graphic.DrawString("Total to pay ".PadRight(40) + String.Format("{0:c}", total_cost), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startx, starty + offset);
            offset += 50; //make some room so goodbye message stands out
            graphic.DrawString("Thank you for dining with Infinity Restaurants!", font, new SolidBrush(Color.Black), startx, starty + offset);
        }
    }
}
