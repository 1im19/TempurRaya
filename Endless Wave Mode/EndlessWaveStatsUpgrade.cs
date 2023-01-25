using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndlessWaveStatsUpgrade : MonoBehaviour
{
    public TextMeshProUGUI wintext;

    public TextMeshProUGUI HPUpgradetext;
    public TextMeshProUGUI SPUpgradetext;
    public TextMeshProUGUI ATKUpgradetext;
    public TextMeshProUGUI DEFUpgradetext;

    private float levelloader;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wintext.text = "You win! Wave " + EndlessWaveBattle.wave + " survived";
        HPUpgradetext.text = "HP (" + EndlessWaveBattle.playermaxHP + " -> " + (EndlessWaveBattle.playermaxHP + 100) + ")\n(also replenish your HP)";
        SPUpgradetext.text = "SP (" + EndlessWaveBattle.playermaxSP + " -> " + (EndlessWaveBattle.playermaxSP + 50) + ")\n(also replenish your SP)";
        ATKUpgradetext.text = "ATK (" + EndlessWaveBattle.playerATK + " -> " + (EndlessWaveBattle.playerATK + 10) + ")";
        DEFUpgradetext.text = "DEF (" + EndlessWaveBattle.playerDEF + " -> " + (EndlessWaveBattle.playerDEF + 5) + ")";
    }

    public void HPUpgrade()
    {
        EndlessWaveBattle.playermaxHP += 100;
        EndlessWaveBattle.playerHP = EndlessWaveBattle.playermaxHP;

        EndlessWaveBattle.wave += 1;

        SceneManager.LoadScene("Endless Wave Stats Display");
    }

    public void SPUpgrade()
    {
        EndlessWaveBattle.playermaxSP += 50;
        EndlessWaveBattle.playerSP = EndlessWaveBattle.playermaxSP;

        EndlessWaveBattle.wave += 1;

        SceneManager.LoadScene("Endless Wave Stats Display");
    }

    public void ATKUpgrade()
    {
        EndlessWaveBattle.playerATK += 10;

        EndlessWaveBattle.wave += 1;

        SceneManager.LoadScene("Endless Wave Stats Display");
    }

    public void DEFUpgrade()
    {
        EndlessWaveBattle.playerDEF += 5;

        EndlessWaveBattle.wave += 1;

        SceneManager.LoadScene("Endless Wave Stats Display");
    }
}
