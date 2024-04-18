using DocumentFormat.OpenXml.Office2013.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio18Aprile.ModelsMeteo
{
    public class Record
    {
        public Timelines timelines { get; set; }
        public Location location { get; set; }
    }
}
