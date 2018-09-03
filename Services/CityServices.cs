using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todoApi.Entities;

namespace todoApi.Services
{
    public class CityServices
    {
        public CityServices()
        {

        }

        public string temperaturaObregon()
        {
            return "{data: [33.5,30,32,34,33,31,28,28,31,30,30,25,24,29], label: 'Obregon'}";

        }
        public string temperaturaNavojoa()
        {
            return "{data: [28,39,30,30,31,32,33.5,30.5,32,34,33,31,30,30], label: 'Navojoa'}";
        }
        public string temperaturaHermosillo()
        {
            return "{data: [30,32,30,33.5,30,32,34,33,31,30.5,31,33,30.5,31], label: 'Hermosillo'}";

        }
        public string temperaturaNogales()
        {
            return "{data: [30,32,30,31,29,30,30.5,29,33.5,30,32,34,33,31], label: 'Nogales'}";
        }
    }
}
