using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;    

public class EndlessWaveBattle : MonoBehaviour
{
    public GameObject player;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    public GameObject battlepanel;
    public GameObject attackpanel;
    public GameObject skillpanel;
    public GameObject attackingpanel;
    public GameObject pausepanel;

    public GameObject attackenemy1button;
    public GameObject attackenemy2button;
    public GameObject attackenemy3button;

    public GameObject skillbutton;

    public GameObject skillenemy1button;
    public GameObject skillenemy2button;
    public GameObject skillenemy3button;

    public TextMeshProUGUI attackingtext;

    public Animator playeranimation;

    public Animator enemy1animation;
    public Animator enemy2animation;
    public Animator enemy3animation;

    public AudioSource shootingsound;

    public static int wave = 1;

    public static int playerHP;
    public static int playermaxHP;
    public static int playerSP;
    public static int playermaxSP;
    public static int playerATK;
    public static int playerDEF;

    public static int enemy1maxHP;
    public static int enemy1HP;
    public static int enemy1maxSP;
    public static int enemy1SP;
    public static int enemy1ATK;
    public static int enemy1DEF;

    public static int enemy2maxHP;
    public static int enemy2HP;
    public static int enemy2maxSP;
    public static int enemy2SP;
    public static int enemy2ATK;
    public static int enemy2DEF;

    public static int enemy3maxHP;
    public static int enemy3HP;
    public static int enemy3maxSP;
    public static int enemy3SP;
    public static int enemy3ATK;
    public static int enemy3DEF;

    public TextMeshProUGUI playerHPtext;
    public TextMeshProUGUI playerSPtext;

    public TextMeshProUGUI enemy1HPtext;
    public TextMeshProUGUI enemy2HPtext;
    public TextMeshProUGUI enemy3HPtext;

    public TextMeshProUGUI playerdamagetext;
    public TextMeshProUGUI spconsumedtext;

    public TextMeshProUGUI enemydamagetext;

    public GameObject playercritimage;
    public GameObject enemycritimage;

    private int playercrit;
    private int enemycrit;

    private int playerdamage;
    private int enemydamage;

    private int enemycount;
    private int maxenemycount;

    private float enemyturn;

    private bool playerskill;
    private float enemymove;
    private bool enemyskill;

    // Start is called before the first frame update
    void Start()
    {
        if (wave == 1)
        {
            playermaxHP = 100;
            playerHP = playermaxHP;
            playermaxSP = 50;
            playerSP = playermaxSP;
            playerATK = 10;
            playerDEF = 5;
        }

        enemy1maxHP = 20 * wave;
        enemy1HP = enemy1maxHP;
        enemy1maxSP = 10 * wave;
        enemy1SP = enemy1maxSP;
        enemy1ATK = 5 * wave;
        enemy1DEF = 2 * wave;


        enemy2maxHP = 20 * wave;
        enemy2HP = enemy2maxHP;
        enemy2maxSP = 10 * wave;
        enemy2SP = enemy2maxSP;
        enemy2ATK = 5 * wave;
        enemy2DEF = 2 * wave;

        enemy3maxHP = 20 * wave;
        enemy3HP = enemy3maxHP;
        enemy3maxSP = 10 * wave;
        enemy3SP = enemy3maxSP;
        enemy3ATK = 5 * wave;
        enemy3DEF = 2 * wave;

        playerskill = false;
        enemymove = 0.0f;
        enemyskill = true;

        enemycount = 0;
        maxenemycount = 3;

        player.transform.position = new Vector3(0, 0, 0);
        player.transform.rotation = Quaternion.Euler(0, 0, 0);

        enemy1.transform.position = new Vector3(0, 0, 0);
        enemy1.transform.rotation = Quaternion.Euler(0, 0, 0);

        enemy2.transform.position = new Vector3(0, 0, 0);
        enemy2.transform.rotation = Quaternion.Euler(0, 0, 0);

        enemy3.transform.position = new Vector3(0, 0, 0);
        enemy3.transform.rotation = Quaternion.Euler(0, 0, 0);

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

        playercritimage.transform.position = new Vector3(playercritimage.transform.position.x, playercritimage.transform.position.y - 1, playercritimage.transform.position.z);
        enemycritimage.transform.position = new Vector3(enemycritimage.transform.position.x, enemycritimage.transform.position.y - 1, enemycritimage.transform.position.z);

        if(playerSP <= 0)
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
        SceneManager.LoadScene("Endless Wave Game Over");
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
        if(playerskill)
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
            if (enemycount >= maxenemycount)
            {
                SceneManager.LoadScene("Endless Wave Stats Upgrade");
            }
            battlepanel.SetActive(true);
            attackingpanel.SetActive(false);
            attackenemy1button.SetActive(false);
            skillenemy1button.SetActive(false);
        }
        else
        {
            enemyturn = (Random.Range(1, maxenemycount * 10));
            if (enemy2HP > 0 || enemy3HP > 0)
            { 
                if (enemyturn >= 20 && enemy3HP > 0)
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
        if(playerskill)
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
        if(playercrit > 3)
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
                SceneManager.LoadScene("Endless Wave Stats Upgrade");
            }
            battlepanel.SetActive(true);
            attackingpanel.SetActive(false);
            attackenemy2button.SetActive(false);
            skillenemy2button.SetActive(false);
        }
        else
        {
            enemyturn = Random.Range(1, maxenemycount * 10);
            if (enemy1HP > 0 || enemy3HP > 0)
            {
                if (enemyturn >= 20 && enemyturn < 30 && enemy3HP > 0)
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
            attackingtext.text = "Enemy 3 Died";
            enemycount += 1;
            yield return new WaitForSeconds(2f);
            if (enemycount >= maxenemycount)
            {
                SceneManager.LoadScene("Endless Wave Stats Upgrade");
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
                if (enemyturn >= 10 && enemyturn < 20 && enemy2HP > 0)
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

    IEnumerator Enemy1AttackSequence()
    {
        enemymove = Random.Range(1.0f, 20.0f);
        if(enemymove > 10.0f && enemy1SP > 0)
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
        if(enemyskill)
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
        if(enemycrit > 3)
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
            playerHP = 0;
            playeranimation.SetTrigger("PlayerDie");
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Endless Wave Game Over");
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
            enemy1SP -= 10;
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
        if(enemyskill)
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
            playerHP = 0;
            playeranimation.SetTrigger("PlayerDie");
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Endless Wave Game Over");
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
        attackingtext.text = "Enemy 3 Attacking";
        enemy3.transform.position = new Vector3(-5, 0, -20);
        enemy3.transform.rotation = Quaternion.Euler(0, -45, 0);
        enemy3animation.SetTrigger("EnemyShoot");
        yield return new WaitForSeconds(1f);
        shootingsound.Play();
        playeranimation.SetTrigger("PlayerDamage");
        if(enemyskill)
        {
            enemy3SP -= 10;
            enemycrit = Random.Range(2, 5);
            playerdamage = (Random.Range(enemy3ATK / 2, enemy3ATK) * 2 - Random.Range(playerDEF / 2, playerDEF)) * enemycrit;
        }
        else
        {
            enemycrit = 0;
            playerdamage = Random.Range(enemy3ATK / 2, enemy3ATK) * 2 - Random.Range(playerDEF / 2, playerDEF);
        }
        
        if (playerdamage <= 0)
        {
            playerdamage = 1;
        }
        playerHP -= playerdamage;
        if(enemycrit > 3)
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
            playerHP = 0;
            playeranimation.SetTrigger("PlayerDie");
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("Endless Wave Game Over");
        }
        enemy3.transform.position = new Vector3(0, 0, 0);
        enemy3.transform.rotation = Quaternion.Euler(0, 0, 0);
        enemy3animation.SetTrigger("EnemyIdle");
        battlepanel.SetActive(true);
        attackingpanel.SetActive(false);
    }
}