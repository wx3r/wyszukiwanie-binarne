using System;

class WyszukiwanieBinarne
{
    public static int AlgorytmWyszukiwaniaBinarnego(int[] tabela, int cel)
    {
        int left = 0;
        int right = tabela.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (tabela[mid] == cel)
            {
                return mid; // znaleziono
            }
            else if (tabela[mid] < cel)
            {
                left = mid + 1; // przesunięcie w lewo
            }
            else
            {
                right = mid - 1; // przesunięcie w prawo
            }
        }
        return -1; // nie znaleziono
    }

    public static void Main()
    {
        int[] tabela = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

        Console.Write("Wprowadź poszukiwaną liczbę: ");
        int cel = int.Parse(Console.ReadLine());

        int wynik = AlgorytmWyszukiwaniaBinarnego(tabela, cel);

        if (wynik != -1)
        {
            Console.WriteLine($"Liczba {cel} znajduje się na indeksie {wynik} w tablicy.");
        }
        else
        {
            Console.WriteLine($"Liczba {cel} nie została znaleziona w tablicy.");
        }
    }
}