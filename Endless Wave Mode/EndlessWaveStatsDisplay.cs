using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndlessWaveStatsDisplay : MonoBehaviour
{
    public TextMeshProUGUI wavetext;

    public TextMeshProUGUI HPtext;
    public TextMeshProUGUI SPtext;
    public TextMeshProUGUI ATKtext;
    public TextMeshProUGUI DEFtext;

    private float levelloader;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wavetext.text = "Wave " + EndlessWaveBattle.wave;

        if (EndlessWaveBattle.wave == 1)
        {
            HPtext.text = "= 100";
            SPtext.text = "= 50 ";
            ATKtext.text = "= 10";
            DEFtext.text = "= 5";
        }
        else
        {
            HPtext.text = "= " + EndlessWaveBattle.playerHP;
            SPtext.text = "= " + EndlessWaveBattle.playerSP;
            ATKtext.text = "= " + EndlessWaveBattle.playerATK;
            DEFtext.text = "= " + EndlessWaveBattle.playerDEF;
        }
    }

    public void StartBattle()
    {
        levelloader = Random.Range(0, 300.0f);
        if(levelloader < 100.0f)
        {
            SceneManager.LoadScene("Endless Wave Battle 1");
        }
        else if(levelloader >= 100.0f && levelloader < 200.0f)
        {
            SceneManager.LoadScene("Endless Wave Battle 2");
        }
        else if (levelloader >= 200.0f && levelloader < 300.0f)
        {
            SceneManager.LoadScene("Endless Wave Battle 3");
        }
    }
}
