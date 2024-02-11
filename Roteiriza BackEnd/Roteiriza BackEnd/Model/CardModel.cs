using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiriza_BackEnd.Model
{
    public class CardModel : AbstractCardModel
    {

        public CardModel(int cardId, string cardName, string cardDescription) 
            : base(cardId, cardName, cardDescription)
        { }

        public override string ToString()
        {
            return "\n Nome do Card: "
                + CardName
                + "\n Descrição do Card "
                + CardDescription;
        }

    }
}
