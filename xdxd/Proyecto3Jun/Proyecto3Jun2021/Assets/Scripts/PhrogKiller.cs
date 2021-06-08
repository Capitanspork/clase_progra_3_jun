using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhrogKiller : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 screenBounds;
    public static bool iscollider;

    
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y < -screenBounds.y * 2)
        {
            Destroy(gameObject);
        }
    }
}
