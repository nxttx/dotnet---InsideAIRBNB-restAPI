using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("neighbourhoods")]
    public class NeighbourhoodsController : ControllerBase
    {
        [HttpGet]
        public String GetNeighbourhoods()
        {
            return
                "[\"Bijlmer-Centrum\",\"Bijlmer-Oost\",\"Bos en Lommer\",\"Buitenveldert - Zuidas\",\"Centrum-Oost\",\"Centrum-West\",\"De Aker - Nieuw Sloten\",\"De Baarsjes - Oud-West\",\"De Pijp - Rivierenbuurt\",\"Gaasperdam - Driemond\",\"Geuzenveld - Slotermeer\",\"IJburg - Zeeburgereiland\",\"Noord-Oost\",\"Noord-West\",\"Oostelijk Havengebied - Indische Buurt\",\"Osdorp\",\"Oud-Noord\",\"Oud-Oost\",\"Slotervaart\",\"Watergraafsmeer\",\"Westerpark\",\"Zuid\"]";

        }
    }
}