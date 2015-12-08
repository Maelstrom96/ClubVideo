using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubVideo
{
    public class MovieObject
    {
        public string Nom_en { get; set; }
        public string Nom_fr { get; set; }
        public string Description_en { get; set; }
        public string Description_fr { get; set; }
        public int Year { get; set; }
        public string Rated { get; set; }
        public int Runtime { get; set; }
        public string Director { get; set; }
        public Image Poster {get; set;}
    }
}
