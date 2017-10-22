using EldritchHorrorHelper.InvestigatorCards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace EldritchHorrorHelper
{
    public partial class OpeningWindow : Form
    {
        public static OpeningWindow INSTANCE;
        public static CardCollection COLLECTION;

        public OpeningWindow()
        {
            InitializeComponent();
            INSTANCE = this;
        }

        private void StartNewBtn_Click(object sender, EventArgs e)
        {
            string masterCardFile = "master.cards";
            COLLECTION = CardCollection.Load(masterCardFile);

            foreach (int i in ExpansionsChecklists.CheckedIndices)
            {
                Expansion exp = (Expansion)(i + 1);
                COLLECTION.ExpansionsInUse.Add(exp);
            }

            MoveToMain();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            using (Stream s = openFileDialog.OpenFile())
            {
                COLLECTION = CardCollection.Load(s);
            }

            MoveToMain();
        }

        /// <summary>
        /// Moves to the main menu.
        /// </summary>
        private void MoveToMain()
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
