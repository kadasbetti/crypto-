using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH_A
{
    internal class Crypto
    {
        string date;
        string name;
        float open;
        float close;

        public Crypto(string date, string name, float open, float close)
        {
            this.date = date;
            this.name = name;
            this.open = open;
            this.close = close;
        }

        public string Name { get { return name; } }
        public string Date { get { return date; } }
        public float Open { get { return open; } }
        public float Close { get { return close; } }
    }
}
