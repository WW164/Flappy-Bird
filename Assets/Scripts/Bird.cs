using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public float UpForce = 200f;

    private bool isDead = false;
    private Rigidbody2D RB2D;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {

        RB2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(isDead == false)
        {

            if(Input.GetKeyDown(KeyCode.Space))
            {

                RB2D.velocity = Vector2.zero;
                RB2D.AddForce(new Vector2(0, UpForce));

                anim.SetTrigger("Flap");

            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        isDead = true;
        anim.SetTrigger("Die");

        GameControl.instance.BirdDied();
    }
}
