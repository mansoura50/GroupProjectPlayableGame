using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;
    //bullet damage
    public int damage = 5;

    // Start is called before the first frame update
    void Start() {
        //shots bullet right 
        rb.velocity = transform.right * speed;
    }

    //causes bullets to damage from HurtEnemy and EnemyHealthManager scripts
    void OnTriggerEnter2D(Collider2D hitInfo) {
        EnemyHealthManager enemy = hitInfo.GetComponent<EnemyHealthManager>();
        if (enemy != null) {
            enemy.HurtEnemy(damage);
        }
        Destroy(gameObject);    
    }

}
