namespace Calculator
{
    partial class frm_cal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cal));
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.lbl_history = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(14, 90);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(45, 45);
            this.btn_7.TabIndex = 0;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(229, 90);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(45, 45);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "CE";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_div
            // 
            this.btn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.Location = new System.Drawing.Point(175, 90);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(45, 45);
            this.btn_div.TabIndex = 2;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(119, 90);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(45, 45);
            this.btn_9.TabIndex = 3;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(65, 90);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(45, 45);
            this.btn_8.TabIndex = 4;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_point
            // 
            this.btn_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_point.Location = new System.Drawing.Point(119, 243);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(45, 45);
            this.btn_point.TabIndex = 8;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(175, 243);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(45, 45);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_result.Location = new System.Drawing.Point(229, 193);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(45, 95);
            this.btn_result.TabIndex = 6;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(14, 243);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(95, 45);
            this.btn_0.TabIndex = 5;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(65, 141);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(45, 45);
            this.btn_5.TabIndex = 14;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(119, 141);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(45, 45);
            this.btn_6.TabIndex = 13;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multi.Location = new System.Drawing.Point(175, 141);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(45, 45);
            this.btn_multi.TabIndex = 12;
            this.btn_multi.Text = "*";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(229, 141);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(45, 45);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(14, 141);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(45, 45);
            this.btn_4.TabIndex = 10;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(65, 192);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(45, 45);
            this.btn_2.TabIndex = 19;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(119, 192);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(45, 45);
            this.btn_3.TabIndex = 18;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(175, 192);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(45, 45);
            this.btn_sub.TabIndex = 17;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(14, 192);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(45, 45);
            this.btn_1.TabIndex = 15;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.Button_Click);
            // 
            // txtBx
            // 
            this.txtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx.Location = new System.Drawing.Point(14, 42);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(260, 29);
            this.txtBx.TabIndex = 20;
            this.txtBx.Text = "0";
            this.txtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_history
            // 
            this.lbl_history.AutoSize = true;
            this.lbl_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_history.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_history.Location = new System.Drawing.Point(12, 9);
            this.lbl_history.Name = "lbl_history";
            this.lbl_history.Size = new System.Drawing.Size(0, 25);
            this.lbl_history.TabIndex = 21;
            // 
            // frm_cal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(286, 301);
            this.Controls.Add(this.lbl_history);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_cal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.Label lbl_history;
    }
}

