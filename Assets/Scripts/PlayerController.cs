using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    
    

    [SerializeField]
    float playerSpeed = 5;

    [SerializeField]
    float jumpForce = 25;

    [SerializeField]
    bool isOnGround = true;

    private GameManager gameManager;

    

    /*[SerializeField]
    bool doubleJump = false;*/

    /*[SerializeField]
    float doubleJumpForce = 15;*/

    private Rigidbody playerRb;

    public GameObject sword;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(horizontalInput * Time.deltaTime * playerSpeed * Vector3.right);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameManager.gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            // playerAnim.SetTrigger("Jump_trig");

            // dirtParticle.Stop();
            // playerAudio.PlayOneShot(jumpSound, 1.0f);
            // doubleJump = true;
        }

        

        //if (Input.GetKeyDown(KeyCode.Space) && !isOnGround && doubleJump && !gameOver)
        //{
        //    playerRb.AddForce(Vector3.up * doubleJumpForce, ForceMode.Impulse);
        //    //playerAnim.SetTrigger("Jump_trig");
        //    //dirtParticle.Stop();
        //    doubleJump = false;
        //    //playerAudio.PlayOneShot(jumpSound, 1.0f);
        //}


    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground") && !gameManager.gameOver)
        {
            isOnGround = true;
            // dirtParticle.Play();
        }
        /*else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;
            // dirtParticle.Stop();
            // explosionParticle.Play();
            // playerAudio.PlayOneShot(crashSound);
            // playerAnim.SetBool("Death_b", true);
            // playerAnim.SetInteger("DeathType_int", 2);
        }*/
    }
}
