using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livsperiodesystem
{
    public class AktivitetsKAtalogDic
    {
        private Dictionary<int, Aktivitet> _aktivitetsdic;
        public string Lokation { get; set; }
        public string Aktivitet { get; set; }
        public AktivitetsKAtalogDic(string aktivitet, string lokation)
        {
            _aktivitetsdic = new Dictionary<int, Aktivitet>();
            Lokation = lokation;
            Aktivitet = aktivitet;
        }
        public void AddAktivitet(Aktivitet aktivitet)
        {
            if (aktivitet.MinAlder > aktivitet.MaxAlder)
            {
                throw new ArgumentException("min/max alder er ugyldig");
            }
            if (aktivitet.SlutTidspunkt < aktivitet.StartTidspunkt)
            {
                throw new ArgumentException("Slut tidspunkt skal være efter start");
            }
            else
            {
                _aktivitetsdic.Add(aktivitet.ID, aktivitet);
            }
        }
        public void DeleteAktivitet(int id)
        {
            _aktivitetsdic.Remove(id);
        }
        public override string ToString()
        {
            string aktiviteterReturn = "";
            //foreach (var item in _aktivitetsdic)
            //{
            //    aktiviteterReturn += item.ToString() + "\n";
            //}
            //return $"{Aktivitet}, {Lokation}\n\t" + aktiviteterReturn;
            int i = 0;
            while (i < _aktivitetsdic.Count)
            {
                aktiviteterReturn += _aktivitetsdic.ElementAt(i).ToString() + "\n";
                i++;
            }
            return $"{Aktivitet}, {Lokation}\n" + aktiviteterReturn;
        }
    }
}
