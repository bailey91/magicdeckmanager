using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicDeckManager.Models
{
    public class Card
    {
        public string id { get; set; }
        public string name { get; set; }
        public string manaCost { get; set; }
        public int cmc { get; set; }
        public List<string> colors { get; set; }
        public List<string> colorIdentity { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public string set { get; set; }
        public string setName { get; set; }
        public string imageUrl { get; set; }
    }
}
