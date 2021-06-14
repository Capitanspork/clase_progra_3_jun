using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shapes
{

    public int normalAtk;
    public int specialAtk;
    public int rnd;

    protected override void OnTriggerStay2D(Collider2D collision)
    {
        Circle other = collision.gameObject.GetComponent<Circle>();
        if (other)
        {

            rnd = Random.Range(0, 2);
            if (rnd == 0)
            {
                normalAtk = (currentVida -= (other.atk - def));
                Debug.Log("chocando con algoOtherNormal");
            }
            else
            {
                specialAtk = (currentVida -= other.atk);
                Debug.Log("chocando con algoOtherSpecial");
            }


            if (currentVida <= 0)
            {
                Destroy(this.gameObject);
            }

        }

        

    }
}
