namespace EldritchHorrorHelper
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
            this.components = new System.ComponentModel.Container();
            this.TabContainer = new System.Windows.Forms.TabControl();
            this.DrawPanel = new System.Windows.Forms.TabPage();
            this.KeepCardBtn = new System.Windows.Forms.Button();
            this.RedrawCardBtn = new System.Windows.Forms.Button();
            this.DrawCardBtn = new System.Windows.Forms.Button();
            this.CardDrawLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TraitsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CardTypeBox = new System.Windows.Forms.ComboBox();
            this.DiscardPanel = new System.Windows.Forms.TabPage();
            this.DiscardsDataGrid = new System.Windows.Forms.DataGridView();
            this.ShuffleDiscardsBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ShuffleSelectionBtn = new System.Windows.Forms.Button();
            this.TabContainer.SuspendLayout();
            this.DrawPanel.SuspendLayout();
            this.DiscardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscardsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TabContainer
            // 
            this.TabContainer.Controls.Add(this.DrawPanel);
            this.TabContainer.Controls.Add(this.DiscardPanel);
            this.TabContainer.Location = new System.Drawing.Point(12, 47);
            this.TabContainer.Name = "TabContainer";
            this.TabContainer.SelectedIndex = 0;
            this.TabContainer.Size = new System.Drawing.Size(557, 258);
            this.TabContainer.TabIndex = 0;
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.DrawPanel.Controls.Add(this.KeepCardBtn);
            this.DrawPanel.Controls.Add(this.RedrawCardBtn);
            this.DrawPanel.Controls.Add(this.DrawCardBtn);
            this.DrawPanel.Controls.Add(this.CardDrawLabel);
            this.DrawPanel.Controls.Add(this.CostTextBox);
            this.DrawPanel.Controls.Add(this.label3);
            this.DrawPanel.Controls.Add(this.TraitsTextBox);
            this.DrawPanel.Controls.Add(this.label2);
            this.DrawPanel.Controls.Add(this.label1);
            this.DrawPanel.Controls.Add(this.CardTypeBox);
            this.DrawPanel.Location = new System.Drawing.Point(4, 22);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Padding = new System.Windows.Forms.Padding(3);
            this.DrawPanel.Size = new System.Drawing.Size(549, 232);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Text = "Draw";
            // 
            // KeepCardBtn
            // 
            this.KeepCardBtn.Location = new System.Drawing.Point(368, 153);
            this.KeepCardBtn.Name = "KeepCardBtn";
            this.KeepCardBtn.Size = new System.Drawing.Size(173, 38);
            this.KeepCardBtn.TabIndex = 9;
            this.KeepCardBtn.Text = "Keep Card";
            this.KeepCardBtn.UseVisualStyleBackColor = true;
            this.KeepCardBtn.Click += new System.EventHandler(this.KeepCardBtn_Click);
            // 
            // RedrawCardBtn
            // 
            this.RedrawCardBtn.Location = new System.Drawing.Point(189, 153);
            this.RedrawCardBtn.Name = "RedrawCardBtn";
            this.RedrawCardBtn.Size = new System.Drawing.Size(173, 38);
            this.RedrawCardBtn.TabIndex = 8;
            this.RedrawCardBtn.Text = "Redraw Card";
            this.RedrawCardBtn.UseVisualStyleBackColor = true;
            this.RedrawCardBtn.Click += new System.EventHandler(this.RedrawCardBtn_Click);
            // 
            // DrawCardBtn
            // 
            this.DrawCardBtn.Location = new System.Drawing.Point(10, 153);
            this.DrawCardBtn.Name = "DrawCardBtn";
            this.DrawCardBtn.Size = new System.Drawing.Size(173, 38);
            this.DrawCardBtn.TabIndex = 7;
            this.DrawCardBtn.Text = "Draw New Card";
            this.DrawCardBtn.UseVisualStyleBackColor = true;
            this.DrawCardBtn.Click += new System.EventHandler(this.DrawCardBtn_Click);
            // 
            // CardDrawLabel
            // 
            this.CardDrawLabel.BackColor = System.Drawing.Color.LavenderBlush;
            this.CardDrawLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardDrawLabel.Location = new System.Drawing.Point(10, 80);
            this.CardDrawLabel.Name = "CardDrawLabel";
            this.CardDrawLabel.Size = new System.Drawing.Size(533, 69);
            this.CardDrawLabel.TabIndex = 6;
            this.CardDrawLabel.Text = "When you draw a card, the details will be displayed in this box.";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(329, 11);
            this.CostTextBox.MaxLength = 1;
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(20, 20);
            this.CostTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost:";
            // 
            // TraitsTextBox
            // 
            this.TraitsTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TraitsTextBox.Location = new System.Drawing.Point(72, 39);
            this.TraitsTextBox.MaxLength = 200;
            this.TraitsTextBox.Name = "TraitsTextBox";
            this.TraitsTextBox.Size = new System.Drawing.Size(213, 20);
            this.TraitsTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tags:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card Type:";
            // 
            // CardTypeBox
            // 
            this.CardTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CardTypeBox.FormattingEnabled = true;
            this.CardTypeBox.Location = new System.Drawing.Point(72, 11);
            this.CardTypeBox.Name = "CardTypeBox";
            this.CardTypeBox.Size = new System.Drawing.Size(213, 21);
            this.CardTypeBox.TabIndex = 0;
            // 
            // DiscardPanel
            // 
            this.DiscardPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.DiscardPanel.Controls.Add(this.ShuffleSelectionBtn);
            this.DiscardPanel.Controls.Add(this.DiscardsDataGrid);
            this.DiscardPanel.Controls.Add(this.ShuffleDiscardsBtn);
            this.DiscardPanel.Location = new System.Drawing.Point(4, 22);
            this.DiscardPanel.Name = "DiscardPanel";
            this.DiscardPanel.Padding = new System.Windows.Forms.Padding(3);
            this.DiscardPanel.Size = new System.Drawing.Size(549, 232);
            this.DiscardPanel.TabIndex = 1;
            this.DiscardPanel.Text = "Removed Cards";
            // 
            // DiscardsDataGrid
            // 
            this.DiscardsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiscardsDataGrid.Location = new System.Drawing.Point(7, 7);
            this.DiscardsDataGrid.Name = "DiscardsDataGrid";
            this.DiscardsDataGrid.Size = new System.Drawing.Size(536, 190);
            this.DiscardsDataGrid.TabIndex = 1;
            // 
            // ShuffleDiscardsBtn
            // 
            this.ShuffleDiscardsBtn.Location = new System.Drawing.Point(121, 203);
            this.ShuffleDiscardsBtn.Name = "ShuffleDiscardsBtn";
            this.ShuffleDiscardsBtn.Size = new System.Drawing.Size(145, 23);
            this.ShuffleDiscardsBtn.TabIndex = 0;
            this.ShuffleDiscardsBtn.Text = "Shuffle In Removed";
            this.ShuffleDiscardsBtn.UseVisualStyleBackColor = true;
            this.ShuffleDiscardsBtn.Click += new System.EventHandler(this.ShuffleDiscardsBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(16, 13);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(136, 28);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save...";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ShuffleSelectionBtn
            // 
            this.ShuffleSelectionBtn.Location = new System.Drawing.Point(272, 203);
            this.ShuffleSelectionBtn.Name = "ShuffleSelectionBtn";
            this.ShuffleSelectionBtn.Size = new System.Drawing.Size(145, 23);
            this.ShuffleSelectionBtn.TabIndex = 2;
            this.ShuffleSelectionBtn.Text = "Shuffle In Selected";
            this.ShuffleSelectionBtn.UseVisualStyleBackColor = true;
            this.ShuffleSelectionBtn.Click += new System.EventHandler(this.ShuffleSelectionBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 317);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TabContainer);
            this.Name = "Main";
            this.Text = "Eldritch Horror Helper";
            this.TabContainer.ResumeLayout(false);
            this.DrawPanel.ResumeLayout(false);
            this.DrawPanel.PerformLayout();
            this.DiscardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiscardsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabContainer;
        private System.Windows.Forms.TabPage DrawPanel;
        private System.Windows.Forms.TextBox TraitsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage DiscardPanel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RedrawCardBtn;
        private System.Windows.Forms.Button DrawCardBtn;
        private System.Windows.Forms.Label CardDrawLabel;
        private System.Windows.Forms.DataGridView DiscardsDataGrid;
        private System.Windows.Forms.Button ShuffleDiscardsBtn;
        private System.Windows.Forms.ComboBox CardTypeBox;
        private System.Windows.Forms.Button KeepCardBtn;
        private System.Windows.Forms.Button ShuffleSelectionBtn;
    }
}