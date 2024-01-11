using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livsperiodesystem
{
    public class Aktivitet
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _minAlder;

        public int MinAlder
        {
            get { return _minAlder; }
            set { _minAlder = value; }
        }
        private int _maxAlder;

        public int MaxAlder
        {
            get { return _maxAlder; }
            set { _maxAlder = value; }
        }
        private DateTime _startTidspunkt;

        public DateTime StartTidspunkt
        {
            get { return _startTidspunkt; }
            set { _startTidspunkt = value; }
        }
        private DateTime _slutTidspunkt;

        public DateTime SlutTidspunkt
        {
            get { return _slutTidspunkt; }
            set { _slutTidspunkt = value; }
        }
        //public int ID { get; set; }
        //public int MinAlder { get; set; }
        //public int MaxAlder { get; set; }
        //public DateTime Start { get; set; }
        //public DateTime Slut { get; set; }
        public Aktivitet(int id, int minAlder, int maxAlder)
        {
            _id = id;
            _minAlder = minAlder;
            _maxAlder = maxAlder;
            _startTidspunkt = DateTime.Now;
            _slutTidspunkt = DateTime.Now.AddHours(3);
        }
        public override string ToString()
        {
            return $"ID:{ID} \n\t Min-alder: {MinAlder} \n\t Max-alder: {MaxAlder} \n\t Starttid: {StartTidspunkt} \n\t Sluttid: {SlutTidspunkt}";
        }

    }
}
