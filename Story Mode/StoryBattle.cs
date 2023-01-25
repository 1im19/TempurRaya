using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StoryBattle : MonoBehaviour
{
    public GameObject player;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;

    public GameObject battlepanel;
    public GameObject attackpanel;
    public GameObject skillpanel;
    public GameObject attackingpanel;
    public GameObject pausepanel;

    public GameObject attackenemy1button;
    public GameObject attackenemy2button;
    public GameObject attackenemy3button;
    public GameObject attackenemy4button;
    public GameObject attackenemy5button;

    public GameObject skillbutton;

    public GameObject skillenemy1button;
    public GameObject skillenemy2button;
    public GameObject skillenemy3button;
    public GameObject skillenemy4button;
    public GameObject skillenemy5button;

    public TextMeshProUGUI attackingtext;

    public Animator playeranimation;

    public Animator enemy1animation;
    public Animator enemy2animation;
    public Animator enemy3animation;
    public Animator enemy4animation;
    public Animator enemy5animation;

    public AudioSource shootingsound;

    public static int wave = 1;

    public static int playermaxHP;
    public static int playerHP;
    public static int playermaxSP;
    public static int playerSP;
    public static int playerATK;
    public static int playerDEF;

    public static int enemy1HP;
    public static int enemy1SP;
    public static int enemy1ATK;
    public static int enemy1DEF;

    public static int enemy2HP;
    public static int enemy2SP;
    public static int enemy2ATK;
    public static int enemy2DEF;

    public static int enemy3HP;
    public static int enemy3SP;
    public static int enemy3ATK;
    public static int enemy3DEF;

    public static int enemy4HP;
    public static int enemy4SP;
    public static int enemy4ATK;
    public static int enemy4DEF;

    public static int enemy5HP;
    public static int enemy5SP;
    public static int enemy5ATK;
    public static int enemy5DEF;

    public TextMeshProUGUI playerHPtext;
    public TextMeshProUGUI playerSPtext;

    public TextMeshProUGUI enemy1HPtext;
    public TextMeshProUGUI enemy2HPtext;
    public TextMeshProUGUI enemy3HPtext;
    public TextMeshProUGUI enemy4HPtext;
    public TextMeshProUGUI enemy5HPtext;

    public TextMeshProUGUI playerdamagetext;
    public TextMeshProUGUI spconsumedtext;

    public TextMeshProUGUI enemydamagetext;

    public GameObject playercritimage;
    public GameObject enemycritimage;

    private int playerdamage;
    private int enemydamage;

    private int playercrit;
    private int enemycrit;

    private int enemycount;
    private int maxenemycount;

    private float enemyturn;

    private bool playerskill;
    private float enemymove;
    private bool enemyskill;

    // Start is called before the first frame update
    void Start()
    {
        if(wave == 1)
        {
            playermaxHP = 100;
            playerHP = playermaxHP;
            playermaxSP = 50;
            playerSP = playermaxSP;
            playerATK = 10;
            playerDEF = 5;

            enemy1HP = 20;
            enemy1SP = 10;
            enemy1ATK = 5;
            enemy1DEF = 2;

            enemy2HP = 20;
            enemy2SP = 10;
            enemy2ATK = 5;
            enemy2DEF = 2;

            enemy3HP = 20;
            enemy3SP = 10;
            enemy3ATK = 5;
            enemy3DEF = 2;

            enemy4HP = 20;
            enemy4SP = 10;
            enemy4ATK = 5;
            enemy4DEF = 2;

            enemy5HP = 20;
            enemy5SP = 10;
            enemy5ATK = 5;
            enemy5DEF = 2;

            enemycount = 0;
            maxenemycount = 2;

            enemy1.SetActive(true);
            enemy2.SetActive(true);
            enemy3.SetActive(false);
            enemy4.SetActive(false);
            enemy5.SetActive(false);

            attackenemy1button.SetActive(true);
            attackenemy2button.SetActive(true);
            attackenemy3button.SetActive(false);
            attackenemy4button.SetActive(false);
            attackenemy5button.SetActive(false);

            skillenemy1button.SetActive(true);
            skillenemy2button.SetActive(true);
            skillenemy3button.SetActive(false);
            skillenemy4button.SetActive(false);
            skillenemy5button.SetActive(false);

            enemy1HPtext.gameObject.SetActive(true);
            enemy2HPtext.gameObject.SetActive(true);
            enemy3HPtext.gameObject.SetActive(false);
            enemy4HPtext.gameObject.SetActive(false);
            enemy5HPtext.gameObject.SetActive(false);
        }
        else if(wave == 2)
        {
            enemy1HP = 40;
            enemy1SP = 10;
            enemy1ATK = 10;
            enemy1DEF = 4;

            enemy2HP = 40;
            enemy2SP = 10;
            enemy2ATK = 10;
            enemy2DEF = 4;

            enemy3HP = 40;
            enemy3SP = 10;
            enemy3ATK = 10;
            enemy3DEF = 4;

            enemy3HP = 40;
            enemy3SP = 10;
            enemy3ATK = 10;
            enemy3DEF = 4;

            enemy4HP = 40;
            enemy4SP = 10;
            enemy4ATK = 10;
            enemy4DEF = 4;

            enemy5HP = 40;
            enemy5SP = 10;
            enemy5ATK = 10;
            enemy5DEF = 4;

            enemycount = 0;
            maxenemycount = 3;

            enemy1.SetActive(true);
            enemy2.SetActive(true);
            enemy3.SetActive(true);
            enemy4.SetActive(false);
            enemy5.SetActive(false);

            attackenemy1button.SetActive(true);
            attackenemy2button.SetActive(true);
            attackenemy3button.SetActive(true);
            attackenemy4button.SetActive(false);
            attackenemy5button.SetActive(false);

            skillenemy1button.SetActive(true);
            skillenemy2button.SetActive(true);
            skillenemy3button.SetActive(true);
            skillenemy4button.SetActive(false);
            skillenemy5button.SetActive(false);

            enemy1HPtext.gameObject.SetActive(true);
            enemy2HPtext.gameObject.SetActive(true);
            enemy3HPtext.gameObject.SetActive(true);
            enemy4HPtext.gameObject.SetActive(false);
            enemy5HPtext.gameObject.SetActive(false);
        }
        else if(wave == 3)
        {
            enemy1HP = 60;
            enemy1SP = 10;
            enemy1ATK = 15;
            enemy1DEF = 6;

            enemy2HP = 60;
            enemy2SP = 10;
            enemy2ATK = 15;
            enemy2DEF = 6;

            enemy3HP = 150;
            enemy3SP = 10;
            enemy3ATK = 30;
            enemy3DEF = 15;

            enemy4HP = 60;
            enemy4SP = 10;
            enemy4ATK = 15;
            enemy4DEF = 6;

            enemy5HP = 60;
            enemy5SP = 10;
            enemy5ATK = 15;
            enemy5DEF = 6;

            enemycount = 0;
            maxenemycount = 5;  

            enemy1.SetActive(true);
            enemy2.SetActive(true);
            enemy3.SetActive(true);
            enemy4.SetActive(true);
            enemy5.SetActive(true);

            attackenemy1button.SetActive(true);
            attackenemy2button.SetActive(true);
            attackenemy3button.SetActive(true);
            attackenemy4button.SetActive(true);
            attackenemy5button.SetActive(true);

            skillenemy1button.SetActive(true);
            skillenemy2button.SetActive(true);
            skillenemy3button.SetActive(true);
            skillenemy4button.SetActive(true);
            skillenemy5button.SetActive(true);

            enemy1HPtext.gameObject.SetActive(true);
            enemy2HPtext.gameObject.SetActive(true);
            enemy3HPtext.gameObject.SetActive(true);
            enemy4HPtext.gameObject.SetActive(true);
            enemy5HPtext.gameObject.SetActive(true);
        }

        player.transform.position = new Vector3(0, 0, 0);
        player.transform.rotation = Quaternion.Euler(0, 0, 0);

        enemy1.transform.position = new Vector3(0, 0, 0);
        enemy1.transform.rotation = Quaternion.Euler(0, 0, 0);

        enemy2.transform.position = new Vector3(0, 0, 0);
        enemy2.transform.rotation = Quaternion.Euler(0, 0, 0);

        enemy3.transform.position = new Vector3(0, 0, 0);
        enemy3.transform.rotation = Quaternion.Euler(0, 0, 0);

        enemy4.transform.position = new Vector3(0, 0, 0);
        enemy4.transform.rotation = Quaternion.Euler(0, 0, 0);

        enemy5.transform.position = new Vector3(0, 0, 0);
        enemy5.transform.rotation = Quaternion.Euler(0, 0, 0);

        playerdamagetext.transform.position = new Vector3(280, 450, 0);
        enemydamagetext.transform.position = new Vector3(770, 410, 0);

        playercritimage.transform.position = new Vector3(500, 450, 0);
        enemycritimage.transform.position = new Vector3(350, 400, 0);

        playerdamagetext.gameObject.SetActive(false);
        spconsumedtext.gameObject.SetActive(false);
        enemydamagetext.gameObject.SetActive(false);

        playercritimage.SetActive(false);
        enemycritimage.SetActive(false);

        battlepanel.SetActive(true);
        attackpanel.SetActive(false);
        skillpanel.SetActive(false);
        attackingpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        playerHPtext.text = "= " + playerHP;
        playerSPtext.text = "= " + playerSP;

        enemy1HPtext.text = enemy1HP.ToString();
        enemy2HPtext.text = enemy2HP.ToString();
        enemy3HPtext.text = enemy3HP.ToString();

        playerdamagetext.transform.position = new Vector3(playerdamagetext.transform.position.x, playerdamagetext.transform.position.y - 1, playerdamagetext.transform.position.z);
        enemydamagetext.transform.position = new Vector3(enemydamagetext.transform.position.x, enemydamagetext.transform.position.y - 1, enemydamagetext.transform.position.z);

        spconsumedtext.transform.position = new Vector3(spconsumedtext.transform.position.x, spconsumedtext.transform.position.y - 1, spconsumedtext.transform.position.z);

        playercritimage.transform.position = new Vector3(playercritimage.transform.position.x, playercritimage.transform.position.y-1, playercritimage.transform.position.z);
        enemycritimage.transform.position = new Vector3(enemycritimage.transform.position.x, enemycritimage.transform.position.y-1, enemycritimage.transform.position.z);

        if (playerSP <= 0)
        {
            skillbutton.SetActive(false);
        }
    }

    public void Attack()
    {
        attackpanel.SetActive(true);
        battlepanel.SetActive(false);
    }

    public void Skill()
    {
        skillpanel.SetActive(true);
        battlepanel.SetActive(false);
    }

    public void AttackEnemy1()
    {
        playerskill = false;
        StartCoroutine(PlayerAttack1Sequence());
    }

    public void AttackEnemy2()
    {
        playerskill = false;
        StartCoroutine(PlayerAttack2Sequence());
    }

    public void AttackEnemy3()
    {
        playerskill = false;
        StartCoroutine(PlayerAttack3Sequence());
    }

    public void AttackEnemy4()
    {
        playerskill = false;
        StartCoroutine(PlayerAttack4Sequence());
    }

    public void AttackEnemy5()
    {
        playerskill = false;
        StartCoroutine(PlayerAttack5Sequence());
    }

    public void SkillEnemy1()
    {
        playerskill = true;
        StartCoroutine(PlayerAttack1Sequence());
    }

    public void SkillEnemy2()
    {
        playerskill = true;
        StartCoroutine(PlayerAttack2Sequence());
    }

    public void SkillEnemy3()
    {
        playerskill = true;
        StartCoroutine(PlayerAttack3Sequence());
    }

    public void SkillEnemy4()
    {
        playerskill = true;
        StartCoroutine(PlayerAttack4Sequence());
    }

    public void SkillEnemy5()
    {
        playerskill = true;
        StartCoroutine(PlayerAttack5Sequence());
    }

    public void AttackBack()
    {
        battlepanel.SetActive(true);
        attackpanel.SetActive(false);
    }

    public void SkillBack()
    {
        battlepanel.SetActive(true);
        skillpanel.SetActive(false);
    }

    public void Pause()
    {
        pausepanel.SetActive(true);
    }

    public void Continue()
    {
        pausepanel.SetActive(false);
    }

    public void Quit()
    {
        SceneManager.LoadScene("Story Mode Game Over");
    }

    IEnumerator PlayerAttack1Sequence()
    {
        attackingpanel.SetActive(true);
        attackpanel.SetActive(false);
        skillpanel.SetActive(false);
        attackingtext.text = "Player Attacking";
        player.transform.position = new Vector3(-10, 0, -25);
        player.transform.rotation = Quaternion.Euler(0, 90, 0);
        playeranimation.SetTrigger("PlayerShoot");
        yield return new WaitForSeconds(2f);
        shootingsound.Play();
        enemy1animation.SetTrigger("EnemyDamage");
        if (playerskill)
        {
            playerSP -= 10;
            spconsumedtext.gameObject.SetActive(true);
            spconsumedtext.transform.position = new Vector3(800, 850, 0);

            playercrit = Random.Range(2, 5);
            enemydamage = (Random.Range(playerATK / 2, playerATK) - Random.Range(enemy1DEF / 2, enemy1DEF)) * playercrit;
        }
        else
        {
            playercrit = 0;
            enemydamage = Random.Range(playerATK / 2, playerATK) - Random.Range(enemy1DEF / 2, enemy1DEF);
        }
        if (enemydamage <= 0)
        {
            enemydamage = 1;
        }
        enemy1HP -= enemydamage;
        if (playercrit > 3)
        {
            playercritimage.transform.position = new Vector3(1000, 850, 0);
            playercritimage.SetActive(true);
        }
        else
        {
            playercritimage.SetActive(false);
        }
        enemydamagetext.text = enemydamage.ToString();
        enemydamagetext.transform.position = new Vector3(1200, 850, 0);
        enemydamagetext.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        player.transform.position = new Vector3(0, 0, 0);
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
        playeranimation.SetTrigger("PlayerIdle");
        if (enemy1HP <= 0)
        {
            enemy1HP = 0;
            enemy1animation.SetTrigger("EnemyDie");
            attackingtext.text = "Enemy 1 Died";
            enemycount += 1;
            yield return new WaitForSeconds(2f);
            if(enemycount >= maxenemycount)
            {
                if(wave < 3)
                {
                    SceneManager.LoadScene("Story Mode StatsUpgrade");
                }
                else
                {
                    SceneManager.LoadScene("Story Victory");
                }
            }
            battlepanel.SetActive(true);
            attackingpanel.SetActive(false);
            attackenemy1button.SetActive(false);
            skillenemy1button.SetActive(false);
        }
        else
        {
            enemyturn = Random.Range(1, maxenemycount * 10);
            if (enemy2HP > 0 || enemy3HP > 0 || enemy4HP > 0 || enemy5HP > 0)
            {
                if (enemyturn >= 40 && enemy5HP > 0)
                {
                    enemy1animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy5AttackSequence());
                }
                else if (enemyturn >= 30 && enemyturn < 40 && enemy4HP > 0)
                {
                    enemy1animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy4AttackSequence());
                }
                else if (enemyturn >= 20 && enemyturn < 30 && enemy3HP > 0)
                {
                    enemy1animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy3AttackSequence());
                }
                else if (enemyturn >= 10 && enemyturn < 20 && enemy2HP > 0)
                {
                    enemy1animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy2AttackSequence());
                }
                else
                {
                    StartCoroutine(Enemy1AttackSequence());
                }
            }
            else
            {
                StartCoroutine(Enemy1AttackSequence());
            }    
        }
    }

    IEnumerator PlayerAttack2Sequence()
    {
        attackingpanel.SetActive(true);
        attackpanel.SetActive(false);
        skillpanel.SetActive(false);
        attackingtext.text = "Player Attacking";
        player.transform.position = new Vector3(-10, 0, -25);
        player.transform.rotation = Quaternion.Euler(0, 90, 0);
        playeranimation.SetTrigger("PlayerShoot");
        yield return new WaitForSeconds(2f);
        shootingsound.Play();
        enemy2animation.SetTrigger("EnemyDamage");
        if (playerskill)
        {
            playerSP -= 10;
            spconsumedtext.gameObject.SetActive(true);
            spconsumedtext.transform.position = new Vector3(800, 850, 0);

            playercrit = Random.Range(2, 5);
            enemydamage = (Random.Range(playerATK / 2, playerATK) - Random.Range(enemy2DEF / 2, enemy2DEF)) * playercrit;
        }
        else
        {
            playercrit = 0;
            enemydamage = Random.Range(playerATK / 2, playerATK) - Random.Range(enemy2DEF / 2, enemy2DEF);
        }
        if (enemydamage <= 0)
        {
            enemydamage = 1;
        }
        enemy2HP -= enemydamage;
        if (playercrit > 3)
        {
            playercritimage.transform.position = new Vector3(1000, 850, 0);
            playercritimage.SetActive(true);
        }
        else
        {
            playercritimage.SetActive(false);
        }
        enemydamagetext.text = enemydamage.ToString();
        enemydamagetext.transform.position = new Vector3(1250, 850, 0);
        enemydamagetext.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        player.transform.position = new Vector3(0, 0, 0);
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
        playeranimation.SetTrigger("PlayerIdle");
        if (enemy2HP <= 0)
        {
            enemy2HP = 0;
            enemy2animation.SetTrigger("EnemyDie");
            attackingtext.text = "Enemy 2 Died";
            enemycount += 1;
            yield return new WaitForSeconds(2f);
            if (enemycount >= maxenemycount)
            {
                if (wave < 3)
                {
                    SceneManager.LoadScene("Story Mode StatsUpgrade");
                }
                else
                {
                    SceneManager.LoadScene("Story Victory");
                }
            }
            battlepanel.SetActive(true);
            attackingpanel.SetActive(false);
            attackenemy2button.SetActive(false);
            skillenemy2button.SetActive(false);
        }
        else
        {
            enemyturn = Random.Range(1, maxenemycount * 10);
            if (enemy1HP > 0 || enemy3HP > 0 || enemy4HP > 0 || enemy5HP > 0)
            {
                if (enemyturn >= 40 && enemy5HP > 0)
                {
                    enemy2animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy5AttackSequence());
                }
                else if (enemyturn >= 30 && enemyturn < 40 && enemy4HP > 0)
                {
                    enemy2animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy4AttackSequence());
                }
                else if (enemyturn >= 20 && enemyturn < 40 && enemy3HP > 0)
                {
                    enemy2animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy3AttackSequence());
                }
                else if (enemyturn >= 0 && enemyturn < 10 && enemy1HP > 0)
                {
                    enemy2animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy1AttackSequence());
                }
                else
                {
                    StartCoroutine(Enemy2AttackSequence());
                }
            }
            else
            {
                StartCoroutine(Enemy2AttackSequence());
            }
        }
    }

    IEnumerator PlayerAttack3Sequence()
    {
        attackingpanel.SetActive(true);
        attackpanel.SetActive(false);
        skillpanel.SetActive(false);
        attackingtext.text = "Player Attacking";
        player.transform.position = new Vector3(-10, 0, -25);
        player.transform.rotation = Quaternion.Euler(0, 90, 0);
        playeranimation.SetTrigger("PlayerShoot");
        yield return new WaitForSeconds(2f);
        shootingsound.Play();
        enemy3animation.SetTrigger("EnemyDamage");
        if(playerskill)
        {
            playerSP -= 10;
            spconsumedtext.gameObject.SetActive(true);
            spconsumedtext.transform.position = new Vector3(800, 850, 0);

            playercrit = Random.Range(2, 5);
            enemydamage = (Random.Range(playerATK / 2, playerATK) - Random.Range(enemy3DEF / 2, enemy3DEF)) * playercrit;
        }
        else
        {
            playercrit = 0;
            enemydamage = Random.Range(playerATK / 2, playerATK) - Random.Range(enemy3DEF / 2, enemy3DEF);
        }
        if (enemydamage <= 0)
        {
            enemydamage = 1;
        }
        enemy3HP -= enemydamage;
        if (playercrit > 3)
        {
            playercritimage.transform.position = new Vector3(1000, 850, 0);
            playercritimage.SetActive(true);
        }
        else
        {
            playercritimage.SetActive(false);
        }
        enemydamagetext.text = enemydamage.ToString();
        enemydamagetext.transform.position = new Vector3(1400, 800, 0);
        enemydamagetext.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        player.transform.position = new Vector3(0, 0, 0);
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
        playeranimation.SetTrigger("PlayerIdle");
        if (enemy3HP <= 0)
        {
            enemy3HP = 0;
            enemy3animation.SetTrigger("EnemyDie");
            if(wave == 3)
            {
                attackingtext.text = "Boss Died";
                yield return new WaitForSeconds(2f);
                SceneManager.LoadScene("Story Victory");
            }
            else
            {
                attackingtext.text = "Enemy 3 Died";
            }
            enemycount += 1;
            yield return new WaitForSeconds(2f);
            if (enemycount >= maxenemycount)
            {
                SceneManager.LoadScene("Story Mode StatsUpgrade");
            }
            battlepanel.SetActive(true);
            attackingpanel.SetActive(false);
            attackenemy3button.SetActive(false);
            skillenemy3button.SetActive(false);
        }
        else
        {
            enemyturn = Random.Range(1, maxenemycount * 10);
            if (enemy1HP > 0 || enemy2HP > 0)
            {
                if (enemyturn >= 40 && enemy5HP > 0)
                {
                    enemy3animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy5AttackSequence());
                }
                else if (enemyturn >= 30 && enemyturn < 40 && enemy4HP > 0)
                {
                    enemy3animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy4AttackSequence());
                }
                else if (enemyturn >= 10 && enemyturn < 20 && enemy2HP > 0)
                {
                    enemy3animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy2AttackSequence());
                }
                else if (enemyturn >= 0 && enemyturn < 10 && enemy1HP > 0)
                {
                    enemy3animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy1AttackSequence());
                }
                else
                {
                    StartCoroutine(Enemy3AttackSequence());
                }
            }
            else
            {
                StartCoroutine(Enemy3AttackSequence());
            }
        }
    }

    IEnumerator PlayerAttack4Sequence()
    {
        attackingpanel.SetActive(true);
        attackpanel.SetActive(false);
        skillpanel.SetActive(false);
        attackingtext.text = "Player Attacking";
        player.transform.position = new Vector3(-10, 0, -25);
        player.transform.rotation = Quaternion.Euler(0, 90, 0);
        playeranimation.SetTrigger("PlayerShoot");
        yield return new WaitForSeconds(2f);
        shootingsound.Play();
        enemy4animation.SetTrigger("EnemyDamage");
        if (playerskill)
        {
            playerSP -= 10;
            spconsumedtext.gameObject.SetActive(true);
            spconsumedtext.transform.position = new Vector3(800, 850, 0);

            playercrit = Random.Range(2, 5);
            enemydamage = (Random.Range(playerATK / 2, playerATK) - Random.Range(enemy4DEF / 2, enemy4DEF)) * playercrit;
        }
        else
        {
            playercrit = 0;
            enemydamage = Random.Range(playerATK / 2, playerATK) - Random.Range(enemy4DEF / 2, enemy4DEF);
        }
        if (enemydamage <= 0)
        {
            enemydamage = 1;
        }
        enemy4HP -= enemydamage;
        if (playercrit > 3)
        {
            playercritimage.transform.position = new Vector3(1000, 850, 0);
            playercritimage.SetActive(true);
        }
        else
        {
            playercritimage.SetActive(false);
        }
        enemydamagetext.text = enemydamage.ToString();
        enemydamagetext.transform.position = new Vector3(1550, 750, 0);
        enemydamagetext.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        player.transform.position = new Vector3(0, 0, 0);
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
        playeranimation.SetTrigger("PlayerIdle");
        if (enemy4HP <= 0)
        {
            enemy4HP = 0;
            enemy4animation.SetTrigger("EnemyDie");
            attackingtext.text = "Enemy 3 Died";
            enemycount += 1;
            yield return new WaitForSeconds(2f);
            if (enemycount >= maxenemycount)
            {
                if (wave < 3)
                {
                    SceneManager.LoadScene("Story Mode StatsUpgrade");
                }
                else
                {
                    SceneManager.LoadScene("Story Victory");
                }
            }
            battlepanel.SetActive(true);
            attackingpanel.SetActive(false);
            attackenemy4button.SetActive(false);
            skillenemy4button.SetActive(false);
        }
        else
        {
            enemyturn = Random.Range(1, maxenemycount * 10);
            if (enemy1HP > 0 || enemy2HP > 0)
            {
                if (enemyturn >= 40 && enemy5HP > 0)
                {
                    enemy4animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy5AttackSequence());
                }
                else if (enemyturn >= 20 && enemyturn < 30 && enemy3HP > 0)
                {
                    enemy4animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy3AttackSequence());
                }
                else if (enemyturn >= 10 && enemyturn < 20 && enemy2HP > 0)
                {
                    enemy3animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy2AttackSequence());
                }
                else if (enemyturn >= 0 && enemyturn < 10 && enemy3HP > 0)
                {
                    enemy3animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy1AttackSequence());
                }
                else
                {
                    StartCoroutine(Enemy4AttackSequence());
                }
            }
            else
            {
                StartCoroutine(Enemy4AttackSequence());
            }
        }
    }

    IEnumerator PlayerAttack5Sequence()
    {
        attackingpanel.SetActive(true);
        attackpanel.SetActive(false);
        skillpanel.SetActive(false);
        attackingtext.text = "Player Attacking";
        player.transform.position = new Vector3(-10, 0, -25);
        player.transform.rotation = Quaternion.Euler(0, 90, 0);
        playeranimation.SetTrigger("PlayerShoot");
        yield return new WaitForSeconds(2f);
        shootingsound.Play();
        enemy5animation.SetTrigger("EnemyDamage");
        if (playerskill)
        {
            playerSP -= 10;
            spconsumedtext.gameObject.SetActive(true);
            spconsumedtext.transform.position = new Vector3(800, 850, 0);

            playercrit = Random.Range(2, 5);
            enemydamage = (Random.Range(playerATK / 2, playerATK) - Random.Range(enemy5DEF / 2, enemy5DEF)) * playercrit;
        }
        else
        {
            playercrit = 0;
            enemydamage = Random.Range(playerATK / 2, playerATK) - Random.Range(enemy5DEF / 2, enemy5DEF);
        }
        if (enemydamage <= 0)
        {
            enemydamage = 1;
        }
        enemy5HP -= enemydamage;
        if (playercrit > 3)
        {
            playercritimage.transform.position = new Vector3(1000, 850, 0);
            playercritimage.SetActive(true);
        }
        else
        {
            playercritimage.SetActive(false);
        }
        enemydamagetext.text = enemydamage.ToString();
        enemydamagetext.transform.position = new Vector3(170, 700, 0);
        enemydamagetext.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        player.transform.position = new Vector3(0, 0, 0);
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
        playeranimation.SetTrigger("PlayerIdle");
        if (enemy5HP <= 0)
        {
            enemy5HP = 0;
            enemy5animation.SetTrigger("EnemyDie");
            attackingtext.text = "Enemy 4 Died";
            enemycount += 1;
            yield return new WaitForSeconds(2f);
            if (enemycount >= maxenemycount)
            {
                if (wave < 3)
                {
                    SceneManager.LoadScene("Story Mode StatsUpgrade");
                }
                else
                {
                    SceneManager.LoadScene("Story Victory");
                }
            }
            battlepanel.SetActive(true);
            attackingpanel.SetActive(false);
            attackenemy5button.SetActive(false);
            skillenemy5button.SetActive(false);
        }
        else
        {
            enemyturn = Random.Range(1, maxenemycount * 10);
            if (enemy1HP > 0 || enemy2HP > 0)
            {
                if (enemyturn >= 40 && enemy5HP > 0)
                {
                    enemy5animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy5AttackSequence());
                }
                else if (enemyturn >= 20 && enemyturn < 30 && enemy3HP > 0)
                {
                    enemy5animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy3AttackSequence());
                }
                else if (enemyturn >= 10 && enemyturn < 20 && enemy2HP > 0)
                {
                    enemy3animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy2AttackSequence());
                }
                else if (enemyturn >= 0 && enemyturn < 10 && enemy3HP > 0)
                {
                    enemy3animation.SetTrigger("EnemyIdle");
                    StartCoroutine(Enemy1AttackSequence());
                }
                else
                {
                    StartCoroutine(Enemy4AttackSequence());
                }
            }
            else
            {
                StartCoroutine(Enemy4AttackSequence());
            }
        }
    }

    IEnumerator Enemy1AttackSequence()
    {
        enemymove = Random.Range(1.0f, 20.0f);
        if (enemymove > 10.0f && enemy1SP > 0)
        {
            enemyskill = true;
        }
        else
        {
            enemyskill = false;
        }
        attackingtext.text = "Enemy 1 Attacking";
        enemy1.transform.position = new Vector3(5, 0, -15);
        enemy1.transform.rotation = Quaternion.Euler(0, -45, 0);
        enemy1animation.SetTrigger("EnemyShoot");
        yield return new WaitForSeconds(1f);
        shootingsound.Play();
        playeranimation.SetTrigger("PlayerDamage");
        if (enemyskill)
        {
            enemy1SP -= 10;
            enemycrit = Random.Range(2, 5);
            playerdamage = (Random.Range(enemy1ATK / 2, enemy1ATK) - Random.Range(playerDEF / 2, playerDEF)) * enemycrit;
        }
        else
        {
            enemycrit = 0;
            playerdamage = Random.Range(enemy1ATK / 2, enemy1ATK) - Random.Range(playerDEF / 2, playerDEF);
        }

        if (playerdamage <= 0)
        {
            playerdamage = 1;
        }
        playerHP -= playerdamage;
        if (enemycrit > 3)
        {
            enemycritimage.transform.position = new Vector3(800, 850, 0);
            enemycritimage.SetActive(true);
        }
        else
        {
            enemycritimage.SetActive(false);
        }
        playerdamagetext.text = playerdamage.ToString();
        playerdamagetext.transform.position = new Vector3(750, 1000, 0);
        playerdamagetext.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        if (playerHP <= 0)
        {
            playeranimation.SetTrigger("PlayerDie");
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Story Mode Game Over");
        }
        enemy1.transform.position = new Vector3(0, 0, 0);
        enemy1.transform.rotation = Quaternion.Euler(0, 0, 0);
        enemy1animation.SetTrigger("EnemyIdle");
        battlepanel.SetActive(true);
        attackingpanel.SetActive(false);
    }

    IEnumerator Enemy2AttackSequence()
    {
        enemymove = Random.Range(1.0f, 20.0f);
        if (enemymove > 10.0f && enemy2SP > 0)
        {
            enemyskill = true;
        }
        else
        {
            enemyskill = false;
        }
        attackingtext.text = "Enemy 2 Attacking";
        enemy2.transform.position = new Vector3(0, 0, -15);
        enemy2.transform.rotation = Quaternion.Euler(0, -45, 0);
        enemy2animation.SetTrigger("EnemyShoot");
        yield return new WaitForSeconds(1f);
        shootingsound.Play();
        playeranimation.SetTrigger("PlayerDamage");
        if (enemyskill)
        {
            enemy2SP -= 10;
            enemycrit = Random.Range(2, 5);
            playerdamage = (Random.Range(enemy2ATK / 2, enemy2ATK) - Random.Range(playerDEF / 2, playerDEF)) * enemycrit;
        }
        else
        {
            enemycrit = 0;
            playerdamage = Random.Range(enemy2ATK / 2, enemy2ATK) - Random.Range(playerDEF / 2, playerDEF);
        }

        if (playerdamage <= 0)
        {
            playerdamage = 1;
        }
        playerHP -= playerdamage;
        if (enemycrit > 3)
        {
            enemycritimage.transform.position = new Vector3(800, 850, 0);
            enemycritimage.SetActive(true);
        }
        else
        {
            enemycritimage.SetActive(false);
        }
        playerdamagetext.text = playerdamage.ToString();
        playerdamagetext.transform.position = new Vector3(750, 1000, 0);
        playerdamagetext.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        if (playerHP <= 0)
        {
            playeranimation.SetTrigger("PlayerDie");
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Story Mode Game Over");
        }
        enemy2.transform.position = new Vector3(0, 0, 0);
        enemy2.transform.rotation = Quaternion.Euler(0, 0, 0);
        enemy2animation.SetTrigger("EnemyIdle");
        battlepanel.SetActive(true);
        attackingpanel.SetActive(false);
    }

    IEnumerator Enemy3AttackSequence()
    {
        enemymove = Random.Range(1.0f, 20.0f);
        if (enemymove > 10.0f && enemy3SP > 0)
        {
            enemyskill = true;
        }
        else
        {
            enemyskill = false;
        }
        if (wave == 3)
        {
            attackingtext.text = "Boss Attacking";
            enemy3.transform.position = new Vector3(5, 0, 5);
            enemy3.transform.rotation = Quaternion.Euler(0, 20, 0);
        }
        else
        {
            attackingtext.text = "Enemy 3 Attacking";
            enemy3.transform.position = new Vector3(10, 0, 10);
            enemy3.transform.rotation = Quaternion.Euler(0, -45, 0);
        }

        enemy3animation.SetTrigger("EnemyShoot");
        yield return new WaitForSeconds(1f);
        shootingsound.Play();
        playeranimation.SetTrigger("PlayerDamage");
        if (enemyskill)
        {
            enemy3SP -= 10;
            enemycrit = Random.Range(2, 5);
            playerdamage = (Random.Range(enemy3ATK / 2, enemy3ATK) - Random.Range(playerDEF / 2, playerDEF)) * enemycrit;
        }
        else
        {
            enemycrit = 0;
            playerdamage = Random.Range(enemy3ATK / 2, enemy3ATK) - Random.Range(playerDEF / 2, playerDEF);
        }

        if (playerdamage <= 0)
        {
            playerdamage = 1;
        }
        playerHP -= playerdamage;
        if (enemycrit > 3)
        {
            enemycritimage.transform.position = new Vector3(800, 850, 0);
            enemycritimage.SetActive(true);
        }
        else
        {
            enemycritimage.SetActive(false);
        }
        playerdamagetext.text = playerdamage.ToString();
        playerdamagetext.transform.position = new Vector3(750, 1000, 0);
        playerdamagetext.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        if (playerHP <= 0)
        {
            playeranimation.SetTrigger("PlayerDie");
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Story Mode Game Over");
        }
        enemy3.transform.position = new Vector3(0, 0, 0);
        enemy3.transform.rotation = Quaternion.Euler(0, 0, 0);
        enemy3animation.SetTrigger("EnemyIdle");
        battlepanel.SetActive(true);
        attackingpanel.SetActive(false);
    }

    IEnumerator Enemy4AttackSequence()
    {
        enemymove = Random.Range(1.0f, 20.0f);
        if (enemymove > 10.0f && enemy3SP > 0)
        {
            enemyskill = true;
        }
        else
        {
            enemyskill = false;
        }
        attackingtext.text = "Enemy 3 Attacking";
        enemy4.transform.position = new Vector3(-5, 0, -20);
        enemy4.transform.rotation = Quaternion.Euler(0, -45, 0);
        enemy4animation.SetTrigger("EnemyShoot");
        yield return new WaitForSeconds(1f);
        shootingsound.Play();
        playeranimation.SetTrigger("PlayerDamage");
        if (enemyskill)
        {
            enemy4SP -= 10;
            enemycrit = Random.Range(2, 5);
            playerdamage = (Random.Range(enemy4ATK / 2, enemy4ATK) - Random.Range(playerDEF / 2, playerDEF)) * enemycrit;
        }
        else
        {
            enemycrit = 0;
            playerdamage = Random.Range(enemy4ATK / 2, enemy4ATK) - Random.Range(playerDEF / 2, playerDEF);
        }

        if (playerdamage <= 0)
        {
            playerdamage = 1;
        }
        playerHP -= playerdamage;
        if (enemycrit > 3)
        {
            enemycritimage.transform.position = new Vector3(800, 850, 0);
            enemycritimage.SetActive(true);
        }
        else
        {
            enemycritimage.SetActive(false);
        }
        playerdamagetext.text = playerdamage.ToString();
        playerdamagetext.transform.position = new Vector3(750, 1000, 0);
        playerdamagetext.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        if (playerHP <= 0)
        {
            playeranimation.SetTrigger("PlayerDie");
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Story Mode Game Over");
        }
        enemy4.transform.position = new Vector3(0, 0, 0);
        enemy4.transform.rotation = Quaternion.Euler(0, 0, 0);
        enemy4animation.SetTrigger("EnemyIdle");
        battlepanel.SetActive(true);
        attackingpanel.SetActive(false);
    }

    IEnumerator Enemy5AttackSequence()
    {
        enemymove = Random.Range(1.0f, 20.0f);
        if (enemymove > 10.0f && enemy3SP > 0)
        {
            enemyskill = true;
        }
        else
        {
            enemyskill = false;
        }
        attackingtext.text = "Enemy 4 Attacking";
        enemy5.transform.position = new Vector3(-5, 0, -20);
        enemy5.transform.rotation = Quaternion.Euler(0, -45, 0);
        enemy5animation.SetTrigger("EnemyShoot");
        yield return new WaitForSeconds(1f);
        shootingsound.Play();
        playeranimation.SetTrigger("PlayerDamage");
        if (enemyskill)
        {
            enemy4SP -= 10;
            enemycrit = Random.Range(2, 5);
            playerdamage = (Random.Range(enemy4ATK / 2, enemy4ATK) - Random.Range(playerDEF / 2, playerDEF)) * enemycrit;
        }
        else
        {
            enemycrit = 0;
            playerdamage = Random.Range(enemy4ATK / 2, enemy4ATK) - Random.Range(playerDEF / 2, playerDEF);
        }

        if (playerdamage <= 0)
        {
            playerdamage = 1;
        }
        playerHP -= playerdamage;
        if (enemycrit > 3)
        {
            enemycritimage.transform.position = new Vector3(800, 850, 0);
            enemycritimage.SetActive(true);
        }
        else
        {   
            enemycritimage.SetActive(false);
        }
        playerdamagetext.text = playerdamage.ToString();
        playerdamagetext.transform.position = new Vector3(750, 1000, 0);
        playerdamagetext.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        if (playerHP <= 0)
        {
            playeranimation.SetTrigger("PlayerDie");
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Story Mode Game Over");
        }
        enemy5.transform.position = new Vector3(0, 0, 0);
        enemy5.transform.rotation = Quaternion.Euler(0, 0, 0);
        enemy5animation.SetTrigger("EnemyIdle");
        battlepanel.SetActive(true);
        attackingpanel.SetActive(false);
    }
}
