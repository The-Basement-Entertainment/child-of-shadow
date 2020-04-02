using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagePlayer : MonoBehaviour
{
    public int playerHealth = 30;
    int damage = 1;

    void Start()
    {
        print(playerHealth);
    }

    void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.tag == "enemyDong")
        {
            playerHealth -= damage;
            print("A escuridão está de dominando" + playerHealth);
        }
        if (playerHealth <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }
}