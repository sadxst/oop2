using System;

class ArrayProcessing
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int k = 7;
        int n = (int)(20 + 0.6 * k);
        Console.WriteLine($"Розмір масиву: 20 + 0,6 x 7 = {n}");
        int[] arr = CreateRandomArray(n, 10, 100);
        Console.WriteLine("\nПочатковий масив:");
        Print(arr);
        MergeSort(arr, 0, arr.Length - 1);
        Console.WriteLine("\nВідсортований масив:");
        Print(arr);
        Console.Write("\nВведіть ключ для пошуку: ");
        int key = int.Parse(Console.ReadLine());
        int bcount = CountBinary(arr, key);
        int scount = CountSequential(arr, key);
        Console.WriteLine($"\nКількість входжень за бінарним пошуком: {bcount}");
        Console.WriteLine($"Кількість входжень за послідовним пошуком: {scount}");
    }

    static int[] CreateRandomArray(int n, int min, int max)
    {
        Random rand = new Random();
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = rand.Next(min, max + 1);
        return arr;
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right) return;
        int mid = (left + right) / 2;
        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;

        while (i <= mid && j <= right)
            temp[k++] = (arr[i] <= arr[j]) ? arr[i++] : arr[j++];

        while (i <= mid) temp[k++] = arr[i++];
        while (j <= right) temp[k++] = arr[j++];

        Array.Copy(temp, 0, arr, left, temp.Length);
    }

    static int CountBinary(int[] arr, int key)
    {
        int f = FindOccurrence(arr, key, true);
        if (f == -1) return 0;
        int l = FindOccurrence(arr, key, false);
        return l - f + 1;
    }

    static int FindOccurrence(int[] arr, int key, bool first)
    {
        int low = 0, high = arr.Length - 1, result = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == key)
            {
                result = mid;
                if (first) high = mid - 1; else low = mid + 1;
            }
            else if (arr[mid] < key) low = mid + 1;
            else high = mid - 1;
        }
        return result;
    }

    static int CountSequential(int[] arr, int key)
    {
        int count = 0;
        foreach (var num in arr)
            if (num == key) count++;
        return count;
    }
    static void Print(int[] arr) => Console.WriteLine(string.Join(", ", arr));
}