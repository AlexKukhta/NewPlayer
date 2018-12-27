using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewPlayer
{
    class Artist
    {
        public string Genre;
        public string Name;

        public Artist()
        {
            this.Name = "Default Name";
            this.Genre = "Default genre";
        }

        public Artist(string Genre)
        {
            this.Name = "Default Name";
            this.Genre = Genre;
        }

        public Artist(string Name, string Genre)
        {
            this.Name = Name;
            this.Genre = Genre;
        }
    }
}
