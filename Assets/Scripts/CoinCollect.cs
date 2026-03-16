using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    [SerializeField] AudioSource coinFx;

    private void OnTriggerEnter(Collider other)
    {
        coinFx.Play();
        MasterInfo.coinCount++;
        this.gameObject.SetActive(false);
    }
}
