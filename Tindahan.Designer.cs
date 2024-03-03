namespace Activity2
{
    partial class F_Main
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
            this.RD_Student = new System.Windows.Forms.RadioButton();
            this.RD_Senior = new System.Windows.Forms.RadioButton();
            this.RD_PWD = new System.Windows.Forms.RadioButton();
            this.RD_Regular = new System.Windows.Forms.RadioButton();
            this.GB_Discount = new System.Windows.Forms.GroupBox();
            this.GB_Menu = new System.Windows.Forms.GroupBox();
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
            this.BT_Buy = new System.Windows.Forms.Button();
            this.LB_Subtotal = new System.Windows.Forms.Label();
            this.LB_Total = new System.Windows.Forms.Label();
            this.NM_Rice = new System.Windows.Forms.NumericUpDown();
            this.LB_Rice = new System.Windows.Forms.Label();
            this.LB_Gravy = new System.Windows.Forms.Label();
            this.NM_Gravy = new System.Windows.Forms.NumericUpDown();
            this.LB_Ketchup = new System.Windows.Forms.Label();
            this.NM_Ketchup = new System.Windows.Forms.NumericUpDown();
            this.TB_Subtotal = new System.Windows.Forms.TextBox();
            this.TB_Total = new System.Windows.Forms.TextBox();
            this.TB_Discount = new System.Windows.Forms.TextBox();
            this.LB_Discount = new System.Windows.Forms.Label();
            this.GB_Discount.SuspendLayout();
            this.GB_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NM_Rice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_Gravy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_Ketchup)).BeginInit();
            this.SuspendLayout();
            // 
            // RD_Student
            // 
            this.RD_Student.AutoSize = true;
            this.RD_Student.Location = new System.Drawing.Point(23, 34);
            this.RD_Student.Name = "RD_Student";
            this.RD_Student.Size = new System.Drawing.Size(91, 17);
            this.RD_Student.TabIndex = 4;
            this.RD_Student.TabStop = true;
            this.RD_Student.Tag = "10";
            this.RD_Student.Text = "Student - 10%";
            this.RD_Student.UseVisualStyleBackColor = true;
            // 
            // RD_Senior
            // 
            this.RD_Senior.AutoSize = true;
            this.RD_Senior.Location = new System.Drawing.Point(23, 67);
            this.RD_Senior.Name = "RD_Senior";
            this.RD_Senior.Size = new System.Drawing.Size(84, 17);
            this.RD_Senior.TabIndex = 5;
            this.RD_Senior.TabStop = true;
            this.RD_Senior.Tag = "20";
            this.RD_Senior.Text = "Senior - 20%";
            this.RD_Senior.UseVisualStyleBackColor = true;
            // 
            // RD_PWD
            // 
            this.RD_PWD.AutoSize = true;
            this.RD_PWD.Location = new System.Drawing.Point(23, 100);
            this.RD_PWD.Name = "RD_PWD";
            this.RD_PWD.Size = new System.Drawing.Size(80, 17);
            this.RD_PWD.TabIndex = 6;
            this.RD_PWD.TabStop = true;
            this.RD_PWD.Tag = "20";
            this.RD_PWD.Text = "PWD - 20%";
            this.RD_PWD.UseVisualStyleBackColor = true;
            // 
            // RD_Regular
            // 
            this.RD_Regular.AutoSize = true;
            this.RD_Regular.Location = new System.Drawing.Point(23, 133);
            this.RD_Regular.Name = "RD_Regular";
            this.RD_Regular.Size = new System.Drawing.Size(85, 17);
            this.RD_Regular.TabIndex = 7;
            this.RD_Regular.TabStop = true;
            this.RD_Regular.Tag = "0";
            this.RD_Regular.Text = "Regular - 0%";
            this.RD_Regular.UseVisualStyleBackColor = true;
            // 
            // GB_Discount
            // 
            this.GB_Discount.Controls.Add(this.RD_Regular);
            this.GB_Discount.Controls.Add(this.RD_PWD);
            this.GB_Discount.Controls.Add(this.RD_Senior);
            this.GB_Discount.Controls.Add(this.RD_Student);
            this.GB_Discount.Location = new System.Drawing.Point(801, 42);
            this.GB_Discount.Name = "GB_Discount";
            this.GB_Discount.Size = new System.Drawing.Size(131, 173);
            this.GB_Discount.TabIndex = 8;
            this.GB_Discount.TabStop = false;
            this.GB_Discount.Text = "Discount";
            // 
            // GB_Menu
            // 
            this.GB_Menu.Controls.Add(this.M_20);
            this.GB_Menu.Controls.Add(this.M_19);
            this.GB_Menu.Controls.Add(this.M_18);
            this.GB_Menu.Controls.Add(this.M_16);
            this.GB_Menu.Controls.Add(this.M_15);
            this.GB_Menu.Controls.Add(this.M_14);
            this.GB_Menu.Controls.Add(this.M_12);
            this.GB_Menu.Controls.Add(this.M_11);
            this.GB_Menu.Controls.Add(this.M_10);
            this.GB_Menu.Controls.Add(this.M_17);
            this.GB_Menu.Controls.Add(this.M_13);
            this.GB_Menu.Controls.Add(this.M_09);
            this.GB_Menu.Controls.Add(this.M_08);
            this.GB_Menu.Controls.Add(this.M_07);
            this.GB_Menu.Controls.Add(this.M_06);
            this.GB_Menu.Controls.Add(this.M_05);
            this.GB_Menu.Controls.Add(this.M_04);
            this.GB_Menu.Controls.Add(this.M_03);
            this.GB_Menu.Controls.Add(this.M_02);
            this.GB_Menu.Controls.Add(this.M_01);
            this.GB_Menu.Location = new System.Drawing.Point(37, 42);
            this.GB_Menu.Name = "GB_Menu";
            this.GB_Menu.Size = new System.Drawing.Size(732, 172);
            this.GB_Menu.TabIndex = 9;
            this.GB_Menu.TabStop = false;
            this.GB_Menu.Text = "Menu";
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
            // BT_Buy
            // 
            this.BT_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BT_Buy.Location = new System.Drawing.Point(801, 221);
            this.BT_Buy.Name = "BT_Buy";
            this.BT_Buy.Size = new System.Drawing.Size(131, 47);
            this.BT_Buy.TabIndex = 10;
            this.BT_Buy.Text = "Buy";
            this.BT_Buy.UseVisualStyleBackColor = true;
            this.BT_Buy.Click += new System.EventHandler(this.BT_Buy_Click);
            // 
            // LB_Subtotal
            // 
            this.LB_Subtotal.AutoSize = true;
            this.LB_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LB_Subtotal.Location = new System.Drawing.Point(57, 302);
            this.LB_Subtotal.Name = "LB_Subtotal";
            this.LB_Subtotal.Size = new System.Drawing.Size(69, 20);
            this.LB_Subtotal.TabIndex = 11;
            this.LB_Subtotal.Text = "Subtotal";
            // 
            // LB_Total
            // 
            this.LB_Total.AutoSize = true;
            this.LB_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LB_Total.Location = new System.Drawing.Point(475, 302);
            this.LB_Total.Name = "LB_Total";
            this.LB_Total.Size = new System.Drawing.Size(44, 20);
            this.LB_Total.TabIndex = 12;
            this.LB_Total.Text = "Total";
            // 
            // NM_Rice
            // 
            this.NM_Rice.Location = new System.Drawing.Point(171, 237);
            this.NM_Rice.Name = "NM_Rice";
            this.NM_Rice.Size = new System.Drawing.Size(43, 20);
            this.NM_Rice.TabIndex = 13;
            // 
            // LB_Rice
            // 
            this.LB_Rice.AutoSize = true;
            this.LB_Rice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LB_Rice.Location = new System.Drawing.Point(70, 237);
            this.LB_Rice.Name = "LB_Rice";
            this.LB_Rice.Size = new System.Drawing.Size(95, 15);
            this.LB_Rice.TabIndex = 14;
            this.LB_Rice.Tag = "15";
            this.LB_Rice.Text = "Extra Rice - ₱15";
            // 
            // LB_Gravy
            // 
            this.LB_Gravy.AutoSize = true;
            this.LB_Gravy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LB_Gravy.Location = new System.Drawing.Point(259, 237);
            this.LB_Gravy.Name = "LB_Gravy";
            this.LB_Gravy.Size = new System.Drawing.Size(100, 15);
            this.LB_Gravy.TabIndex = 16;
            this.LB_Gravy.Tag = "10";
            this.LB_Gravy.Text = "Extra Gravy - ₱10";
            // 
            // NM_Gravy
            // 
            this.NM_Gravy.Location = new System.Drawing.Point(365, 237);
            this.NM_Gravy.Name = "NM_Gravy";
            this.NM_Gravy.Size = new System.Drawing.Size(43, 20);
            this.NM_Gravy.TabIndex = 15;
            // 
            // LB_Ketchup
            // 
            this.LB_Ketchup.AutoSize = true;
            this.LB_Ketchup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LB_Ketchup.Location = new System.Drawing.Point(456, 237);
            this.LB_Ketchup.Name = "LB_Ketchup";
            this.LB_Ketchup.Size = new System.Drawing.Size(115, 15);
            this.LB_Ketchup.TabIndex = 18;
            this.LB_Ketchup.Tag = "10";
            this.LB_Ketchup.Text = "Extra Ketchup - ₱10";
            // 
            // NM_Ketchup
            // 
            this.NM_Ketchup.Location = new System.Drawing.Point(577, 237);
            this.NM_Ketchup.Name = "NM_Ketchup";
            this.NM_Ketchup.Size = new System.Drawing.Size(43, 20);
            this.NM_Ketchup.TabIndex = 17;
            // 
            // TB_Subtotal
            // 
            this.TB_Subtotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TB_Subtotal.Enabled = false;
            this.TB_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TB_Subtotal.Location = new System.Drawing.Point(132, 300);
            this.TB_Subtotal.Name = "TB_Subtotal";
            this.TB_Subtotal.Size = new System.Drawing.Size(80, 24);
            this.TB_Subtotal.TabIndex = 19;
            this.TB_Subtotal.Text = "0.00";
            // 
            // TB_Total
            // 
            this.TB_Total.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TB_Total.Enabled = false;
            this.TB_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TB_Total.Location = new System.Drawing.Point(525, 300);
            this.TB_Total.Name = "TB_Total";
            this.TB_Total.Size = new System.Drawing.Size(80, 24);
            this.TB_Total.TabIndex = 20;
            this.TB_Total.Text = "0.00";
            // 
            // TB_Discount
            // 
            this.TB_Discount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TB_Discount.Enabled = false;
            this.TB_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TB_Discount.Location = new System.Drawing.Point(338, 300);
            this.TB_Discount.Name = "TB_Discount";
            this.TB_Discount.Size = new System.Drawing.Size(80, 24);
            this.TB_Discount.TabIndex = 22;
            this.TB_Discount.Text = "0.00";
            // 
            // LB_Discount
            // 
            this.LB_Discount.AutoSize = true;
            this.LB_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LB_Discount.Location = new System.Drawing.Point(263, 302);
            this.LB_Discount.Name = "LB_Discount";
            this.LB_Discount.Size = new System.Drawing.Size(72, 20);
            this.LB_Discount.TabIndex = 21;
            this.LB_Discount.Text = "Discount";
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.TB_Discount);
            this.Controls.Add(this.LB_Discount);
            this.Controls.Add(this.TB_Total);
            this.Controls.Add(this.TB_Subtotal);
            this.Controls.Add(this.LB_Ketchup);
            this.Controls.Add(this.NM_Ketchup);
            this.Controls.Add(this.LB_Gravy);
            this.Controls.Add(this.NM_Gravy);
            this.Controls.Add(this.LB_Rice);
            this.Controls.Add(this.NM_Rice);
            this.Controls.Add(this.LB_Total);
            this.Controls.Add(this.LB_Subtotal);
            this.Controls.Add(this.BT_Buy);
            this.Controls.Add(this.GB_Menu);
            this.Controls.Add(this.GB_Discount);
            this.Name = "F_Main";
            this.Text = "Jed\'s Restaurant";
            this.GB_Discount.ResumeLayout(false);
            this.GB_Discount.PerformLayout();
            this.GB_Menu.ResumeLayout(false);
            this.GB_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NM_Rice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_Gravy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_Ketchup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RD_Student;
        private System.Windows.Forms.RadioButton RD_Senior;
        private System.Windows.Forms.RadioButton RD_PWD;
        private System.Windows.Forms.RadioButton RD_Regular;
        private System.Windows.Forms.GroupBox GB_Discount;
        private System.Windows.Forms.GroupBox GB_Menu;
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
        private System.Windows.Forms.Button BT_Buy;
        private System.Windows.Forms.Label LB_Subtotal;
        private System.Windows.Forms.Label LB_Total;
        private System.Windows.Forms.NumericUpDown NM_Rice;
        private System.Windows.Forms.Label LB_Rice;
        private System.Windows.Forms.Label LB_Gravy;
        private System.Windows.Forms.NumericUpDown NM_Gravy;
        private System.Windows.Forms.Label LB_Ketchup;
        private System.Windows.Forms.NumericUpDown NM_Ketchup;
        private System.Windows.Forms.TextBox TB_Subtotal;
        private System.Windows.Forms.TextBox TB_Total;
        private System.Windows.Forms.TextBox TB_Discount;
        private System.Windows.Forms.Label LB_Discount;
    }
}

