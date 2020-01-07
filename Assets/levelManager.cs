using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelManager : MonoBehaviour
{
    public int targerBoxCount;
    public int currentBoxCount =0;
    public GameObject succesText;
    public bool isGameActive = true;
    // Update is called once per frame
    void Update()
    {
        if(!isGameActive) return;

        if(currentBoxCount >= targerBoxCount)
        {
            Debug.Log("Succcesss");
            isGameActive = false;
            succesText.SetActive(true);
            Invoke("loadNextScene",1.5f);
        }
    }

    void loadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
