using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AnimatorControl : MonoBehaviour
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
            body.AddForce(new Vector3(0, 4, 0));
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            body.AddForce(new Vector3(1, 0, 0));
        }

        animator.SetFloat("Velocity", Mathf.Abs(body.velocity.magnitude));
        //Debug.Log(body.velocity.magnitude);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Red_Platform")
        {
            Debug.Log("Red Platform Collision");
            gameObject.transform.position = new Vector3(-9, -2, 0);
        }

        if (collision.gameObject.tag == "Green_Platform")
        {
            Debug.Log("Green Platform Collision");
        }

        if (collision.gameObject.tag == "CheckPoint")
        {
            Debug.Log("Player Won");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Win", LoadSceneMode.Single);
        }
        
    }
}
