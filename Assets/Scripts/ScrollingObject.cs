using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{

    private Rigidbody2D RB2D;

    // Start is called before the first frame update
    void Start()
    {

        RB2D = GetComponent<Rigidbody2D>();
        RB2D.velocity = new Vector2(GameControl.instance.ScrollSpeed, 0);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GameControl.instance.GameOver == true)
            RB2D.velocity = Vector2.zero;
        
    }
}
