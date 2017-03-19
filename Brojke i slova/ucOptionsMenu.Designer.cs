namespace Brojke_i_slova
{
    partial class ucOptionsMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBack = new System.Windows.Forms.Button();
            this.numNumTimer = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.listOperators = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numLarge = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numSmall = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPlayerName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.numRounds = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numLetTimer = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numVowels = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numConsonants = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLetTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVowels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConsonants)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnBack);
            this.splitContainer1.Panel1.Controls.Add(this.numNumTimer);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.listOperators);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.numLarge);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.numSmall);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textPlayerName);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.numRounds);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.numLetTimer);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.numVowels);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.numConsonants);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(733, 600);
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(115, 535);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Natrag";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numNumTimer
            // 
            this.numNumTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numNumTimer.Location = new System.Drawing.Point(202, 457);
            this.numNumTimer.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numNumTimer.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numNumTimer.Name = "numNumTimer";
            this.numNumTimer.Size = new System.Drawing.Size(120, 20);
            this.numNumTimer.TabIndex = 8;
            this.numNumTimer.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(22, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Trajanje runde (sek)";
            // 
            // listOperators
            // 
            this.listOperators.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listOperators.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listOperators.FormattingEnabled = true;
            this.listOperators.Items.AddRange(new object[] {
            "Zbrajanje (+)",
            "Oduzimanje (-)",
            "Množenje (*)",
            "Dijeljenje (/)",
            "Potenciranje (^)"});
            this.listOperators.Location = new System.Drawing.Point(26, 301);
            this.listOperators.Name = "listOperators";
            this.listOperators.Size = new System.Drawing.Size(173, 109);
            this.listOperators.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(22, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Koje operatore želite";
            // 
            // numLarge
            // 
            this.numLarge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numLarge.Location = new System.Drawing.Point(202, 186);
            this.numLarge.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numLarge.Name = "numLarge";
            this.numLarge.Size = new System.Drawing.Size(120, 20);
            this.numLarge.TabIndex = 4;
            this.numLarge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(22, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Koliko velikih brojeva";
            // 
            // numSmall
            // 
            this.numSmall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSmall.Location = new System.Drawing.Point(202, 142);
            this.numSmall.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numSmall.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSmall.Name = "numSmall";
            this.numSmall.Size = new System.Drawing.Size(120, 20);
            this.numSmall.TabIndex = 2;
            this.numSmall.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Koliko malih brojeva";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(166, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brojke";
            // 
            // textPlayerName
            // 
            this.textPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPlayerName.Location = new System.Drawing.Point(202, 411);
            this.textPlayerName.Name = "textPlayerName";
            this.textPlayerName.Size = new System.Drawing.Size(120, 20);
            this.textPlayerName.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(22, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ime igrača";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(169, 535);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Spremi postavke";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // numRounds
            // 
            this.numRounds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numRounds.Location = new System.Drawing.Point(202, 457);
            this.numRounds.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numRounds.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRounds.Name = "numRounds";
            this.numRounds.Size = new System.Drawing.Size(120, 20);
            this.numRounds.TabIndex = 12;
            this.numRounds.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(22, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Broj rundi (za obje igre)";
            // 
            // numLetTimer
            // 
            this.numLetTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numLetTimer.Location = new System.Drawing.Point(202, 260);
            this.numLetTimer.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numLetTimer.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numLetTimer.Name = "numLetTimer";
            this.numLetTimer.Size = new System.Drawing.Size(120, 20);
            this.numLetTimer.TabIndex = 10;
            this.numLetTimer.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(22, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Trajanje runde (sek)";
            // 
            // numVowels
            // 
            this.numVowels.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numVowels.Location = new System.Drawing.Point(202, 190);
            this.numVowels.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numVowels.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numVowels.Name = "numVowels";
            this.numVowels.Size = new System.Drawing.Size(120, 20);
            this.numVowels.TabIndex = 6;
            this.numVowels.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numVowels.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(22, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Koliko samoglasnika";
            // 
            // numConsonants
            // 
            this.numConsonants.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numConsonants.Location = new System.Drawing.Point(202, 145);
            this.numConsonants.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numConsonants.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numConsonants.Name = "numConsonants";
            this.numConsonants.Size = new System.Drawing.Size(120, 20);
            this.numConsonants.TabIndex = 4;
            this.numConsonants.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(22, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Koliko suglasnika";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(164, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Slova";
            // 
            // ucOptionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Enabled = false;
            this.Name = "ucOptionsMenu";
            this.Size = new System.Drawing.Size(733, 600);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNumTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLetTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVowels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConsonants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox listOperators;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numLarge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSmall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numNumTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numConsonants;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numVowels;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numRounds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numLetTimer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textPlayerName;
        private System.Windows.Forms.Label label11;
    }
}
