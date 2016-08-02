using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notecards
{

    public class CardPack
    {
        public string PackName { get; set; }
        public int NumOfCards { get; set; }
        public string PackCategory { get; set; }

        public List<Notecard> Notecards = new List<Notecard>();


        public Notecard this[int index]
        {
            get { return Notecards[index]; }
            set { Notecards[index] = value; }
        }
        
        public CardPack()
        {

        }

        public void AddNewCard(Notecard CardToAdd)
        {
            Notecards.Add(CardToAdd);

        }
        
    }
}
