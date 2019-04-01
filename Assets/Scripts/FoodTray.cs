using UnityEngine;

public class FoodTray : MonoBehaviour
{
    // Start is called before the first frame update
    public const float maxDurability = 10f;
    public float currDurability = maxDurability;
    private GameObject emptyTray;
    private GameObject halfTray;
    private GameObject fullTray;
    private bool emptyTrayActive = false;
    private bool halfTrayActive = false;
    private bool fullTrayActive = false;

    private void Start()
    {
        emptyTray = transform.GetChild(0).gameObject;
        halfTray = transform.GetChild(1).gameObject;
        fullTray = transform.GetChild(2).gameObject;
        toogleTrayView();
    }

    private void toogleTrayView()
    {
        if (currDurability <= 0 && !emptyTrayActive)
        {
            halfTray.SetActive(!halfTrayActive);
            fullTray.SetActive(!fullTrayActive);
            emptyTray.SetActive(emptyTrayActive =! emptyTrayActive);

        }
        else if (currDurability <= 0.5*maxDurability && !halfTrayActive)
        {
            emptyTray.SetActive(emptyTrayActive=false);
            fullTray.SetActive(!fullTrayActive);
            halfTray.SetActive(halfTrayActive = !halfTrayActive);
        }
        else if(currDurability <=maxDurability && !fullTrayActive)
        {
            emptyTray.SetActive(emptyTrayActive = false);
            halfTray.SetActive(halfTrayActive = false);
            fullTray.SetActive(fullTrayActive = !fullTrayActive);
        }
    }

    public void addDurability()
    {
        currDurability = maxDurability;
        toogleTrayView();
    }

    // Update is called once per frame
    void Update()
    {
        if (currDurability > 0)
        {
            currDurability -= Time.deltaTime;
            toogleTrayView();
        }
    }
}
