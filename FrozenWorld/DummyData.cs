using FrozenWorld.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
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
                case 2: return getLevel2();
                case 3: return getLevel3();
                case 4: return getLevel4();
                case 5: return getLevel5();
                case 6: return getLevel6();
                case 7: return getLevel7();
                case 8: return getLevel8();
                case 9: return getLevel9();
                case 10: return getLevel10();
                case 11: return getLevel11();
                case 12: return getLevel12();
                case 13: return getLevel13();
                case 14: return getLevel14();
                case 15: return getLevel15();
                default: return getLevel1();
            }
        }
        public static Game2Player getLevel2Player(int level)
        {
            switch (level)
            {
                case 1: return getLevel1_2Player();
                case 2: return getLevel2_2Player();
                case 3: return getLevel3_2Player();
                case 4: return getLevel4_2Player();
                case 5: return getLevel5_2Player();
                case 6: return getLevel6_2Player();
                case 7: return getLevel7_2Player();
                case 8: return getLevel8_2Player();
                case 9: return getLevel9_2Player();
                case 10: return getLevel10_2Player();
                case 11: return getLevel11_2Player();
                case 12: return getLevel12_2Player();
                case 13: return getLevel13_2Player();
                case 14: return getLevel14_2Player();
                case 15: return getLevel15_2Player();
                default: return getLevel1_2Player();
            }           
        }
        
        public static Game2Player getLevel1_2Player()
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

            //Enemy x = new Enemy(100,120-Enemy.Height,0,250);
            //x.makeAdvancedEnemy();
            //g.Enemies.Add(x);

            g.Enemies.Add(new Enemy(400, 145, 400, 750));

            g.Platforms = platforms;

            g.Player1 = new Player(200, 200);
            g.Player2 = new Player(260, 200);
            

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
            g.Snowflakes.Add(new Snowflake(70, 250));

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
        public static Game2Player getLevel2_2Player()
        {

            Game2Player g = new Game2Player(0, 600, 850, 0);
            g.BACKGROUNDIMAGE = Resources.background1;
            g.LEVELID = 2;

            for (int i = 0; i < 3 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 280));
            }
            g.Platforms.Add(new Platform(4 * Platform.Width, g.maxDown - 200));
            g.Snowflakes.Add(new Snowflake(4 * Platform.Width + 10, g.maxDown - 240));

            for (int i = 5 * Platform.Width; i < 8 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 280));
            }
            g.Platforms.Add(new Platform(9 * Platform.Width, g.maxDown - 400));
            g.Platforms.Add(new Platform(8 * Platform.Width, g.maxDown - 200));
            g.Snowflakes.Add(new Snowflake(9 * Platform.Width + 10, g.maxDown - 440));
            g.Snowflakes.Add(new Snowflake(8 * Platform.Width + 10, g.maxDown - 240));

            g.Enemies.Add(new Enemy(7 * Platform.Width, g.maxDown - 95 - Enemy.Height, 5 * Platform.Width, 8 * Platform.Width));

            for (int i = 10 * Platform.Width; i < 12 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 280));
            }


            for (int i = 1 * Platform.Width; i < 6 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 500));
            }
            Enemy a = new Enemy(5 * Platform.Width, g.maxDown - 500 - Enemy.Height, 1 * Platform.Width, 6 * Platform.Width);
            a.makeAdvancedEnemy();
            g.Enemies.Add(a);

            for (int i = g.maxDown - 500; i < g.maxDown - 280; i += Platform.Height)
            {
                g.Stairs.Add(new Stairs(2 * Platform.Width, i));
                if (i > g.maxDown - 480 && i < g.maxDown - 300)
                {
                    g.Snowflakes.Add(new Snowflake(1 * Platform.Width, i));
                    g.Snowflakes.Add(new Snowflake(5 * Platform.Width, i));
                }
            }

            for (int i = 12 * Platform.Width; i < g.maxRight - Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 400));
            }
            for (int i = g.maxDown - 360; i < g.maxDown - 110; i += Snowflake.Height + 20)
            {
                g.Snowflakes.Add(new Snowflake(g.maxRight - 2 * Platform.Width, i));
            }
            g.Enemies.Add(new Enemy(15 * Platform.Width, g.maxDown - 400 - Enemy.Height, 12 * Platform.Width, g.maxRight - Platform.Width));


            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player1 = new Player(50, g.maxDown - 200);
            g.Player2 = new Player(500, g.maxDown - 200);

            return g;
        }
        public static Game2Player getLevel3_2Player()
        {
            Game2Player g = new Game2Player(0, 600, 1000, 0);
            g.BACKGROUNDIMAGE = Resources.background2;
            g.LEVELID = 3;

            //PLATFORMS

            for (int i = 0; i <= g.maxRight - Platform.Width; i += 50)
            {
                if (i % 150 == 0)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 90));
                }
                else if (i % 150 < 75 && i <= 500)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 230));
                }
                if (i > 500)
                {
                    g.Snowflakes.Add(new Snowflake(i, g.maxDown - 440));
                    g.Platforms.Add(new Platform(i, g.maxDown - 400));
                }
                if (i > 180 && i < 450)
                {
                    g.Snowflakes.Add(new Snowflake(i, g.maxDown - 550));
                    g.Platforms.Add(new Platform(i, g.maxDown - 500));
                }

            }
            g.Platforms.Add(new Platform(0, g.maxDown - 430));
            //ENEMIES
            g.Enemies.Add(new Enemy(300, g.maxDown - 500 - Enemy.Height, 180, 450));
            Enemy e = new Enemy(550, g.maxDown - 400 - Enemy.Height, 500, g.maxRight);
            e.makeAdvancedEnemy();
            g.Enemies.Add(e);
            g.Enemies.Add(new Enemy(750, g.maxDown - 400 - Enemy.Height, 500, g.maxRight));

            for (int i = g.maxDown - 120; i > g.maxDown - 400; i -= Stairs.Height)
            {
                g.Stairs.Add(new Stairs(600, i));
            }
            //STAIRS


            //SNOWFLAKES
            for (int i = 0; i <= g.maxRight - Platform.Width; i += 50)
            {
                if (i % 150 == 0)
                {
                    g.Snowflakes.Add(new Snowflake(i + 10, g.maxDown - 130));
                }
                else if (i % 150 < 75 && i <= 500)
                {
                    g.Snowflakes.Add(new Snowflake(i + 10, g.maxDown - 270));
                }

            }
            g.Player1 = new Player(0, 100);
            g.Player2 = new Player(0, 300);
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;
            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            return g;
        }
        public static Game2Player getLevel4_2Player()
        {
            Game2Player g = new Game2Player(0, 600, 850, 0);
            g.BACKGROUNDIMAGE = Resources.background4;
            g.LEVELID = 4;

            for (int i = 0; i <= g.maxRight - Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                //g.Snowflakes.Add(new Snowflake(i, g.maxDown - 135));
            }
            //g.Enemies.Add(new Enemy(g.maxRight - 100, g.maxDown - 95 - Enemy.Height, 0, g.maxRight));
            for (int i = 2 * Platform.Width; i < 7 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 300));
                g.Platforms.Add(new Platform(i, g.maxDown - 500));
            }
            for (int i = 10 * Platform.Width; i < 15 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 300));
                g.Platforms.Add(new Platform(i, g.maxDown - 500));
            }
            Enemy x = new Enemy(5 * Platform.Width, g.maxDown - 500 - Enemy.Height, 2 * Platform.Width, 7 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(new Enemy(6 * Platform.Width, g.maxDown - 300 - Enemy.Height, 2 * Platform.Width, 7 * Platform.Width));
            g.Enemies.Add(x);

            x = new Enemy(10 * Platform.Width, g.maxDown - 300 - Enemy.Height, 10 * Platform.Width, 15 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);
            //g.Enemies.Add(new Enemy(13 * Platform.Width, g.maxDown - 500 - Enemy.Height, 10 * Platform.Width, 15 * Platform.Width));


            for (int i = g.maxUp + 40; i < g.maxDown - 200; i += Snowflake.Height + 30)
            {
                g.Snowflakes.Add(new Snowflake(1 * Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(8 * Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(9 * Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(16 * Platform.Width, i));

            }

            for (int i = g.maxDown - 500; i <= g.maxDown - 300; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(11 * Platform.Width, i));
            }
            for (int i = g.maxDown - 300; i <= g.maxDown - 100; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(5 * Platform.Width, i));
                g.Stairs.Add(new Stairs(14 * Platform.Width, i));
            }

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player1 = new Player(200, g.maxDown - 200);
            g.Player2 = new Player(300, g.maxDown - 200);

            return g;
        }
        public static Game2Player getLevel5_2Player()
        {
            Game2Player g = new Game2Player(0, 630, 900, 0);
            g.BACKGROUNDIMAGE = Resources.background5;
            g.LEVELID = 5;

            //PLATFORMS
            //1
            for (int i = 0; i <= g.maxRight - 50; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 90));
            }
            //2
            for (int i = g.maxLeft + Platform.Width; i <= g.maxLeft + 5 * Platform.Width; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 12 * Platform.Height - 3));
            }
            //3
            for (int i = g.maxLeft + 9 * Platform.Width; i <= g.maxLeft + 14 * Platform.Width; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 7 * Platform.Height - 5));
            }
            //4
            for (int i = g.maxLeft + Platform.Width; i <= g.maxLeft + 5 * Platform.Width; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 3 * Platform.Height - 3));
            }

            //5
            g.Platforms.Add(new Platform(g.maxLeft + 11 * Platform.Width, g.maxUp + 12 * Platform.Height));
            g.Platforms.Add(new Platform(g.maxLeft + 12 * Platform.Width, g.maxUp + 12 * Platform.Height));

            //6
            g.Platforms.Add(new Platform(g.maxLeft + 3 * Platform.Width, g.maxUp + 7 * Platform.Height));

            g.Platforms.Add(new Platform(g.maxRight - Platform.Width - 15, g.maxUp + 7 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxRight - Platform.Width - 5, g.maxUp + 7 * Platform.Height - 40));

            g.Platforms.Add(new Platform(g.maxRight - Platform.Width - 15, g.maxUp + 12 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxRight - Platform.Width - 5, g.maxUp + 12 * Platform.Height - 40));

            g.Platforms.Add(new Platform(g.maxRight - Platform.Width - 15, g.maxUp + 3 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxRight - Platform.Width - 5, g.maxUp + 3 * Platform.Height - 40));


            //STAIRS
            for (int i = g.maxDown - 90; i >= g.maxUp + 12 * Platform.Height; i -= 30)
            {
                //s1
                g.Stairs.Add(new Stairs(g.maxLeft + Platform.Width + 5, i));
                //s2
                g.Stairs.Add(new Stairs(g.maxLeft + 5 * Platform.Width - 5, i));
            }
            for (int i = g.maxDown - 90; i >= g.maxUp + 7 * Platform.Height; i -= 30)
            {
                //s3
                g.Stairs.Add(new Stairs(g.maxLeft + 14 * Platform.Width - 7, i));
            }


            //ENEMIES
            //e1           
            g.Enemies.Add(new Enemy(g.maxLeft + 3 * Platform.Width, g.maxUp + 12 * Platform.Height - 3 - Enemy.Height, g.maxLeft + Platform.Width, g.maxLeft + 6 * Platform.Width));
            //e2
            g.Enemies.Add(new Enemy(10 * Platform.Width, g.maxUp + 7 * Platform.Height - 5 - Enemy.Height, g.maxLeft + 9 * Platform.Width, g.maxLeft + 15 * Platform.Width));
            //e3
            Enemy e = new Enemy(5 * Platform.Width, g.maxUp + 3 * Platform.Height - 3 - Enemy.Height, g.maxLeft + Platform.Width, g.maxLeft + 6 * Platform.Width);
            e.makeAdvancedEnemy();
            g.Enemies.Add(e);


            //SNOWFLAKES
            //s3
            for (int i = g.maxDown - 120; i > g.maxUp + 7 * Platform.Height; i -= 40)
            {
                g.Snowflakes.Add(new Snowflake(g.maxLeft + 9 * Platform.Width + 7, i));
            }
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 11 * Platform.Width + 10, g.maxUp + 11 * Platform.Height - 5));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 12 * Platform.Width + 10, g.maxUp + 11 * Platform.Height - 5));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 10 + 12 * Platform.Width - Platform.Width / 2, g.maxUp + 10 * Platform.Height - 5));

            g.Snowflakes.Add(new Snowflake(g.maxLeft + 3 * Platform.Width + 10, g.maxUp + 6 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 3 * Platform.Width + 10, g.maxUp + 5 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 3 * Platform.Width + 10, g.maxUp + 4 * Platform.Height));

            for (int i = g.maxLeft + 9 * Platform.Width; i <= g.maxLeft + 14 * Platform.Width; i += 50)
            {
                g.Snowflakes.Add(new Snowflake(i, g.maxUp + 3 * Platform.Height - 5));
            }

            //PLAYER
            g.Player1 = new Player(150, g.maxDown - 90 - Player.Height);
            g.Player2 = new Player(g.maxLeft + 11 * Platform.Width, g.maxDown - 90 - Player.Height);

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            return g;
        }
        public static Game2Player getLevel6_2Player()
        {
            Game2Player g = new Game2Player(0, 600, 850, 0);
            g.BACKGROUNDIMAGE = Resources.background6;
            g.LEVELID = 6;

            //PLATFORMS

            for (int i = 0; i <= g.maxRight - Platform.Width; i += 50)
            {
                if (i >= 50 && i <= 250)
                {
                    g.Snowflakes.Add(new Snowflake(i, g.maxDown - 480));
                    g.Platforms.Add(new Platform(i, g.maxDown - 430));
                }
                if (i >= 300 && i <= 400) g.Platforms.Add(new Platform(i, g.maxDown - 270));
                if (i >= 500 && i <= 650)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 470));
                }
                if (i == 50 || i == 100 || i == 550 || i == 600) continue;
                g.Platforms.Add(new Platform(i, g.maxDown - 90));

            }
            g.Platforms.Add(new Platform(50, g.maxDown - 200));
            g.Platforms.Add(new Platform(100, g.maxDown - 310));
            g.Platforms.Add(new Platform(550, g.maxDown - 310));
            g.Platforms.Add(new Platform(600, g.maxDown - 200));
            g.Platforms.Add(new Platform(650, g.maxDown - 410));

            g.Platforms.Add(new Platform(g.maxRight-100, 260));
            g.Platforms.Add(new Platform(g.maxRight - 100, 400));

            //ENEMIES
            g.Enemies.Add(new Enemy(50, g.maxDown - 430 - Enemy.Height, 45, 310));
            g.Enemies.Add(new Enemy(300, g.maxDown - 270 - Enemy.Height, 290, 460));
            Enemy a = new Enemy(400, g.maxDown - 90 - Enemy.Height, 140, 560);
            a.makeAdvancedEnemy();
            g.Enemies.Add(a);
            //STAIRS


            //SNOWFLAKES
            g.Snowflakes.Add(new Snowflake(60, g.maxDown - 250));
            g.Snowflakes.Add(new Snowflake(110, g.maxDown - 360));
            g.Snowflakes.Add(new Snowflake(560, g.maxDown - 360));
            g.Snowflakes.Add(new Snowflake(610, g.maxDown - 250));
            g.Snowflakes.Add(new Snowflake(660, g.maxDown - 440));

            g.Snowflakes.Add(new Snowflake(500, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(540, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(580, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(620, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(660, g.maxDown - 510));

            g.Snowflakes.Add(new Snowflake(520, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(560, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(600, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(640, g.maxDown - 540));


            g.Player1 = new Player(200, 400);
            g.Player2 = new Player(230, 400);
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;
            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            return g;
        }
        public static Game2Player getLevel7_2Player()
        {
            Game2Player g = new Game2Player(0, 640, 900, 0);
            g.BACKGROUNDIMAGE = Resources.background8;
            g.LEVELID = 7;

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

            Enemy x = new Enemy(100,120-Enemy.Height,0,250);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            g.Enemies.Add(new Enemy(400, 145, 400, 750));

            g.Platforms = platforms;

            g.Player1 = new Player(200, 200);
            g.Player2 = new Player(260, 200);


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
            g.Snowflakes.Add(new Snowflake(70, 250));

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
        public static Game2Player getLevel8_2Player()
        {

            Game2Player g = new Game2Player(0, 600, 850, 0);
            g.BACKGROUNDIMAGE = Resources.background9;
            g.LEVELID = 8;

            for (int i = 0; i < 3 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 280));
            }
            g.Platforms.Add(new Platform(4 * Platform.Width, g.maxDown - 200));
            g.Snowflakes.Add(new Snowflake(4 * Platform.Width + 10, g.maxDown - 240));

            for (int i = 5 * Platform.Width; i < 8 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 280));
            }
            g.Platforms.Add(new Platform(9 * Platform.Width, g.maxDown - 400));
            g.Platforms.Add(new Platform(8 * Platform.Width, g.maxDown - 200));
            g.Snowflakes.Add(new Snowflake(9 * Platform.Width + 10, g.maxDown - 440));
            g.Snowflakes.Add(new Snowflake(8 * Platform.Width + 10, g.maxDown - 240));

            g.Enemies.Add(new Enemy(7 * Platform.Width, g.maxDown - 95 - Enemy.Height, 5 * Platform.Width, 8 * Platform.Width));

            for (int i = 10 * Platform.Width; i < 12 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 280));
            }


            for (int i = 1 * Platform.Width; i < 6 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 500));
            }
            Enemy a = new Enemy(5 * Platform.Width, g.maxDown - 500 - Enemy.Height, 1 * Platform.Width, 6 * Platform.Width);
            a.makeAdvancedEnemy();
            g.Enemies.Add(a);

            for (int i = g.maxDown - 500; i < g.maxDown - 280; i += Platform.Height)
            {
                g.Stairs.Add(new Stairs(2 * Platform.Width, i));
                if (i > g.maxDown - 480 && i < g.maxDown - 300)
                {
                    g.Snowflakes.Add(new Snowflake(1 * Platform.Width, i));
                    g.Snowflakes.Add(new Snowflake(5 * Platform.Width, i));
                }
            }

            for (int i = 12 * Platform.Width; i < g.maxRight - Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 400));
            }
            for (int i = g.maxDown - 360; i < g.maxDown - 110; i += Snowflake.Height + 20)
            {
                g.Snowflakes.Add(new Snowflake(g.maxRight - 2 * Platform.Width, i));
            }
            g.Enemies.Add(new Enemy(15 * Platform.Width, g.maxDown - 400 - Enemy.Height, 12 * Platform.Width, g.maxRight - Platform.Width));


            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player1 = new Player(50, g.maxDown - 200);
            g.Player2 = new Player(500, g.maxDown - 200);

            return g;
        }
        public static Game2Player getLevel9_2Player()
        {
            Game2Player g = new Game2Player(0, 600, 1000, 0);
            g.BACKGROUNDIMAGE = Resources.background4;
            g.LEVELID = 9;

            //PLATFORMS

            for (int i = 0; i <= g.maxRight - Platform.Width; i += 50)
            {
                if (i % 150 == 0)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 90));
                }
                else if (i % 150 < 75 && i <= 500)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 230));
                }
                if (i > 500)
                {
                    g.Snowflakes.Add(new Snowflake(i, g.maxDown - 440));
                    g.Platforms.Add(new Platform(i, g.maxDown - 400));
                }
                if (i > 180 && i < 450)
                {
                    g.Snowflakes.Add(new Snowflake(i, g.maxDown - 550));
                    g.Platforms.Add(new Platform(i, g.maxDown - 500));
                }

            }
            g.Platforms.Add(new Platform(0, g.maxDown - 430));
            //ENEMIES
            g.Enemies.Add(new Enemy(300, g.maxDown - 500 - Enemy.Height, 180, 450));
            Enemy e = new Enemy(550, g.maxDown - 400 - Enemy.Height, 500, g.maxRight);
            e.makeAdvancedEnemy();
            g.Enemies.Add(e);
            g.Enemies.Add(new Enemy(750, g.maxDown - 400 - Enemy.Height, 500, g.maxRight));

            for (int i = g.maxDown - 120; i > g.maxDown - 400; i -= Stairs.Height)
            {
                g.Stairs.Add(new Stairs(600, i));
            }
            //STAIRS


            //SNOWFLAKES
            for (int i = 0; i <= g.maxRight - Platform.Width; i += 50)
            {
                if (i % 150 == 0)
                {
                    g.Snowflakes.Add(new Snowflake(i + 10, g.maxDown - 130));
                }
                else if (i % 150 < 75 && i <= 500)
                {
                    g.Snowflakes.Add(new Snowflake(i + 10, g.maxDown - 270));
                }

            }
            g.Player1 = new Player(0, 100);
            g.Player2 = new Player(0, 300);
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;
            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            return g;
        }
        public static Game2Player getLevel10_2Player()
        {
            Game2Player g = new Game2Player(0, 600, 850, 0);
            g.BACKGROUNDIMAGE = Resources.background4;
            g.LEVELID = 10;

            for (int i = 0; i <= g.maxRight - Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Snowflakes.Add(new Snowflake(i, g.maxDown - 135));
            }
            //g.Enemies.Add(new Enemy(g.maxRight - 100, g.maxDown - 95 - Enemy.Height, 0, g.maxRight));
            for (int i = 2 * Platform.Width; i < 7 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 300));
                g.Platforms.Add(new Platform(i, g.maxDown - 500));
            }
            for (int i = 10 * Platform.Width; i < 15 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 300));
                g.Platforms.Add(new Platform(i, g.maxDown - 500));
            }
            Enemy x = new Enemy(5 * Platform.Width, g.maxDown - 500 - Enemy.Height, 2 * Platform.Width, 7 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(new Enemy(6 * Platform.Width, g.maxDown - 300 - Enemy.Height, 2 * Platform.Width, 7 * Platform.Width));
            g.Enemies.Add(x);

            x = new Enemy(10 * Platform.Width, g.maxDown - 300 - Enemy.Height, 10 * Platform.Width, 15 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);
            g.Enemies.Add(new Enemy(14 * Platform.Width, g.maxDown - 500 - Enemy.Height, 10 * Platform.Width, 15 * Platform.Width));
            //g.Enemies.Add(new Enemy(13 * Platform.Width, g.maxDown - 500 - Enemy.Height, 10 * Platform.Width, 15 * Platform.Width));


            for (int i = g.maxUp + 40; i < g.maxDown - 200; i += Snowflake.Height + 30)
            {
                g.Snowflakes.Add(new Snowflake(1 * Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(8 * Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(9 * Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(16 * Platform.Width, i));

            }

            for (int i = g.maxDown - 500; i <= g.maxDown - 300; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(11 * Platform.Width, i));
            }
            for (int i = g.maxDown - 300; i <= g.maxDown - 100; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(5 * Platform.Width, i));
                g.Stairs.Add(new Stairs(14 * Platform.Width, i));
            }

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player1 = new Player(200, g.maxDown - 200);
            g.Player2 = new Player(300, g.maxDown - 200);

            return g;
        }
        public static Game2Player getLevel11_2Player()
        {
            Game2Player g = new Game2Player(0, 630, 900, 0);
            g.BACKGROUNDIMAGE = Resources.DarkForest6;
            g.LEVELID = 11;

            //PLATFORMS
            //1
            for (int i = 0; i <= g.maxRight - 50; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 90));
            }
            g.Enemies.Add(new Enemy(g.maxRight-100, g.maxDown - 90-Enemy.Height, 0, g.maxRight));

            //2
            for (int i = g.maxLeft + Platform.Width; i <= g.maxLeft + 5 * Platform.Width; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 12 * Platform.Height - 3));
            }
            //3
            for (int i = g.maxLeft + 9 * Platform.Width; i <= g.maxLeft + 14 * Platform.Width; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 7 * Platform.Height - 5));
            }
            //4
            for (int i = g.maxLeft + Platform.Width; i <= g.maxLeft + 5 * Platform.Width; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 3 * Platform.Height - 3));
            }

            //5
            g.Platforms.Add(new Platform(g.maxLeft + 11 * Platform.Width, g.maxUp + 12 * Platform.Height));
            g.Platforms.Add(new Platform(g.maxLeft + 12 * Platform.Width, g.maxUp + 12 * Platform.Height));

            //6
            g.Platforms.Add(new Platform(g.maxLeft + 3 * Platform.Width, g.maxUp + 7 * Platform.Height));

            g.Platforms.Add(new Platform(g.maxRight - Platform.Width - 15, g.maxUp + 7 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxRight - Platform.Width - 5, g.maxUp + 7 * Platform.Height - 40));

            g.Platforms.Add(new Platform(g.maxRight - Platform.Width - 15, g.maxUp + 12 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxRight - Platform.Width - 5, g.maxUp + 12 * Platform.Height - 40));

            g.Platforms.Add(new Platform(g.maxRight - Platform.Width - 15, g.maxUp + 3 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxRight - Platform.Width - 5, g.maxUp + 3 * Platform.Height - 40));


            //STAIRS
            for (int i = g.maxDown - 90; i >= g.maxUp + 12 * Platform.Height; i -= 30)
            {
                //s1
                g.Stairs.Add(new Stairs(g.maxLeft + Platform.Width + 5, i));
                //s2
                g.Stairs.Add(new Stairs(g.maxLeft + 5 * Platform.Width - 5, i));
            }
            for (int i = g.maxDown - 90; i >= g.maxUp + 7 * Platform.Height; i -= 30)
            {
                //s3
                g.Stairs.Add(new Stairs(g.maxLeft + 14 * Platform.Width - 7, i));
            }


            //ENEMIES
            //e1           
            g.Enemies.Add(new Enemy(g.maxLeft + 3 * Platform.Width, g.maxUp + 12 * Platform.Height - 3 - Enemy.Height, g.maxLeft + Platform.Width, g.maxLeft + 6 * Platform.Width));
            //e2
            g.Enemies.Add(new Enemy(10 * Platform.Width, g.maxUp + 7 * Platform.Height - 5 - Enemy.Height, g.maxLeft + 9 * Platform.Width, g.maxLeft + 15 * Platform.Width));
            //e3
            Enemy e = new Enemy(5 * Platform.Width, g.maxUp + 3 * Platform.Height - 3 - Enemy.Height, g.maxLeft + Platform.Width, g.maxLeft + 6 * Platform.Width);
            e.makeAdvancedEnemy();
            g.Enemies.Add(e);


            //SNOWFLAKES
            //s3
            for (int i = g.maxDown - 120; i > g.maxUp + 7 * Platform.Height; i -= 40)
            {
                g.Snowflakes.Add(new Snowflake(g.maxLeft + 9 * Platform.Width + 7, i));
            }
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 11 * Platform.Width + 10, g.maxUp + 11 * Platform.Height - 5));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 12 * Platform.Width + 10, g.maxUp + 11 * Platform.Height - 5));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 10 + 12 * Platform.Width - Platform.Width / 2, g.maxUp + 10 * Platform.Height - 5));

            g.Snowflakes.Add(new Snowflake(g.maxLeft + 3 * Platform.Width + 10, g.maxUp + 6 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 3 * Platform.Width + 10, g.maxUp + 5 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 3 * Platform.Width + 10, g.maxUp + 4 * Platform.Height));

            for (int i = g.maxLeft + 9 * Platform.Width; i <= g.maxLeft + 14 * Platform.Width; i += 50)
            {
                g.Snowflakes.Add(new Snowflake(i, g.maxUp + 3 * Platform.Height - 5));
            }

            //PLAYER
            g.Player1 = new Player(150, g.maxDown - 90 - Player.Height);
            g.Player2 = new Player(g.maxLeft + 11 * Platform.Width, g.maxDown - 90 - Player.Height);

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            return g;
        }
        public static Game2Player getLevel12_2Player()
        {
            Game2Player g = new Game2Player(0, 600, 850, 0);
            g.BACKGROUNDIMAGE = Resources.background1;
            g.LEVELID = 6;

            //PLATFORMS

            for (int i = 0; i <= g.maxRight - Platform.Width; i += 50)
            {
                if (i >= 50 && i <= 250)
                {
                    g.Snowflakes.Add(new Snowflake(i, g.maxDown - 480));
                    g.Platforms.Add(new Platform(i, g.maxDown - 430));
                }
                if (i >= 300 && i <= 400) g.Platforms.Add(new Platform(i, g.maxDown - 270));
                if (i >= 500 && i <= 650)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 470));
                }
                if (i == 50 || i == 100 || i == 550 || i == 600) continue;
                g.Platforms.Add(new Platform(i, g.maxDown - 90));

            }
            g.Platforms.Add(new Platform(50, g.maxDown - 200));
            g.Platforms.Add(new Platform(100, g.maxDown - 310));
            g.Platforms.Add(new Platform(550, g.maxDown - 310));
            g.Platforms.Add(new Platform(600, g.maxDown - 200));
            g.Platforms.Add(new Platform(650, g.maxDown - 410));

            g.Platforms.Add(new Platform(g.maxRight - 100, 260));
            g.Platforms.Add(new Platform(g.maxRight - 100, 400));

            //ENEMIES
            g.Enemies.Add(new Enemy(50, g.maxDown - 430 - Enemy.Height, 45, 310));
            g.Enemies.Add(new Enemy(300, g.maxDown - 270 - Enemy.Height, 290, 460));
            Enemy a = new Enemy(400, g.maxDown - 90 - Enemy.Height, 140, 560);
            a.makeAdvancedEnemy();
            g.Enemies.Add(a);
            //STAIRS


            //SNOWFLAKES
            g.Snowflakes.Add(new Snowflake(60, g.maxDown - 250));
            g.Snowflakes.Add(new Snowflake(110, g.maxDown - 360));
            g.Snowflakes.Add(new Snowflake(560, g.maxDown - 360));
            g.Snowflakes.Add(new Snowflake(610, g.maxDown - 250));
            g.Snowflakes.Add(new Snowflake(660, g.maxDown - 440));

            g.Snowflakes.Add(new Snowflake(500, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(540, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(580, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(620, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(660, g.maxDown - 510));

            g.Snowflakes.Add(new Snowflake(520, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(560, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(600, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(640, g.maxDown - 540));


            g.Player1 = new Player(200, 400);
            g.Player2 = new Player(230, 400);
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;
            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            return g;
        }
        public static Game2Player getLevel13_2Player()
        {
            Game2Player g = new Game2Player(0, 700, 1000, 0);
            g.BACKGROUNDIMAGE = Resources.background5;
            g.LEVELID = 13;

            //PLATFORMS
            for (int i = 0; i <= g.maxRight - Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 90));
                g.Snowflakes.Add(new Snowflake(i, g.maxDown - 130));
            }
            g.Enemies.Add(new Enemy(g.maxRight - 100, g.maxDown - 90 - Enemy.Height, 0, g.maxRight));
            for (int i = 12 * Platform.Width; i <= g.maxRight - 2 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 300));
            }

            for (int i = Platform.Width; i <= 8 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 100));
            }

            for (int i = 3 * Platform.Width; i < 5 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 250));
                g.Platforms.Add(new Platform(i + 150, g.maxDown - 350));
                g.Platforms.Add(new Platform(i + 300, g.maxDown - 450));
            }
            for (int i = 15 * Platform.Width; i <= g.maxRight - Platform.Width; i += Platform.Width)
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
                g.Stairs.Add(new Stairs(17 * Platform.Width, i));
            }

            //ENEMIES
            g.Enemies.Add(new Enemy(4 * Platform.Width, g.maxUp + 100 - Enemy.Height, Platform.Width, 9 * Platform.Width));
            g.Enemies.Add(new Enemy(17 * Platform.Width, g.maxDown - 530 - Enemy.Height, 15 * Platform.Width, g.maxRight));
            Enemy e = new Enemy(14 * Platform.Width, g.maxDown - 300 - Enemy.Height, 12 * Platform.Width, g.maxRight - Platform.Width);
            e.makeAdvancedEnemy();
            g.Enemies.Add(e);

            //SNOWFLAKES
            for (int i = g.maxUp + 100; i <= g.maxDown - 150; i += Snowflake.Height + 30)
            {
                g.Snowflakes.Add(new Snowflake(5, i));
            }
            for (int i = 3 * Platform.Width - 10; i <= 5 * Platform.Width + 10; i += Snowflake.Width + 15)
            {
                g.Snowflakes.Add(new Snowflake(i, g.maxDown - 300));
                g.Snowflakes.Add(new Snowflake(i + 150, g.maxDown - 400));
                g.Snowflakes.Add(new Snowflake(i + 300, g.maxDown - 500));

            }
            for (int i = g.maxDown - 600; i < g.maxDown - 300; i += Snowflake.Height + 20)
            {
                g.Snowflakes.Add(new Snowflake(14 * Platform.Width, i));
            }


            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player1 = new Player(200, g.maxDown - 200);
            g.Player2 = new Player(250, g.maxDown - 200);

            return g;
        }
        public static Game2Player getSomeLevel_2Player()
        {
            Game2Player g = new Game2Player(0, 600, 730, 0);
            g.BACKGROUNDIMAGE = Resources.DarkForest6;
            g.LEVELID = 1;

            //PLATFORMS

            for (int i = 0; i <= g.maxRight - Platform.Width; i += 50)
            {
                if (i >= 50 && i <= 250)
                {
                    g.Snowflakes.Add(new Snowflake(i, g.maxDown - 480));
                    g.Platforms.Add(new Platform(i, g.maxDown - 430));
                }
                if (i >= 300 && i <= 400) g.Platforms.Add(new Platform(i, g.maxDown - 270));
                if (i >= 500 && i <= 650)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 470));
                }
                if (i == 50 || i == 100 || i == 550 || i == 600) continue;
                g.Platforms.Add(new Platform(i, g.maxDown - 90));

            }
            g.Platforms.Add(new Platform(50, g.maxDown - 200));
            g.Platforms.Add(new Platform(100, g.maxDown - 310));
            g.Platforms.Add(new Platform(550, g.maxDown - 310));
            g.Platforms.Add(new Platform(600, g.maxDown - 200));
            g.Platforms.Add(new Platform(650, g.maxDown - 410));

            //ENEMIES
            g.Enemies.Add(new Enemy(50, g.maxDown - 430 - Enemy.Height, 45, 310));
            g.Enemies.Add(new Enemy(300, g.maxDown - 270 - Enemy.Height, 290, 460));
            Enemy a = new Enemy(400, g.maxDown - 90 - Enemy.Height, 140, 560);
            a.makeAdvancedEnemy();
            g.Enemies.Add(a);
            //STAIRS


            //SNOWFLAKES
            g.Snowflakes.Add(new Snowflake(60, g.maxDown - 250));
            g.Snowflakes.Add(new Snowflake(110, g.maxDown - 360));
            g.Snowflakes.Add(new Snowflake(560, g.maxDown - 360));
            g.Snowflakes.Add(new Snowflake(610, g.maxDown - 250));
            g.Snowflakes.Add(new Snowflake(660, g.maxDown - 440));

            g.Snowflakes.Add(new Snowflake(500, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(540, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(580, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(620, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(660, g.maxDown - 510));

            g.Snowflakes.Add(new Snowflake(520, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(560, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(600, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(640, g.maxDown - 540));


            g.Player1 = new Player(200, 400);
            g.Player2 = new Player(230, 400);
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;
            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            return g;
        }
        public static Game2Player getLevel14_2Player()
        {
            Game2Player g = new Game2Player(0, 700, 900, 0);
            g.BACKGROUNDIMAGE = Resources.background6;
            g.LEVELID = 14;

            //PLATFORMS
            for (int i = 0; i <= g.maxRight - Platform.Width; i += Platform.Width)
            {
                if (i > 7 * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, 110));
                    g.Snowflakes.Add(new Snowflake(i, 20));
                    g.Snowflakes.Add(new Snowflake(i, 70));
                }
                if (i < 2 * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, 100));
                    g.Platforms.Add(new Platform(i, 610));
                    g.Snowflakes.Add(new Snowflake(i, 60));
                    g.Snowflakes.Add(new Snowflake(i, 570));
                }

                if (i < 6 * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, 250));
                    g.Snowflakes.Add(new Snowflake(i, 210));
                }
                if ((i < 2 * Platform.Width || i > 4 * Platform.Width) && i < 10 * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, 400));
                    g.Snowflakes.Add(new Snowflake(i, 360));
                }
                if (i < 14 * Platform.Width && i > 4 * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, 610));
                    g.Snowflakes.Add(new Snowflake(i, 570));
                }
                if (i > 13 * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, 470));
                }
            }
            g.Platforms.Add(new Platform(9 * Platform.Width, 250));
            g.Platforms.Add(new Platform(10 * Platform.Width, 250));
            g.Platforms.Add(new Platform(11 * Platform.Width, 250));
            g.Enemies.Add(new Enemy(10 * Platform.Width, 250 - Enemy.Height, 9 * Platform.Width, 12 * Platform.Width));

            Enemy x = new Enemy(300, 400 - Enemy.Height, 5 * Platform.Width, 10 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);
            x = new Enemy(600, 610 - Enemy.Height, 5 * Platform.Width, 14 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            x = new Enemy(500, 110 - Enemy.Height, 8 * Platform.Width, g.maxRight);
            x.Direction = Enemy.DIRECTION.LEFT;
            g.Enemies.Add(x);

            for (int i = 400; i < 610; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(20, i));
                if (i > 410 && i < 570)
                    g.Snowflakes.Add(new Snowflake(80, i));
            }

            for (int i = 120; i < 470; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(700, i));
                if (i > 150 && i < 450 && i % 20 == 0)
                    g.Snowflakes.Add(new Snowflake(770, i));
            }

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player1 = new Player(0, 0);
            g.Player2 = new Player(15*Platform.Width, 400);

            return g;
        }

        public static Game2Player getLevel15_2Player()
        {
            Game2Player g = new Game2Player(0, 600, 900, 0);
            g.BACKGROUNDIMAGE = Resources.winterImageNightBG;
            g.LEVELID = 15;

            //PLATFORMS

            for (int i = 0; i < g.maxRight; i += Platform.Width)
            {
                if (i > 1 * Platform.Width && i < 8 * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 90));
                    g.Platforms.Add(new Platform(i, g.maxDown - 260));
                    g.Platforms.Add(new Platform(i, g.maxDown - 430));

                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 130));
                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 300));
                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 470));
                }

                else if (i > 9 * Platform.Width && i < 16 * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 180));
                    g.Platforms.Add(new Platform(i, g.maxDown - 350));
                    g.Platforms.Add(new Platform(i, g.maxDown - 520));

                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 220));
                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 390));
                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 560));
                }
                if (i < Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 190));
                    g.Platforms.Add(new Platform(i, g.maxDown - 350));

                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 230));
                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 390));
                }
            }

            Enemy x = new Enemy(300, g.maxDown - 260 - Enemy.Height, 2 * Platform.Width, 8 * Platform.Width);
            x.Direction = Enemy.DIRECTION.LEFT;
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            x = new Enemy(200, g.maxDown - 430 - Enemy.Height, 2 * Platform.Width, 8 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            x = new Enemy(600, g.maxDown - 180 - Enemy.Height, 10 * Platform.Width, 16 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            x = new Enemy(600, g.maxDown - 350 - Enemy.Height, 10 * Platform.Width, 16 * Platform.Width);
            x.Direction = Enemy.DIRECTION.LEFT;
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            x = new Enemy(600, g.maxDown - 520 - Enemy.Height, 10 * Platform.Width, 16 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            g.Player1 = new Player(200, 400);
            g.Player2 = new Player(0, 300);
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;
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

            g.Enemies.Add(new Enemy(400, 145, 400, 750));

            //Enemy x = new Enemy(100,120-Enemy.Height,0,250);
            //x.makeAdvancedEnemy();
            //g.Enemies.Add(x);

            g.Platforms = platforms;

            g.Player = new Player(200, 200);

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
            g.Snowflakes.Add(new Snowflake(70, 250));

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
            Game g = new Game(0, 630, 800, 0);
            g.BACKGROUNDIMAGE = Resources.background1;
            g.LEVELID = 2;

            //PLATFORMS
            //1
            for (int i = 0; i <= g.maxRight - 50; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 90));
            }
            //2
            for (int i = g.maxLeft + Platform.Width; i <= g.maxLeft + 5 * Platform.Width; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 12 * Platform.Height - 3));
            }
            //3
            for (int i = g.maxLeft + 9 * Platform.Width; i <= g.maxLeft + 14 * Platform.Width; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 7 * Platform.Height - 5));
            }
            //4
            for (int i = g.maxLeft + Platform.Width; i <= g.maxLeft + 5 * Platform.Width; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 3 * Platform.Height - 3));
            }

            //5
            g.Platforms.Add(new Platform(g.maxLeft + 11 * Platform.Width, g.maxUp + 12 * Platform.Height));
            g.Platforms.Add(new Platform(g.maxLeft + 12 * Platform.Width, g.maxUp + 12 * Platform.Height));

            //6
            g.Platforms.Add(new Platform(g.maxLeft + 3 * Platform.Width, g.maxUp + 7 * Platform.Height));


            //STAIRS
            for (int i = g.maxDown - 90; i >= g.maxUp + 12 * Platform.Height; i -= 30)
            {
                //s1
                g.Stairs.Add(new Stairs(g.maxLeft + Platform.Width + 5, i));
                //s2
                g.Stairs.Add(new Stairs(g.maxLeft + 5 * Platform.Width - 5, i));
            }
            for (int i = g.maxDown - 90; i >= g.maxUp + 7 * Platform.Height; i -= 30)
            {
                //s3
                g.Stairs.Add(new Stairs(g.maxLeft + 14 * Platform.Width - 7, i));
            }


            //ENEMIES
            //e1           
            g.Enemies.Add(new Enemy(g.maxLeft + 3 * Platform.Width, g.maxUp + 12 * Platform.Height - 3 - Enemy.Height, g.maxLeft + Platform.Width, g.maxLeft + 6 * Platform.Width));
            //e2
            g.Enemies.Add(new Enemy(10 * Platform.Width, g.maxUp + 7 * Platform.Height - 5 - Enemy.Height, g.maxLeft + 9 * Platform.Width, g.maxLeft + 15 * Platform.Width));
            //e3

            Enemy e = new Enemy(5 * Platform.Width, g.maxUp + 3 * Platform.Height - 3 - Enemy.Height, g.maxLeft + Platform.Width, g.maxLeft + 6 * Platform.Width);
            //e.makeAdvancedEnemy();
            g.Enemies.Add(e);


            //SNOWFLAKES
            //s3
            for (int i = g.maxDown - 120; i > g.maxUp + 7 * Platform.Height; i -= 40)
            {
                g.Snowflakes.Add(new Snowflake(g.maxLeft + 9 * Platform.Width + 7, i));
            }
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 11 * Platform.Width + 10, g.maxUp + 11 * Platform.Height - 5));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 12 * Platform.Width + 10, g.maxUp + 11 * Platform.Height - 5));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 10 + 12 * Platform.Width - Platform.Width / 2, g.maxUp + 10 * Platform.Height - 5));

            g.Snowflakes.Add(new Snowflake(g.maxLeft + 3 * Platform.Width + 10, g.maxUp + 6 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 3 * Platform.Width + 10, g.maxUp + 5 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 3 * Platform.Width + 10, g.maxUp + 4 * Platform.Height));

            for (int i = g.maxLeft + 9 * Platform.Width; i <= g.maxLeft + 14 * Platform.Width; i += 50)
            {
                g.Snowflakes.Add(new Snowflake(i, g.maxUp + 3 * Platform.Height - 5));
            }

            //PLAYER
            g.Player = new Player(150, g.maxDown - 90 - Player.Height);


            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            return g;
        }
        public static Game getLevel3()
        {
            Game g = new Game(0, 600, 1000, 0);
            g.BACKGROUNDIMAGE = Resources.background2;
            g.LEVELID = 3;

            //PLATFORMS

            for (int i = 0; i <= g.maxRight - Platform.Width; i += 50)
            {
                if (i % 150 == 0)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 90));
                }
                else if (i % 150 < 75 && i <= 500)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 230));
                }
                if (i > 500)
                {
                    g.Snowflakes.Add(new Snowflake(i, g.maxDown - 440));
                    g.Platforms.Add(new Platform(i, g.maxDown - 400));
                }
                if (i > 180 && i < 450)
                {
                    g.Snowflakes.Add(new Snowflake(i, g.maxDown - 550));
                    g.Platforms.Add(new Platform(i, g.maxDown - 500));
                }

            }
            g.Platforms.Add(new Platform(0, g.maxDown - 430));
            //ENEMIES
            g.Enemies.Add(new Enemy(300, g.maxDown - 500 - Enemy.Height, 180, 450));
            Enemy e = new Enemy(550, g.maxDown - 400 - Enemy.Height, 500, g.maxRight);
            e.makeAdvancedEnemy();
            g.Enemies.Add(e);
            g.Enemies.Add(new Enemy(750, g.maxDown - 400 - Enemy.Height, 500, g.maxRight));

            for (int i = g.maxDown - 120; i > g.maxDown - 400; i -= Stairs.Height)
            {
                g.Stairs.Add(new Stairs(600, i));
            }
            //STAIRS


            //SNOWFLAKES
            for (int i = 0; i <= g.maxRight - Platform.Width; i += 50)
            {
                if (i % 150 == 0)
                {
                    g.Snowflakes.Add(new Snowflake(i + 10, g.maxDown - 130));
                }
                else if (i % 150 < 75 && i <= 500)
                {
                    g.Snowflakes.Add(new Snowflake(i + 10, g.maxDown - 270));
                }

            }
            g.Player = new Player(0, 100);
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;
            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            return g;
        }
        public static Game getLevel4()
        {
            Game g = new Game(0, 600, 800, 0);
            g.BACKGROUNDIMAGE = Resources.background4;
            g.LEVELID = 4;

            for (int i = 0; i <= g.maxRight - Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
            }
            for (int i = 2 * Platform.Width; i < 7 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 300));
                g.Platforms.Add(new Platform(i, g.maxDown - 500));
            }
            for (int i = 10 * Platform.Width; i < 15 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 300));
                g.Platforms.Add(new Platform(i, g.maxDown - 500));
            }
            Enemy x = new Enemy(5 * Platform.Width, g.maxDown - 500 - Enemy.Height, 2 * Platform.Width,7 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(new Enemy(6 * Platform.Width, g.maxDown - 300 - Enemy.Height, 2 * Platform.Width, 7 * Platform.Width));
            g.Enemies.Add(x);           
            
            x= new Enemy(10 * Platform.Width, g.maxDown - 300 - Enemy.Height, 10 * Platform.Width, 15 * Platform.Width);
            //x.makeAdvancedEnemy();
            g.Enemies.Add(x);
            //g.Enemies.Add(new Enemy(13 * Platform.Width, g.maxDown - 500 - Enemy.Height, 10 * Platform.Width, 15 * Platform.Width));
            

            for (int i = g.maxUp + 40; i < g.maxDown - 200; i += Snowflake.Height + 30)
            {
                g.Snowflakes.Add(new Snowflake(1*Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(8 * Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(9 * Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(16 * Platform.Width, i));

            }

            for (int i = g.maxDown - 500; i <= g.maxDown - 300; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(11 * Platform.Width, i));                
            }
            for (int i = g.maxDown - 300; i <= g.maxDown - 100; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(5 * Platform.Width, i));
                g.Stairs.Add(new Stairs(14 * Platform.Width, i));
            }

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player = new Player(200, g.maxDown - 200);

            return g;
        }
        public static Game getLevel5()
        {
            Game g = new Game(0, 600, 600, 0);
            g.BACKGROUNDIMAGE = Resources.background5;
            g.LEVELID = 5;

            for (int i = 0; i < 3*Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 280));
            }
            g.Platforms.Add(new Platform(4 * Platform.Width, g.maxDown - 200));
            g.Snowflakes.Add(new Snowflake(4 * Platform.Width+10, g.maxDown - 240));

            for (int i = 5* Platform.Width; i < 8* Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 280));
            }
            g.Platforms.Add(new Platform(9 * Platform.Width, g.maxDown - 400));
            g.Platforms.Add(new Platform(8 * Platform.Width, g.maxDown - 200));
            g.Snowflakes.Add(new Snowflake(9 * Platform.Width+10, g.maxDown - 440));
            g.Snowflakes.Add(new Snowflake(8 * Platform.Width+10, g.maxDown - 240));

            g.Enemies.Add(new Enemy(7 * Platform.Width, g.maxDown - 95 - Enemy.Height, 5 * Platform.Width, 8 * Platform.Width));

            for (int i = 10 * Platform.Width; i < 12 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 280));
            }


            for (int i = 1 * Platform.Width; i < 6 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 500));                
            }
            Enemy a = new Enemy(5 * Platform.Width, g.maxDown - 500 - Enemy.Height, 1 * Platform.Width, 6 * Platform.Width);
            a.makeAdvancedEnemy();
            g.Enemies.Add(a);

            for (int i = g.maxDown - 500; i < g.maxDown - 280; i += Platform.Height)
            {
                g.Stairs.Add(new Stairs(2*Platform.Width, i));
                if (i > g.maxDown - 480 && i < g.maxDown - 300)
                {
                    g.Snowflakes.Add(new Snowflake(1 * Platform.Width, i));
                    g.Snowflakes.Add(new Snowflake(5 * Platform.Width, i));
                }
            }
            
            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player = new Player(50, g.maxDown - 200);

            return g;
        }
        public static Game getLevel6()
        {
            Game g = new Game(0,600,730,0);
            g.BACKGROUNDIMAGE = Resources.background6;
            g.LEVELID = 6;

            //PLATFORMS

            for(int i = 0; i <= g.maxRight - Platform.Width; i += 50)
            {
                if (i >= 50 && i <= 250)
                {
                    g.Snowflakes.Add(new Snowflake(i, g.maxDown - 480));
                    g.Platforms.Add(new Platform(i, g.maxDown - 430));
                }
                if (i >= 300 && i <= 400) g.Platforms.Add(new Platform(i, g.maxDown - 270));
                if (i >= 500 && i <= 650)
                {                   
                    g.Platforms.Add(new Platform(i, g.maxDown - 470));
                }
                if (i == 50 || i == 100 || i==550 || i==600) continue;
                g.Platforms.Add(new Platform(i, g.maxDown-90));

            }
            g.Platforms.Add(new Platform(50, g.maxDown - 200));
            g.Platforms.Add(new Platform(100, g.maxDown - 310));
            g.Platforms.Add(new Platform(550, g.maxDown - 310));
            g.Platforms.Add(new Platform(600, g.maxDown - 200));
            g.Platforms.Add(new Platform(650, g.maxDown - 410));

            //ENEMIES
            g.Enemies.Add(new Enemy(50, g.maxDown - 430-Enemy.Height,45,310));
            g.Enemies.Add(new Enemy(300, g.maxDown - 270 - Enemy.Height, 290, 460));
            Enemy a = new Enemy(400, g.maxDown - 90 - Enemy.Height, 140,560);
            a.makeAdvancedEnemy();
            g.Enemies.Add(a);
            //STAIRS


            //SNOWFLAKES
            g.Snowflakes.Add(new Snowflake(60, g.maxDown - 250));
            g.Snowflakes.Add(new Snowflake(110, g.maxDown - 360));
            g.Snowflakes.Add(new Snowflake(560, g.maxDown - 360));
            g.Snowflakes.Add(new Snowflake(610, g.maxDown - 250));
            g.Snowflakes.Add(new Snowflake(660, g.maxDown - 440));

            g.Snowflakes.Add(new Snowflake(500, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(540, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(580, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(620, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(660, g.maxDown - 510));

            g.Snowflakes.Add(new Snowflake(520, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(560, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(600, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(640, g.maxDown - 540));
            

            g.Player = new Player(200, 200);
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;
            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            return g;
        }
        public static Game getLevel7()
        {
            Game g = new Game(0, 640, 900, 0);
            g.BACKGROUNDIMAGE = Resources.background8;
            g.LEVELID = 7;

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

            g.Enemies.Add(new Enemy(400, 145, 400, 750));

            Enemy x = new Enemy(100,120-Enemy.Height,0,250);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            g.Platforms = platforms;

            g.Player = new Player(200, 200);

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
            g.Snowflakes.Add(new Snowflake(70, 250));

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
        public static Game getLevel8()
        {
            Game g = new Game(0, 630, 800, 0);
            g.BACKGROUNDIMAGE = Resources.background9;
            g.LEVELID = 8;

            //PLATFORMS
            //1
            for (int i = 0; i <= g.maxRight - 50; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 90));
            }
            //2
            for (int i = g.maxLeft + Platform.Width; i <= g.maxLeft + 5 * Platform.Width; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 12 * Platform.Height - 3));
            }
            //3
            for (int i = g.maxLeft + 9 * Platform.Width; i <= g.maxLeft + 14 * Platform.Width; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 7 * Platform.Height - 5));
            }
            //4
            for (int i = g.maxLeft + Platform.Width; i <= g.maxLeft + 5 * Platform.Width; i += 50)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 3 * Platform.Height - 3));
            }

            //5
            g.Platforms.Add(new Platform(g.maxLeft + 11 * Platform.Width, g.maxUp + 12 * Platform.Height));
            g.Platforms.Add(new Platform(g.maxLeft + 12 * Platform.Width, g.maxUp + 12 * Platform.Height));

            //6
            g.Platforms.Add(new Platform(g.maxLeft + 3 * Platform.Width, g.maxUp + 7 * Platform.Height));


            //STAIRS
            for (int i = g.maxDown - 90; i >= g.maxUp + 12 * Platform.Height; i -= 30)
            {
                //s1
                g.Stairs.Add(new Stairs(g.maxLeft + Platform.Width + 5, i));
                //s2
                g.Stairs.Add(new Stairs(g.maxLeft + 5 * Platform.Width - 5, i));
            }
            for (int i = g.maxDown - 90; i >= g.maxUp + 7 * Platform.Height; i -= 30)
            {
                //s3
                g.Stairs.Add(new Stairs(g.maxLeft + 14 * Platform.Width - 7, i));
            }


            //ENEMIES
            //e1           
            g.Enemies.Add(new Enemy(g.maxLeft + 3 * Platform.Width, g.maxUp + 12 * Platform.Height - 3 - Enemy.Height, g.maxLeft + Platform.Width, g.maxLeft + 6 * Platform.Width));
            //e2
            g.Enemies.Add(new Enemy(10 * Platform.Width, g.maxUp + 7 * Platform.Height - 5 - Enemy.Height, g.maxLeft + 9 * Platform.Width, g.maxLeft + 15 * Platform.Width));
            //e3

            Enemy e = new Enemy(5 * Platform.Width, g.maxUp + 3 * Platform.Height - 3 - Enemy.Height, g.maxLeft + Platform.Width, g.maxLeft + 6 * Platform.Width);
            e.makeAdvancedEnemy();
            g.Enemies.Add(e);


            //SNOWFLAKES
            //s3
            for (int i = g.maxDown - 120; i > g.maxUp + 7 * Platform.Height; i -= 40)
            {
                g.Snowflakes.Add(new Snowflake(g.maxLeft + 9 * Platform.Width + 7, i));
            }
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 11 * Platform.Width + 10, g.maxUp + 11 * Platform.Height - 5));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 12 * Platform.Width + 10, g.maxUp + 11 * Platform.Height - 5));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 10 + 12 * Platform.Width - Platform.Width / 2, g.maxUp + 10 * Platform.Height - 5));

            g.Snowflakes.Add(new Snowflake(g.maxLeft + 3 * Platform.Width + 10, g.maxUp + 6 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 3 * Platform.Width + 10, g.maxUp + 5 * Platform.Height));
            g.Snowflakes.Add(new Snowflake(g.maxLeft + 3 * Platform.Width + 10, g.maxUp + 4 * Platform.Height));

            for (int i = g.maxLeft + 9 * Platform.Width; i <= g.maxLeft + 14 * Platform.Width; i += 50)
            {
                g.Snowflakes.Add(new Snowflake(i, g.maxUp + 3 * Platform.Height - 5));
            }

            //PLAYER
            g.Player = new Player(150, g.maxDown - 90 - Player.Height);


            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            return g;
        }
        public static Game getLevel9()
        {
            Game g = new Game(0, 600, 1000, 0);
            g.BACKGROUNDIMAGE = Resources.background4;
            g.LEVELID = 9;

            //PLATFORMS

            for (int i = 0; i <= g.maxRight - Platform.Width; i += 50)
            {
                if (i % 150 == 0)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 90));
                }
                else if (i % 150 < 75 && i <= 500)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 230));
                }
                if (i > 500)
                {
                    g.Snowflakes.Add(new Snowflake(i, g.maxDown - 440));
                    g.Platforms.Add(new Platform(i, g.maxDown - 400));
                }
                if (i > 180 && i < 450)
                {
                    g.Snowflakes.Add(new Snowflake(i, g.maxDown - 550));
                    g.Platforms.Add(new Platform(i, g.maxDown - 500));
                }

            }
            g.Platforms.Add(new Platform(0, g.maxDown - 430));
            //ENEMIES
            g.Enemies.Add(new Enemy(300, g.maxDown - 500 - Enemy.Height, 180, 450));
            Enemy e = new Enemy(550, g.maxDown - 400 - Enemy.Height, 500, g.maxRight);
            e.makeAdvancedEnemy();
            g.Enemies.Add(e);
            e = new Enemy(750, g.maxDown - 400 - Enemy.Height, 500, g.maxRight);
            e.makeAdvancedEnemy();
            g.Enemies.Add(e);

            for (int i = g.maxDown - 120; i > g.maxDown - 400; i -= Stairs.Height)
            {
                g.Stairs.Add(new Stairs(600, i));
            }
            //STAIRS


            //SNOWFLAKES
            for (int i = 0; i <= g.maxRight - Platform.Width; i += 50)
            {
                if (i % 150 == 0)
                {
                    g.Snowflakes.Add(new Snowflake(i + 10, g.maxDown - 130));
                }
                else if (i % 150 < 75 && i <= 500)
                {
                    g.Snowflakes.Add(new Snowflake(i + 10, g.maxDown - 270));
                }

            }
            g.Player = new Player(0, 100);
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;
            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            return g;
        }
        public static Game getLevel10()
        {
            Game g = new Game(0, 600, 800, 0);
            g.BACKGROUNDIMAGE = Resources.background6;
            g.LEVELID = 10;

            for (int i = 0; i <= g.maxRight - Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Snowflakes.Add(new Snowflake(i, g.maxDown - 135));

            }
            g.Enemies.Add(new Enemy(g.maxRight-100, g.maxDown - 95 - Enemy.Height, 0, g.maxRight));

            for (int i = 2 * Platform.Width; i < 7 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 300));
                g.Platforms.Add(new Platform(i, g.maxDown - 500));
            }
            for (int i = 10 * Platform.Width; i < 15 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 300));
                g.Platforms.Add(new Platform(i, g.maxDown - 500));
            }
            Enemy x = new Enemy(5 * Platform.Width, g.maxDown - 500 - Enemy.Height, 2 * Platform.Width, 7 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(new Enemy(6 * Platform.Width, g.maxDown - 300 - Enemy.Height, 2 * Platform.Width, 7 * Platform.Width));
            g.Enemies.Add(x);

            x = new Enemy(10 * Platform.Width, g.maxDown - 300 - Enemy.Height, 10 * Platform.Width, 15 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);
            g.Enemies.Add(new Enemy(13 * Platform.Width, g.maxDown - 500 - Enemy.Height, 10 * Platform.Width, 15 * Platform.Width));


            for (int i = g.maxUp + 40; i < g.maxDown - 200; i += Snowflake.Height + 30)
            {
                g.Snowflakes.Add(new Snowflake(1 * Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(8 * Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(9 * Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(16 * Platform.Width, i));

            }

            for (int i = g.maxDown - 500; i <= g.maxDown - 300; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(11 * Platform.Width, i));
            }
            for (int i = g.maxDown - 300; i <= g.maxDown - 100; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(5 * Platform.Width, i));
                g.Stairs.Add(new Stairs(14 * Platform.Width, i));
            }

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player = new Player(200, g.maxDown - 200);

            return g;
        }
        public static Game getLevel11()
        {
            Game g = new Game(0, 600, 600, 0);
            g.BACKGROUNDIMAGE = Resources.DarkForest6;
            g.LEVELID = 11;

            for (int i = 0; i < 3 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 280));
            }
            g.Platforms.Add(new Platform(4 * Platform.Width, g.maxDown - 200));
            g.Snowflakes.Add(new Snowflake(4 * Platform.Width + 10, g.maxDown - 240));

            for (int i = 5 * Platform.Width; i < 8 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 280));
            }
            g.Platforms.Add(new Platform(9 * Platform.Width, g.maxDown - 400));
            g.Platforms.Add(new Platform(8 * Platform.Width, g.maxDown - 200));
            g.Snowflakes.Add(new Snowflake(9 * Platform.Width + 10, g.maxDown - 440));
            g.Snowflakes.Add(new Snowflake(8 * Platform.Width + 10, g.maxDown - 240));

            Enemy e = new Enemy(7 * Platform.Width, g.maxDown - 95 - Enemy.Height, 5 * Platform.Width, 8 * Platform.Width);
            e.makeAdvancedEnemy();
            g.Enemies.Add(e);

            for (int i = 10 * Platform.Width; i < 12 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 95));
                g.Platforms.Add(new Platform(i, g.maxDown - 280));
            }


            for (int i = 1 * Platform.Width; i < 6 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 500));
            }
            Enemy a = new Enemy(5 * Platform.Width, g.maxDown - 500 - Enemy.Height, 1 * Platform.Width, 6 * Platform.Width);
            a.makeAdvancedEnemy();
            g.Enemies.Add(a);

            for (int i = g.maxDown - 500; i < g.maxDown - 280; i += Platform.Height)
            {
                g.Stairs.Add(new Stairs(2 * Platform.Width, i));
                if (i > g.maxDown - 480 && i < g.maxDown - 300)
                {
                    g.Snowflakes.Add(new Snowflake(1 * Platform.Width, i));
                    g.Snowflakes.Add(new Snowflake(5 * Platform.Width, i));
                }
            }

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player = new Player(50, g.maxDown - 200);

            return g;
        }
        public static Game getLevel12()
        {
            Game g = new Game(0, 600, 730, 0);
            g.BACKGROUNDIMAGE = Resources.background1;
            g.LEVELID = 12;

            //PLATFORMS

            for (int i = 0; i <= g.maxRight - Platform.Width; i += 50)
            {
                if (i >= 50 && i <= 250)
                {
                    g.Snowflakes.Add(new Snowflake(i, g.maxDown - 480));
                    g.Platforms.Add(new Platform(i, g.maxDown - 430));
                }
                if (i >= 300 && i <= 400) g.Platforms.Add(new Platform(i, g.maxDown - 270));
                if (i >= 500 && i <= 650)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 470));
                }
                if (i == 50 || i == 100 || i == 550 || i == 600) continue;
                g.Platforms.Add(new Platform(i, g.maxDown - 90));

            }
            g.Platforms.Add(new Platform(50, g.maxDown - 200));
            g.Platforms.Add(new Platform(100, g.maxDown - 310));
            g.Platforms.Add(new Platform(550, g.maxDown - 310));
            g.Platforms.Add(new Platform(600, g.maxDown - 200));
            g.Platforms.Add(new Platform(650, g.maxDown - 410));

            //ENEMIES
            Enemy e = new Enemy(50, g.maxDown - 430 - Enemy.Height, 45, 310);
            e.makeAdvancedEnemy();
            g.Enemies.Add(e);
            g.Enemies.Add(new Enemy(300, g.maxDown - 270 - Enemy.Height, 290, 460));
            Enemy a = new Enemy(400, g.maxDown - 90 - Enemy.Height, 140, 560);
            a.makeAdvancedEnemy();
            g.Enemies.Add(a);
            //STAIRS


            //SNOWFLAKES
            g.Snowflakes.Add(new Snowflake(60, g.maxDown - 250));
            g.Snowflakes.Add(new Snowflake(110, g.maxDown - 360));
            g.Snowflakes.Add(new Snowflake(560, g.maxDown - 360));
            g.Snowflakes.Add(new Snowflake(610, g.maxDown - 250));
            g.Snowflakes.Add(new Snowflake(660, g.maxDown - 440));

            g.Snowflakes.Add(new Snowflake(500, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(540, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(580, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(620, g.maxDown - 510));
            g.Snowflakes.Add(new Snowflake(660, g.maxDown - 510));

            g.Snowflakes.Add(new Snowflake(520, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(560, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(600, g.maxDown - 540));
            g.Snowflakes.Add(new Snowflake(640, g.maxDown - 540));


            g.Player = new Player(200, 200);
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;
            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            return g;
        }

        public static Game getLevel13()
        {
            Game g = new Game(0, 700, 1000, 0);
            g.BACKGROUNDIMAGE = Resources.background5;
            g.LEVELID = 13;

            //PLATFORMS
            for (int i = 0; i <= g.maxRight - Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 90));
                g.Snowflakes.Add(new Snowflake(i, g.maxDown - 130));
            }
            g.Enemies.Add(new Enemy(g.maxRight-100,g.maxDown-90-Enemy.Height,0,g.maxRight));
            for (int i = 12 * Platform.Width; i <= g.maxRight - 2 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 300));
            }

            for (int i = Platform.Width; i <= 8 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxUp + 100));
            }

            for (int i = 3 * Platform.Width; i < 5 * Platform.Width; i += Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown - 250));
                g.Platforms.Add(new Platform(i + 150, g.maxDown - 350));
                g.Platforms.Add(new Platform(i + 300, g.maxDown - 450));
            }
            for (int i = 15 * Platform.Width; i <= g.maxRight - Platform.Width; i += Platform.Width)
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
                g.Stairs.Add(new Stairs(17 * Platform.Width, i));
            }

            //ENEMIES
            g.Enemies.Add(new Enemy(4 * Platform.Width, g.maxUp + 100 - Enemy.Height, Platform.Width, 9 * Platform.Width));
            g.Enemies.Add(new Enemy(17 * Platform.Width, g.maxDown - 530 - Enemy.Height, 15 * Platform.Width, g.maxRight));
            Enemy e = new Enemy(14 * Platform.Width, g.maxDown - 300 - Enemy.Height, 12 * Platform.Width, g.maxRight - Platform.Width);
            e.makeAdvancedEnemy();
            g.Enemies.Add(e);

            //SNOWFLAKES
            for (int i = g.maxUp + 100; i <= g.maxDown - 150; i += Snowflake.Height + 30)
            {
                g.Snowflakes.Add(new Snowflake(5, i));
            }
            for (int i = 3 * Platform.Width - 10; i <= 5 * Platform.Width + 10; i += Snowflake.Width + 15)
            {
                g.Snowflakes.Add(new Snowflake(i, g.maxDown - 300));
                g.Snowflakes.Add(new Snowflake(i + 150, g.maxDown - 400));
                g.Snowflakes.Add(new Snowflake(i + 300, g.maxDown - 500));

            }
            for (int i = g.maxDown - 600; i < g.maxDown - 300; i += Snowflake.Height + 20)
            {
                g.Snowflakes.Add(new Snowflake(14 * Platform.Width, i));
            }


            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player = new Player(200, g.maxDown - 200);

            return g;
        }

        public static Game getLevel14()
        {
            Game g = new Game(0, 700, 900, 0);
            g.BACKGROUNDIMAGE = Resources.background6;
            g.LEVELID = 14;

            //PLATFORMS
            for (int i = 0; i <= g.maxRight - Platform.Width; i += Platform.Width)
            {
                if(i> 7 * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, 110));
                    g.Snowflakes.Add(new Snowflake(i, 20));
                    g.Snowflakes.Add(new Snowflake(i, 70));
                }
                if (i < 2 * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, 100));
                    g.Platforms.Add(new Platform(i, 610));
                    g.Snowflakes.Add(new Snowflake(i, 60));
                    g.Snowflakes.Add(new Snowflake(i, 570));
                }

                if (i < 6 * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, 250));
                    g.Snowflakes.Add(new Snowflake(i,210));
                }
                if ((i < 2 * Platform.Width || i>4*Platform.Width) && i< 10* Platform.Width)
                {                    
                    g.Platforms.Add(new Platform(i, 400));
                    g.Snowflakes.Add(new Snowflake(i, 360));
                }
                if (i < 14 * Platform.Width && i> 4*Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, 610));
                    g.Snowflakes.Add(new Snowflake(i, 570));
                }
                if (i > 13 * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i,470));
                }
            }
            g.Platforms.Add(new Platform(9*Platform.Width, 250));
            g.Platforms.Add(new Platform(10 * Platform.Width, 250));
            g.Platforms.Add(new Platform(11 * Platform.Width, 250));
            g.Enemies.Add(new Enemy(10 * Platform.Width,250-Enemy.Height, 9 * Platform.Width, 12 * Platform.Width));

            Enemy x = new Enemy(300, 400 - Enemy.Height, 5 * Platform.Width, 10 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);
            x = new Enemy(600, 610 - Enemy.Height, 5 * Platform.Width, 14 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            x = new Enemy(500, 110 - Enemy.Height, 8 * Platform.Width, g.maxRight);
            x.Direction = Enemy.DIRECTION.LEFT;
            g.Enemies.Add(x);

            for(int i = 400; i < 610; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(20,i));
                if(i>410 && i<570)
                g.Snowflakes.Add(new Snowflake(80, i));
            }

            for (int i = 120; i < 470; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(700, i));
                if(i>150 && i< 450 && i%20==0)
                g.Snowflakes.Add(new Snowflake(770, i));
            }

            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;

            g.Player = new Player(0,0);

            return g;
        }

        public static Game getLevel15()
        {
            Game g = new Game(0, 600, 900, 0);
            g.BACKGROUNDIMAGE = Resources.winterImageNightBG;
            g.LEVELID = 15;

            //PLATFORMS

            for (int i = 0; i <g.maxRight; i += Platform.Width)
            {
                if (i > 1 * Platform.Width && i < 8  * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 90));
                    g.Platforms.Add(new Platform(i, g.maxDown - 260));
                    g.Platforms.Add(new Platform(i, g.maxDown - 430));

                    g.Snowflakes.Add(new Snowflake(i+15, g.maxDown - 130));
                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 300));
                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 470));
                }

                else if(i>9*Platform.Width && i< 16 * Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 180));
                    g.Platforms.Add(new Platform(i, g.maxDown - 350));
                    g.Platforms.Add(new Platform(i, g.maxDown - 520));

                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 220));
                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 390));
                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 560));
                }
                if (i < Platform.Width)
                {
                    g.Platforms.Add(new Platform(i, g.maxDown - 190));
                    g.Platforms.Add(new Platform(i, g.maxDown - 350));

                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 230));
                    g.Snowflakes.Add(new Snowflake(i + 15, g.maxDown - 390));
                }
            }

            Enemy x = new Enemy(300, g.maxDown - 260-Enemy.Height, 2 * Platform.Width, 8 * Platform.Width);
            x.Direction = Enemy.DIRECTION.LEFT;
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            x = new Enemy(200, g.maxDown - 430 - Enemy.Height, 2 * Platform.Width, 8 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            x = new Enemy(600, g.maxDown - 180 - Enemy.Height, 10 * Platform.Width, 16 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            x = new Enemy(600, g.maxDown - 350 - Enemy.Height, 10 * Platform.Width, 16 * Platform.Width);
            x.Direction = Enemy.DIRECTION.LEFT;
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            x = new Enemy(600, g.maxDown - 520 - Enemy.Height, 10 * Platform.Width, 16 * Platform.Width);
            x.makeAdvancedEnemy();
            g.Enemies.Add(x);

            g.Player = new Player(200, 400);
            g.TOTALITEMSTOFREEZE = g.Stairs.Count + g.Platforms.Count;
            g.TOTALSNOWFLAKES = g.Snowflakes.Count;
            return g;
        }


    }
}
