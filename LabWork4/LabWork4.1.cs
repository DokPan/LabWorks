Console.Write("Введите сумму для сдачи: ");
int amount =30;

if (amount < 0)
{
    Console.Write("Некорректная сумма");
    return;
}
List<int> result = Change(amount);

if (result.Count > 0)
{
    Console.WriteLine("Монеты для сдачи: ");
    foreach (int coin in result)
        Console.WriteLine(coin);
}
else
    Console.WriteLine("Сдача невозможна");

static List<int> Change(int amount)
{
    int[] coins = { 10, 5, 2, 1 };
    List<int> change = new List<int>();
    foreach (int coin in coins)
    {
        while (amount >= coin)
        {
            amount -= coin;
            change.Add(coin);
        }
    }
    if (amount != 0)
        return new List<int>();
    return change;
}
