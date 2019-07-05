# <img src="https://github.com/djankovik/FrozenWorld/blob/master/FrozenWorld/Resources/Snowflake1.jpg" alt="icon" width="25px"/> FrozenWorld 
### изработила Душица Јанковиќ 161509

## Опис на играта

Frozen World е платформска игра. Идејата потекнува од играта [Jack Frost]( http://www.nitrome.com/games/jackfrost/#.XRno5-j_xPa) од Nitrome. Во мојата имплементација на играта постои можност за single player и multiplayer игра.

#### Gameplay
Главната цел на играта е да се замрзнат сите платформи и скали. Секој левел започнува со незамрзнати блокови - црвени платформи и скали стратешки поставени на различни места на екранот. Играчот го контролира својот аватар и замрзнува блокови од играта така што оди/претрчува врз нив. Левелот е освоен и може да се продолжи на следниот кога секој видлив блок е замрзнат.

#### Движење
Играчот може да се движи на пет начина: горе и долу (по скалите), лево, десно и може да скока. Иницијално постојат default  контроли за играчот, но тие, како и аватарот на играчот можат да бидат променети во Settings.

#### Непријатели
Во секој левел има неколку неуништливи непријатели. Тие го отежнуваат движењето на играчот бидејќи при допир на непријател играчот губи од своите животи. Играчот може привремено да ги онеспособи непријателите така што ќе ги замрзне со скокање врз нив и со тоа ќе го оневозможи нивното движење. Замрзнат непријател не му прави никаква штета на играчот - не одзема од неговите животи. За определено време секој непријател се одмрзнува и продолжува со својата нормална функција. Кога не се замрзнати неријателите можат се движат лево и десно врз платформите, но не можат да се движат по скалите. Постојат два вида на непријатели, обични и advanced, а единствената разлика е тоа што при одмрзнување advanced непријателите блујат оган и одмрзнуваат неколку блокови во нивната непосредна околина.
Освен заради непријатели, играчот може да ја загуби играта и доколку падне во дупка помеѓу платформите. Ваков пад ги одзема сите животи на играчот.

#### Снегулки
Снегулките во играта се поставени на различни места во секое ниво. Тие не се задолжителни за победа на нивото, но се корисни за освојување на повеќе бодови – а со тоа и искачување повисоко на scoreboard-от. Играчот собира снегулки така што доаѓа во допир со нив.

## Имплементација

#### Класи
Секој корисник кој сака да ја игра оваа игра мора да внесе корисничко име пред да продолжи понатаму. Ова овозможува водење на евиденција за тоа кои играчи ја играле играта во минатото и зачувување на нивните резултати. Секој корисник е објект од класата `User.cs`. Класата User e [Serializable]. Објектите од оваа класа во бинарен формат се запишуваат на default локација одредена од следната линија код: 
```csharp
public readonly string PATH = @"%USERPROFILE%\Documents\FrozenWorldUserData";  
````
- Запишување на објект од класа User на преодредената локација со екстенција .fwuser се остварува со функцијата SaveFile.
```charp
 public void SaveFile()
        {
            string fileName = User.UserName;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = File.Create($@"{PATH}\{fileName}.fwuser"))
                formatter.Serialize(file, User);
        }
```
- При Login на корисник кој веќе игра, истиот се чита од меморија со OpenFile.
```csharp
public void OpenFile(string fileName)
        {
            if (fileName != null)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream file = File.OpenRead($@"{PATH}\{fileName}.fwuser"))
                    User = (User)formatter.Deserialize(file);
            }
        }
```
Секое ниво на од оваа игра, во кое што се случува контролата на аватарот (играчот) од страна на корисникот, интеракцијата со непријателите, замрзнувањето на блоковите и собирање на снегулките, претставува нова инстанца од класата `Game.cs`.

За игра со два играчи се користат објекти од класата `Game2Player.cs`.

Секој елемент од играта (game item) е имплементиран со посебна класа:
- Сите потребни податоци и функции за сосtојбата и позицијата на играчот на екранот се претставени преку класата `Player.cs`.
- Блоковите кои можат да се замрзнуваат (платформи и скали) се имплементирани со класите `Platform.cs` и `Stairs.cs` соодветно.
- Сите непријатели се инстанци од класата `Enemy.cs`. Advanced непријателите се претставени со истата `Enemy.cs` класа, но дистинкцијата доаѓа зависно од boolean варијабла ```bool isAdvanced```.

- Снегулките кои го подобруваат постоечкиот резултат на корисникот се репрезентирани со класата `Snowflake.cs`.
- Класата `DummyData.cs` e генератор на левели. Со податоците во оваа класа се полни game атрибутот во формите кои се однесуваат на играње на определено ниво.

#### Forms
Секој прозорец од оваа игра е претставен со различен Windows Form.

Почетниот екран од играта е страната за Log In - `StartLoginPage.cs`. Тука корисникот може да се регистрира доколку прв пат ја игра играта, или пак да внесе корисничко име со кое веќе играл и да ја продолжи играта од каде што застанал. При регистрирање на корисник тој добива шанса да одбере дали ќе игра во single player или two player mode. На екранот за Log In освен копчињата за Start или Continue (се ажурираат зависно од внесеното корисничко име во полето за username), понудено е мени за лесен пристап до Scoreboard страната и About страната.

По внесување на корисничко име на Log In страната и кликање на опцијата за започнување или продолжување на играта се отвара нов прозорец каде што корисникот може да одбере кој левел сака да го игра. Овој преглед е формата `LevelChooserForm.cs` и во неа се излистани сите нивоа од играта. Во зависност од предходните успеси на играчот во играта некои нивоа се отклучени, додека некои се заклучени и можат да се отклучат доколку играчот ги освои сите предходни нивоа. Освен нивоата, на оваа форма во горниот десен агол има копче Settings со чив клик се отвара форма `SettingsPage.cs`.

`SettingsPage.cs` е форма која му нуди на корисникот увид во моменталниот избор за аватар, како и за контроли со кои се движи играчот. Доколку сака, корисникот може да ги смени контролите како што ќе посака и да одбере некој од понудените аватари. Промена на контролите се врши со притискање на посакувано копче од тастатурата додека курсорот е позициониран кај посакуваната контрола која сакаме да ја ажурираме. Промена на аватар се врши со кликање на некој од понудените аватари. Промените направени во Settings формата се зачувуваат со кликање на копчето Save.

По избирање на ниво од `LevelChooserForm.cs`. Се отвара форма од типот `Form1.cs` или `Form1Player2.cs` (зависно од тоа со колку играчи предходно корисникот одбрал дека сака да настапи) каде што е прикажана играта. Во овие форми се исцртуваат сите елементи од играта, платформите, скалите, непријателите, снегулките и играчите. Во нив се регистрираат KeyUp i KeyDown настани со кои корисникот го контролира својот аватар и се вршат проверки за победа или загуба на определено ниво. Најдоле на секоја форма има statusStrip во кој се прикажуваат податоци за моменталната состојба на: собрани снегулки, замрзнати блокови, преостанати животи.

Прегледот на најдобрите резултати е овозможен со `ScoreboardForm.cs`. До него се стигнува со клик на Scoreboard копчето од Log In страната. Во оваа форма резултатите од сите корисници кои ја играле играта на вашата машина се појауваат излистани сортирани според резултатот кој го постигнале. Иницијално, доколку никој не ја играл играта овој екран не прикажува никакви корисници.

Можност за увид во правилата на игра и запознавање со контролите може да се направи со помош на `AboutPage.cs`. Објект од оваа форма се креира со клик на About копчето од Log In страната. На оваа страна со помош на текст и илустрации корисникот се запознава со правилата и очекуваното однесувње во самата игра.

## Имплементација на класата Game.cs

Атрибутите на оваа класа се сите потребни податоци за еден левел.

```csharp
        public int LEVELID { get; set; }
        public Image BACKGROUNDIMAGE { get; set; }
        public int TOTALITEMSTOFREEZE { get; set; }
        public int TOTALSNOWFLAKES { get; set; }
        public List<Enemy> Enemies { get; set; }
        public List<Platform> Platforms { get; set; }
        public List<Stairs> Stairs { get; set; }
        public List<Snowflake> Snowflakes { get; set; }
        public Player Player { get; set; }
        public int maxUp { get; set; }
        public int maxDown { get; set; }
        public int maxLeft { get; set; }
        public int maxRight { get; set; }
        public int collectedSnowflakes { get; set; }
```

За проверка на тоа дали играчот е надвор од границите на левелот - односно дали паднал во дупка се врши со функцијата `isPlayerOutOfBounds`.
```csharp
    public bool isPlayerOutOfBounds()
        {
            if (Player.Y > maxDown + 10) return true;
            return false;
        }
```

Проверка за тоа дали играта е загубена - односно дали сите играчи ги загубиле сите свои животи е имплементирано со функцијата `isGameWon`.
```csharp
        public bool isGameWon()
        {
            if (getFrozenBlockNumber() == TOTALITEMSTOFREEZE)
            {
                return true;
            }
            return false;
        }
```
Пресметка на поените кои играчот ги добил по завршување на нивото се врши со функцијата `calculateScore`.
```csharp
        public int calculateScore()
        {
            return collectedSnowflakes * 100 + TOTALITEMSTOFREEZE;
        }
```
        
Итерација низ сите блокови и броење на сите кои се замрзнати од играчот е имплементирано со функцијата `getFrozenBlockNumber`.
```csharp
        public int getFrozenBlockNumber()
        {
            int frozenBlocks = 0;
            foreach (Platform p in Platforms)
            {
                if (p.isFrozen) frozenBlocks++;
            }
            foreach (Stairs s in Stairs)
            {
                if (s.isFrozen) frozenBlocks++;
            }
            return frozenBlocks;
        }
```

Собирање на снегулки зависно од позицијата на играчот е имплементирано со `collectSnowflakes`
```csharp
 public void collectSnowflakes()
        {
            for (int i = 0; i < Snowflakes.Count; i++)
            {
                if (Snowflakes[i].Collect(Player))
                {
                    collectedSnowflakes++;
                    Snowflakes.RemoveAt(i);
                    i--;
                }
            }
        }
```
Замрзнувањето на блокови од страна на играчот е имплементирано со `FreezeFreezableBlocks`
```csharp
public void FreezeFreezableBlocks()
        {
            foreach (Platform p in Platforms)
            {
                p.Freeze(Player);
            }
            foreach (Stairs st in Stairs)
            {
                st.Freeze(Player);

            }
        }
```
Движењето на играчот е имплементирано со 4 функции.

Движење во лево:
```csharp
public void MovePlayerLeft()
        {
            Player.X -= Player.VELOCITY;

            if (Player.isOnStairs)
            {
                foreach (Stairs stair in Stairs)
                {
                    if (Player.getRectagle().IntersectsWith(stair.getRectagle()))
                    {
                        Player.isOnStairs = true; break;
                    }
                    else
                    {
                        Player.isOnStairs = false;
                    }
                }
            }
        }
```
Движење во десно:
```csharp
public void MovePlayerRight()
        {
            Player.X += Player.VELOCITY;
            if (Player.isOnStairs)
            {
                foreach (Stairs stair in Stairs)
                {
                    if (Player.getRectagle().IntersectsWith(stair.getRectagle()))
                    {
                        Player.isOnStairs = true; break;
                    }
                    else
                    {
                        Player.isOnStairs = false;
                    }
                }
            }
        }
```
Движење нагоре:
```csharp
public void MovePlayerUp()
        {
            foreach (Stairs stair in Stairs)
            {
                if (Player.getRectagle().IntersectsWith(stair.getRectagle()))
                {
                    Player.Y -= Player.VELOCITY;
                    Player.isOnStairs = true; break;
                }
                else
                {
                    Player.isOnStairs = false;
                }
            }
        }
```
Движење надоле:
```csharp
public void MovePlayerDown()
        {
            foreach (Stairs stair in Stairs)
            {
                if ((Player.getRectagle().IntersectsWith(stair.getRectagle()) && Player.Y + Player.Height < stair.Y + stair.getHeight() + 1) || Player.Y + Player.Height == stair.Y)
                {
                    Player.Y += Player.VELOCITY;
                    Player.isOnStairs = true; break;
                }
                else
                {
                    Player.isOnStairs = false;
                }
            }
        }
```

Проверка за тоа дали играчот моментално се наоѓа врз платформа од која што може да отскокне е имплементирано со `isPlayerOnJumpablePlatform`.
```csharp
public bool isPlayerOnJumpablePlatform()
        {
           foreach (Platform p in Platforms)
            {
                if (Player.getRectagleWithPadding(-30,3,0,0).IntersectsWith(p.getRectagle())) return true;
            }
            foreach (Stairs s in Stairs)
            {
                if (Player.getRectagleWithPadding(-30, 3, 0, 0).IntersectsWith(s.getRectagle())) return true;
            }
            foreach(Enemy e in Enemies)
            {
                if (e.isFrozen) {
                    if (Math.Abs(Player.Y + Player.Height - e.Y) <= 3        //if the player is on top of the enemy
                        && ((Player.X <= e.X && Player.X + Player.Width >= e.X) //if the player is on the left side of enemy
                        || (e.X + Enemy.Width >= Player.X && e.X <= Player.X)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
```

Интеракција со непријателите во зависно од позицијата на играчот e имплементирано со `interactWithEnemies` 

```csharp
        public void interactWithEnemies()
        {
            foreach (Enemy e in Enemies)
            {
                e.Freeze(Player);

                if(!e.isFrozen && e.getRectagle().IntersectsWith(Player.getRectagleWithPadding(0, -3, 0, 0))){
                    Player.reduceLives();
                }
            }
        }
```

Движењето на непријателите е имплементирано со функцијата `MoveEnemies`
```charp
public void MoveEnemies()
        {
            foreach (Enemy e in Enemies)
            {
                e.timerTick();
                if (e.isAngry && e.isAdvancedEnemy)
                {
                    e.isAngry = false;
                    foreach(Platform p in Platforms)
                    {
                        if (e.getRectagleWithPadding(35, 35, 35, 35).IntersectsWith(p.getRectagle()))
                        {
                            p.unfreeze();
                        }
                    }
                    foreach (Stairs s in Stairs)
                    {
                        if (e.getRectagleWithPadding(5, 5, 5, 5).IntersectsWith(s.getRectagle()))
                        {
                            s.unfreeze();
                        }
                    }
                }
            }
        }
```

#### Timer Tick
Најважниот метод е имплементацијата на timer_tick. Тука се повикуваат сите методи со кои се придвижува играчот, непријателите, се овозможува замрзнување на платформите и скалите итн. Ова е методот кој потоа се повикува на секој timer_tick евент кој произлегува од тајмерот врзан за таа форма.

```csharp
        public void timerTick()
        {
            MoveEnemies();
            FreezeFreezableBlocks();
            interactWithEnemies();

            if (!Player.isOnStairs)
            {
                Player.Y += Player.JUMPSPEED;
            }

            if (Player.isJumping && Player.GRAVITY < 0)
            {
                Player.isJumping = false;
            }

            if (Player.isGoingLeft && Player.X > 1)
            {
                MovePlayerLeft();
            }

            if (Player.isGoingRight && Player.X+ Player.Width+Player.VELOCITY < this.maxRight)
            {
                MovePlayerRight();
            }

            if (Player.isGoingUp)
            {
                MovePlayerUp();
            }

            if (Player.isGoingDown)
            {
                MovePlayerDown();
            }

            if (Player.isJumping && !Player.isOnStairs)
            {
                Player.JUMPSPEED = -22;
                Player.GRAVITY -= 3;
            }
            else if (Player.isOnStairs)
            {
                Player.JUMPSPEED = 22;
                Player.GRAVITY -= 3;
            }
            else
            {
                bool flag = false;
                Player.JUMPSPEED = 22;
            
                foreach (Platform p in Platforms)
                {
                    if (Player.getRectagleWithPadding(-35, 0, 0, 0).IntersectsWith(p.getRectagle()) && !Player.isJumping)
                    {
                        Player.GRAVITY = 12;
                        Player.Y = p.Y - Player.Height;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    foreach (Enemy e in Enemies)
                    {
                        if (e.isFrozen)
                        {
                            if (Math.Abs(Player.Y + Player.Height - e.Y) <= 15        //if the player is on top of the enemy
                                && ((Player.X <= e.X && Player.X + Player.Width >= e.X) //if the player is on the left side of enemy
                                || (e.X + Enemy.Width >= Player.X && e.X <= Player.X)))
                            {
                                Player.GRAVITY = 12;
                                Player.Y = e.Y - Player.Height;
                                flag = true;
                                break;
                            }
                        }
                    }
                }
                if (!flag)
                {
                    foreach (Stairs s in Stairs)
                    {
                        if (Player.getRectagleWithPadding(-20, 0, 0, 0).IntersectsWith(s.getRectagle()) && !Player.isJumping)
                        {
                            Player.GRAVITY = 12;
                            Player.Y = s.Y - Player.Height;
                            break;
                        }
                    }
                }
            }
            collectSnowflakes();
            Player.RehabTimeLeft--;
        }
```

## Screenshots and tutorial

#### Log in Start Page

![Log in page](/Screenshots/LogInPage.png)

#### Level Chooser Page

![Levels page](/Screenshots/LevelsPage.png)

#### Settings page for one player mode

![Levels page](/Screenshots/Settings1Player.png)

#### Settings page for two player mode

![Setiings page](/Screenshots/Settings2Player.png)

#### Game one player mode

![Setiings page](/Screenshots/Level1Player.png)

#### Game two player mode

![Game page](/Screenshots/Level2Player.png)

#### About page

![Game page](/Screenshots/AboutPage.png)

#### Scoreboard page

![Scoreboard page](/Screenshots/ScoreboardPage.png)
