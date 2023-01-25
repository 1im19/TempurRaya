using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Cutscene1 : MonoBehaviour
{
    public RawImage background;
    public GameObject panel;
    public TextMeshProUGUI backgroundtext;

    public Camera camera;

    public GameObject player1;
    public GameObject player2;
    public GameObject enemy;

    public RawImage textbox1;
    public TextMeshProUGUI textboxtext1;
    public RawImage textbox2;
    public TextMeshProUGUI textboxtext2;
    public RawImage textbox3;
    public TextMeshProUGUI textboxtext3;
    public RawImage textbox4;
    public TextMeshProUGUI textboxtext4;
    public RawImage textbox5;
    public TextMeshProUGUI textboxtext5;
    public RawImage textbox6;
    public TextMeshProUGUI textboxtext6;

    public TextMeshProUGUI startbattletext;

    public Button nextbutton;

    private int sequence;


    // Start is called before the first frame update
    void Start()
    {
        background.gameObject.SetActive(true);
        panel.gameObject.SetActive(true);
        backgroundtext.gameObject.SetActive(true);

        player1.gameObject.SetActive(false);
        player2.gameObject.SetActive(false);
        enemy.gameObject.SetActive(false);

        textbox1.gameObject.SetActive(false);
        textboxtext1.gameObject.SetActive(false);
        textbox2.gameObject.SetActive(false);
        textboxtext2.gameObject.SetActive(false);
        textbox3.gameObject.SetActive(false);
        textboxtext3.gameObject.SetActive(false);
        textbox4.gameObject.SetActive(false);
        textboxtext4.gameObject.SetActive(false);
        textbox5.gameObject.SetActive(false);
        textboxtext5.gameObject.SetActive(false);
        textbox6.gameObject.SetActive(false);
        textboxtext6.gameObject.SetActive(false);

        nextbutton.gameObject.SetActive(true);
        startbattletext.gameObject.SetActive(true);

        startbattletext.text = "Next";

        sequence = 1;
    }

    public void NextSequence()
    {
        sequence += 1;

        if (sequence == 2)
        {
            Sequence2();
        }
        else if (sequence == 3)
        {
            Sequence3();
        }
        else if (sequence == 4)
        {
            Sequence4();
        }
        else if (sequence == 5)
        {
            Sequence5();
        }
        else if (sequence == 6)
        {
            Sequence6();    
        }

        if (sequence >= 6)
        {
            startbattletext.text = "Start Battle";
        }

        if (sequence >= 7)
        {
            SceneManager.LoadScene("Story Mode StatsDisplay");
        }
    }

    void Sequence2()
    {
        background.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);
        backgroundtext.gameObject.SetActive(false);

        camera.transform.position = new Vector3(-20, 5, -20);
        camera.transform.rotation = Quaternion.Euler(0.0f, 30.0f, 0.0f);

        player1.transform.position = new Vector3(-25, 0, 5);
        player1.transform.rotation = Quaternion.Euler(0.0f, 45.0f, 0.0f);

        player1.gameObject.SetActive(true);

        textbox1.gameObject.SetActive(true);
        textboxtext1.gameObject.SetActive(true);

        nextbutton.gameObject.SetActive(true);
        startbattletext.gameObject.SetActive(true);
    }

    void Sequence3()
    {
        textbox1.gameObject.SetActive(false);
        textboxtext1.gameObject.SetActive(false);

        textbox2.gameObject.SetActive(true);
        textboxtext2.gameObject.SetActive(true);

        nextbutton.gameObject.SetActive(true);
        startbattletext.gameObject.SetActive(true);
    }

    void Sequence4()
    {
        enemy.gameObject.SetActive(true);

        textbox2.gameObject.SetActive(false);
        textboxtext2.gameObject.SetActive(false);

        textbox3.gameObject.SetActive(true);
        textboxtext3.gameObject.SetActive(true);

        nextbutton.gameObject.SetActive(true);
        startbattletext.gameObject.SetActive(true);
    }

    void Sequence5()
    {
        enemy.gameObject.SetActive(false);

        camera.transform.rotation = Quaternion.Euler(0.0f, -20.0f, 0.0f);

        player1.transform.position = new Vector3(-20, 0, 0);
        player1.transform.rotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);

        player2.gameObject.SetActive(true);

        textbox3.gameObject.SetActive(false);
        textboxtext3.gameObject.SetActive(false);

        textbox4.gameObject.SetActive(true);
        textboxtext4.gameObject.SetActive(true);

        nextbutton.gameObject.SetActive(true);
        startbattletext.gameObject.SetActive(true);
    }

    void Sequence6()
    {
        player1.transform.position = new Vector3(-15, 0, 0);
        player1.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);

        textbox4.gameObject.SetActive(false);
        textboxtext4.gameObject.SetActive(false);

        textbox5.gameObject.SetActive(true);
        textboxtext5.gameObject.SetActive(true);

        textbox6.gameObject.SetActive(true);
        textboxtext6.gameObject.SetActive(true);

        nextbutton.gameObject.SetActive(true);
        startbattletext.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
    