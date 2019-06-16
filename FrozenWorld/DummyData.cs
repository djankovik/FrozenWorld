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
                case 1: return test();
                //case 2: return getLevel2();
                //case 3: return getLevel3();
                default: return FAKE1(level);
            }
        }
        public static Game2Player getLevel2Player(int level)
        {
            switch (level)
            {
                case 1: return FAKE2(level);
                default: return FAKE2(level);
            }           
        }
        public static Game FAKE1(int level)
        {
            Game g = new Game(0, 500, 500, 0);
            g.BACKGROUNDIMAGE = Resources.DarkForest6;
            g.LEVELID = level;

            g.Platforms.Add(new Platform(200,g.maxDown-100));
            g.Platforms.Add(new Platform(250, g.maxDown - 100));
            g.Platforms.Add(new Platform(300, g.maxDown - 100));
            g.Platforms.Add(new Platform(350, g.maxDown - 100));
            g.Platforms.Add(new Platform(400, g.maxDown - 100));

            g.Player = new Player(200, g.maxDown - 150 -Player.Height);

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            return g;
        }
        public static Game test()
        {
            Game g = new Game(0, 800,1000, 0);
            g.BACKGROUNDIMAGE = Resources.DarkForest6;
            g.LEVELID = 1;

            for (int i=0;i<=g.maxDown - 30;i+=30)
            {
                for (int j = 0; j <= g.maxRight - 50; j += 50)
                {
                    g.Platforms.Add(new Platform(j, i));
                }                
            }

            g.Player = new Player(200, g.maxDown - 150 - Player.Height);
            

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            return g;
        }
        public static Game2Player FAKE2(int level)
        {
            Game2Player g = new Game2Player(0, 500, 500, 0);
            g.BACKGROUNDIMAGE = Resources.DarkForest6;
            g.LEVELID = level;

            g.Platforms.Add(new Platform(200, g.maxDown - 100));
            g.Platforms.Add(new Platform(250, g.maxDown - 100));
            g.Platforms.Add(new Platform(300, g.maxDown - 100));
            g.Platforms.Add(new Platform(350, g.maxDown - 100));
            g.Platforms.Add(new Platform(400, g.maxDown - 100));

            g.Player1 = new Player(200, g.maxDown - 150 - Player.Height);
            g.Player2 = new Player(250, g.maxDown - 150 - Player.Height);

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            return g;
        }

        public static Game2Player getLevel12Player()
        {
            Game2Player g = new Game2Player(0, 640, 900, 0);
            g.BACKGROUNDIMAGE = Resources.DarkForest6;
            g.LEVELID = 1;

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

            platforms.Add(new Platform(0, 120));
            platforms.Add(new Platform(50, 120));
            platforms.Add(new Platform(100, 120));
            platforms.Add(new Platform(150, 120));
            platforms.Add(new Platform(200, 120));

            platforms.Add(new Platform(600, 560));
            platforms.Add(new Platform(650, 560));
            platforms.Add(new Platform(700, 560));
            platforms.Add(new Platform(750, 560));
            platforms.Add(new Platform(800, 560));
            platforms.Add(new Platform(850, 560));

            g.Enemies.Add(new Enemy(400, 150, 400, 750));

            g.Platforms = platforms;

            g.Player1 = new Player(200, 200);
            g.Player2 = new Player(260, 200);
            

            Enemy e = new Enemy(400, 350, 400, 560); e.makeAdvancedEnemy();
            g.Enemies.Add(e);

            g.Enemies.Add(new Enemy(850, g.maxDown - 80 - Enemy.Height, 600, 900));

            g.Stairs.Add(new Stairs(500, 400));
            g.Stairs.Add(new Stairs(500, 370));
            g.Stairs.Add(new Stairs(500, 340));
            g.Stairs.Add(new Stairs(500, 310));
            g.Stairs.Add(new Stairs(500, 280));
            g.Stairs.Add(new Stairs(500, 250));
            g.Stairs.Add(new Stairs(500, 220));

            g.Stairs.Add(new Stairs(20, 530));
            g.Stairs.Add(new Stairs(20, 500));
            g.Stairs.Add(new Stairs(20, 470));
            g.Stairs.Add(new Stairs(20, 440));
            g.Stairs.Add(new Stairs(20, 410));
            g.Stairs.Add(new Stairs(20, 380));

            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Snowflakes.Add(new Snowflake(20, 250));
            g.Snowflakes.Add(new Snowflake(50, 230));
            g.Snowflakes.Add(new Snowflake(70, 550));

            g.Snowflakes.Add(new Snowflake(0, 70));
            g.Snowflakes.Add(new Snowflake(50, 70));
            g.Snowflakes.Add(new Snowflake(100, 70));
            g.Snowflakes.Add(new Snowflake(150, 70));
            g.Snowflakes.Add(new Snowflake(200, 70));

            g.Snowflakes.Add(new Snowflake(350, 200));
            g.Snowflakes.Add(new Snowflake(350, 250));
            g.Snowflakes.Add(new Snowflake(350, 300));
            g.Snowflakes.Add(new Snowflake(350, 350));
            g.Snowflakes.Add(new Snowflake(350, 400));
            g.Snowflakes.Add(new Snowflake(350, 450));
            g.Snowflakes.Add(new Snowflake(350, 500));
            g.Snowflakes.Add(new Snowflake(350, 650));

            for (int i = g.maxUp + 200; i <= g.maxDown - 100; i += 50)
            {
                g.Snowflakes.Add(new Snowflake(850, i));
            }

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;

            return g;
        }
        public static Game getLevel1()
        {
            Game g = new Game(0,640,900,0);
            g.BACKGROUNDIMAGE = Resources.DarkForest6;
            g.LEVELID = 1;

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

            platforms.Add(new Platform(0, 120));
            platforms.Add(new Platform(50, 120));
            platforms.Add(new Platform(100, 120));
            platforms.Add(new Platform(150, 120));
            platforms.Add(new Platform(200, 120));

            platforms.Add(new Platform(600, 560));
            platforms.Add(new Platform(650, 560));
            platforms.Add(new Platform(700, 560));
            platforms.Add(new Platform(750, 560));
            platforms.Add(new Platform(800, 560));
            platforms.Add(new Platform(850, 560));

            g.Enemies.Add(new Enemy(400, 150, 400, 750));

            g.Platforms = platforms;

            g.Player = new Player(200, 200);

            Enemy e = new Enemy(400, 350, 400, 560); e.makeAdvancedEnemy();
            g.Enemies.Add(e);

            g.Enemies.Add(new Enemy(850, g.maxDown-80-Enemy.Height, 600, 900));

            g.Stairs.Add(new Stairs(500, 400));
            g.Stairs.Add(new Stairs(500, 370));
            g.Stairs.Add(new Stairs(500, 340));
            g.Stairs.Add(new Stairs(500, 310));
            g.Stairs.Add(new Stairs(500, 280));
            g.Stairs.Add(new Stairs(500, 250));
            g.Stairs.Add(new Stairs(500, 220));

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

            g.Snowflakes.Add(new Snowflake(0, 70));
            g.Snowflakes.Add(new Snowflake(50, 70));
            g.Snowflakes.Add(new Snowflake(100, 70));
            g.Snowflakes.Add(new Snowflake(150, 70));
            g.Snowflakes.Add(new Snowflake(200, 70));

            g.Snowflakes.Add(new Snowflake(350, 200));
            g.Snowflakes.Add(new Snowflake(350, 250));
            g.Snowflakes.Add(new Snowflake(350, 300));
            g.Snowflakes.Add(new Snowflake(350, 350));
            g.Snowflakes.Add(new Snowflake(350, 400));
            g.Snowflakes.Add(new Snowflake(350, 450));
            g.Snowflakes.Add(new Snowflake(350, 500));
            g.Snowflakes.Add(new Snowflake(350, 650));

            for(int i=g.maxUp + 200; i <= g.maxDown - 100; i += 50)
            {
                g.Snowflakes.Add(new Snowflake(850,i));
            }

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;

            return g;
        }
        public static Game getLevel2()
        {
            Game g = new Game(0, 700, 1000, 0);
            g.BACKGROUNDIMAGE = Resources.winterImageNightBG;
            g.LEVELID = 2;

            //PLATFORMS
           for (int i=0;i<=g.maxRight-Platform.Width;i+= Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown-100));
            }

            for (int i = 12*Platform.Width; i <= g.maxRight -2*Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 300));
            }

            for (int i = Platform.Width; i <= 8 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxUp +100));
            }

            for (int i = 3*Platform.Width; i < 5*Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 250));
                g.Platforms.Add(new Platform(i+150, g.maxDown - 350));
                g.Platforms.Add(new Platform(i+300, g.maxDown - 450));
            }
            for (int i = 15*Platform.Width; i <= g.maxRight - Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 530));
            }

            //STAIRS
            for (int i = g.maxUp + 100; i <= g.maxDown - 100; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(1 * Platform.Width, i));
            }

            for (int i = g.maxUp + 400; i <= g.maxDown - 100; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(17* Platform.Width, i));
            }

            //ENEMIES
            g.Enemies.Add(new Enemy(5, g.maxDown - 100-Enemy.Height, 0, g.maxRight));
            g.Enemies.Add(new Enemy(4 * Platform.Width, g.maxUp + 100 - Enemy.Height, Platform.Width, 9 * Platform.Width));
            g.Enemies.Add(new Enemy(17 * Platform.Width, g.maxDown - 530 - Enemy.Height, 15 * Platform.Width, g.maxRight));
            g.Enemies.Add(new Enemy(14 * Platform.Width, g.maxDown - 300-Enemy.Height, 12 * Platform.Width, g.maxRight - Platform.Width));

            //SNOWFLAKES
            for (int i = g.maxUp + 100; i <= g.maxDown - 150; i += Snowflake.Height+30)
            {
                g.Snowflakes.Add(new Snowflake(5,i ));
            }
            for (int i = 3 * Platform.Width-10; i <= 5 * Platform.Width+10; i += Snowflake.Width+15)
            {
                g.Snowflakes.Add(new Snowflake(i, g.maxDown - 300));
                g.Snowflakes.Add(new Snowflake(i + 150, g.maxDown - 400));
                g.Snowflakes.Add(new Snowflake(i + 300, g.maxDown - 500));

            }
            for (int i = g.maxDown-600; i < g.maxDown - 300; i += Snowflake.Height+20)
            {
                g.Snowflakes.Add(new Snowflake(14* Platform.Width, i));
            }


            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player = new Player(200, g.maxDown - 200);

            return g;
        }
        public static Game getLevel3()
        {
            Game g = new Game(0, 800, 1200, 0);
            g.BACKGROUNDIMAGE = Resources.winterImageNightBG;
            g.LEVELID = 2;

            for (int i = 0; i <= g.maxRight - Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 100));
            }
            for (int i = 3 * Platform.Width; i < 10 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 300));
                g.Platforms.Add(new Platform(i, g.maxDown - 500));
                g.Platforms.Add(new Platform(i, g.maxDown - 700));


                g.Enemies.Add(new Enemy(4 * Platform.Width, g.maxDown - 300 - Enemy.Height, 3 * Platform.Width, 10 * Platform.Width));
                g.Enemies.Add(new Enemy(7 * Platform.Width, g.maxDown - 500 - Enemy.Height, 3 * Platform.Width, 10 * Platform.Width));
                g.Enemies.Add(new Enemy(8 * Platform.Width, g.maxDown - 700 - Enemy.Height, 3 * Platform.Width, 10 * Platform.Width));
            }

            for (int i = 15 * Platform.Width; i < 23 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 300));
                g.Platforms.Add(new Platform(i, g.maxDown - 500));
                g.Platforms.Add(new Platform(i, g.maxDown - 700));               
                
            }
            Enemy e = new Enemy(16 * Platform.Width, g.maxDown - 300 - Enemy.Height, 15 * Platform.Width, 23 * Platform.Width);
            e.makeAdvancedEnemy();
            g.Enemies.Add(e);
            g.Enemies.Add(new Enemy(18 * Platform.Width, g.maxDown - 500 - Enemy.Height, 15 * Platform.Width, 23 * Platform.Width));
            g.Enemies.Add(new Enemy(20 * Platform.Width, g.maxDown - 700 - Enemy.Height, 15 * Platform.Width, 23 * Platform.Width));
            

            for (int i = g.maxUp + 40; i < g.maxDown - 200; i += Snowflake.Height + 30)
            {
                g.Snowflakes.Add(new Snowflake(11 * Platform.Width, i));
                if (i < g.maxDown - 500)
                {
                    g.Snowflakes.Add(new Snowflake(12 * Platform.Width+Platform.Width/2, i));
                }
                g.Snowflakes.Add(new Snowflake(14 * Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(2 * Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(1*Platform.Width, i+15));
              
            }

            for (int i = g.maxDown - 700; i <= g.maxDown - 500; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(7 * Platform.Width, i));
                g.Stairs.Add(new Stairs(17 * Platform.Width, i));
            }
            for (int i = g.maxDown - 500; i <= g.maxDown - 300; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(9 * Platform.Width, i));
                g.Stairs.Add(new Stairs(22 * Platform.Width, i));
            }
            for (int i = g.maxDown - 300; i <= g.maxDown - 100; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(5 * Platform.Width, i));
                g.Stairs.Add(new Stairs(15 * Platform.Width, i));
            }

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player = new Player(200, g.maxDown - 200);

            return g;
        }

        public static Game getLevel4()
        {
            Game g = new Game(0, 800, 800, 0);
            g.LEVELID = 4;
            

            return g;
        }


    }
}
