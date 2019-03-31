using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private DataManager dataManager;

    void Awake()
    {
        dataManager = new DataManager();
        dataManager.addItem();
        dataManager.addItem();
        dataManager.addItem();
        dataManager.addItem();
    }

    public DataManager GetDataManager()
    {
        return dataManager;
    }
}
