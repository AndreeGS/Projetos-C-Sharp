using System;
using Roteiriza_BackEnd.Model;

namespace Roteiriza_BackEnd.Model
{
    public  class TravelModel 
    {
        public int IdTravel { get; set; }

        public string CardName { get; set; }

        public string CardDescription { get; set; }
        public DateTime travelDateInitial {  get; set; }
        public DateTime travelDateFinal { get; set; }
        public Valor? travelValue {  get; set; }

        public TravelModel(int idTravel, string cardName, string cardDescription, DateTime travelDateInitial, DateTime travelDateFinal)
        {
            IdTravel = idTravel;
            CardName = cardName;
            CardDescription = cardDescription;
            this.travelDateInitial = travelDateInitial;
            this.travelDateFinal = travelDateFinal;
            this.travelValue = travelValue;
        }

        public TravelModel(int idTravel, string cardName, string cardDescription, DateTime travelDateInitial, DateTime travelDateFinal, Valor travelValue)
        {
            IdTravel = idTravel;
            CardName = cardName;
            CardDescription = cardDescription;
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
                + "\n Desepesas: \n"
                + travelValue;
        }
    }
}
