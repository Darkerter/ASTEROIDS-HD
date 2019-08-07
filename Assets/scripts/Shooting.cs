using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    Vector2 GunP;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          GameObject bullets = (GameObject)Instantiate(bullet, GunP, Quaternion.identity);
            
        }
        
        BulletPosition();
    }

    void BulletPosition()
    {

        GunP = transform.position;
        GunP += Vector2.up / 2;

    }
}

