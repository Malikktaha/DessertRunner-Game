using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControl : MonoBehaviour
{
    [SerializeField] GameObject fadeOut;
    [SerializeField] GameObject animCam;
    [SerializeField] GameObject bounceText;
    [SerializeField] GameObject bigButton;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject menuControl;
    [SerializeField] AudioSource buttonSelect;
    public static bool hasClick;
    [SerializeField] GameObject fadeIn;

    [SerializeField] int loadCoins;
    [SerializeField] int loadGems;
    [SerializeField] int loadDistance;
    [SerializeField] Text coinText;
    [SerializeField] Text gemText;
    [SerializeField] Text runText;


    void Start()
    {
        StartCoroutine(FadeInTrunOff());
        if (hasClick == true)
        {
            animCam.SetActive(false);
            mainCam.SetActive(true);
            menuControl.SetActive(true);
            bounceText.SetActive(false);
            bigButton.SetActive(false);
        }
    }
    public void MenuBeginButton()
    {
        StartCoroutine(AnimCam());
    }
    public void StartGame()
    {
        StartCoroutine(StartButton()); 
    }
    IEnumerator StartButton()
    {
        buttonSelect.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);

    }
    IEnumerator AnimCam()
    {
        animCam.GetComponent<Animator>().Play("AnimMenuCam");
        bounceText.SetActive(false);
        bigButton.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        fadeIn.SetActive(false);
        mainCam.SetActive(true);
        animCam.SetActive(false);
        menuControl.SetActive(true);
        hasClick = true;
    }
    IEnumerator FadeInTrunOff()
    {
        yield return new WaitForSeconds(0.05f);
        loadCoins = PlayerPrefs.GetInt("COINSAVE");
        loadGems = PlayerPrefs.GetInt("GEMSAVE");
        loadDistance = PlayerPrefs.GetInt("DISTANCESAVE");
        coinText.text = "" + loadCoins;
        gemText.text = "" + loadGems;
        runText.text = "" + loadDistance;
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);

    }
}
