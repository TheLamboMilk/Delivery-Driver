using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oncollision : MonoBehaviour
{
     void OnCollisionEnter2D(Collision2D other) 
     {
       Debug.Log("Mono:NUUUUUUUUUUUU, masinuta s-a spart");
     }
     
     void OnTriggerEnter2D(Collider2D other) 
     {
       Debug.Log("Mono:A inceput Cars 3");
     }
}
