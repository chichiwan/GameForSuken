using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosionPrefab;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.08f, 0);
        
        if(transform.position.y > 5) {
            Destroy(gameObject);
        }
    }
    
    void OnTriggerEnter2D(Collider2D coll) {
        if(transform.position.y > -3/*coll.gameObject.tag == "Rock"*/) {
            GameObject.Find("Canvas").GetComponent<UIController> ().AddScore ();
        
            GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
            Destroy(effect, 1.0f);
    
            //Instantiate(explosionPrefab, transform.position,  Quaternion.identity);
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }
}
