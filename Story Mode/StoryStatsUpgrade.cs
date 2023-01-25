using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StoryStatsUpgrade : MonoBehaviour
{
    public TextMeshProUGUI wintext;

    public TextMeshProUGUI HPUpgradetext;
    public TextMeshProUGUI SPUpgradetext;
    public TextMeshProUGUI ATKUpgradetext;
    public TextMeshProUGUI DEFUpgradetext;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        wintext.text = "You win! Wave " + StoryBattle.wave + " survived";
        HPUpgradetext.text = "HP (" + StoryBattle.playermaxHP + " -> " + (StoryBattle.playermaxHP + 100) + ")\n(also replenish your HP)";
        SPUpgradetext.text = "SP (" + StoryBattle.playermaxSP + " -> " + (StoryBattle.playermaxSP + 50) + ")\n(also replenish your SP)";
        ATKUpgradetext.text = "ATK (" + StoryBattle.playerATK + " -> " + (StoryBattle.playerATK + 10) + ")";
        DEFUpgradetext.text = "DEF (" + StoryBattle.playerDEF + " -> " + (StoryBattle.playerDEF + 5) + ")";
    }

    public void HPUpgrade()
    {
        StoryBattle.playermaxHP += 100;
        StoryBattle.playerHP = StoryBattle.playermaxHP;

        StoryBattle.wave += 1;

        SceneManager.LoadScene("Story Mode StatsDisplay");
    }

    public void SPUpgrade()
    {
        StoryBattle.playermaxSP += 50;
        StoryBattle.playerSP = StoryBattle.playermaxSP;

        StoryBattle.wave += 1;

        SceneManager.LoadScene("Story Mode StatsDisplay");
    }

    public void ATKUpgrade()
    {
        StoryBattle.playerATK += 10;

        StoryBattle.wave += 1;

        SceneManager.LoadScene("Story Mode StatsDisplay");
    }

    public void DEFUpgrade()
    {
        StoryBattle.playerDEF += 5;

        StoryBattle.wave += 1;

        SceneManager.LoadScene("Story Mode StatsDisplay");
    }
}
