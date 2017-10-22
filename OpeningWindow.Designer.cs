namespace EldritchHorrorHelper
{
    partial class OpeningWindow
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
            this.StartNewBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.ExpansionsChecklists = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartNewBtn
            // 
            this.StartNewBtn.Location = new System.Drawing.Point(13, 13);
            this.StartNewBtn.Name = "StartNewBtn";
            this.StartNewBtn.Size = new System.Drawing.Size(138, 36);
            this.StartNewBtn.TabIndex = 0;
            this.StartNewBtn.Text = "Start New Game";
            this.StartNewBtn.UseVisualStyleBackColor = true;
            this.StartNewBtn.Click += new System.EventHandler(this.StartNewBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(160, 13);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(138, 36);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "Load Game";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ExpansionsChecklists
            // 
            this.ExpansionsChecklists.FormattingEnabled = true;
            this.ExpansionsChecklists.Items.AddRange(new object[] {
            "Forsaken Lore",
            "Mountains of Madness",
            "Strange Remnants",
            "Under the Pyramids",
            "Signs of Carcosa",
            "The Dreamlands",
            "Cities in Ruin"});
            this.ExpansionsChecklists.Location = new System.Drawing.Point(13, 71);
            this.ExpansionsChecklists.Name = "ExpansionsChecklists";
            this.ExpansionsChecklists.Size = new System.Drawing.Size(285, 139);
            this.ExpansionsChecklists.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Expansions for a new game:";
            // 
            // OpeningWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExpansionsChecklists);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.StartNewBtn);
            this.Name = "OpeningWindow";
            this.Text = "Eldritch Horror Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartNewBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.CheckedListBox ExpansionsChecklists;
        private System.Windows.Forms.Label label1;
    }
}