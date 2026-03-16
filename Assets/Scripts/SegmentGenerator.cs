using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segment;
    [SerializeField] int zPos = 50;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;
    // Start is called before the first frame update
    void Update()
    {
        if (creatingSegment == false) 
        {
            StartCoroutine(SegmentGen());
            creatingSegment = true;
        } 
    }


    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0, 3);
        Instantiate(segment[segmentNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(3);
        creatingSegment = false;
    }
}
