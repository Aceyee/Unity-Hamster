using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcherClean : PanelSwitcher
{
    private List<Item> cleanerList;                // a list that contains items

    protected override void init() {
        target = GameObject.Find("Cage");
        listParent = GameObject.Find("listCleaner").transform;
    }

    /// <summary>
    /// Load content of the panel by calling DataManager method
    /// </summary>
    public override void loadList()
    {
        cleanerList = manager.GetDataManager().getCleanerList();

        foreach (Item item in cleanerList)
        {
            //Debug.Log(item.getName());
        }
    }

    /// <summary>
    /// Display content of the panel by duplicating the prefab style
    /// </summary>
    public override void displayItem()
    {
        foreach (var item in cleanerList)
        {
            GameObject prefabClone = Instantiate(prefab, listParent);
            prefabClone.transform.GetChild(0).GetComponent<Text>().text = item.getName() + " - " + calcDuralbility(item.getDurability());
            prefabClone.GetComponent<Button>().onClick.AddListener(target.GetComponent<Cage>().addDurability);
        }
    }
}
