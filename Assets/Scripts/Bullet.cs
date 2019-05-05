using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    //allows bullets to go left and right
    public float xSpeed = 0.1f;

    //allows bullets to go up and down
    public float ySpeed = 0.1f;

    public Rigidbody2D rb;
    //bullet damage
    public int damage = 5;

    // Start is called before the first frame update
    void Start() {
        //shots bullet right 
        //rb.velocity = transform.right * speed;
    }

    private void Update()
    {
        Vector2 position = transform.position;
        position.x += xSpeed;
        position.y += ySpeed;
        transform.position = position;
    }
 

    //causes bullets to damage from HurtEnemy and EnemyHealthManager scripts
    void OnTriggerEnter2D(Collider2D hitInfo) {
        EnemyHealthManager enemy = hitInfo.GetComponent<EnemyHealthManager>();
        if (enemy != null) {
            enemy.HurtEnemy(damage);
        }
        //Destroy(gameObject);    
    }

}
