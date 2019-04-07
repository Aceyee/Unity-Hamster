using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcherFood : PanelSwitcher
{
    private List<Item> foodList;                // a list that contains items

    protected override void init() {
        target = GameObject.Find("FoodTray");
        listParent = GameObject.Find("listFood").transform;
    }

    /// <summary>
    /// Load content of the panel by calling DataManager method
    /// </summary>
    public override void loadList()
    {
        foodList = manager.GetDataManager().getFoodList();

        foreach (Item item in foodList)
        {
            //Debug.Log(item.getName());
        }
    }

    /// <summary>
    /// Display content of the panel by duplicating the prefab style
    /// </summary>
    public override void displayItem()
    {
        foreach (var item in foodList)
        {
            GameObject prefabClone = Instantiate(prefab, listParent);
            prefabClone.transform.GetChild(0).GetComponent<Text>().text = item.getName() + " - " + calcDuralbility(item.getDurability());
            prefabClone.GetComponent<Button>().onClick.AddListener(target.GetComponent<FoodTray>().addDurability);
        }
    }
}
