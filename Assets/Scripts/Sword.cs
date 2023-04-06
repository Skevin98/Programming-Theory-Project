using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private const float swing = 600f;
    private Vector3 offset = new(0.8f, 1, 0);


    //[SerializeField]
    //float damages = 20;

    [SerializeField]
    Rigidbody swordRb;

    public GameManager gameManager;

    private void Start()
    {
        swordRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }


    // Update is called once per frame
    void Update()
    {
        // To change a object pivot rotation, create an empty parent and make it rotate
        // An make sure to use locale- coordinates for movements and positions.
        transform.localPosition = transform.parent.localPosition + offset;
        if (Input.GetKey(KeyCode.X) && !gameManager.gameOver)
        {
            transform.parent.Rotate(Vector3.back,Time.deltaTime * swing, Space.Self);
            //Debug.Log("Attack");
            // Maybe use animation on the Rb later
            //swordRb.AddRelativeTorque(Vector3.back * 100, ForceMode.Impulse);

        }
    }

}
