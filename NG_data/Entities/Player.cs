
    public class Player
    {
        public int ID {get; set;}
        public string NAme {get; set;} = string.Empty;
        public int HealthPoints {get; set;} = 100;

        public bool IsDead{
            get
            {
                return (HealthPoints <= 0) ? true : false;
            }
        }

        public void DecreaseHealth(int pointValue = 5)
        {
            HealthPoints -= pointValue;
        }

        public void IncreaseHealth(int pointValue = 5)
        {
            HealthPoints += pointValue;
        }

        public List<Weapons> Items;

        private Weapons criticism;
        private Weapons laser;
        private Weapons karate;
        private Weapons sulfa;

        public void CritiqueHer(Enemy enemy, int attackPower = 30)
        {
                enemy.DecreaseHealth(attackPower);
                System.Console.WriteLine("She doesn't handle criticism very well! Good job.");
        }

        public void FreakinLasers(Enemy enemy, int IncreaseHealth = 10)
        {
            enemy.IncreaseHealth(HealthPoints);
            System.Console.WriteLine("You fool! She eats lasers for BREAKFAST.");
        }

        public void UseKarate(Enemy enemy, int attackPower = 20)
        {
            enemy.DecreaseHealth (attackPower);
            System.Console.WriteLine("You demonstrate some cool karate moves. KRISTEN bows and respectfully gives up 20 health points.");
        }

        public void PoisonHer (Enemy enemy, int attackPower = 100)
        {
            enemy.DecreaseHealth(attackPower);
            System.Console.WriteLine("She is deathly allergic to sulfa, so you win but... maybe calm down?");
        }
    }