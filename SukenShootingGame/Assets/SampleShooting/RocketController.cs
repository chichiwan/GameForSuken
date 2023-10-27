using UnityEngine;
using System.Collections;

public class RocketController:MonoBehaviour {
    int i = 0;
    public GameObject bulletPrefab;
    void Update() {
        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(-0.04f, 0, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(0.04f, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.Space)) {

                Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            
            
        }
        if (Input.GetKeyDown (KeyCode.UpArrow)) {
            ++i;
            if(i < 6) {
                Instantiate(bulletPrefab, new Vector3(transform.position.x - 1.0f, transform.position.y, transform.position.z), Quaternion.identity);
                Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                Instantiate(bulletPrefab, new Vector3(transform.position.x + 1.0f, transform.position.y, transform.position.z), Quaternion.identity);
            }
            
         
            
        }
        if(transform.position.x < -3.1f) {
            transform.position = new Vector3 (-3.1f, -4, 0);
        }
        if(transform.position.x > 3.1f) {
            transform.position = new Vector3 (3.1f, -4, 0);
        }
    }
}