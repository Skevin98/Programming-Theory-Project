using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    public int livePoints = 1;
    public float speed = 1f;

    protected Rigidbody monsterRb;

    [SerializeField]
    protected GameObject player;

    

    // Start is called before the first frame update
    void Start()
    {
        monsterRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(speed * Time.deltaTime * (player.transform.position - transform.position).normalized);
        if (livePoints <= 0) KillMonster();
    }

    protected virtual void KillMonster()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Weapon")
        {
            livePoints--;
        }
    }


}
