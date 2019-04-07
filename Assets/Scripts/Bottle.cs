using UnityEngine;

public class Bottle : MonoBehaviour
{
    // Start is called before the first frame update
    public const float maxDurability = 10f;
    public float currDurability = maxDurability;
    private GameObject bottleFull;
    private GameObject bottle70;
    private GameObject bottle50;
    private GameObject bottle20;
    private GameObject bottle5;
    private GameObject bottleEmpty;

    private bool bottleEmptyActive = false;
    private bool bottle5Active = false;
    private bool bottle20Active = false;
    private bool bottle50Active = false;
    private bool bottle70Active = false;
    private bool bottleFullActive = false;

    private void Start()
    {
        bottleFull = transform.GetChild(0).gameObject;
        bottle70 = transform.GetChild(1).gameObject;
        bottle50 = transform.GetChild(2).gameObject;
        bottle20 = transform.GetChild(3).gameObject;
        bottle5 = transform.GetChild(4).gameObject;
        bottleEmpty = transform.GetChild(5).gameObject;

        toogleBottleView();
    }

    private void toogleBottleView()
    {
        if (currDurability <= 0 && !bottleEmptyActive)
        {
            bottleFull.SetActive(!bottleFullActive);
            bottle70.SetActive(!bottle70Active);
            bottle50.SetActive(!bottle50Active);
            bottle20.SetActive(!bottle20Active);
            bottle5.SetActive(!bottle5Active);
            bottleEmpty.SetActive(bottleEmptyActive = !bottleEmptyActive);
        }
        else if (currDurability <= 0.05 * maxDurability && !bottle5Active)
        {
            bottleFull.SetActive(!bottleFullActive);
            bottle70.SetActive(!bottle70Active);
            bottle50.SetActive(!bottle50Active);
            bottle20.SetActive(!bottle20Active);
            bottle5.SetActive(bottle5Active = !bottle5Active);
            bottleEmpty.SetActive(bottleEmptyActive = false);
        }
        else if (currDurability <= 0.2 * maxDurability && !bottle20Active)
        {
            bottleFull.SetActive(!bottleFullActive);
            bottle70.SetActive(!bottle70Active);
            bottle50.SetActive(!bottle50Active);
            bottle20.SetActive(bottle20Active = !bottle20Active);
            bottle5.SetActive(bottle5Active = false);
            bottleEmpty.SetActive(bottleEmptyActive = false);
        }
        else if (currDurability <= 0.5 * maxDurability && !bottle50Active)
        {
            bottleFull.SetActive(!bottleFullActive);
            bottle70.SetActive(!bottle70Active);
            bottle50.SetActive(bottle50Active = !bottle50Active);
            bottle20.SetActive(bottle20Active = false);
            bottle5.SetActive(bottle5Active = false);
            bottleEmpty.SetActive(bottleEmptyActive = false);
        }
        else if (currDurability <= 0.7 * maxDurability && !bottle70Active)
        {
            bottleFull.SetActive(!bottleFullActive);
            bottle70.SetActive(bottle70Active = !bottle70Active);
            bottle50.SetActive(bottle50Active = false);
            bottle20.SetActive(bottle20Active = false);
            bottle5.SetActive(bottle5Active = false);
            bottleEmpty.SetActive(bottleEmptyActive = false);
        }
        else if (currDurability <= maxDurability && !bottleFullActive)
        {
            bottleFull.SetActive(bottleFullActive = !bottleFullActive);
            bottle70.SetActive(bottle70Active = false);
            bottle50.SetActive(bottle50Active = false);
            bottle20.SetActive(bottle20Active = false);
            bottle5.SetActive(bottle5Active = false);
            bottleEmpty.SetActive(bottleEmptyActive = false);
        }
    }

    public void addDurability()
    {
        bottleEmptyActive = false;
        bottle5Active = false;
        bottle20Active = false;
        bottle50Active = false;
        bottle70Active = false;
        bottleFullActive = false;
        currDurability = maxDurability;
        toogleBottleView();
    }

    // Update is called once per frame
    void Update()
    {
        if (currDurability > 0)
        {
            currDurability -= Time.deltaTime;
            toogleBottleView();
        }
    }
}
