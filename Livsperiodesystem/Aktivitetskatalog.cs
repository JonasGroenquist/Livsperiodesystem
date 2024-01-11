using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Livsperiodesystem
{
    public class Aktivitetskatalog
    {
        private List<Aktivitet> _aktivitetskatalog;

        public string Lokation { get; set; }
        public string Aktivitet { get; set; }
        public Aktivitetskatalog(string aktivitet, string lokation)
        {
            Aktivitet = aktivitet;
            Lokation = lokation;
            _aktivitetskatalog = new List<Aktivitet>();
        }
        public void AddAktivitet(int id, int minAlder, int maxAlder)
        {
            if (minAlder > maxAlder)
            {
                throw new ArgumentException("min/max alder er ugyldig");
            }
            //if (Slut > Start)
            //{
            //    throw new ArgumentException("min/max alder er ugyldig");
            //}
            //else
            {
                _aktivitetskatalog.Add(new Aktivitet(id, minAlder, maxAlder));
            }
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
                _aktivitetskatalog.Add(aktivitet);
            }
        }
        public Aktivitet DeleteAktivitet(int id)
        {
            foreach (var aktivitet in _aktivitetskatalog)
            {
                if (id == aktivitet.ID)
                {
                    _aktivitetskatalog.Remove(aktivitet);
                    return aktivitet;
                }
            }
            return null;
        }

        public override string ToString()
        {
            string aktiviteterReturn = "";
            foreach (var item in _aktivitetskatalog)
            {
                aktiviteterReturn += item.ToString() + "\n";
            }
            return $"{Aktivitet}, {Lokation}\n" + aktiviteterReturn;
            //int i = 0;
            //while (i < _aktivitetskatalog.Count)
            //{
            //    aktiviteterReturn += _aktivitetskatalog[i].ToString() + "\n";
            //    i++;
            //}
            //return $"{Aktivitet}, {Lokation}\n" + aktiviteterReturn;
        }
    }
}
