using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    private Rigidbody2D _compRibody;
    private SpriteRenderer _compRender;
    public int xdirec = 1;
    public int ydirec = 1;
    public int velocidad=1;
   
    // Start is called before the first frame update
     void Awake()
    {
        _compRender = GetComponent<SpriteRenderer>();
        _compRibody = GetComponent<Rigidbody2D>();
    }
    void Star()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _compRibody.velocity = new Vector2(xdirec*velocidad,ydirec*velocidad);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       

        if (collision.gameObject.tag == "verticales")
        {
            if (ydirec == 1)
            {
                ydirec = -1;
                _compRender.flipY = true;

            }
            else
            {
                ydirec = 1;
                _compRender.flipY = false;

            }
        }
        else
        if (collision.gameObject.tag == "horizontales")
        {
            if (xdirec == 1)
            {
                xdirec = -1;
                _compRender.flipX = true;
            }
            else
            {
                xdirec = 1;
                _compRender.flipX = false;

            }
        }
        
        
       
    }
}
