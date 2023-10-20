using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1735_Group6_A2.DTL
{
    public class Show
    {
        public int ShowID { get; set; }
        public int RoomID { get; set; }
        public int FilmID { get; set; }
        public DateTime ShowDate { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
        public int Slot { get; set; }
    }
}
