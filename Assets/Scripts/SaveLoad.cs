using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{

    public static int loadCoins;
    public static int loadGems;
    public static int loadDistance;
    public static bool saveData;

    [SerializeField] int internalCoins;
    [SerializeField] int internalGems;
    [SerializeField] int internalDistance;
    void Start()
    {
        loadCoins = PlayerPrefs.GetInt("COINSAVE");
        loadGems = PlayerPrefs.GetInt("GEMSAVE");
        loadDistance = PlayerPrefs.GetInt("DISTANCESAVE");
        saveData = true;

    }

    // Update is called once per frame
    void Update()
    {
        internalCoins = loadCoins + MasterInfo.coinCount;
        internalGems = loadGems + MasterInfo.gemCount;
        internalDistance = loadDistance + MasterInfo.distanceRun;
        if (saveData == true)
        {
            saveData = false;
            PlayerPrefs.SetInt("COINSAVE", internalCoins);
            PlayerPrefs.SetInt("GEMSAVE", internalGems);
            PlayerPrefs.SetInt("DISTANCESAVE", internalDistance);

        }
    }
}
