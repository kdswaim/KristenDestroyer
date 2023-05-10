using System;

public class ProgramUI
{
    private bool IsRunning = true;
    private Player player = new Player();
    private Enemy enemy = new Enemy();

    public void Run()
    {
        RunApplication();
    }

    private void RunApplication()
{
    Console.WriteLine("Welcome to KRISTEN DESTROYER! A truly one-of-a-kind game.");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("She's just standing there... menacingly.");
    Console.WriteLine("Let her know, 'Not in MY city.'");

    Console.Write("Are you the person for the job? (Y/N) ");
    string answer = Console.ReadLine();

    if (answer == "Y" || answer == "y")
    {
        while (!enemy.IsDead)
        {
            Console.WriteLine("Choose your weapon:");
            Console.WriteLine("(1) Laser, (2) Criticism, (3) Karate, (4) Sulfa");
            string action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    player.FreakinLasers(enemy);
                    break;
                case "2":
                    player.CritiqueHer(enemy);
                    break;
                case "3":
                    player.UseKarate(enemy);
                    break;
                case "4":
                    player.PoisonHer(enemy);
                    break;
                default:
                    Console.WriteLine("You MUST play by the rules! Please choose a weapon (1-4).");
                    break;
            }

            if (enemy.IsDead)
            {
                Console.WriteLine("The cops are on their way. You can't just run around defeating people.");
                System.Console.WriteLine("YOU WIN (????!)");
            }
            else
            {
                Console.WriteLine($"She's still standing there with that menacing look on her face. She has {enemy.HealthPoints} health left. Keep fighting!");
            }
        }
    }
    else
    {
        Console.WriteLine("Yeah, it's probably for the best. That's murder. See you around, dude.");
    }

    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}
    private void Clear()
    {
        Console.Clear();
    }
}
