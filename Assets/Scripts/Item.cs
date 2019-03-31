using System.Collections;
using System.Collections.Generic;


public class Item
{
    private string name;
    private int price;
    private const int maxQuantity = 100;
    private int quantity;
    private static int count;

    public Item()
    {
        name = "item" + count;
        quantity = maxQuantity;
        count++;
    }

    public Item(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return name;
    }

    public int getQuantity()
    {
        return quantity;
    }
}
