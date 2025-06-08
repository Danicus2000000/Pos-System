namespace Pos_System
{
    partial class POS_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS_system));
            this.Button_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.Status_lbl = new System.Windows.Forms.Label();
            this.Starters_btn = new System.Windows.Forms.Button();
            this.Mains_btn = new System.Windows.Forms.Button();
            this.Desserts_btn = new System.Windows.Forms.Button();
            this.Drinks_btn = new System.Windows.Forms.Button();
            this.Time_update = new System.Windows.Forms.Timer(this.components);
            this.order_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.total_lbl = new System.Windows.Forms.Label();
            this.itemremove_btn = new System.Windows.Forms.Button();
            this.complete_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.order_txt = new System.Windows.Forms.TextBox();
            this.order_flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_flow
            // 
            this.Button_flow.BackColor = System.Drawing.Color.Gray;
            this.Button_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Button_flow.Location = new System.Drawing.Point(106, 2);
            this.Button_flow.Name = "Button_flow";
            this.Button_flow.Size = new System.Drawing.Size(842, 567);
            this.Button_flow.TabIndex = 0;
            // 
            // Status_lbl
            // 
            this.Status_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Status_lbl.AutoSize = true;
            this.Status_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_lbl.Location = new System.Drawing.Point(127, 583);
            this.Status_lbl.Name = "Status_lbl";
            this.Status_lbl.Size = new System.Drawing.Size(604, 29);
            this.Status_lbl.TabIndex = 1;
            this.Status_lbl.Text = "POS Status: Online        Job: Name    Time: hh:mm:ss dt";
            this.Status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Starters_btn
            // 
            this.Starters_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Starters_btn.BackColor = System.Drawing.Color.Green;
            this.Starters_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Starters_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Starters_btn.Location = new System.Drawing.Point(12, 27);
            this.Starters_btn.Name = "Starters_btn";
            this.Starters_btn.Size = new System.Drawing.Size(88, 23);
            this.Starters_btn.TabIndex = 0;
            this.Starters_btn.Text = "Starters";
            this.Starters_btn.UseVisualStyleBackColor = false;
            this.Starters_btn.Click += new System.EventHandler(this.FoodSelection_btn_click);
            // 
            // Mains_btn
            // 
            this.Mains_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Mains_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Mains_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mains_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mains_btn.Location = new System.Drawing.Point(12, 56);
            this.Mains_btn.Name = "Mains_btn";
            this.Mains_btn.Size = new System.Drawing.Size(75, 23);
            this.Mains_btn.TabIndex = 2;
            this.Mains_btn.Text = "Mains";
            this.Mains_btn.UseVisualStyleBackColor = false;
            this.Mains_btn.Click += new System.EventHandler(this.FoodSelection_btn_click);
            // 
            // Desserts_btn
            // 
            this.Desserts_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Desserts_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Desserts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desserts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desserts_btn.Location = new System.Drawing.Point(12, 85);
            this.Desserts_btn.Name = "Desserts_btn";
            this.Desserts_btn.Size = new System.Drawing.Size(75, 23);
            this.Desserts_btn.TabIndex = 3;
            this.Desserts_btn.Text = "Desserts";
            this.Desserts_btn.UseVisualStyleBackColor = false;
            this.Desserts_btn.Click += new System.EventHandler(this.FoodSelection_btn_click);
            // 
            // Drinks_btn
            // 
            this.Drinks_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Drinks_btn.BackColor = System.Drawing.Color.Aqua;
            this.Drinks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Drinks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drinks_btn.Location = new System.Drawing.Point(12, 114);
            this.Drinks_btn.Name = "Drinks_btn";
            this.Drinks_btn.Size = new System.Drawing.Size(75, 31);
            this.Drinks_btn.TabIndex = 4;
            this.Drinks_btn.Text = "Drinks";
            this.Drinks_btn.UseVisualStyleBackColor = false;
            this.Drinks_btn.Click += new System.EventHandler(this.FoodSelection_btn_click);
            // 
            // Time_update
            // 
            this.Time_update.Enabled = true;
            this.Time_update.Tick += new System.EventHandler(this.Time_update_Tick);
            // 
            // order_flow
            // 
            this.order_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.order_flow.Controls.Add(this.order_txt);
            this.order_flow.Controls.Add(this.total_lbl);
            this.order_flow.Controls.Add(this.itemremove_btn);
            this.order_flow.Controls.Add(this.complete_btn);
            this.order_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.order_flow.Location = new System.Drawing.Point(954, 12);
            this.order_flow.Name = "order_flow";
            this.order_flow.Size = new System.Drawing.Size(249, 557);
            this.order_flow.TabIndex = 7;
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.total_lbl.Location = new System.Drawing.Point(3, 429);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(138, 29);
            this.total_lbl.TabIndex = 8;
            this.total_lbl.Text = "Total: £0.00";
            // 
            // itemremove_btn
            // 
            this.itemremove_btn.Location = new System.Drawing.Point(3, 461);
            this.itemremove_btn.Name = "itemremove_btn";
            this.itemremove_btn.Size = new System.Drawing.Size(94, 36);
            this.itemremove_btn.TabIndex = 9;
            this.itemremove_btn.Text = "Remove Item";
            this.itemremove_btn.UseVisualStyleBackColor = true;
            this.itemremove_btn.Click += new System.EventHandler(this.Itemremove_btn_Click);
            // 
            // complete_btn
            // 
            this.complete_btn.Location = new System.Drawing.Point(3, 503);
            this.complete_btn.Name = "complete_btn";
            this.complete_btn.Size = new System.Drawing.Size(94, 36);
            this.complete_btn.TabIndex = 10;
            this.complete_btn.Text = "Complete Order";
            this.complete_btn.UseVisualStyleBackColor = true;
            this.complete_btn.Click += new System.EventHandler(this.Complete_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logout_btn.Location = new System.Drawing.Point(905, 575);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(89, 29);
            this.logout_btn.TabIndex = 8;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // order_txt
            // 
            this.order_txt.BackColor = System.Drawing.Color.Gray;
            this.order_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.order_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_txt.Location = new System.Drawing.Point(3, 3);
            this.order_txt.MaximumSize = new System.Drawing.Size(9999999, 9999999);
            this.order_txt.Multiline = true;
            this.order_txt.Name = "order_txt";
            this.order_txt.ReadOnly = true;
            this.order_txt.Size = new System.Drawing.Size(114, 423);
            this.order_txt.TabIndex = 11;
            this.order_txt.Text = "Order\r\n)----(";
            // 
            // POS_system
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1006, 612);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.order_flow);
            this.Controls.Add(this.Drinks_btn);
            this.Controls.Add(this.Desserts_btn);
            this.Controls.Add(this.Mains_btn);
            this.Controls.Add(this.Starters_btn);
            this.Controls.Add(this.Status_lbl);
            this.Controls.Add(this.Button_flow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POS_system";
            this.ShowIcon = false;
            this.Text = "POS system";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POS_system_Load);
            this.order_flow.ResumeLayout(false);
            this.order_flow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Button_flow;
        private System.Windows.Forms.Label Status_lbl;
        private System.Windows.Forms.Button Starters_btn;
        private System.Windows.Forms.Button Mains_btn;
        private System.Windows.Forms.Button Desserts_btn;
        private System.Windows.Forms.Button Drinks_btn;
        private System.Windows.Forms.Timer Time_update;
        private System.Windows.Forms.FlowLayoutPanel order_flow;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button itemremove_btn;
        private System.Windows.Forms.Button complete_btn;
        private System.Windows.Forms.TextBox order_txt;
    }
}

