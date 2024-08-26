using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideal.Models.ViewModels
{
    public class SampleViewModel
    {
        //ctor
        public SampleViewModel()
        {
            this.Name = string.Empty;
        }
        //prop
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
