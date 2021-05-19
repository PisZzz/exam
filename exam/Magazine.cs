using System;
using System.Collections.Generic;
using System.Text;

namespace exam
{
    class Magazine
    {
        public string Name { get; set; }

        public string Publisher { get; set; }

        public decimal Price { get; set; }

        public int Issn { get; set; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3}", Name, Publisher, Price, Issn);
        }

    }
}