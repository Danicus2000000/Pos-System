namespace Pos_System
{
    partial class Remove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove));
            this.Item_lbl = new System.Windows.Forms.Label();
            this.Quantity_lbl = new System.Windows.Forms.Label();
            this.Item_combo = new System.Windows.Forms.ComboBox();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Quantity_txt = new System.Windows.Forms.TextBox();
            this.Quantity_tick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Item_lbl
            // 
            this.Item_lbl.AutoSize = true;
            this.Item_lbl.Location = new System.Drawing.Point(31, 32);
            this.Item_lbl.Name = "Item_lbl";
            this.Item_lbl.Size = new System.Drawing.Size(80, 13);
            this.Item_lbl.TabIndex = 0;
            this.Item_lbl.Text = "Item to remove:";
            // 
            // Quantity_lbl
            // 
            this.Quantity_lbl.AutoSize = true;
            this.Quantity_lbl.Location = new System.Drawing.Point(12, 56);
            this.Quantity_lbl.Name = "Quantity_lbl";
            this.Quantity_lbl.Size = new System.Drawing.Size(99, 13);
            this.Quantity_lbl.TabIndex = 1;
            this.Quantity_lbl.Text = "Quantity to remove:";
            // 
            // Item_combo
            // 
            this.Item_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item_combo.Location = new System.Drawing.Point(117, 29);
            this.Item_combo.Name = "Item_combo";
            this.Item_combo.Size = new System.Drawing.Size(217, 21);
            this.Item_combo.TabIndex = 7;
            // 
            // Remove_btn
            // 
            this.Remove_btn.Location = new System.Drawing.Point(117, 93);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(90, 32);
            this.Remove_btn.TabIndex = 4;
            this.Remove_btn.Text = "Remove";
            this.Remove_btn.UseVisualStyleBackColor = true;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(244, 93);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(90, 32);
            this.Cancel_btn.TabIndex = 5;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.Location = new System.Drawing.Point(117, 53);
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.Size = new System.Drawing.Size(217, 20);
            this.Quantity_txt.TabIndex = 6;
            this.Quantity_txt.Text = "1";
            this.Quantity_txt.Click += new System.EventHandler(this.Quantity_txt_Click);
            // 
            // Quantity_tick
            // 
            this.Quantity_tick.Tick += new System.EventHandler(this.Quantity_tick_Tick);
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 138);
            this.Controls.Add(this.Quantity_txt);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.Item_combo);
            this.Controls.Add(this.Quantity_lbl);
            this.Controls.Add(this.Item_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Remove";
            this.ShowIcon = false;
            this.Text = "Remove item?";
            this.Load += new System.EventHandler(this.Remove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Item_lbl;
        private System.Windows.Forms.Label Quantity_lbl;
        private System.Windows.Forms.ComboBox Item_combo;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.TextBox Quantity_txt;
        private System.Windows.Forms.Timer Quantity_tick;
    }
}