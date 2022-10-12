using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Does the rotation in direction of mouse, update sprite
public class LookAtMouse : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    private Vector3 mousePos;
    
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        rb = this.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(mousePos);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0,0,rotZ);
    }
}

    

