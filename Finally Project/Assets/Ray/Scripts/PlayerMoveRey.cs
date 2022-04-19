using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMoveRey : MonoBehaviour {


    public float speed;
    public float rotspeed;

    private CharacterController playerMove;


    void Start ()
    {
        playerMove = gameObject.GetComponent<CharacterController>();
    }
	
	void Update () {

        float x = 0, y = 0, z = 0;
 
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
            transform.Rotate(Vector3.up * Time.deltaTime * -rotspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotspeed);
        }

       playerMove.Move(transform.TransformDirection(new Vector3(x, y, z)));

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            SceneManager.LoadScene(2);
        }

        if (other.tag == "enemy")
        {
            SceneManager.LoadScene(3);
        }
    }
}
