using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVirus : MonoBehaviour
{
    /* GameManager GM;

     Vector2 targetPos;
     public float speed;
     // Start is called before the first frame update
     void Start()
     {
         GM = GameObject.Find("GameManager").GetComponent<GameManager>();
         GM.virusSpawned++;
         Debug.Log(GM.virusSpawned);
         if ((GM.virusSpawned%2 == 0) && GM.spawnDelay > 0.6f)
         {
             GM.spawnDelay -= 0.3f;
         }
         targetPos = GetRandomPos();


     }

     void Update()
     {
         //have movement randomised
         if (Vector2.Distance(transform.position, targetPos) > 0.1)
         {
             transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
         }

         else
         {
             targetPos = GetRandomPos();
         }

     }

     // Update is called once per frame
     void OnMouseDown()
     {
         GM.virusDestroyed++;
         Debug.Log("Virus destroyed! Destruction count: "+ GM.virusDestroyed);
         //any destroy effects spawned here
         Destroy(gameObject);
     }

     Vector2 GetRandomPos()
     {
         float randX = Random.Range(-8.5f, 8.5f);
         float randY = Random.Range(-4.5f, 4.5f);
         return new Vector2(randX, randY);
     }*/
}
