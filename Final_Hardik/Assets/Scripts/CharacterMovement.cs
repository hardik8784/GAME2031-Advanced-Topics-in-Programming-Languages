using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 0.2f;
    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            Vector3 tpos = Camera.main.ScreenToWorldPoint(t.position);
            tpos.z = 0.0f;
            //transform.position = tpos;
            Vector3 f = tpos - transform.position;
            if (f.magnitude > 3)
            {
                f.Normalize();
                f = f * 0.1f;
            }
            if (f.x < 0)
            {
                if(f.x > -10.0f)
                {
                    transform.position += Vector3.left * Time.deltaTime;
                }
                //gameObject.transform.localScale = new Vector3(-1, 1, 1);
                else
                {
                    transform.position += Vector3.right *  Time.deltaTime;
                }
                
            }
            else
            {
                if (f.x > 0)
                {
                    if (f.x < 10)
                    {
                        transform.position += Vector3.right *  Time.deltaTime;
                    }
                }
                else
                {
                    transform.position += Vector3.left * Time.deltaTime;
                }
                // gameObject.transform.localScale = new Vector3(1, 1, 1);
                transform.position += Vector3.right * Time.deltaTime;
            }
            body.AddForce(f, ForceMode2D.Impulse);
        }
            //Vector3 position = transform.position;

            ////if (Input.GetKey("up"))
            ////{
            ////    position.y += speed * Time.deltaTime;
            ////}

            ////if (Input.GetKey("down"))
            ////{
            ////    position.y -= speed * Time.deltaTime;
            ////}

            //if (Input.GetKey(KeyCode.RightArrow))
            //{
            //    position.x += speed * Time.deltaTime;
            //}

            //if (Input.GetKey(KeyCode.LeftArrow))
            //{
            //    position.x -= speed * Time.deltaTime;
            //}

            //transform.position = position;
        }

    }

