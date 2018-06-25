using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour
{
    public GameObject obstacle;
    //public GameObject zombie;
   

    float timeElapsed = 0;
    float spawnCycle = 1f;
    bool spawnPowerup = true;
    int x = 1;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > spawnCycle)
        {
            GameObject temp;
            
            if (spawnPowerup)
            {
               
            }
            else
            {


                print("boom obstacle");
                temp = (GameObject)Instantiate(obstacle);
                Vector2 pos = temp.transform.position;
               
                temp.transform.position = new Vector2(Random.Range(-4, 4), pos.y+6);
                
               
                   temp.transform.parent = transform;
                   
                
                
                
              
            }
            
            timeElapsed -= spawnCycle;
            spawnPowerup = !spawnPowerup;
        }
    }
}