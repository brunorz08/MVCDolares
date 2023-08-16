using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDolar.Models.Dolares
{
    public class Dolares
    {
        public Oficial? oficial { get; set; }
        public Blue? blue { get; set; }
        public oficial_euro? oficial_euro { get; set; }
        public blue_euro? blue_euro { get; set; }

        public DateTime last_update { get; set; }



    }
}
