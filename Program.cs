Random rnd = new Random();

int[,] income = new int[3, 10];

Console.WriteLine("           День 1  День 2  День 3  День 4  День 5  День 6  День 7  День 8  День 9  День 10");

for (int i = 0; i < 3; i++)
{
    Console.Write($"\nМагазин {i + 1}: ");
    for (int j = 0; j < 10; j++)
    {
        income[i, j] = rnd.Next(1000000, 3000000);
        Console.Write(income[i, j] + " ");
    }

}

Console.WriteLine("\n");

int maxShopIncome = 0;
int dayOfMaxShopIncome = 0;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if (income[i, j] > maxShopIncome)
        {
            maxShopIncome = income[i, j];
            dayOfMaxShopIncome = j;
        }
        if (j == 9)
        {
            Console.WriteLine($"Для {i + 1} магазина максимальный доход за месяц был {dayOfMaxShopIncome + 1} числа: {maxShopIncome.ToString("0 000 000")} руб.");
        }
    }
    maxShopIncome = 0;
}

Console.WriteLine();


int maxDayIncome = 0;
int shopOfMaxDayIncome = 0;

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (income[j, i] > maxDayIncome)
        {
            maxDayIncome = income[j, i];
            shopOfMaxDayIncome = j;
        }
        if (j == 2)
        {
            Console.WriteLine($"Для {i + 1} дня {shopOfMaxDayIncome + 1} магазин получил больше всего дохода: {maxDayIncome.ToString("0 000 000")} руб.");
        }
    }
    maxDayIncome = 0;
}