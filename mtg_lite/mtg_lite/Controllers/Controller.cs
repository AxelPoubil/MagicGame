using mtg_lite.Models.Players;
using mtg_lite.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Controllers
{
    public class Controller
    {
        private Player player;

        public Player Player { get => player; }

        public Controller()
        {
            player = new Player("Red");
        }
        public void Mafonction()
        {
         //Test   
        }

    }
}
