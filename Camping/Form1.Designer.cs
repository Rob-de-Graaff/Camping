namespace Camping
{
    partial class Form1
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
            this.panelLayout = new System.Windows.Forms.Panel();
            this.checkBoxCar = new System.Windows.Forms.CheckBox();
            this.labelCar = new System.Windows.Forms.Label();
            this.numericUpDownPersons = new System.Windows.Forms.NumericUpDown();
            this.labelPersons = new System.Windows.Forms.Label();
            this.checkBoxDog = new System.Windows.Forms.CheckBox();
            this.labelDog = new System.Windows.Forms.Label();
            this.numericUpDownLegth = new System.Windows.Forms.NumericUpDown();
            this.labelLength = new System.Windows.Forms.Label();
            this.panelPrices = new System.Windows.Forms.Panel();
            this.labelPrice1 = new System.Windows.Forms.Label();
            this.panelSubscriptions = new System.Windows.Forms.Panel();
            this.labelSubscription1 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTicketsTotal = new System.Windows.Forms.Label();
            this.labelPriceTotal = new System.Windows.Forms.Label();
            this.panelMonth = new System.Windows.Forms.Panel();
            this.numericUpDownMonth1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMonth2 = new System.Windows.Forms.NumericUpDown();
            this.panelDay = new System.Windows.Forms.Panel();
            this.numericUpDownDay1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDay2 = new System.Windows.Forms.NumericUpDown();
            this.panelYear = new System.Windows.Forms.Panel();
            this.numericUpDownYear1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYear2 = new System.Windows.Forms.NumericUpDown();
            this.panelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLegth)).BeginInit();
            this.panelPrices.SuspendLayout();
            this.panelSubscriptions.SuspendLayout();
            this.panelMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth2)).BeginInit();
            this.panelDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay2)).BeginInit();
            this.panelYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLayout
            // 
            this.panelLayout.Controls.Add(this.panelMonth);
            this.panelLayout.Controls.Add(this.panelDay);
            this.panelLayout.Controls.Add(this.panelYear);
            this.panelLayout.Controls.Add(this.checkBoxCar);
            this.panelLayout.Controls.Add(this.labelCar);
            this.panelLayout.Controls.Add(this.numericUpDownPersons);
            this.panelLayout.Controls.Add(this.labelPersons);
            this.panelLayout.Controls.Add(this.checkBoxDog);
            this.panelLayout.Controls.Add(this.labelDog);
            this.panelLayout.Controls.Add(this.numericUpDownLegth);
            this.panelLayout.Controls.Add(this.labelLength);
            this.panelLayout.Controls.Add(this.panelPrices);
            this.panelLayout.Controls.Add(this.panelSubscriptions);
            this.panelLayout.Controls.Add(this.buttonCalculate);
            this.panelLayout.Controls.Add(this.labelTicketsTotal);
            this.panelLayout.Controls.Add(this.labelPriceTotal);
            this.panelLayout.Location = new System.Drawing.Point(12, 12);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(776, 209);
            this.panelLayout.TabIndex = 28;
            // 
            // checkBoxCar
            // 
            this.checkBoxCar.AutoSize = true;
            this.checkBoxCar.Location = new System.Drawing.Point(139, 110);
            this.checkBoxCar.Name = "checkBoxCar";
            this.checkBoxCar.Size = new System.Drawing.Size(18, 17);
            this.checkBoxCar.TabIndex = 62;
            this.checkBoxCar.UseVisualStyleBackColor = true;
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Location = new System.Drawing.Point(7, 110);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(45, 17);
            this.labelCar.TabIndex = 61;
            this.labelCar.Text = "Auto :";
            // 
            // numericUpDownPersons
            // 
            this.numericUpDownPersons.Location = new System.Drawing.Point(140, 59);
            this.numericUpDownPersons.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPersons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPersons.Name = "numericUpDownPersons";
            this.numericUpDownPersons.ReadOnly = true;
            this.numericUpDownPersons.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownPersons.TabIndex = 60;
            this.numericUpDownPersons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPersons
            // 
            this.labelPersons.AutoSize = true;
            this.labelPersons.Location = new System.Drawing.Point(7, 61);
            this.labelPersons.Name = "labelPersons";
            this.labelPersons.Size = new System.Drawing.Size(120, 17);
            this.labelPersons.TabIndex = 59;
            this.labelPersons.Text = "Aantal personen :";
            // 
            // checkBoxDog
            // 
            this.checkBoxDog.AutoSize = true;
            this.checkBoxDog.Location = new System.Drawing.Point(139, 87);
            this.checkBoxDog.Name = "checkBoxDog";
            this.checkBoxDog.Size = new System.Drawing.Size(18, 17);
            this.checkBoxDog.TabIndex = 58;
            this.checkBoxDog.UseVisualStyleBackColor = true;
            // 
            // labelDog
            // 
            this.labelDog.AutoSize = true;
            this.labelDog.Location = new System.Drawing.Point(7, 87);
            this.labelDog.Name = "labelDog";
            this.labelDog.Size = new System.Drawing.Size(50, 17);
            this.labelDog.TabIndex = 58;
            this.labelDog.Text = "Hond :";
            // 
            // numericUpDownLegth
            // 
            this.numericUpDownLegth.Location = new System.Drawing.Point(140, 31);
            this.numericUpDownLegth.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownLegth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownLegth.Name = "numericUpDownLegth";
            this.numericUpDownLegth.ReadOnly = true;
            this.numericUpDownLegth.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownLegth.TabIndex = 57;
            this.numericUpDownLegth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(7, 33);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(60, 17);
            this.labelLength.TabIndex = 56;
            this.labelLength.Text = "Lengte :";
            // 
            // panelPrices
            // 
            this.panelPrices.Controls.Add(this.labelPrice1);
            this.panelPrices.Location = new System.Drawing.Point(140, 4);
            this.panelPrices.Name = "panelPrices";
            this.panelPrices.Size = new System.Drawing.Size(633, 21);
            this.panelPrices.TabIndex = 53;
            // 
            // labelPrice1
            // 
            this.labelPrice1.AutoSize = true;
            this.labelPrice1.Location = new System.Drawing.Point(4, 3);
            this.labelPrice1.Name = "labelPrice1";
            this.labelPrice1.Size = new System.Drawing.Size(13, 17);
            this.labelPrice1.TabIndex = 6;
            this.labelPrice1.Text = "-";
            // 
            // panelSubscriptions
            // 
            this.panelSubscriptions.Controls.Add(this.labelSubscription1);
            this.panelSubscriptions.Location = new System.Drawing.Point(3, 3);
            this.panelSubscriptions.Name = "panelSubscriptions";
            this.panelSubscriptions.Size = new System.Drawing.Size(131, 22);
            this.panelSubscriptions.TabIndex = 52;
            // 
            // labelSubscription1
            // 
            this.labelSubscription1.AutoSize = true;
            this.labelSubscription1.Location = new System.Drawing.Point(4, 4);
            this.labelSubscription1.Name = "labelSubscription1";
            this.labelSubscription1.Size = new System.Drawing.Size(13, 17);
            this.labelSubscription1.TabIndex = 6;
            this.labelSubscription1.Text = "-";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(462, 172);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(89, 33);
            this.buttonCalculate.TabIndex = 23;
            this.buttonCalculate.Text = "show price";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelTicketsTotal
            // 
            this.labelTicketsTotal.AutoSize = true;
            this.labelTicketsTotal.Location = new System.Drawing.Point(3, 155);
            this.labelTicketsTotal.Name = "labelTicketsTotal";
            this.labelTicketsTotal.Size = new System.Drawing.Size(13, 17);
            this.labelTicketsTotal.TabIndex = 22;
            this.labelTicketsTotal.Text = "-";
            // 
            // labelPriceTotal
            // 
            this.labelPriceTotal.AutoSize = true;
            this.labelPriceTotal.Location = new System.Drawing.Point(3, 172);
            this.labelPriceTotal.Name = "labelPriceTotal";
            this.labelPriceTotal.Size = new System.Drawing.Size(13, 17);
            this.labelPriceTotal.TabIndex = 21;
            this.labelPriceTotal.Text = "-";
            // 
            // panelMonth
            // 
            this.panelMonth.Controls.Add(this.numericUpDownMonth1);
            this.panelMonth.Controls.Add(this.numericUpDownMonth2);
            this.panelMonth.Location = new System.Drawing.Point(410, 34);
            this.panelMonth.Name = "panelMonth";
            this.panelMonth.Size = new System.Drawing.Size(47, 56);
            this.panelMonth.TabIndex = 64;
            // 
            // numericUpDownMonth1
            // 
            this.numericUpDownMonth1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownMonth1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth1.Name = "numericUpDownMonth1";
            this.numericUpDownMonth1.ReadOnly = true;
            this.numericUpDownMonth1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownMonth1.TabIndex = 25;
            this.numericUpDownMonth1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMonth2
            // 
            this.numericUpDownMonth2.Location = new System.Drawing.Point(0, 31);
            this.numericUpDownMonth2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth2.Name = "numericUpDownMonth2";
            this.numericUpDownMonth2.ReadOnly = true;
            this.numericUpDownMonth2.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownMonth2.TabIndex = 28;
            this.numericUpDownMonth2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelDay
            // 
            this.panelDay.Controls.Add(this.numericUpDownDay1);
            this.panelDay.Controls.Add(this.numericUpDownDay2);
            this.panelDay.Location = new System.Drawing.Point(335, 34);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(47, 56);
            this.panelDay.TabIndex = 65;
            // 
            // numericUpDownDay1
            // 
            this.numericUpDownDay1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownDay1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay1.Name = "numericUpDownDay1";
            this.numericUpDownDay1.ReadOnly = true;
            this.numericUpDownDay1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownDay1.TabIndex = 26;
            this.numericUpDownDay1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDay2
            // 
            this.numericUpDownDay2.Location = new System.Drawing.Point(0, 31);
            this.numericUpDownDay2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay2.Name = "numericUpDownDay2";
            this.numericUpDownDay2.ReadOnly = true;
            this.numericUpDownDay2.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownDay2.TabIndex = 29;
            this.numericUpDownDay2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelYear
            // 
            this.panelYear.Controls.Add(this.numericUpDownYear1);
            this.panelYear.Controls.Add(this.numericUpDownYear2);
            this.panelYear.Location = new System.Drawing.Point(484, 33);
            this.panelYear.Name = "panelYear";
            this.panelYear.Size = new System.Drawing.Size(67, 57);
            this.panelYear.TabIndex = 63;
            // 
            // numericUpDownYear1
            // 
            this.numericUpDownYear1.Location = new System.Drawing.Point(1, 1);
            this.numericUpDownYear1.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericUpDownYear1.Minimum = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            this.numericUpDownYear1.Name = "numericUpDownYear1";
            this.numericUpDownYear1.ReadOnly = true;
            this.numericUpDownYear1.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownYear1.TabIndex = 24;
            this.numericUpDownYear1.Value = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            // 
            // numericUpDownYear2
            // 
            this.numericUpDownYear2.Location = new System.Drawing.Point(1, 32);
            this.numericUpDownYear2.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericUpDownYear2.Minimum = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            this.numericUpDownYear2.Name = "numericUpDownYear2";
            this.numericUpDownYear2.ReadOnly = true;
            this.numericUpDownYear2.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownYear2.TabIndex = 27;
            this.numericUpDownYear2.Value = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLayout.ResumeLayout(false);
            this.panelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLegth)).EndInit();
            this.panelPrices.ResumeLayout(false);
            this.panelPrices.PerformLayout();
            this.panelSubscriptions.ResumeLayout(false);
            this.panelSubscriptions.PerformLayout();
            this.panelMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth2)).EndInit();
            this.panelDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay2)).EndInit();
            this.panelYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLayout;
        private System.Windows.Forms.Label labelDog;
        private System.Windows.Forms.NumericUpDown numericUpDownLegth;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Panel panelPrices;
        private System.Windows.Forms.Label labelPrice1;
        private System.Windows.Forms.Panel panelSubscriptions;
        private System.Windows.Forms.Label labelSubscription1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTicketsTotal;
        private System.Windows.Forms.Label labelPriceTotal;
        private System.Windows.Forms.NumericUpDown numericUpDownPersons;
        private System.Windows.Forms.Label labelPersons;
        private System.Windows.Forms.CheckBox checkBoxDog;
        private System.Windows.Forms.CheckBox checkBoxCar;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.Panel panelMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth1;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth2;
        private System.Windows.Forms.Panel panelDay;
        private System.Windows.Forms.NumericUpDown numericUpDownDay1;
        private System.Windows.Forms.NumericUpDown numericUpDownDay2;
        private System.Windows.Forms.Panel panelYear;
        private System.Windows.Forms.NumericUpDown numericUpDownYear1;
        private System.Windows.Forms.NumericUpDown numericUpDownYear2;
    }
}

