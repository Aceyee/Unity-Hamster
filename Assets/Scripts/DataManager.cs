using System.Collections.Generic;

public class DataManager
{
    private List<Item> foodList;

    public DataManager()
    {
        foodList = new List<Item>();
    }

    /// <summary>
    /// Add item to the list
    /// </summary>
    public void addItem()
    {
        foodList.Add(new Item());
    }

    /// <summary>
    /// Add item to the list
    /// </summary>
    public void addItem(string name)
    {
        foodList.Add(new Item(name));
    }

    /// <summary>
    /// Use item, the quantity of the item -1
    /// </summary>
    public static void useItem()
    {
        //foodList

    }

    /// <summary>
    /// Remove the item if its quantity is 0
    /// </summary>
    public void removeItem()
    {
        //foodList.Remove();
    }

    /// <summary>
    /// Return the list of food
    /// </summary>
    public List<Item> getFoodList()
    {
        return foodList;
    }
}
