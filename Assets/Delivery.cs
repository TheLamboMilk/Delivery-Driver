using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{ 
  bool hasPackage;

    void OnCollisionEnter2D(Collision2D other) 
   {
     Debug.Log("Mono:NUUUUUUUUUUUUU, masinuta s-a spart");
   }
    void OnTriggerEnter2D(Collider2D other) 
   {
     if (other.tag == "Package")
     {
       Debug.Log("Filmul cu cars 3 a fost ridicat");
       hasPackage = true;
     }
     if (other.tag == "Mono" && hasPackage)
     {
       Debug.Log("Filmul cu cars 3 a fost livrat domnului Mono");
       hasPackage = false;
     }
   }
}
