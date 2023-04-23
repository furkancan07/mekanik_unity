using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karekterKontrol : MonoBehaviour
{
    public float hiz;
    CharacterController cc;
    Rigidbody  rb;
    void Start()
    {
        cc=GetComponent<CharacterController>();
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x=Input.GetAxis("Horizontal");
         float z=Input.GetAxis("Vertical");
         float y=Input.GetAxis("Jump");
         
         Vector3 move=new Vector3(x,y*hiz*0.4f ,z);
         transform.Translate(move*hiz*Time.deltaTime);
         //cc.Move(move*hiz*Time.deltaTime);
         //cc.Move(rb.velocity*Time.deltaTime);
         
    }
}
