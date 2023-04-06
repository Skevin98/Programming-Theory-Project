using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Monster
{

    [SerializeField]
    private GameObject minionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        monsterRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.gameOver)
        {
            // /normalized return the direction of the vector. ie Vector3(0,15,3).normalized === Vector3(0,1,1)
            monsterRb.AddForce(speed * Time.deltaTime * (player.transform.position - transform.position).normalized, ForceMode.Acceleration);
            //transform.Translate(speed * Time.deltaTime * (player.transform.position - transform.position));
            if (livePoints <= 0) KillMonster();
        }
        
    }

    protected override void KillMonster()
    {


        SpawnMinions();
        Destroy(gameObject);
    }

    void SpawnMinions()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(minionPrefab, transform.position + new Vector3(i,0,0),transform.rotation);
        }

    }

}
