using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {
	private bool cloned;
    public bool colliding = false;

	// Use this for initialization
	void Start () {
		cloned = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        if(!colliding)
		transform.position = new Vector2 (transform.position.x, transform.position.y -0.05f); 
		if (!cloned && transform.position.y <= 0) {
			Instantiate(transform, new Vector2(transform.position.x,transform.position.y+renderer.bounds.size.y),Quaternion.identity);
			cloned = true;
		}
		if (transform.position.y < -renderer.bounds.size.y) {
			Destroy(gameObject);		
		}
	}
}
