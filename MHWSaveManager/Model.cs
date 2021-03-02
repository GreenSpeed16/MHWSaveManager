﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace MHWSaveManager
{
    public class Model
    {
        public static BinaryFormatter binaryFormatter { get; private set; }
        public List<string> SaveList { get; private set; }
        public bool MainLoaded { get; private set; }
        string CurrentSavePath;
        public string WorldPath { get; private set; }
        public static ProgramState State;

        public Model()
        {
            binaryFormatter = new BinaryFormatter();
            State = ProgramState.State;
            CurrentSavePath = State.CurrentSavePath;
            WorldPath = State.WorldPath;
            MainLoaded = State.MainLoaded;
            SaveList = State.SaveList;
        }

        public void SwitchSave(string FileName)
        {
            if (MainLoaded)
            {
                DialogResult dialogResult =
                MessageBox.Show("You are about to switch off of your main save file. Would you like to save it?", "Confirm Save Switch", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    SetMain();
                }
            }

            CurrentSavePath = FileName;
            File.Delete(WorldPath + "\\SAVEDATA1000");
            File.Copy(".\\Saves\\" + FileName, WorldPath + "\\SAVEDATA1000");
            MainLoaded = false;
        }

        public void Save()
        {
            //Pass data to CurrentState
            State.Save(WorldPath, CurrentSavePath, SaveList, MainLoaded);
            //Save to file
            using (Stream output = File.Create("program.state"))
            {
                binaryFormatter.Serialize(output, State);
            }
        }

        public void CreateSave(string FilePath)
        {
            File.Copy(WorldPath + "\\SAVEDATA1000", FilePath);
        }

        public void LoadMain()
        {
            if (!MainLoaded)
            {
                File.Delete(WorldPath + "\\SAVEDATA1000");
                File.Copy(".\\MainSave\\MainData", WorldPath + "\\SAVEDATA1000");
                MainLoaded = true;
                CurrentSavePath = "Main";
            }
            else
            {
                MessageBox.Show("Main Save Is Already Loaded", "Already Loaded");
            }
        }

        public void SetWorldFolder(string Path)
        {
            WorldPath = Path;
        }

        public void SetMain()
        {
            if (File.Exists(".\\MainSave\\MainData"))
            {
                string confirmation = Interaction.InputBox("You are about to overwrite your main save file. Type \"Confirm\" to continue.");

                if(confirmation.ToUpper() != "CONFIRM")
                {
                    MessageBox.Show("Cancelled save set.", "Cancelled");
                    return;
                }
            }
            File.Delete(".\\MainSave\\MainData");
            File.Copy(WorldPath + "\\SAVEDATA1000", ".\\MainSave\\MainData");
        }

        public string GetSave()
        {
            return CurrentSavePath;
        }

        public void DeleteSave(string FileName)
        {
            DialogResult dialogResult = MessageBox.Show("You are about to delete " + FileName + ". Continue?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                File.Delete(".\\Saves\\" + FileName);
            }
            
        }

        public List<string> ListSaves()
        {
            SaveList.Clear();
            DirectoryInfo d = new DirectoryInfo(".\\Saves\\");
            FileInfo[] files = d.GetFiles();

            foreach (FileInfo file in files)
            {
                SaveList.Add(file.Name);
            }

            return SaveList;
        }
    }
}