using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public float hasasiyet;
    public float mermiHiz;
    public Transform player;
    public Transform mermi,nokta,klon;
    float xDonme; // rotatede x-y dir y-x dir
    
   private void Start() {
    Cursor.lockState=CursorLockMode.Locked;
   }

    // Update is called once per frame
    void Update()
    {
       float mousex=Input.GetAxis("Mouse X")*hasasiyet*Time.deltaTime; 
       float mousey=Input.GetAxis("Mouse Y")*hasasiyet*Time.deltaTime; 
       player.Rotate(Vector3.up,mousex);
       xDonme-=mousey;
       xDonme=Mathf.Clamp(xDonme,-75,75);
       transform.localRotation=Quaternion.Euler(xDonme,0,0);
      if(Input.GetMouseButtonDown(0)){
       klon= Instantiate(mermi,nokta.position,transform.rotation);
       Rigidbody rb=klon.GetComponent<Rigidbody>();
       rb.AddForce(transform.forward*mermiHiz);
       //rb.velocity=transform.forward*mermiHiz;
       Destroy(klon.gameObject,2f);
      }
       

      
    }
    
}
