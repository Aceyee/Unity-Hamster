using System.Collections.Generic;

public class DataManager
{
    private List<Item> foodList;
    private List<Item> drinkList;
    private List<Item> cleanerList;

    public DataManager()
    {
        foodList = new List<Item>();
        drinkList = new List<Item>();
        cleanerList = new List<Item>();
    }

    /// <summary>
    /// Add item to the list
    /// </summary>
    public void addFood()
    {
        foodList.Add(new Item());
    }

    /// <summary>
    /// Add item to the list
    /// </summary>
    public void addFood(string name)
    {
        foodList.Add(new Item(name));
    }

    /// <summary>
    /// Add item to the list
    /// </summary>
    public void addDrink()
    {
        drinkList.Add(new Item());
    }

    /// <summary>
    /// Add item to the list
    /// </summary>
    public void addDrink(string name)
    {
        drinkList.Add(new Item(name));
    }

    /// <summary>
    /// Add item to the list
    /// </summary>
    public void addCleaner()
    {
        cleanerList.Add(new Item());
    }

    /// <summary>
    /// Add item to the list
    /// </summary>
    public void addCleaner(string name)
    {
        cleanerList.Add(new Item(name));
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

    /// <summary>
    /// Return the list of food
    /// </summary>
    public List<Item> getDrinkList()
    {
        return drinkList;
    }

    /// <summary>
    /// Return the list of food
    /// </summary>
    public List<Item> getCleanerList()
    {
        return cleanerList;
    }
}
