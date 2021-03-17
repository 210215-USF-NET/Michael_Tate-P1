using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models.PatronModel
{
    public class PatronIndex
    {
        public IEnumerable<PatronDetailModel> Patrons { get; set; }
    }
}