using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Monster
{
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

    
}
