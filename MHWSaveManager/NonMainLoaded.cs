using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSaveManager
{
    public class NonMainLoaded : State
    {
        public NonMainLoaded(Model owner) : base(owner)
        {
            this.__Owner = owner;
        }

        public override void SwitchSave(string SourcePath, string DestPath)
        {
            base.SwitchSave(SourcePath, DestPath);
        }

        public override void LoadMain()
        {
            base.LoadMain();
        }
    }
}
