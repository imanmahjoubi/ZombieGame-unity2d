using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

    AudioClip sonattack;
    GameObject gameOver;

  // Use this for initialization
	void Start () {
        gameOver = GameObject.FindGameObjectWithTag("Game Over");
	}
	
	// Update is called once per frame
    void Update() { }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "hero")
        {
            audio.PlayOneShot(sonattack);
            Destroy(collision.gameObject);
            print(gameObject.name);
            //Debug.Log("GAME OVER");

           
            // Application.LoadLevel(Application.loadedLevel);

            SpriteRenderer spriteRenderer = (SpriteRenderer)gameOver.GetComponent<SpriteRenderer>();
            spriteRenderer.enabled = true;
            


        }
    }
 }
    

