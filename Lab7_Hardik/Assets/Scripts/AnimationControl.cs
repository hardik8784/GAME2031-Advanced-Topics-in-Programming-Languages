using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{

    Animator animator;
    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
           // animator.SetTrigger("Jump");
            body.AddForce(new Vector3(0, 20, 0));
           
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {

        }
      
        animator.SetFloat("Velocity", Mathf.Abs(body.velocity.magnitude));
        Debug.Log(body.velocity.magnitude);

    }
}
