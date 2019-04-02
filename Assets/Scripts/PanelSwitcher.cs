using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    private bool active;                        // if the current panel displays(active) or hides(inactive)
    private Transform parent;                   // the parent of the detail content items
    private List<Item> foodList;                // a list that contains items
    private Manager manager;                    // the game manager to share information with
    private GameObject foodTray;
    public GameObject prefab;                   // the prefab style to duplicate a item in the view

    /// <summary>
    /// set initial value
    /// </summary>
    private void Awake()
    {
        active = gameObject.activeSelf;
        manager = GameObject.Find("Manager").GetComponent<Manager>();
        parent = GameObject.Find("listFood").transform;
        foodTray = GameObject.Find("FoodTray");
    }

    /// <summary>
    /// Display and hide a panel
    /// - if the panel is displayed, load relative data and item
    /// - if the panel is hidden, clear the objects attached on the panel 
    /// </summary>
    public void toogle()
    {
        active = !active;
        gameObject.SetActive(active);
        if (active)
        {
            loadList();
            displayItem();
        }
        else
        {
            clearItem();
        }
    }

    /// <summary>
    /// Load content of the panel by calling DataManager method
    /// </summary>
    public void loadList()
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
    public void displayItem()
    {
        foreach(var item in foodList)
        {
            GameObject prefabClone = Instantiate(prefab, parent);
            prefabClone.transform.GetChild(0).GetComponent<Text>().text = item.getName()+" - "+ calcDuralbility(item.getDurability());
            prefabClone.GetComponent<Button>().onClick.AddListener(foodTray.GetComponent<FoodTray>().addDurability);
        }
    }

    /// <summary>
    /// Clear content of the panel after the panel is hidden
    /// </summary>
    public void clearItem()
    {
        for (int i=0; i<parent.childCount; i++)
        {
            Destroy(parent.GetChild(i).gameObject);
        }
    }

    public string calcDuralbility(float second)
    {
        if (second == 10f)
        {
            return "10s";
        }
        return "";
    }
}
