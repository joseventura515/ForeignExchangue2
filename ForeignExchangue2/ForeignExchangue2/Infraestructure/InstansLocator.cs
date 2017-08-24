using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeignExchangue2.Infraestructure
{
    using ViewModels;

    public class InstansLocator
    {
        public MainViewModel Main { get; set; }

        public InstansLocator()
        {
            Main = new MainViewModel();
        }
    }
}
