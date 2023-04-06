using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    [SerializeField]
    int lifePoints = 5;

    [SerializeField]
    float playerSpeed = 5;

    [SerializeField]
    float jumpForce = 25;

    [SerializeField]
    bool isOnGround = true;

    // private GameManager gameManager;


    private Rigidbody playerRb;

    public GameObject sword;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(horizontalInput * Time.deltaTime * playerSpeed * Vector3.right);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            // playerAnim.SetTrigger("Jump_trig");

            // dirtParticle.Stop();
            // playerAudio.PlayOneShot(jumpSound, 1.0f);
        }

        



    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground") && !GameManager.gameOver)
        {
            isOnGround = true;
            // dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Monster"))
        {
            lifePoints--;
            Debug.Log($"Life points : {lifePoints}");
            if (lifePoints <=0)
            {
                PlayerGameOver();
            }




            // dirtParticle.Stop();
            // explosionParticle.Play();
            // playerAudio.PlayOneShot(crashSound);
            // playerAnim.SetBool("Death_b", true);
            // playerAnim.SetInteger("DeathType_int", 2);
        }
    }

    private void PlayerGameOver()
    {
        Destroy(gameObject);
        Debug.Log("Game Over");
        GameManager.gameOver = true;
    }
}
