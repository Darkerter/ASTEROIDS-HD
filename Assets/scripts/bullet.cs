using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float BulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletForce();
        //destroys de object
        Destroy(this.gameObject, 2);
    }
    void BulletForce()
    {
        transform.Translate((Vector2.up * Time.deltaTime) * BulletSpeed);

        

    }
}
