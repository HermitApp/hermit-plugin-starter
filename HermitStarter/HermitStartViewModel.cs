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
    [Export(typeof(IPlugin))]
    public class HermitStartViewModel : PropertyChangedBase, IPlugin
    {
        private string _DisplayName;

        /// <summary>
        /// 
        /// </summary>
        public string DisplayName
        {
            get
            {
                return _DisplayName;
            }
            set
            {
                if(value != _DisplayName)
                {
                    _DisplayName = value;
                    NotifyOfPropertyChange(() => DisplayName);
                }
            }
        }

        public HermitStartViewModel()
        {
            this.DisplayName = "Hermit Starter Project";
        }
    }
}
