namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character firstCharacter = new Character("Paul", 120, 10, 50);
            Character secondCharacter = new Character("Roro", 70, 60, 20);

            while (firstCharacter.IsAlive() && secondCharacter.IsAlive())
            {
                firstCharacter.Attack(secondCharacter);
                secondCharacter.Attack(firstCharacter);
                if (!firstCharacter.IsAlive())
                {
                    Console.WriteLine($"{secondCharacter._name} a mis une branlée à {firstCharacter._name}. Cheh à lui.");
                }
                else if (secondCharacter.IsAlive())
                {
                    Console.WriteLine($"{firstCharacter._name} a mis une branlée à {secondCharacter._name}. Cheh à lui.");

                }
            }
        }
    }
}
