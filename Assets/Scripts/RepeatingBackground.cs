using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{

    private BoxCollider2D GroundCollider;
    private float GroundHorizontalLenght;

    // Start is called before the first frame update
    void Start()
    {

        GroundCollider = GetComponent<BoxCollider2D>();
        GroundHorizontalLenght = GroundCollider.size.x;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < -GroundHorizontalLenght)
            RepositionBackground();
        
    }

    private void RepositionBackground()
    {
        Vector2 GroundOffset = new Vector2(GroundHorizontalLenght * 2f, 0);
        transform.position = (Vector2)transform.position + GroundOffset + new Vector2 (-0.1f , 0);
    }
}
