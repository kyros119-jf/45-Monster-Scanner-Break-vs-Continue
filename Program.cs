
// Scan monsters 1 through 15.
for (int monster = 1; monster <= 15; monster++)
{
    // Skip invisible monsters.
    if (monster == 4 || monster == 9)
    {
        Console.WriteLine($"Monster {monster} is invisible. Scanner skipped it.");
        continue;
    }

    // Stop scanning when the boss is found.
    if (monster == 12)
    {
        Console.WriteLine("Boss detected! Ending scan.");
        break;
    }

    // Scan monsters that are not invisible or bosses.
    Console.WriteLine($"Scanning monster {monster}");
}
