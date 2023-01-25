using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class StoryGameOver : MonoBehaviour
{
    public TextMeshProUGUI wavesurvivedtext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wavesurvivedtext.text = "Waves survived: " + (StoryBattle.wave - 1);
    }

    public void Retry()
    {
        StoryBattle.wave = 1;

        SceneManager.LoadScene("Story Mode Wave 1");
    }

    public void MainMenu()
    {
        StoryBattle.wave = 1;

        SceneManager.LoadScene("Main Menu");
    }
}
