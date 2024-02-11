using System;
using Roteiriza_BackEnd.Model;

namespace Roteiriza_BackEnd.Model
{
    public  class TravelModel : AbstractCardModel
    {
        public DateTime travelDateInitial {  get; set; }
        public DateTime travelDateFinal { get; set; }

        public double travelValue {  get; set; }

        public TravelModel(int cardId, string cardName, string cardDescription, DateTime travelDateInitial, DateTime travelDateFinal, double travelValue) 
            : base (cardId, cardName, cardDescription)
        {
            this.travelDateInitial = travelDateInitial;
            this.travelDateFinal = travelDateFinal;
            this.travelValue = travelValue;
        }

        

        public override string ToString()
        {
            return "\n Nome da viagem: "
                + CardName
                + "\n Descrição da viagem: "
                + CardDescription
                + "\n Data da viagem: "
                + travelDateInitial + " Até " + travelDateFinal 
                + "\n Valor da viagem: "
                + travelValue;
        }
    }
}
