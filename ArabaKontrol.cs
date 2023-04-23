using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaKontrol : MonoBehaviour
{
    public WheelCollider onsag,onsol,arkasag,arkasol;
    public Transform sag,sol,arkarigt,arkaleft;
    public float donmeGucu,frenGucu,motorGucu,tekerlekdonmehiz;
    public GameObject camera1,camera2,direksiyon;
    string hangi;
    Rigidbody rb;
    float tekerlekDonme;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
        camera2.SetActive(false);
        camera1.SetActive(true);
        hangi="1"; 
    }
   private void Update() {
    hareket();
    // iç kamera
    float x=Input.GetAxis("Mouse X");
    float y=Input.GetAxis("Mouse Y");
    print(x);
     if(Input.GetMouseButton(1)){
camera2.transform.Rotate(-y,x,0);
            }
            // kamera degistirme 
     if(Input.GetKeyUp(KeyCode.V)){
        
        if(hangi=="1"){
            camera1.SetActive(false);
            camera2.SetActive(true);
            hangi="2";
        }else{
            camera2.SetActive(false);
            camera1.SetActive(true);
            hangi="1";
        }
    }
   }
    void hareket(){
float v=Input.GetAxis("Vertical")*motorGucu;
        float h=Input.GetAxis("Horizontal")*donmeGucu;
    
        arkasag.motorTorque=v;
        arkasol.motorTorque=v;
        onsag.steerAngle=h;
        onsol.steerAngle=h;
        if(Input.GetKey(KeyCode.Space)){
            arkasol.brakeTorque=frenGucu;
            arkasag.brakeTorque=frenGucu;
        }
        else{
            arkasol.brakeTorque=0;
            arkasag.brakeTorque=0;
        }
        tekerlekDonme=h;
        float hiz=rb.velocity.magnitude;
            tekerlekDonme=Mathf.Clamp(tekerlekDonme,-30,30);
            float direksiyonDonme =h;
            direksiyonDonme=Mathf.Clamp(direksiyonDonme,-180,180); 
              arkarigt.Rotate(Vector3.right*hiz);
              arkaleft.Rotate(Vector3.right*hiz);
              sag.localRotation=Quaternion.Euler(hiz*120,tekerlekDonme*tekerlekdonmehiz,0);
               sol.localRotation=Quaternion.Euler(hiz*120,tekerlekDonme*tekerlekdonmehiz,0);
               direksiyon.transform.localRotation=Quaternion.Euler(0,0,-direksiyonDonme*tekerlekdonmehiz);
    }
    
    
}
