using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livsperiodesystem
{
    public class HoldAktivitet : Aktivitet
    {
        public string HoldID { get; set; }
        public HoldAktivitet(string holdid, int id, int minAlder, int maxAlder) : base(id, minAlder, maxAlder)
        {
            HoldID = holdid;
        }
        public override string ToString()
        {
            return base.ToString() + $"\n\t Hold Id:{HoldID}";
        }
    }
}
