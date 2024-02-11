using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiriza_BackEnd.Model
{
    public abstract class AbstractCardModel
    {
        public int CardId { get; set; }
        public string CardName { get; set; }
        public string CardDescription { get; set; }

        public AbstractCardModel(int cardId, string cardName, string cardDescription)
        {
            CardId = cardId;
            CardName = cardName;
            CardDescription = cardDescription;
        }

    }
}
