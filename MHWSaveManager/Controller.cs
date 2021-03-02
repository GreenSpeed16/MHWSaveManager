using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSaveManager
{
    public class Controller
    {
        Form1 __View;
        public Model __Model { get; private set; }
        
        public Controller(Form1 View, Model Model)
        {
            this.__View = View;
            this.__Model = Model;

            __View.MainLoaded(__Model.MainLoaded);
            if(__Model.WorldPath == null)
            {
                __View.EnableButtons(false);
            }
            else
            {
                __View.EnableButtons(true);
            }
        }

        public void SetWorldPath(string Path)
        {
            __Model.SetWorldFolder(Path);
        }

        public void Save()
        {
            __Model.Save();
        }

        public void LoadSave(string FileName)
        {
            __Model.SwitchSave(FileName);
        }

        public void SetMain()
        {
            __Model.SetMain();
        }

        public string GetSave()
        {
            return __Model.GetSave();
        }

        public void LoadMain()
        {
            __Model.LoadMain();
        }

        public void DeleteSave(string FileName)
        {
            __Model.DeleteSave(FileName);
        }

        public void ListSaves()
        {
            __View.ListSaves(__Model.ListSaves());
        }

        public void CreateSave(string FileName)
        {
            __Model.CreateSave(".\\Saves\\" + FileName);
        }
    }
}
