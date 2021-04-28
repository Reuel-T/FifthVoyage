using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.Util;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HotelController : ControllerBase
    {
        private List<Hotel> hotels = HotelListUtil.hotels;

        private readonly ILogger<WeatherForecastController> _logger;

        public HotelController()
        {
            if(hotels.Count < 1)
            {
                Hotel h1 = new Hotel(1, "Tipton Hotel", "https://suitelife.fandom.com/wiki/The_Tipton_Hotel", "Boston", 6, "https://www.google.com/search?q=tipton+hotel&sxsrf=ALeKk01lA82fprm4lpQAWHWehFypS8MbYA:1618906018286&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjZ45PxrozwAhWjShUIHYAaB0oQ_AUoAXoECAEQAw&cshid=1618906080116785&biw=1396&bih=657#imgrc=lk7ODAT2N2Zq0M");
                Hotel h2  = new Hotel (2, "Hotel California", "https://www.youtube.com/watch?v=EqPtz5qN7HM", "California", 3, "https://www.google.com/search?q=hotel+california&hl=en&tbm=isch&sxsrf=ALeKk02m77N4m8Qy2ODCiAENkCNyuOF5Rw:1618906183290&source=lnms&sa=X&ved=0ahUKEwjc6uq_r4zwAhUSHcAKHXp2BQwQ_AUIECgC&biw=1920&bih=903&dpr=1#imgrc=54AQyNXEo8iARM");
                Hotel h3 = new Hotel(3, "Hotel Transylvania", "https://en.wikipedia.org/wiki/Hotel_Transylvania", "Unknown", 5, "https://www.google.com/search?q=hotel+tran&sxsrf=ALeKk00wS-_PWTfZY8K-qRsoOK-A4gDtfA:1618906244179&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiT-e7cr4zwAhWa8rsIHRuaDYUQ_AUoAXoECAEQAw&biw=1920&bih=903#imgrc=HEO72PElj77YAM");

                hotels.Add(h1);
                hotels.Add(h2);
                hotels.Add(h3);
            }
        }

        [HttpGet]
        public List<Hotel> GetHotels()
        {
            return hotels;
        }

        [HttpGet]
        public Hotel getOne(string s)
        {
            return hotels.Where(x => x.Name.Contains(s)).FirstOrDefault();
        }

        [HttpPost] 
        public List<Hotel> PostHotel(Hotel h)
        {
            hotels.Add(h);
            return hotels;
        }

    }
}
