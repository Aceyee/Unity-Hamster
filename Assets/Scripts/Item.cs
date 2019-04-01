using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Item class can be instantialized to represent for item such as
/// - Food
/// - Drink
/// - Cleaning Staff
/// - Extended items
/// </summary>
public class Item
{
    private string name;                        // name of the item
    private int price;                          // price of the item
    private const int maxDurability = 100;      // maximum durability
    private float durability;                     // current durability
    private int quantity;                       // NEED TO BE DONE
    private static int count;                   // CURRENT VARIABLE

    public Item()
    {
        name = "item" + count;
        durability = maxDurability;
        quantity = 99;
        count++;
    }

    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="name"></param>
    public Item(string name)
    {
        this.name = name;
        durability = 10f;
    }

    /// <summary>
    /// Get item name
    /// </summary>
    public string getName()
    {
        return name;
    }

    /// <summary>
    /// Get item durability
    /// </summary>
    public float getDurability()
    {
        return durability;
    }

    /// <summary>
    /// Get item quantity
    /// </summary>
    public int getQuantity()
    {
        return quantity;
    }
}
