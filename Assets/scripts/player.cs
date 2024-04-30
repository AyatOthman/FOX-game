using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D r1;
    // Start is called before the first frame update
    void Start()
    {
        r1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int x = 0;
        int y = 0;
        int steps = 25;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x = steps;
            transform.localScale = new Vector3(1, 1, 1);

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            x = -steps;
            transform.localScale = new Vector3(-1, 1, 1);

        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            y = steps;

        }
        else
        {
            y = -steps;

        }
        r1.AddForce(new Vector2(x, y));
    }
    private void oncollisionenter2d(Collision2D collision)
    {
        if (collision.gameObject.tag == "bird")
        {
            Destroy(collision.gameObject);
        }
    }
}

