using UnityEngine;
using UnityEngine.UI;

public class MasterInfo : MonoBehaviour
{
    public static int coinCount = 0;
    [SerializeField] Text coinText;
    public static int gemCount = 0;
    [SerializeField] Text gemText;
    public static int distanceRun = 0;
    [SerializeField] int internalDistance;
    [SerializeField] Text runText;

    private void Start()
    {
        coinCount = 0;
        gemCount = 0;
        distanceRun = 0;
    }
    void Update()
    {
        internalDistance = distanceRun;

        coinText.text = "" + coinCount;
        gemText.text = "" + gemCount;
        runText.text = "" + distanceRun;
    }
}
