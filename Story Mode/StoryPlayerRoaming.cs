using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class StoryPlayerRoaming : MonoBehaviour
{
    public Animator playerAnimation;

    public Camera camera;

    private float x;
    private float z;

    // Start is called before the first frame update
    void Start()
    {
        x = -20.0f;
        z = -10.0f;
    }

    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
        {
            playerAnimation.SetTrigger("PlayerWalk");
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S))
        {
            playerAnimation.SetTrigger("PlayerIdle");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //KeyDown
        if(Input.GetKey(KeyCode.W))
        {
            z += 0.05f;
            //transform.position = new Vector3(transform.position.x, transform.position.y, (transform.position.z + 1.0f) * Time.deltaTime);
            //transform.Translate(transform.position.x, transform.position.y, (transform.position.z + 1.0f) * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            //playerAnimation.SetTrigger("PlayerWalk");
        }
        if (Input.GetKey(KeyCode.D))
        {
            x += 0.05f;
            //transform.position = new Vector3((transform.position.x + 1.0f) * Time.deltaTime, transform.position.y, transform.position.z);
            //transform.Translate((transform.position.x + 1.0f) * Time.deltaTime, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.Euler(0, 90, 0);
            //playerAnimation.SetTrigger("PlayerWalk");
        }
        if (Input.GetKey(KeyCode.S))
        {
            z -= 0.05f;
            //transform.position = new Vector3(transform.position.x, transform.position.y, (transform.position.z - 1.0f) * Time.deltaTime);
            //transform.Translate(transform.position.x, transform.position.y, (transform.position.z - 1.0f) * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            //playerAnimation.SetTrigger("PlayerWalk");
        }
        if (Input.GetKey(KeyCode.A))
        {
            x -= 0.05f;
            //transform.position = new Vector3((transform.position.x - 1.0f) * Time.deltaTime, transform.position.y, transform.position.z);
            //transform.Translate((transform.position.x - 1.0f) * Time.deltaTime, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.Euler(0, -90, 0);
            //playerAnimation.SetTrigger("PlayerWalk");
        }

        transform.position = new Vector3(x, transform.position.y, z);
        camera.transform.position = new Vector3(x, 30, z - 40);
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("It hits something" + gameObject.tag);
        if(other.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Story Mode Wave 1");
        }

        //SceneManager.LoadScene("Story Mode Wave 1");
    }
}
