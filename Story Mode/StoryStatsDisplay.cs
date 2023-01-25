using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class StoryStatsDisplay : MonoBehaviour
{
    public TextMeshProUGUI wavetext;

    public TextMeshProUGUI HPtext;
    public TextMeshProUGUI SPtext;
    public TextMeshProUGUI ATKtext;
    public TextMeshProUGUI DEFtext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        wavetext.text = "Wave " + StoryBattle.wave;

        if (StoryBattle.wave == 1)
        {
            HPtext.text = "= 100";
            SPtext.text = "= 50 " ;
            ATKtext.text = "= 10";
            DEFtext.text = "= 5";
        }
        else
        {
            HPtext.text = "= " + StoryBattle.playerHP;
            SPtext.text = "= " + StoryBattle.playerSP;
            ATKtext.text = "= " + StoryBattle.playerATK;
            DEFtext.text = "= " + StoryBattle.playerDEF;
        }
    }

    public void Proceed()
    {
        if (StoryBattle.wave == 1)
        {
            SceneManager.LoadScene("Story Mode Wave 1");
        }
        else if (StoryBattle.wave == 2)
        {
            SceneManager.LoadScene("Story Mode Wave 2");
        }
        else if (StoryBattle.wave == 3)
        {
            SceneManager.LoadScene("Story Mode Wave 3");
        }
    }
}
