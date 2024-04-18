using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio18Aprile.Models
{
    public class Metadata
    {
        public string id { get; set; }
        public bool @private { get; set; }
        public DateTime createdAt { get; set; }
        public string name { get; set; }
    }
}
