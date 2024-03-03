namespace Activity2
{
    partial class Main
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
            this.rd_Student = new System.Windows.Forms.RadioButton();
            this.rd_Senior = new System.Windows.Forms.RadioButton();
            this.rd_PWD = new System.Windows.Forms.RadioButton();
            this.rd_Regular = new System.Windows.Forms.RadioButton();
            this.gb_Discount = new System.Windows.Forms.GroupBox();
            this.gb_Menu = new System.Windows.Forms.GroupBox();
            this.M_20 = new System.Windows.Forms.CheckBox();
            this.M_19 = new System.Windows.Forms.CheckBox();
            this.M_18 = new System.Windows.Forms.CheckBox();
            this.M_16 = new System.Windows.Forms.CheckBox();
            this.M_15 = new System.Windows.Forms.CheckBox();
            this.M_14 = new System.Windows.Forms.CheckBox();
            this.M_12 = new System.Windows.Forms.CheckBox();
            this.M_11 = new System.Windows.Forms.CheckBox();
            this.M_10 = new System.Windows.Forms.CheckBox();
            this.M_17 = new System.Windows.Forms.CheckBox();
            this.M_13 = new System.Windows.Forms.CheckBox();
            this.M_09 = new System.Windows.Forms.CheckBox();
            this.M_08 = new System.Windows.Forms.CheckBox();
            this.M_07 = new System.Windows.Forms.CheckBox();
            this.M_06 = new System.Windows.Forms.CheckBox();
            this.M_05 = new System.Windows.Forms.CheckBox();
            this.M_04 = new System.Windows.Forms.CheckBox();
            this.M_03 = new System.Windows.Forms.CheckBox();
            this.M_02 = new System.Windows.Forms.CheckBox();
            this.M_01 = new System.Windows.Forms.CheckBox();
            this.bt_Buy = new System.Windows.Forms.Button();
            this.lb_Subtotal = new System.Windows.Forms.Label();
            this.lb_Total = new System.Windows.Forms.Label();
            this.num_Rice = new System.Windows.Forms.NumericUpDown();
            this.lb_Rice = new System.Windows.Forms.Label();
            this.lb_Gravy = new System.Windows.Forms.Label();
            this.num_Gravy = new System.Windows.Forms.NumericUpDown();
            this.lb_Ketchup = new System.Windows.Forms.Label();
            this.num_Ketchup = new System.Windows.Forms.NumericUpDown();
            this.tb_Subtotal = new System.Windows.Forms.TextBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.lb_Discount = new System.Windows.Forms.Label();
            this.gb_Discount.SuspendLayout();
            this.gb_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Rice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Gravy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Ketchup)).BeginInit();
            this.SuspendLayout();
            // 
            // rd_Student
            // 
            this.rd_Student.AutoSize = true;
            this.rd_Student.Location = new System.Drawing.Point(23, 34);
            this.rd_Student.Name = "rd_Student";
            this.rd_Student.Size = new System.Drawing.Size(91, 17);
            this.rd_Student.TabIndex = 4;
            this.rd_Student.TabStop = true;
            this.rd_Student.Tag = "10";
            this.rd_Student.Text = "Student - 10%";
            this.rd_Student.UseVisualStyleBackColor = true;
            // 
            // rd_Senior
            // 
            this.rd_Senior.AutoSize = true;
            this.rd_Senior.Location = new System.Drawing.Point(23, 67);
            this.rd_Senior.Name = "rd_Senior";
            this.rd_Senior.Size = new System.Drawing.Size(84, 17);
            this.rd_Senior.TabIndex = 5;
            this.rd_Senior.TabStop = true;
            this.rd_Senior.Tag = "20";
            this.rd_Senior.Text = "Senior - 20%";
            this.rd_Senior.UseVisualStyleBackColor = true;
            // 
            // rd_PWD
            // 
            this.rd_PWD.AutoSize = true;
            this.rd_PWD.Location = new System.Drawing.Point(23, 100);
            this.rd_PWD.Name = "rd_PWD";
            this.rd_PWD.Size = new System.Drawing.Size(80, 17);
            this.rd_PWD.TabIndex = 6;
            this.rd_PWD.TabStop = true;
            this.rd_PWD.Tag = "20";
            this.rd_PWD.Text = "PWD - 20%";
            this.rd_PWD.UseVisualStyleBackColor = true;
            // 
            // rd_Regular
            // 
            this.rd_Regular.AutoSize = true;
            this.rd_Regular.Location = new System.Drawing.Point(23, 133);
            this.rd_Regular.Name = "rd_Regular";
            this.rd_Regular.Size = new System.Drawing.Size(85, 17);
            this.rd_Regular.TabIndex = 7;
            this.rd_Regular.TabStop = true;
            this.rd_Regular.Tag = "0";
            this.rd_Regular.Text = "Regular - 0%";
            this.rd_Regular.UseVisualStyleBackColor = true;
            // 
            // gb_Discount
            // 
            this.gb_Discount.Controls.Add(this.rd_Regular);
            this.gb_Discount.Controls.Add(this.rd_PWD);
            this.gb_Discount.Controls.Add(this.rd_Senior);
            this.gb_Discount.Controls.Add(this.rd_Student);
            this.gb_Discount.Location = new System.Drawing.Point(801, 42);
            this.gb_Discount.Name = "gb_Discount";
            this.gb_Discount.Size = new System.Drawing.Size(131, 173);
            this.gb_Discount.TabIndex = 8;
            this.gb_Discount.TabStop = false;
            this.gb_Discount.Text = "Discount";
            // 
            // gb_Menu
            // 
            this.gb_Menu.Controls.Add(this.M_20);
            this.gb_Menu.Controls.Add(this.M_19);
            this.gb_Menu.Controls.Add(this.M_18);
            this.gb_Menu.Controls.Add(this.M_16);
            this.gb_Menu.Controls.Add(this.M_15);
            this.gb_Menu.Controls.Add(this.M_14);
            this.gb_Menu.Controls.Add(this.M_12);
            this.gb_Menu.Controls.Add(this.M_11);
            this.gb_Menu.Controls.Add(this.M_10);
            this.gb_Menu.Controls.Add(this.M_17);
            this.gb_Menu.Controls.Add(this.M_13);
            this.gb_Menu.Controls.Add(this.M_09);
            this.gb_Menu.Controls.Add(this.M_08);
            this.gb_Menu.Controls.Add(this.M_07);
            this.gb_Menu.Controls.Add(this.M_06);
            this.gb_Menu.Controls.Add(this.M_05);
            this.gb_Menu.Controls.Add(this.M_04);
            this.gb_Menu.Controls.Add(this.M_03);
            this.gb_Menu.Controls.Add(this.M_02);
            this.gb_Menu.Controls.Add(this.M_01);
            this.gb_Menu.Location = new System.Drawing.Point(37, 42);
            this.gb_Menu.Name = "gb_Menu";
            this.gb_Menu.Size = new System.Drawing.Size(732, 172);
            this.gb_Menu.TabIndex = 9;
            this.gb_Menu.TabStop = false;
            this.gb_Menu.Text = "Menu";
            // 
            // M_20
            // 
            this.M_20.AutoSize = true;
            this.M_20.Location = new System.Drawing.Point(611, 135);
            this.M_20.Name = "M_20";
            this.M_20.Size = new System.Drawing.Size(82, 17);
            this.M_20.TabIndex = 23;
            this.M_20.Tag = "20";
            this.M_20.Text = "Minus - ₱20";
            this.M_20.UseVisualStyleBackColor = true;
            // 
            // M_19
            // 
            this.M_19.AutoSize = true;
            this.M_19.Location = new System.Drawing.Point(611, 101);
            this.M_19.Name = "M_19";
            this.M_19.Size = new System.Drawing.Size(107, 17);
            this.M_19.TabIndex = 22;
            this.M_19.Tag = "25";
            this.M_19.Text = "Cocomelon - ₱25";
            this.M_19.UseVisualStyleBackColor = true;
            // 
            // M_18
            // 
            this.M_18.AutoSize = true;
            this.M_18.Location = new System.Drawing.Point(611, 69);
            this.M_18.Name = "M_18";
            this.M_18.Size = new System.Drawing.Size(80, 17);
            this.M_18.TabIndex = 21;
            this.M_18.Tag = "25";
            this.M_18.Text = "Bepis - ₱25";
            this.M_18.UseVisualStyleBackColor = true;
            // 
            // M_16
            // 
            this.M_16.AutoSize = true;
            this.M_16.Location = new System.Drawing.Point(469, 135);
            this.M_16.Name = "M_16";
            this.M_16.Size = new System.Drawing.Size(108, 17);
            this.M_16.TabIndex = 20;
            this.M_16.Tag = "130";
            this.M_16.Text = "Fried Pork - ₱130";
            this.M_16.UseVisualStyleBackColor = true;
            // 
            // M_15
            // 
            this.M_15.AutoSize = true;
            this.M_15.Location = new System.Drawing.Point(469, 102);
            this.M_15.Name = "M_15";
            this.M_15.Size = new System.Drawing.Size(123, 17);
            this.M_15.TabIndex = 19;
            this.M_15.Tag = "125";
            this.M_15.Text = "Roasted Hen - ₱125";
            this.M_15.UseVisualStyleBackColor = true;
            // 
            // M_14
            // 
            this.M_14.AutoSize = true;
            this.M_14.Location = new System.Drawing.Point(469, 69);
            this.M_14.Name = "M_14";
            this.M_14.Size = new System.Drawing.Size(101, 17);
            this.M_14.TabIndex = 18;
            this.M_14.Tag = "85";
            this.M_14.Text = "Beef Sisig - ₱85";
            this.M_14.UseVisualStyleBackColor = true;
            // 
            // M_12
            // 
            this.M_12.AutoSize = true;
            this.M_12.Location = new System.Drawing.Point(314, 135);
            this.M_12.Name = "M_12";
            this.M_12.Size = new System.Drawing.Size(103, 17);
            this.M_12.TabIndex = 17;
            this.M_12.Tag = "40";
            this.M_12.Text = "Siomaipao - ₱40";
            this.M_12.UseVisualStyleBackColor = true;
            // 
            // M_11
            // 
            this.M_11.AutoSize = true;
            this.M_11.Location = new System.Drawing.Point(314, 101);
            this.M_11.Name = "M_11";
            this.M_11.Size = new System.Drawing.Size(117, 17);
            this.M_11.TabIndex = 16;
            this.M_11.Tag = "40";
            this.M_11.Text = "Mug Noodles - ₱40";
            this.M_11.UseVisualStyleBackColor = true;
            // 
            // M_10
            // 
            this.M_10.AutoSize = true;
            this.M_10.Location = new System.Drawing.Point(314, 68);
            this.M_10.Name = "M_10";
            this.M_10.Size = new System.Drawing.Size(132, 17);
            this.M_10.TabIndex = 15;
            this.M_10.Tag = "50";
            this.M_10.Text = "Chicken Niggets - ₱50";
            this.M_10.UseVisualStyleBackColor = true;
            // 
            // M_17
            // 
            this.M_17.AutoSize = true;
            this.M_17.Location = new System.Drawing.Point(611, 36);
            this.M_17.Name = "M_17";
            this.M_17.Size = new System.Drawing.Size(73, 17);
            this.M_17.TabIndex = 11;
            this.M_17.Tag = "25";
            this.M_17.Text = "Coc - ₱25";
            this.M_17.UseVisualStyleBackColor = true;
            // 
            // M_13
            // 
            this.M_13.AutoSize = true;
            this.M_13.Location = new System.Drawing.Point(469, 36);
            this.M_13.Name = "M_13";
            this.M_13.Size = new System.Drawing.Size(99, 17);
            this.M_13.TabIndex = 10;
            this.M_13.Tag = "70";
            this.M_13.Text = "Cowchop - ₱70";
            this.M_13.UseVisualStyleBackColor = true;
            // 
            // M_09
            // 
            this.M_09.AutoSize = true;
            this.M_09.Location = new System.Drawing.Point(314, 35);
            this.M_09.Name = "M_09";
            this.M_09.Size = new System.Drawing.Size(113, 17);
            this.M_09.TabIndex = 9;
            this.M_09.Tag = "60";
            this.M_09.Text = "Gordon Blue - ₱60";
            this.M_09.UseVisualStyleBackColor = true;
            // 
            // M_08
            // 
            this.M_08.AutoSize = true;
            this.M_08.Location = new System.Drawing.Point(175, 134);
            this.M_08.Name = "M_08";
            this.M_08.Size = new System.Drawing.Size(91, 17);
            this.M_08.TabIndex = 7;
            this.M_08.Tag = "5";
            this.M_08.Text = "McBread - ₱5";
            this.M_08.UseVisualStyleBackColor = true;
            // 
            // M_07
            // 
            this.M_07.AutoSize = true;
            this.M_07.Location = new System.Drawing.Point(175, 102);
            this.M_07.Name = "M_07";
            this.M_07.Size = new System.Drawing.Size(98, 17);
            this.M_07.TabIndex = 6;
            this.M_07.Tag = "40";
            this.M_07.Text = "McDonut - ₱40";
            this.M_07.UseVisualStyleBackColor = true;
            // 
            // M_06
            // 
            this.M_06.AutoSize = true;
            this.M_06.Location = new System.Drawing.Point(175, 68);
            this.M_06.Name = "M_06";
            this.M_06.Size = new System.Drawing.Size(114, 17);
            this.M_06.TabIndex = 5;
            this.M_06.Tag = "35";
            this.M_06.Text = "McApple Pie - ₱35";
            this.M_06.UseVisualStyleBackColor = true;
            // 
            // M_05
            // 
            this.M_05.AutoSize = true;
            this.M_05.Location = new System.Drawing.Point(175, 35);
            this.M_05.Name = "M_05";
            this.M_05.Size = new System.Drawing.Size(112, 17);
            this.M_05.TabIndex = 4;
            this.M_05.Tag = "50";
            this.M_05.Text = "McSpaghett - ₱50";
            this.M_05.UseVisualStyleBackColor = true;
            // 
            // M_04
            // 
            this.M_04.AutoSize = true;
            this.M_04.Location = new System.Drawing.Point(27, 133);
            this.M_04.Name = "M_04";
            this.M_04.Size = new System.Drawing.Size(89, 17);
            this.M_04.TabIndex = 3;
            this.M_04.Tag = "40";
            this.M_04.Text = "Hatdog - ₱40";
            this.M_04.UseVisualStyleBackColor = true;
            // 
            // M_03
            // 
            this.M_03.AutoSize = true;
            this.M_03.Location = new System.Drawing.Point(27, 100);
            this.M_03.Name = "M_03";
            this.M_03.Size = new System.Drawing.Size(123, 17);
            this.M_03.TabIndex = 2;
            this.M_03.Tag = "45";
            this.M_03.Text = "Sandwich Egg - ₱45";
            this.M_03.UseVisualStyleBackColor = true;
            // 
            // M_02
            // 
            this.M_02.AutoSize = true;
            this.M_02.Location = new System.Drawing.Point(27, 67);
            this.M_02.Name = "M_02";
            this.M_02.Size = new System.Drawing.Size(120, 17);
            this.M_02.TabIndex = 1;
            this.M_02.Tag = "45";
            this.M_02.Text = "Beesechurger - ₱45";
            this.M_02.UseVisualStyleBackColor = true;
            // 
            // M_01
            // 
            this.M_01.AutoSize = true;
            this.M_01.Location = new System.Drawing.Point(27, 34);
            this.M_01.Name = "M_01";
            this.M_01.Size = new System.Drawing.Size(85, 17);
            this.M_01.TabIndex = 0;
            this.M_01.Tag = "45";
            this.M_01.Text = "Burger - ₱45";
            this.M_01.UseVisualStyleBackColor = true;
            // 
            // bt_Buy
            // 
            this.bt_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_Buy.Location = new System.Drawing.Point(801, 221);
            this.bt_Buy.Name = "bt_Buy";
            this.bt_Buy.Size = new System.Drawing.Size(131, 47);
            this.bt_Buy.TabIndex = 10;
            this.bt_Buy.Text = "Buy";
            this.bt_Buy.UseVisualStyleBackColor = true;
            this.bt_Buy.Click += new System.EventHandler(this.bt_Buy_Click);
            // 
            // lb_Subtotal
            // 
            this.lb_Subtotal.AutoSize = true;
            this.lb_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Subtotal.Location = new System.Drawing.Point(57, 302);
            this.lb_Subtotal.Name = "lb_Subtotal";
            this.lb_Subtotal.Size = new System.Drawing.Size(69, 20);
            this.lb_Subtotal.TabIndex = 11;
            this.lb_Subtotal.Text = "Subtotal";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Total.Location = new System.Drawing.Point(475, 302);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(44, 20);
            this.lb_Total.TabIndex = 12;
            this.lb_Total.Text = "Total";
            // 
            // num_Rice
            // 
            this.num_Rice.Location = new System.Drawing.Point(171, 237);
            this.num_Rice.Name = "num_Rice";
            this.num_Rice.Size = new System.Drawing.Size(43, 20);
            this.num_Rice.TabIndex = 13;
            // 
            // lb_Rice
            // 
            this.lb_Rice.AutoSize = true;
            this.lb_Rice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_Rice.Location = new System.Drawing.Point(70, 237);
            this.lb_Rice.Name = "lb_Rice";
            this.lb_Rice.Size = new System.Drawing.Size(95, 15);
            this.lb_Rice.TabIndex = 14;
            this.lb_Rice.Tag = "15";
            this.lb_Rice.Text = "Extra Rice - ₱15";
            // 
            // lb_Gravy
            // 
            this.lb_Gravy.AutoSize = true;
            this.lb_Gravy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_Gravy.Location = new System.Drawing.Point(259, 237);
            this.lb_Gravy.Name = "lb_Gravy";
            this.lb_Gravy.Size = new System.Drawing.Size(100, 15);
            this.lb_Gravy.TabIndex = 16;
            this.lb_Gravy.Tag = "10";
            this.lb_Gravy.Text = "Extra Gravy - ₱10";
            // 
            // num_Gravy
            // 
            this.num_Gravy.Location = new System.Drawing.Point(365, 237);
            this.num_Gravy.Name = "num_Gravy";
            this.num_Gravy.Size = new System.Drawing.Size(43, 20);
            this.num_Gravy.TabIndex = 15;
            // 
            // lb_Ketchup
            // 
            this.lb_Ketchup.AutoSize = true;
            this.lb_Ketchup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_Ketchup.Location = new System.Drawing.Point(456, 237);
            this.lb_Ketchup.Name = "lb_Ketchup";
            this.lb_Ketchup.Size = new System.Drawing.Size(115, 15);
            this.lb_Ketchup.TabIndex = 18;
            this.lb_Ketchup.Tag = "10";
            this.lb_Ketchup.Text = "Extra Ketchup - ₱10";
            // 
            // num_Ketchup
            // 
            this.num_Ketchup.Location = new System.Drawing.Point(577, 237);
            this.num_Ketchup.Name = "num_Ketchup";
            this.num_Ketchup.Size = new System.Drawing.Size(43, 20);
            this.num_Ketchup.TabIndex = 17;
            // 
            // tb_Subtotal
            // 
            this.tb_Subtotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_Subtotal.Enabled = false;
            this.tb_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_Subtotal.Location = new System.Drawing.Point(132, 300);
            this.tb_Subtotal.Name = "tb_Subtotal";
            this.tb_Subtotal.Size = new System.Drawing.Size(80, 24);
            this.tb_Subtotal.TabIndex = 19;
            this.tb_Subtotal.Text = "0.00";
            // 
            // tb_Total
            // 
            this.tb_Total.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_Total.Enabled = false;
            this.tb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_Total.Location = new System.Drawing.Point(525, 300);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(80, 24);
            this.tb_Total.TabIndex = 20;
            this.tb_Total.Text = "0.00";
            // 
            // tb_Discount
            // 
            this.tb_Discount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_Discount.Enabled = false;
            this.tb_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_Discount.Location = new System.Drawing.Point(338, 300);
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(80, 24);
            this.tb_Discount.TabIndex = 22;
            this.tb_Discount.Text = "0.00";
            // 
            // lb_Discount
            // 
            this.lb_Discount.AutoSize = true;
            this.lb_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Discount.Location = new System.Drawing.Point(263, 302);
            this.lb_Discount.Name = "lb_Discount";
            this.lb_Discount.Size = new System.Drawing.Size(72, 20);
            this.lb_Discount.TabIndex = 21;
            this.lb_Discount.Text = "Discount";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.tb_Discount);
            this.Controls.Add(this.lb_Discount);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.tb_Subtotal);
            this.Controls.Add(this.lb_Ketchup);
            this.Controls.Add(this.num_Ketchup);
            this.Controls.Add(this.lb_Gravy);
            this.Controls.Add(this.num_Gravy);
            this.Controls.Add(this.lb_Rice);
            this.Controls.Add(this.num_Rice);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.lb_Subtotal);
            this.Controls.Add(this.bt_Buy);
            this.Controls.Add(this.gb_Menu);
            this.Controls.Add(this.gb_Discount);
            this.Name = "Main";
            this.Text = "Jed\'s Restaurant";
            this.gb_Discount.ResumeLayout(false);
            this.gb_Discount.PerformLayout();
            this.gb_Menu.ResumeLayout(false);
            this.gb_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Rice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Gravy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Ketchup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd_Student;
        private System.Windows.Forms.RadioButton rd_Senior;
        private System.Windows.Forms.RadioButton rd_PWD;
        private System.Windows.Forms.RadioButton rd_Regular;
        private System.Windows.Forms.GroupBox gb_Discount;
        private System.Windows.Forms.GroupBox gb_Menu;
        private System.Windows.Forms.CheckBox M_20;
        private System.Windows.Forms.CheckBox M_19;
        private System.Windows.Forms.CheckBox M_18;
        private System.Windows.Forms.CheckBox M_16;
        private System.Windows.Forms.CheckBox M_15;
        private System.Windows.Forms.CheckBox M_14;
        private System.Windows.Forms.CheckBox M_12;
        private System.Windows.Forms.CheckBox M_11;
        private System.Windows.Forms.CheckBox M_10;
        private System.Windows.Forms.CheckBox M_17;
        private System.Windows.Forms.CheckBox M_13;
        private System.Windows.Forms.CheckBox M_09;
        private System.Windows.Forms.CheckBox M_08;
        private System.Windows.Forms.CheckBox M_07;
        private System.Windows.Forms.CheckBox M_06;
        private System.Windows.Forms.CheckBox M_05;
        private System.Windows.Forms.CheckBox M_04;
        private System.Windows.Forms.CheckBox M_03;
        private System.Windows.Forms.CheckBox M_02;
        private System.Windows.Forms.CheckBox M_01;
        private System.Windows.Forms.Button bt_Buy;
        private System.Windows.Forms.Label lb_Subtotal;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.NumericUpDown num_Rice;
        private System.Windows.Forms.Label lb_Rice;
        private System.Windows.Forms.Label lb_Gravy;
        private System.Windows.Forms.NumericUpDown num_Gravy;
        private System.Windows.Forms.Label lb_Ketchup;
        private System.Windows.Forms.NumericUpDown num_Ketchup;
        private System.Windows.Forms.TextBox tb_Subtotal;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.Label lb_Discount;
    }
}

