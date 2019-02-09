using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using Infinito.WPF.Framework.Interfaces;

namespace Infinito.WPF.Modules.Shell
{
    [Export(typeof(IShell))]
    public class ShellViewModel : Screen, IShell
    {
        [ImportingConstructor]
        public ShellViewModel()
        {
        }

        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
        }

    }
}
