using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player01 : MonoBehaviour
{

    public float speed;
    public float rotspeed;

    public Animator anim;

    public CharacterController PlayerMove;
    public float gravity = 10f;

    void Start()
    {

    }

    void Update()
    {
        float x = 0, y = 0, z = 0;

        y -= gravity * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            z += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            z -= speed * Time.deltaTime;
        }
   
        if (Input.GetKey(KeyCode.A))
        {
            x = 1;
            transform.Rotate(Vector3.up * Time.deltaTime * -rotspeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            x = 1;
            transform.Rotate(Vector3.up * Time.deltaTime * rotspeed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");

            y += gravity * 30 * Time.deltaTime;
        }
        if (this.gameObject.transform.position.y >= 1.5)
        {
            y -= gravity * 10 * Time.deltaTime;
        }

        PlayerMove.Move(transform.TransformDirection(new Vector3(0, y, z)));


        if (z != 0 || x == 1)
        {
            anim.SetBool("Moving", true);
        }
        else
        {
            anim.SetBool("Moving", false);
        }
  
    }

    void OnTriggerEnter(Collider other)
    {
     
        if (other.tag == "Coin")
        {
            GameManager.Instance.SetScore(1);
            Destroy(other.gameObject);
        }
    }

}
