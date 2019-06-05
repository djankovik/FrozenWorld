using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenWorld
{
    public static class DummyData
    {
        public static Game getLevel1()
        {
            Game g = new Game(0,700,800,0);

            List<Platform> platforms = new List<Platform>();
            platforms.Add(new Platform(0, 560));
            platforms.Add(new Platform(50, 560));
            platforms.Add(new Platform(100, 560));
            platforms.Add(new Platform(150, 560));
            platforms.Add(new Platform(200, 560));
            platforms.Add(new Platform(250, 560));
            platforms.Add(new Platform(300, 560));
            platforms.Add(new Platform(350, 560));
            platforms.Add(new Platform(400, 400));
            platforms.Add(new Platform(450, 400));
            platforms.Add(new Platform(500, 400));

            g.Platforms = platforms;

            g.Player = new Player(200, 200);

            g.Enemies.Add(new Enemy(400, 330, 400, 550));

            g.Stairs.Add(new Stairs(20,530));
            g.Stairs.Add(new Stairs(20, 500));
            g.Stairs.Add(new Stairs(20, 470));
            g.Stairs.Add(new Stairs(20, 440));
            g.Stairs.Add(new Stairs(20, 410));
            g.Stairs.Add(new Stairs(20, 380));
            return g;
        }
    }
}
