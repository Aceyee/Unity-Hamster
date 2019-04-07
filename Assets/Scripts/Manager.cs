using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private DataManager dataManager;

    void Awake()
    {
        dataManager = new DataManager();
        dataManager.addFood("综合鼠粮");
        dataManager.addFood("草莓");
        dataManager.addFood("坚果");
        dataManager.addFood("苹果");

        dataManager.addDrink("清水");

        dataManager.addCleaner("清洁剂");

    }

    public DataManager GetDataManager()
    {
        return dataManager;
    }
}
