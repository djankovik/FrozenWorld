using FrozenWorld.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenWorld
{
    public static class DummyData
    {
        public static Game getLevel(int level)
        {
            switch (level)
            {
                case 1: return getLevel1();
                default: return getLevel1();
            }
        }
        public static Game getLevel1()
        {
            Game g = new Game(0,640,800,0);
            g.BACKGROUNDIMAGE = Resources.DarkForest6;


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

            platforms.Add(new Platform(0, 375));
            platforms.Add(new Platform(50, 375));
            platforms.Add(new Platform(100, 375));
            platforms.Add(new Platform(150, 375));
            platforms.Add(new Platform(200, 375));


            platforms.Add(new Platform(400, 200));
            platforms.Add(new Platform(450, 200));
            platforms.Add(new Platform(500, 200));
            platforms.Add(new Platform(550, 200));
            platforms.Add(new Platform(600, 200));
            platforms.Add(new Platform(650, 200));
            platforms.Add(new Platform(700, 200));

            g.Enemies.Add(new Enemy(400, 150, 400, 750));

            g.Platforms = platforms;

            g.Player = new Player(200, 200);

            g.Enemies.Add(new Enemy(400, 350, 400, 560));

            g.Stairs.Add(new Stairs(500, 400));
            g.Stairs.Add(new Stairs(500, 370));
            g.Stairs.Add(new Stairs(500, 340));
            g.Stairs.Add(new Stairs(500, 310));
            g.Stairs.Add(new Stairs(500, 280));
            g.Stairs.Add(new Stairs(500, 250));

            g.Stairs.Add(new Stairs(20, 530));
            g.Stairs.Add(new Stairs(20, 500));
            g.Stairs.Add(new Stairs(20, 470));
            g.Stairs.Add(new Stairs(20, 440));
            g.Stairs.Add(new Stairs(20, 410));
            g.Stairs.Add(new Stairs(20, 380));

            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;
            g.Snowflakes.Add(new Snowflake(20,250));
            g.Snowflakes.Add(new Snowflake(50, 230));
            g.Snowflakes.Add(new Snowflake(70, 550));

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;

            return g;
        }
    }
}
