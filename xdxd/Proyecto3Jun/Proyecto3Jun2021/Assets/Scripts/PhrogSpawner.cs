using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhrogSpawner : MonoBehaviour

  
{
    
    public GameObject[] phrogArray;
    public GameObject posOneSpawn, posTwoSpawn, posThreeSpawn, posFourSpawn;
    private float timer = 1;
    void Update()
    {
        timer -= Time.deltaTime;
        int drop = Random.Range(0, 4);
        if (drop == 0 && timer <= 0 )
        {
            Instantiate(phrogArray[0], posOneSpawn.transform);
            timer = 1;
        }
        else if (drop == 1 && timer <= 0)
        {
            Instantiate(phrogArray[1], posTwoSpawn.transform);
            timer = 1;
        }
        else if (drop == 2 && timer <= 0)
        {
            Instantiate(phrogArray[2], posThreeSpawn.transform);
            timer = 1;
        }   
        else if (drop == 3 && timer <= 0)
        {
            Instantiate(phrogArray[3], posFourSpawn.transform);
            timer = 1;
        }
    
    }

    
}
    
