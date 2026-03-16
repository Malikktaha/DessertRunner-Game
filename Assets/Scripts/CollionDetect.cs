using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnim;
    [SerializeField] AudioSource collionFx;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject fadeOut;
    private void OnTriggerEnter(Collider other)
    {
        SaveLoad.saveData = true;
        StartCoroutine(CollsionEnd());
    }
    IEnumerator CollsionEnd()
    {
        collionFx.Play();
        thePlayer.GetComponent<PlayerMovemont>().enabled = false;
        playerAnim.GetComponent<Animator>().Play("Stumble Backwords");
        mainCam.GetComponent<Animator>().Play("CollsionCam");
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }

}

