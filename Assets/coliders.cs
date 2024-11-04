using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    
    public int direccionx = -1;
    public int direcciony = -1;
    public float g = 3;
    private SpriteRenderer renderizado;
    private Rigidbody2D rigid;
    private Transform _transform;
    public bool velocity = true;
    // Start is called before the first frame update
    void Start()
    {
        direccionx = direccionx * -1;
        direcciony = direcciony * -1;
        g = 3;
        renderizado = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(_transform.position.x <= -9.0f)
        {
            print("derecha gana");
        }
        if (_transform.position.x >= 9.0f)
        {
            print("izquierda gana");
        }
        if (velocity)
        {
            rigid.velocity = new Vector2(direccionx * g, direcciony * g);
        }
        else
        {
            rigid.AddForce(new Vector2(direccionx * g, direcciony * g));
        }
        
    } 
        
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "murosx")
        {
            direcciony = direcciony * -1;   
        }
        if (collision.gameObject.tag == "pader" && _transform.position.x >= -6.90f && _transform.position.x <= 6.90f)
        {
            g = g + 0.5f;
            direccionx = direccionx * -1;
        }
        if(collision.gameObject.tag == "murosy")
        {
            Vector3 spawn = new Vector3(0, 0, 0);
            Quaternion spawnRotation = Quaternion.identity;

            Instantiate(this.gameObject, spawn, spawnRotation);

            Destroy(this.gameObject);
            
        }

    }

}


