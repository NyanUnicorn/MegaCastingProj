using MegaCasting.DataLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaCasting.Models.PageContents
{
    public class PageOffers
    {
        private List<MGCastingOffer> castingOffers;

        public List<MGCastingOffer> CastingOffers { get => castingOffers; set => castingOffers = value; }
    }
}
