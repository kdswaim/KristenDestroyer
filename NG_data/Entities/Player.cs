
    public class Player
    {
        public int ID {get; set;}
        public string Name {get; set;} = string.Empty;
        public int HealthPoints {get; set;} = 100;

        public bool IsDead{
            get
            {
                return (HealthPoints <= 0);
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

        private Weapons criticism = new Weapons("Criticism", 30);
    private Weapons laser = new Weapons("Laser", 10);
    private Weapons karate = new Weapons("Karate", 20);
    private Weapons sulfa = new Weapons("Sulfa", 100);

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