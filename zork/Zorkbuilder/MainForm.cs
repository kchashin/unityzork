using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Linq;
using Newtonsoft.Json;
using zork.builder;
using Zorkbuilder;
using zork.common;



namespace Zorkbuilder
{
    public partial class MainForm : Form
    {
        private ZorkViewModel zViewModel;
        //private bool zIsWorldLoaded;

        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        private ZorkViewModel ViewModel
        {
            get => zViewModel;
            set
            {
                if(zViewModel != value)
                {
                    zViewModel = value;
                    zorkViewModelBindingSource.DataSource = zViewModel;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new ZorkViewModel();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void WorldInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about to = new about();
            to.Show();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openJSON.ShowDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = Game.Load(openFileDialog.FileName);
                ViewModel.Filename = openFileDialog.FileName;                
            }
        }
        /*private void LaunchZorkConsoleToolStripmenuItem_Click(object sender, EventArgs e)
         {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                
             }
             Process.Start*/


        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveJSON.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveJSON.FileName;
                ViewModel.SaveWorld();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => ViewModel.SaveWorld();


        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void zorkViewModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Rooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RoomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WestN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Namew_Click(object sender, EventArgs e)
        {

        }

        private void NorthN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Room_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void West_Click(object sender, EventArgs e)
        {

        }

        private void Neighbors_Click(object sender, EventArgs e)
        {

        }

        private void EastN_TextChanged(object sender, EventArgs e)
        {

        }

        private void South_Click(object sender, EventArgs e)
        {

        }

        private void SouthN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void Descriptionw_Click(object sender, EventArgs e)
        {

        }

        private void North_Click(object sender, EventArgs e)
        {

        }

        private void East_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
