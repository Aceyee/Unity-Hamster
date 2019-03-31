using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    private bool active;
    private Transform parent;
    private List<Item> foodList;
    private Manager manager;
    public GameObject prefab;


    private void Awake()
    {
        active = gameObject.activeSelf;
        manager = GameObject.Find("Manager").GetComponent<Manager>();
        parent = GameObject.Find("listFood").transform;
    }

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
    
    public void loadList()
    {
        foodList = manager.GetDataManager().getFoodList();

        foreach (Item item in foodList)
        {
            //Debug.Log(item.getName());
        }
    }

    public void displayItem()
    {
        foreach(var item in foodList)
        {
            GameObject prefabClone = Instantiate(prefab, parent);
            prefabClone.transform.GetChild(0).GetComponent<Text>().text = item.getName()+" - "+ item.getQuantity()+"%";
        }
    }

    public void clearItem()
    {
        for (int i=0; i<parent.childCount; i++)
        {
            Destroy(parent.GetChild(i).gameObject);
        }
    }
}
