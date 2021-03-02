using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace MHWSaveManager
{
    public partial class Form1 : Form
    {
        Controller Cont;
        public Form1()
        {
            InitializeComponent();
            
        }

        public void SetController(Controller c)
        {
            Cont = c;
            CurrentSaveLabel.Text = Cont.GetSave();
        }

        public void ListSaves(List<string> SaveList)
        {
            SaveBox.Items.Clear();
            foreach(string Save in SaveList)
            {
                SaveBox.Items.Add(Save);
            }
        }

        public void MainLoaded(bool MainLoaded)
        {
            MainSaveButton.Enabled = !MainLoaded;
        }

        public void EnableButtons(bool WorldPathSet)
        {
            SetMainButton.Enabled = WorldPathSet;
            SaveCurrentSave.Enabled = WorldPathSet;
            LoadButton.Enabled = WorldPathSet;
            DeleteButton.Enabled = WorldPathSet;
            MainSaveButton.Enabled = WorldPathSet;
        }

        private void SetWorldPath_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Cont.SetWorldPath(folderBrowserDialog1.SelectedPath);
            }
            Cont.SetMain();
            Cont.LoadMain();
            CurrentSaveLabel.Text = "Main";
            EnableButtons(true);
            MainLoaded(true);
        }

        private void MainSaveButton_Click(object sender, EventArgs e)
        {
            Cont.LoadMain();
            CurrentSaveLabel.Text = "Main";
            MainLoaded(true); //User cannot load main save if it is already loaded
        }

        private void SetMainButton_Click(object sender, EventArgs e)
        {
            Cont.SetMain();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string SaveName = SaveBox.SelectedItem.ToString();
            if(SaveName != null)
            {
                Cont.LoadSave(SaveName);
                CurrentSaveLabel.Text = SaveName;
            }
            else
            {
                MessageBox.Show("No Save Selected");
            }
            
            MainLoaded(false); //Re-enable main save loading
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string SaveName = SaveBox.SelectedItem.ToString();
            if (SaveName != null && SaveName != CurrentSaveLabel.Text)
            {
                Cont.DeleteSave(SaveName);
                Cont.ListSaves();
            }
            else if(SaveName != null)
            {
                MessageBox.Show("Cannot delete currently loaded save.");
            }
            else
            {
                MessageBox.Show("No Save Selected");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cont.Save();
        }

        private void SaveCurrentSave_Click(object sender, EventArgs e)
        {
            string SaveName = Interaction.InputBox("Enter the name of this save file: ", "Create New Save");
            Cont.CreateSave(SaveName);
            Cont.ListSaves();
        }
    }
}
