namespace EldritchHorrorHelper
{
    partial class Debug
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
            this.CardDataGrid = new System.Windows.Forms.DataGridView();
            this.CollectionBtn = new System.Windows.Forms.Button();
            this.LoadMasterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CardDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CardDataGrid
            // 
            this.CardDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CardDataGrid.Location = new System.Drawing.Point(12, 60);
            this.CardDataGrid.Name = "CardDataGrid";
            this.CardDataGrid.Size = new System.Drawing.Size(854, 399);
            this.CardDataGrid.TabIndex = 0;
            // 
            // CollectionBtn
            // 
            this.CollectionBtn.Location = new System.Drawing.Point(13, 13);
            this.CollectionBtn.Name = "CollectionBtn";
            this.CollectionBtn.Size = new System.Drawing.Size(113, 41);
            this.CollectionBtn.TabIndex = 1;
            this.CollectionBtn.Text = "Make and Save Master Collection";
            this.CollectionBtn.UseVisualStyleBackColor = true;
            this.CollectionBtn.Click += new System.EventHandler(this.ArtifactsBtn_Click);
            // 
            // LoadMasterBtn
            // 
            this.LoadMasterBtn.Location = new System.Drawing.Point(132, 13);
            this.LoadMasterBtn.Name = "LoadMasterBtn";
            this.LoadMasterBtn.Size = new System.Drawing.Size(113, 41);
            this.LoadMasterBtn.TabIndex = 2;
            this.LoadMasterBtn.Text = "Load Master Collection";
            this.LoadMasterBtn.UseVisualStyleBackColor = true;
            this.LoadMasterBtn.Click += new System.EventHandler(this.LoadMasterBtn_Click);
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 471);
            this.Controls.Add(this.LoadMasterBtn);
            this.Controls.Add(this.CollectionBtn);
            this.Controls.Add(this.CardDataGrid);
            this.Name = "Debug";
            this.Text = "EHH - Debug";
            this.Load += new System.EventHandler(this.Debug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CardDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CardDataGrid;
        private System.Windows.Forms.Button CollectionBtn;
        private System.Windows.Forms.Button LoadMasterBtn;
    }
}

