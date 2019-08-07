using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float HorizontalM;
    float VerticalM;

     public int speed;
    
    // Start is called before the first frame update
    void Start()
    {
       
      
    }

   

    // FixedUpdate is called once per frame fixed- for physics
    void FixedUpdate()
    {
        HorizontalM = Input.GetAxisRaw("Horizontal");
        VerticalM  = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(HorizontalM * Time.fixedDeltaTime, VerticalM * Time.fixedDeltaTime)*speed);
    }


}
