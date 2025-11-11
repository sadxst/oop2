using System;

public class Shop
{
    public static int units;
    public void OnBuy(object sender, int count)
    {
        units -= count;
        Console.WriteLine($"Товару в магазині: {units}");
    }

    public void OnFail(object sender, int count)
    {
        Console.WriteLine("Замовити товар на базі");
    }
}

public class Buyer
{
    public int want;
    private bool noUnits = false;
    public bool NoUnits => noUnits;

    public delegate void BuyerEventHandler(object sender, int count);
    public event BuyerEventHandler Event1;
    public event BuyerEventHandler Event2;

    public Buyer(int want)
    {
        this.want = want;
    }

    public void TryBuy()
    {
        if (Shop.units >= want)
        {
            Event1?.Invoke(this, want);
            Console.WriteLine($"Купив товару: {want}");
        }
        else
        {
            noUnits = true;
            Event2?.Invoke(this, want);
            Console.WriteLine($"Не зміг купити товару: {want}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random r = new Random();
        Shop shop = new Shop();
        Shop.units = r.Next(10, 21);
        Console.WriteLine($"Початкова кількість товару: {Shop.units}");

        do
        {
            int count = r.Next(1, 8);
            Buyer b = new Buyer(count);
            b.Event1 += shop.OnBuy;
            b.Event2 += shop.OnFail;
            b.TryBuy();
        }
        while (!new Buyer(0).NoUnits && Shop.units > 0);
    }
}