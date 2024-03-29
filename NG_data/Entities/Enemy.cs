
    public class Enemy
    {
        public int ID { get; set; }
        public string Name{ get; set; } = string.Empty;
        public int HealthPoints { get; set; } = 100;

        public bool IsDead
        {
            get
            {
            return (HealthPoints <= 0) ? true: false ;
            }
        }

    public void DecreaseHealth(int pointValue = 5)
    {
        HealthPoints -=pointValue;
    }

    public void IncreaseHealth(int pointValue = 5)
    {
        HealthPoints += pointValue;
    }
    }

