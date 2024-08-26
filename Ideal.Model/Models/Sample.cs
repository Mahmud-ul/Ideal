using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideal.Model.Models
{
    public class Sample
    {
        //ctor
        public Sample()
        {
            this.Name = string.Empty;
        }
        //prop
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
