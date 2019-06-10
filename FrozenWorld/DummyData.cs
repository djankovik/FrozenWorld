﻿using FrozenWorld.Properties;
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
                case 2: return getLevel2();
                default: return getLevel1();
            }
        }
        public static Game getLevel1()
        {
            Game g = new Game(0,640,800,0);
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
        public static Game getLevel2()
        {
            Game g = new Game(0, 800, 1200, 0);
            g.BACKGROUNDIMAGE = Resources.winterImageNightBG;
            g.LEVELID = 2;

           for (int i=0;i<g.maxRight-Platform.Width;i+= Platform.Width)
            {
                g.Platforms.Add(new Platform(i, g.maxDown-100));
            }
            for (int i = 3*Platform.Width; i < 10*Platform.Width; i += Platform.Width)
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

                g.Enemies.Add(new Enemy(16 * Platform.Width, g.maxDown - 300 - Enemy.Height, 15 * Platform.Width, 23 * Platform.Width));
                g.Enemies.Add(new Enemy(18 * Platform.Width, g.maxDown - 500 - Enemy.Height, 15 * Platform.Width, 23 * Platform.Width));
                g.Enemies.Add(new Enemy(20 * Platform.Width, g.maxDown - 700 - Enemy.Height, 15 * Platform.Width, 23 * Platform.Width));

            }

            
            for (int i = g.maxUp + 40; i < g.maxDown - 200;i+=Snowflake.Height+50)
            {
                g.Snowflakes.Add(new Snowflake(11*Platform.Width, i));
                g.Snowflakes.Add(new Snowflake(14 * Platform.Width, i));
            }

            for (int i = g.maxDown - 700; i <= g.maxDown - 500; i += Stairs.Height)
            {
                g.Stairs.Add(new Stairs(7*Platform.Width, i));
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
    }
}