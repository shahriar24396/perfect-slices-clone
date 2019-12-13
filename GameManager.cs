using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas GameOver;
    public Canvas NextLevel;
    
    void Start()
    {
        GameOver.enabled = false;
        NextLevel.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<KnifeChopAnim>().isGameOver)
        {
            GameOver.enabled = true;
        }

        if (FindObjectOfType<KnifeChopAnim>().isLevelComplete)
        {
            NextLevel.enabled = true;
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevelAction()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
