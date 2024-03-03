using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex2
{
    public class Card
    {
        private string colour;
        private string figure;
        private string type;

        public Card(string colour, string figure, string type)
        {
            this.Colour = colour;
            this.Figure = figure;
            this.Type = type;
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public string Figure
        {
            get { return figure; }
            set { figure = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

    }
}
