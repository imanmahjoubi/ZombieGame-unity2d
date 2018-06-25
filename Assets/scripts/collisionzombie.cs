using UnityEngine;
using System.Collections;

public class collisionzombie : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update() { }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "zombie")
        {
            // audio.PlayOneShot(sonattack);
            Destroy(collision.gameObject);
            Debug.Log("GAME OVER");


            // Application.LoadLevel(Application.loadedLevel);





        }
    }
}
