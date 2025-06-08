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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS_system));
            Button_flow = new System.Windows.Forms.FlowLayoutPanel();
            Status_lbl = new System.Windows.Forms.Label();
            Starters_btn = new System.Windows.Forms.Button();
            Mains_btn = new System.Windows.Forms.Button();
            Desserts_btn = new System.Windows.Forms.Button();
            Drinks_btn = new System.Windows.Forms.Button();
            Time_update = new System.Windows.Forms.Timer(components);
            order_flow = new System.Windows.Forms.FlowLayoutPanel();
            order_txt = new System.Windows.Forms.TextBox();
            total_lbl = new System.Windows.Forms.Label();
            itemremove_btn = new System.Windows.Forms.Button();
            complete_btn = new System.Windows.Forms.Button();
            logout_btn = new System.Windows.Forms.Button();
            order_flow.SuspendLayout();
            SuspendLayout();
            // 
            // Button_flow
            // 
            Button_flow.BackColor = System.Drawing.Color.Gray;
            Button_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Button_flow.Location = new System.Drawing.Point(124, 2);
            Button_flow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Button_flow.Name = "Button_flow";
            Button_flow.Size = new System.Drawing.Size(982, 654);
            Button_flow.TabIndex = 0;
            // 
            // Status_lbl
            // 
            Status_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Status_lbl.AutoSize = true;
            Status_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Status_lbl.Location = new System.Drawing.Point(148, 682);
            Status_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Status_lbl.Name = "Status_lbl";
            Status_lbl.Size = new System.Drawing.Size(604, 29);
            Status_lbl.TabIndex = 1;
            Status_lbl.Text = "POS Status: Online        Job: Name    Time: hh:mm:ss dt";
            Status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Starters_btn
            // 
            Starters_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            Starters_btn.BackColor = System.Drawing.Color.Green;
            Starters_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Starters_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Starters_btn.Location = new System.Drawing.Point(14, 35);
            Starters_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Starters_btn.Name = "Starters_btn";
            Starters_btn.Size = new System.Drawing.Size(103, 27);
            Starters_btn.TabIndex = 0;
            Starters_btn.Text = "Starters";
            Starters_btn.UseVisualStyleBackColor = false;
            Starters_btn.Click += FoodSelection_btn_click;
            // 
            // Mains_btn
            // 
            Mains_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            Mains_btn.BackColor = System.Drawing.Color.FromArgb(128, 64, 64);
            Mains_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Mains_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Mains_btn.Location = new System.Drawing.Point(14, 69);
            Mains_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Mains_btn.Name = "Mains_btn";
            Mains_btn.Size = new System.Drawing.Size(88, 27);
            Mains_btn.TabIndex = 2;
            Mains_btn.Text = "Mains";
            Mains_btn.UseVisualStyleBackColor = false;
            Mains_btn.Click += FoodSelection_btn_click;
            // 
            // Desserts_btn
            // 
            Desserts_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            Desserts_btn.BackColor = System.Drawing.Color.FromArgb(255, 255, 128);
            Desserts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Desserts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Desserts_btn.Location = new System.Drawing.Point(14, 102);
            Desserts_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Desserts_btn.Name = "Desserts_btn";
            Desserts_btn.Size = new System.Drawing.Size(88, 27);
            Desserts_btn.TabIndex = 3;
            Desserts_btn.Text = "Desserts";
            Desserts_btn.UseVisualStyleBackColor = false;
            Desserts_btn.Click += FoodSelection_btn_click;
            // 
            // Drinks_btn
            // 
            Drinks_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            Drinks_btn.BackColor = System.Drawing.Color.Aqua;
            Drinks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Drinks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Drinks_btn.Location = new System.Drawing.Point(14, 136);
            Drinks_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Drinks_btn.Name = "Drinks_btn";
            Drinks_btn.Size = new System.Drawing.Size(88, 36);
            Drinks_btn.TabIndex = 4;
            Drinks_btn.Text = "Drinks";
            Drinks_btn.UseVisualStyleBackColor = false;
            Drinks_btn.Click += FoodSelection_btn_click;
            // 
            // Time_update
            // 
            Time_update.Enabled = true;
            Time_update.Tick += Time_update_Tick;
            // 
            // order_flow
            // 
            order_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            order_flow.Controls.Add(order_txt);
            order_flow.Controls.Add(total_lbl);
            order_flow.Controls.Add(itemremove_btn);
            order_flow.Controls.Add(complete_btn);
            order_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            order_flow.Location = new System.Drawing.Point(1113, 14);
            order_flow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            order_flow.Name = "order_flow";
            order_flow.Size = new System.Drawing.Size(290, 642);
            order_flow.TabIndex = 7;
            // 
            // order_txt
            // 
            order_txt.BackColor = System.Drawing.Color.Gray;
            order_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            order_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            order_txt.Location = new System.Drawing.Point(4, 3);
            order_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            order_txt.MaximumSize = new System.Drawing.Size(11666665, 11538460);
            order_txt.Multiline = true;
            order_txt.Name = "order_txt";
            order_txt.ReadOnly = true;
            order_txt.Size = new System.Drawing.Size(133, 488);
            order_txt.TabIndex = 11;
            order_txt.Text = "Order\r\n)----(";
            // 
            // total_lbl
            // 
            total_lbl.AutoSize = true;
            total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            total_lbl.Location = new System.Drawing.Point(4, 494);
            total_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            total_lbl.Name = "total_lbl";
            total_lbl.Size = new System.Drawing.Size(138, 29);
            total_lbl.TabIndex = 8;
            total_lbl.Text = "Total: £0.00";
            // 
            // itemremove_btn
            // 
            itemremove_btn.Location = new System.Drawing.Point(4, 526);
            itemremove_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            itemremove_btn.Name = "itemremove_btn";
            itemremove_btn.Size = new System.Drawing.Size(110, 42);
            itemremove_btn.TabIndex = 9;
            itemremove_btn.Text = "Remove Item";
            itemremove_btn.UseVisualStyleBackColor = true;
            itemremove_btn.Click += Itemremove_btn_Click;
            // 
            // complete_btn
            // 
            complete_btn.Location = new System.Drawing.Point(4, 574);
            complete_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            complete_btn.Name = "complete_btn";
            complete_btn.Size = new System.Drawing.Size(110, 42);
            complete_btn.TabIndex = 10;
            complete_btn.Text = "Complete Order";
            complete_btn.UseVisualStyleBackColor = true;
            complete_btn.Click += Complete_btn_Click;
            // 
            // logout_btn
            // 
            logout_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            logout_btn.Location = new System.Drawing.Point(1056, 672);
            logout_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new System.Drawing.Size(104, 33);
            logout_btn.TabIndex = 8;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += Logout_btn_Click;
            // 
            // POS_system
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gray;
            ClientSize = new System.Drawing.Size(1294, 715);
            Controls.Add(logout_btn);
            Controls.Add(order_flow);
            Controls.Add(Drinks_btn);
            Controls.Add(Desserts_btn);
            Controls.Add(Mains_btn);
            Controls.Add(Starters_btn);
            Controls.Add(Status_lbl);
            Controls.Add(Button_flow);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "POS_system";
            ShowIcon = false;
            Text = "POS system";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += POS_system_Load;
            order_flow.ResumeLayout(false);
            order_flow.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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

