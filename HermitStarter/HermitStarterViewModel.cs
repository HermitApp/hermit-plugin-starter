using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Hermit.Plugin;
using Caliburn.Micro;

namespace HermitStarter
{
    /// <summary>
    /// 
    /// </summary>
    [Export(typeof(Shell))]
    public class HermitStarterViewModel : Shell
    {
        public HermitStarterViewModel()
        {
            this.DisplayName = "Hermit Starter Project";
        }
    }
}
