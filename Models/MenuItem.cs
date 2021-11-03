using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN.Models
{
    class MenuItem
    {
        public string Name { get; set; } // abstract property --  sử dụng các model

        public string MemnuPage { get; set; }

        public string Icon {get; set;}
    }
}
