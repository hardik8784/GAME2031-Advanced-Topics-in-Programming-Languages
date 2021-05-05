using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    int Score = 0;
    int Lives = 3;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Lives == 0)
        {
            Time.timeScale = 1.0f;
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with Ground");
        Lives = Lives - 1;
        Debug.Log("Lives : " + Lives.ToString());
        gameObject.transform.position = new Vector3(Random.Range(-10, 10.0f), 10, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision with Paddle");
        Score = Score + 1;
        Debug.Log("Score : " + Score.ToString());
        gameObject.transform.position = new Vector3(Random.Range(-10.0f,10.0f),10,0);
        body.velocity = new Vector3(0, 0, 0);
    }
}
