
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace DiceRollerAPI_Practice_Procject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiceRollerController :ControllerBase
    {
       static Random random = new Random();

        [HttpGet("{number}")]

        public string GetDieRoll(int number)
        {
            int dieRoll = random.Next(1, number);
            if (dieRoll == 8 || dieRoll == 18) 
            {
                return $"You rolled an {dieRoll}";
            }
            else
            {
                return $"You rolled a  {dieRoll}";
            }
        }

    }
}
