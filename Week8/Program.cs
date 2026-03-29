namespace Week8;
class Program
{
    static void Main()
    {
        Letter l1 =new Letter("K7108448",0.2);
        Letter l2 =new Letter("DHF38479",3.5);

        Parcel p1 =new Parcel("NDJFI67629394",6.0,"50x80x40");
        Parcel p2 =new Parcel("JFGHSLW930390",1.5,"10x50x10");
        
        CargoContainer<DeliveryItem> CargoContainer1 =new CargoContainer<DeliveryItem>();

        CargoContainer1.AddItem(l1);
        CargoContainer1.AddItem(l2);
        CargoContainer1.AddItem(p1);
        CargoContainer1.AddItem(p2);

        DeliveryItem item = p1;
        item.PrintInfo();
        item = l1;
        item.PrintInfo();

        Console.WriteLine("Сума до сплати: " +CargoContainer1.GetTotalCost() + " грн.");
    }
}