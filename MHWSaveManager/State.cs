using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MHWSaveManager
{
    [Serializable]
    public class State
    {
        protected Model __Owner;

        public State(Model owner)
        {
            __Owner = owner;
        }

        public virtual void SwitchSave(string SourcePath, string DestPath)
        {
            File.Delete(Path.Combine(__Owner.WorldPath, "\\SAVEDATA1000"));
            File.Copy(SourcePath, DestPath);
        }

        public virtual void LoadMain()
        {
            File.Delete(__Owner.WorldPath + "\\SAVEDATA1000");
            File.Copy(".\\MainSave\\MainData", Path.Combine(__Owner.WorldPath, "\\SAVEDATA1000"));
        }

        public virtual void DeleteSave(string PathToDelete)
        {
            File.Delete(PathToDelete);
        }
    }
}
