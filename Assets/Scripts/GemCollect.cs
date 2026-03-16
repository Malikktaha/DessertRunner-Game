using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
{
    [SerializeField] AudioSource gemFx;

    private void OnTriggerEnter(Collider other)
    {
        gemFx.Play();
        MasterInfo.gemCount++;
        this.gameObject.SetActive(false);
    }
}
