    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class EndlessWaveGameOver : MonoBehaviour
{
    public TextMeshProUGUI wavesurvivedtext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wavesurvivedtext.text = "Waves survived: " + (EndlessWaveBattle.wave - 1);
    }

    public void Retry()
    {
        EndlessWaveBattle.wave = 1;

        SceneManager.LoadScene("Endless Wave Stats Display");
    }

    public void MainMenu()
    {
        EndlessWaveBattle.wave = 1;

        SceneManager.LoadScene("Main Menu");
    }
}
