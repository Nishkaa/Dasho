using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private Rigidbody2D GroundBody;
    public float movingV = 5;
    // Start is called before the first frame update
    void Start()
    {
        GroundBody = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        GroundBody.velocity = new Vector2(-movingV, GroundBody.velocity.y);
    }

}
