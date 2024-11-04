using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorrobe : MonoBehaviour
    
{
    private SpriteRenderer renderizado;

    // Start is called before the first frame update

    void Start()
    {
        renderizado = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "murosy" && renderizado.color.g <=0.1f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(this.gameObject.tag == "murosy" && collision.gameObject.tag == "ball")
        {
            renderizado.color = new Color(renderizado.gameObject.GetComponent<SpriteRenderer>().color.r, renderizado.gameObject.GetComponent<SpriteRenderer>().color.g - 0.2f, renderizado.gameObject.GetComponent<SpriteRenderer>().color.b - 0.2f);
        }

        
        //collision.gameObject.GetComponent<SpriteRenderer>().color
    }
}
