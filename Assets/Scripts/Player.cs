using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    public float moveSpeed;
    public float rotateAmount;
    float rot;
    int score;
    public string gameSceneName;
    int i = 1;
    public bool isPaused = false;

    public AudioClip collisionSound; // Reference to the audio clip
    private AudioSource audioSource;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
        audioSource.clip = collisionSound; // Assign the collision sound to the AudioSource
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (mousePos.x < 0)
            {
                rot = rotateAmount;
            }
            else
            {
                rot = -rotateAmount;
            }

            transform.Rotate(0, 0, rot);
        }
        
        


    }

    void FixedUpdate()
    {
        rb.velocity = transform.up * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            audioSource.Play(); // Play the collision sound when the player collides with this object
            Destroy(collision.gameObject);

            score++;
            
            if (score == i)
            {
                moveSpeed = moveSpeed + 0.2f;
                rotateAmount = rotateAmount + 0.2f;
                i++;
            }

            if (score >= 5)
            {
                Debug.Log("Win..Level 1 Complete");
                SceneManager.LoadScene(gameSceneName);
            }

        }

        else if (collision.gameObject.tag == "Danger")
        {
            print("Lose..");
            SceneManager.LoadScene("Game");
        }
    }
}