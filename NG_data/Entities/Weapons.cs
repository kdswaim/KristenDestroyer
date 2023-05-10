
    public class Weapons
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int AttackPower { get; set; }

        public Weapons(string name, int attackPower)
        {
            Name = name;
            AttackPower = attackPower;
        }
    }