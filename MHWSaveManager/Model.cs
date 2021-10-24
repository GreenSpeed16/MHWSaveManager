using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace MHWSaveManager
{
    public class Model
    {
        public static BinaryFormatter binaryFormatter { get; private set; }
        public static List<string> SaveList { get; private set; }
        public bool MainLoaded { get; private set; }
        public string CurrentSavePath;
        public static string WorldPath { get; set; }
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
                    File.Delete(".\\MainSave\\MainData");
                    File.Copy(WorldPath + "\\SAVEDATA1000", ".\\MainSave\\MainData");
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
            State.Save(WorldPath, CurrentSavePath, MainLoaded);
            //Save to file
            using (Stream output = File.Create("program.state"))
            {
                binaryFormatter.Serialize(output, State);
            }
        }

        public void CreateSave(string FilePath)
        {
            if (!SaveList.Contains(FilePath))
            {
                File.Copy(WorldPath + "\\SAVEDATA1000", ".\\Saves\\" + FilePath);
                CurrentSavePath = FilePath.Replace(".\\Saves\\", "");
                MainLoaded = false;
                SaveList.Add(FilePath);
            }
            else
            {
                DialogResult result = MessageBox.Show("A save with that name already exists. Would you like to replace it?", "Save Already Exists",
                    MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    File.Delete(".\\Saves\\" + FilePath);
                    File.Copy(WorldPath + "\\SAVEDATA1000", ".\\Saves\\" + FilePath);
                    CurrentSavePath = FilePath.Replace(".\\Saves\\", "");
                    MainLoaded = false;
                }
            }
            
        }

        public void RenameSave(string oldPath, string newPath)
        {
            SaveList.Remove(oldPath);
            SaveList.Add(newPath);

            newPath = ".\\Saves\\" + newPath;
            oldPath = ".\\Saves\\" + oldPath;
            File.Copy(oldPath, newPath);
            File.Delete(oldPath);
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

        public bool SetWorldFolder()
        {
            object steamPath = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Valve\\Steam", "InstallPath", null);
            string[] userdataFolder = Directory.GetDirectories(steamPath.ToString() + "\\userdata");
            bool storiesFolderExists = false;
            foreach (string folder in userdataFolder)
            {
                Console.WriteLine(folder);
                Console.WriteLine(folder.Substring(folder.LastIndexOf("\\") + 1));
                if (Regex.IsMatch(folder.Substring(folder.LastIndexOf("\\") + 1), "^[0-9]"))
                //Folder is the Id folder
                {
                    foreach (string subFolder in Directory.GetDirectories(folder))
                    {
                        if (subFolder.Substring(subFolder.LastIndexOf("\\") + 1) == "582010")
                        {
                            WorldPath = folder + "\\582010\\remote";
                            return true;
                        }
                    }
                    if (!storiesFolderExists)
                    {
                        string tempPath = Interaction.InputBox("MHW folder not found. Please type the path here: ");
                        if(WorldPath != "")
                        {
                            WorldPath = tempPath;
                            return true;
                        }
                    }
                    return false;
                }
            }
            return false;
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
                SaveList.Remove(FileName);
            }
            
        }

        public void ReorderSaves(List<string> saveList)
        {
            SaveList = saveList;
        }

        public List<string> ListSaves()
        {
            return SaveList;
        }
    }
}
