namespace Brojke_i_slova
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mainMenu = new Brojke_i_slova.ucMainMenu();
            this.optionsMenu = new Brojke_i_slova.ucOptionsMenu();
            this.brojke = new Brojke_i_slova.ucIgraBrojke();
            this.slova = new Brojke_i_slova.ucIgraSlova();
            this.scores = new Brojke_i_slova.scores();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mainMenu
            // 
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(784, 561);
            this.mainMenu.TabIndex = 0;
            // 
            // optionsMenu
            // 
            this.optionsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsMenu.Enabled = false;
            this.optionsMenu.Location = new System.Drawing.Point(0, 0);
            this.optionsMenu.Name = "optionsMenu";
            this.optionsMenu.Size = new System.Drawing.Size(784, 561);
            this.optionsMenu.TabIndex = 1;
            this.optionsMenu.Visible = false;
            // 
            // brojke
            // 
            this.brojke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brojke.Enabled = false;
            this.brojke.Location = new System.Drawing.Point(0, 0);
            this.brojke.Name = "brojke";
            this.brojke.Size = new System.Drawing.Size(784, 561);
            this.brojke.TabIndex = 2;
            // 
            // slova
            // 
            this.slova.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slova.Location = new System.Drawing.Point(0, 0);
            this.slova.Name = "slova";
            this.slova.Size = new System.Drawing.Size(784, 561);
            this.slova.TabIndex = 3;
            // 
            // scores
            // 
            this.scores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scores.Enabled = false;
            this.scores.Location = new System.Drawing.Point(0, 0);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(784, 561);
            this.scores.TabIndex = 4;
            this.scores.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.optionsMenu);
            this.Controls.Add(this.brojke);
            this.Controls.Add(this.slova);
            this.Controls.Add(this.scores);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brojke i slova";
            this.ResumeLayout(false);

        }


        #endregion
        private ucOptionsMenu optionsMenu;
        private ucMainMenu mainMenu;
        private ucIgraBrojke brojke;
        private System.Windows.Forms.Timer timer;
        private ucIgraSlova slova;
        private scores scores;
    }
}