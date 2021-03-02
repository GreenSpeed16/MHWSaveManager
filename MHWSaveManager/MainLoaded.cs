using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MHWSaveManager
{
    [Serializable]
    public class MainLoaded : State
    {
        public MainLoaded(Model owner) : base(owner)
        {
            this.__Owner = owner;
        }
        public override void SwitchSave(string SourcePath, string DestPath)
        {
            DialogResult dialogResult = 
                MessageBox.Show("You are about to switch off of your main save file. Would you like to save it?", "Confirm Save Switch", MessageBoxButtons.YesNo);
            
            if(dialogResult == DialogResult.Yes)
            {
                base.SwitchSave(SourcePath, DestPath);
            }
        }

        public override void LoadMain()
        {
            //Main is already loaded, therefore nothing happens
        }
    }
}
