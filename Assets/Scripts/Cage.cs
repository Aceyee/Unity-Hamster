using UnityEngine;

public class Cage : MonoBehaviour
{
    // Start is called before the first frame update
    public const float maxDurability = 10f;
    public float currDurability = maxDurability;
    private GameObject cleanCage;
    private GameObject dirtyCage;
    private GameObject veryDirtyCage;
    private bool cleanCageActive = false;
    private bool dirtyCageActive = false;
    private bool veryDirtyCageActive = false;

    private void Start()
    {
        cleanCage = transform.GetChild(2).gameObject;
        dirtyCage = transform.GetChild(1).gameObject;
        veryDirtyCage = transform.GetChild(0).gameObject;
        toogleTrayView();
    }

    private void toogleTrayView()
    {
        if (currDurability <= 0 && !cleanCageActive)
        {
            dirtyCage.SetActive(!dirtyCageActive);
            veryDirtyCage.SetActive(!veryDirtyCageActive);
            cleanCage.SetActive(cleanCageActive =! cleanCageActive);

        }
        else if (currDurability <= 0.5*maxDurability && !dirtyCageActive)
        {
            cleanCage.SetActive(cleanCageActive=false);
            veryDirtyCage.SetActive(!veryDirtyCageActive);
            dirtyCage.SetActive(dirtyCageActive = !dirtyCageActive);
        }
        else if(currDurability <=maxDurability && !veryDirtyCageActive)
        {
            cleanCage.SetActive(cleanCageActive = false);
            dirtyCage.SetActive(dirtyCageActive = false);
            veryDirtyCage.SetActive(veryDirtyCageActive = !veryDirtyCageActive);
        }
    }

    public void addDurability()
    {
        cleanCageActive = false;
        dirtyCageActive = false;
        veryDirtyCageActive = false;
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
