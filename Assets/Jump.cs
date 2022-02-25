using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
       this.rb = transform.GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //check if the player object is on the ground
        if (gameObject.GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            //check for the input key
            if (Input.GetKey(KeyCode.UpArrow))
            {
                float jumpVelocity = 10f;
                this.rb.velocity = Vector2.up * jumpVelocity;;
            }
        }
        //check for the input key
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-0.07f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0.07f, 0, 0);
        }
        //check if the player has dropped out of the bar
        if (this.transform.position.y < -2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }       
    }
}
