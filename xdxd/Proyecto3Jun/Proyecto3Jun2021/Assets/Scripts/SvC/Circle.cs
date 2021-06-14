using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shapes
{
    public int attack;
    protected override void OnTriggerStay2D(Collider2D collision)
    {



        Square another = collision.gameObject.GetComponent<Square>();
        
        if (another)
        {

            Debug.Log("chocando con algoAnother");
            attack = (another.atk - def);
            if(attack <= 0)
            {
                attack = 0;
            }

            currentVida -= attack;

            if (currentVida <= 0)
            {
                Destroy(this.gameObject);

            }

        }


    }
}



