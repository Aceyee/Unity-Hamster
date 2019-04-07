using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcherDrink : PanelSwitcher
{
    private List<Item> drinkList;                // a list that contains items

    protected override void init() {
        target = GameObject.Find("Bottle");
        listParent = GameObject.Find("listDrink").transform;
    }

    /// <summary>
    /// Load content of the panel by calling DataManager method
    /// </summary>
    public override void loadList()
    {
        drinkList = manager.GetDataManager().getDrinkList();

        foreach (Item item in drinkList)
        {
            //Debug.Log(item.getName());
        }
    }

    /// <summary>
    /// Display content of the panel by duplicating the prefab style
    /// </summary>
    public override void displayItem()
    {
        foreach (var item in drinkList)
        {
            GameObject prefabClone = Instantiate(prefab, listParent);
            prefabClone.transform.GetChild(0).GetComponent<Text>().text = item.getName() + " - " + calcDuralbility(item.getDurability());
            prefabClone.GetComponent<Button>().onClick.AddListener(target.GetComponent<Bottle>().addDurability);
        }
    }
}
