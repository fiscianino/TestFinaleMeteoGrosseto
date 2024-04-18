using Esercizio18Aprile.ModelsMeteo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio18Aprile.Models
{
    public class Daily
    {
        public DateTime time { get; set; }
        public string status { get; set; }
        public Values values { get; set; }
    }
}
