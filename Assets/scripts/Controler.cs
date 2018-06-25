using UnityEngine;
using System.Collections;
using Assets.scripts;

public class Controler : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float accelerometerX = Input.acceleration.y/2;
        float accelerometerY = Input.acceleration.x*1.5f;

        if (accelerometerY < 0 && (this.transform.localPosition.x >= -4.7))
        {
            this.transform.Translate(new Vector2(-5f * Time.deltaTime, 0f));
        }

        if (accelerometerY > 0 && (this.transform.localPosition.x <= 5.2))
        {
            this.transform.Translate(new Vector2(5f * Time.deltaTime, 0f));
        }

        if (accelerometerX < 0 && (this.transform.localPosition.y >= -3.45))
        {
            // this.transform.Translate(new Vector2(5f * Time.deltaTime, 0f));
            this.transform.Translate(Vector3.down * Time.deltaTime * 5f);
        }
        if (accelerometerX > 0 && (this.transform.localPosition.y <= 3.810114))
        {
            // this.transform.Translate(new Vector2(5f * Time.deltaTime, 0f));
            this.transform.Translate(Vector3.up * Time.deltaTime * 5f);
        }
        if ((Input.GetKey(KeyCode.LeftArrow) && (this.transform.localPosition.x >= -4.7)))
        {
            this.transform.Translate(new Vector2(-5f * Time.deltaTime, 0f));
        }

        if (Input.GetKey(KeyCode.RightArrow) && (this.transform.localPosition.x <= 5.2))
        {
            this.transform.Translate(new Vector2(5f * Time.deltaTime, 0f));
        }

        if (Input.GetKey(KeyCode.DownArrow) && (this.transform.localPosition.y >= -3.45))
        {
            // this.transform.Translate(new Vector2(5f * Time.deltaTime, 0f));
            this.transform.Translate(Vector3.down * Time.deltaTime * 5f);
        }
        if (Input.GetKey(KeyCode.UpArrow) && (this.transform.localPosition.y <= 3.810114))
        {
            // this.transform.Translate(new Vector2(5f * Time.deltaTime, 0f));
            this.transform.Translate(Vector3.up * Time.deltaTime * 5f);
        }
        
	
	}
}
