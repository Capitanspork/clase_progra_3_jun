using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapes : MonoBehaviour
{
    public int atk, def, vida;
    public int currentVida;

    public Transform target;
    public float speed;

    protected virtual void Start()
    {
        currentVida = vida;
    }
    protected virtual void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
    protected virtual void OnTriggerStay2D(Collider2D collision)
    {
        Circle other = collision.gameObject.GetComponent<Circle>();
        if (other)
        {

            Debug.Log("chocando con algoOther");
            currentVida -= (other.atk - def);
            if (currentVida <= 0)
            {
                Destroy(this.gameObject);

            }

        }

        Square another = collision.gameObject.GetComponent<Square>();
        if (another)
        {
            Debug.Log("chocando con algoAnother");
            currentVida -= (another.atk - def);
            if (currentVida <= 0)
            {
                Destroy(this.gameObject);
            }

        }
    }

   



}
