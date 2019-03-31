using System.Collections;
using System.Collections.Generic;

public class DataManager
{
    private List<Item> foodList;

    public DataManager()
    {
        foodList = new List<Item>();
    }

    // add item to list
    public void addItem()
    {
        foodList.Add(new Item());
    }

    // use item, the quantity of the item -1
    public static void useItem()
    {
        //foodList

    }

    // if the quantity of an item is 0, return
    public void removeItem()
    {
        //foodList.Remove();
    }

    //return foodlist
    public List<Item> getFoodList()
    {
        return foodList;
    }
}
