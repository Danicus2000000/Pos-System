namespace Pos_System
{
    partial class Ordering
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordering));
            this.Cost_lbl = new System.Windows.Forms.Label();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Description_lbl = new System.Windows.Forms.Label();
            this.description_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.Quantity_lbl = new System.Windows.Forms.Label();
            this.Quantity_txt = new System.Windows.Forms.TextBox();
            this.Quantity_tick = new System.Windows.Forms.Timer(this.components);
            this.description_flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cost_lbl
            // 
            this.Cost_lbl.AutoSize = true;
            this.Cost_lbl.Location = new System.Drawing.Point(4, 75);
            this.Cost_lbl.Name = "Cost_lbl";
            this.Cost_lbl.Size = new System.Drawing.Size(27, 13);
            this.Cost_lbl.TabIndex = 7;
            this.Cost_lbl.Text = "cost";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(277, 135);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(90, 32);
            this.Cancel_btn.TabIndex = 6;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(86, 135);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(90, 32);
            this.Add_btn.TabIndex = 5;
            this.Add_btn.Text = "Add to order";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Description_lbl
            // 
            this.Description_lbl.AutoSize = true;
            this.Description_lbl.Location = new System.Drawing.Point(3, 0);
            this.Description_lbl.Name = "Description_lbl";
            this.Description_lbl.Size = new System.Drawing.Size(58, 13);
            this.Description_lbl.TabIndex = 4;
            this.Description_lbl.Text = "description";
            // 
            // description_flow
            // 
            this.description_flow.Controls.Add(this.Description_lbl);
            this.description_flow.Location = new System.Drawing.Point(7, 12);
            this.description_flow.Name = "description_flow";
            this.description_flow.Size = new System.Drawing.Size(429, 60);
            this.description_flow.TabIndex = 8;
            // 
            // Quantity_lbl
            // 
            this.Quantity_lbl.AutoSize = true;
            this.Quantity_lbl.Location = new System.Drawing.Point(4, 108);
            this.Quantity_lbl.Name = "Quantity_lbl";
            this.Quantity_lbl.Size = new System.Drawing.Size(49, 13);
            this.Quantity_lbl.TabIndex = 9;
            this.Quantity_lbl.Text = "Quantity:";
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Quantity_txt.Location = new System.Drawing.Point(59, 105);
            this.Quantity_txt.MaxLength = 5;
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.Size = new System.Drawing.Size(100, 20);
            this.Quantity_txt.TabIndex = 10;
            this.Quantity_txt.Text = "1";
            this.Quantity_txt.Click += new System.EventHandler(this.Quantity_txt_Click);
            // 
            // Quantity_tick
            // 
            this.Quantity_tick.Tick += new System.EventHandler(this.Quantity_tick_Tick);
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 179);
            this.Controls.Add(this.Quantity_txt);
            this.Controls.Add(this.Quantity_lbl);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Cost_lbl);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.description_flow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ordering";
            this.ShowIcon = false;
            this.Text = "Add to order?";
            this.Load += new System.EventHandler(this.Ordering_Load);
            this.description_flow.ResumeLayout(false);
            this.description_flow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cost_lbl;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label Description_lbl;
        private System.Windows.Forms.FlowLayoutPanel description_flow;
        private System.Windows.Forms.Label Quantity_lbl;
        private System.Windows.Forms.TextBox Quantity_txt;
        private System.Windows.Forms.Timer Quantity_tick;
    }
}