    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento2 : MonoBehaviour
{
    private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(_transform.position.y <3.5f && Input.GetKey("left"))
        {
            _transform.position = new Vector2(_transform.position.x, _transform.position.y + 0.20f);
        }
        if (_transform.position.y > -3.60f && Input.GetKey("right"))
        {
            _transform.position = new Vector2(_transform.position.x, _transform.position.y - 0.20f);
        }
    }
 
}
