using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oncollision : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D other) {
     Debug.Log("Mono:NUUUUUUUUUUUUU, masinuta s-a spart");
   }
   private void OnTriggerEnter2D(Collider2D other) {
     Debug.Log("Mono:A inceput cars 3");
   }
}
