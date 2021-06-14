using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject[] Phrogs;
    private bool gamepause = true;
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
         if (gamepause)
        {
            gamepause = false;
            
        }
        */
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        while (true)
        {
            Instantiate(Phrogs[Random.Range(0, Phrogs.Length)]);

            //yield on a new YieldInstruction that waits for X seconds.
            yield return new WaitForSeconds(1);

        }
        //gamepause = true;
        //After we have waited X seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }


}
