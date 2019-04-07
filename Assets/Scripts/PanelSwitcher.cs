using System.Collections.Generic;
using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    protected bool active;                        // if the current panel displays(active) or hides(inactive)
    protected Manager manager;                    // the game manager to share information with
    protected Transform listParent;               // the listParent of the detail content items
    protected GameObject target;                  // food tray, bottle
    public GameObject prefab;                     // the prefab style to duplicate a item in the view

    /// <summary>
    /// set initial value
    /// </summary>
    private void Awake()
    {
        active = gameObject.activeSelf;
        manager = GameObject.Find("Manager").GetComponent<Manager>();
        init();
    }

    /// <summary>
    /// init function to be overriden
    /// </summary>
    protected virtual void init(){}

    /// <summary>
    /// Load content of the panel by calling DataManager method
    /// </summary>
    public virtual void loadList(){}

    /// <summary>
    /// Display content of the panel by duplicating the prefab style
    /// </summary>
    public virtual void displayItem(){}

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
    /// Clear content of the panel after the panel is hidden
    /// </summary>
    public virtual void clearItem()
    {
        for (int i=0; i<listParent.childCount; i++)
        {
            Destroy(listParent.GetChild(i).gameObject);
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
