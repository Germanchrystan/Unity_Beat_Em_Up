using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackUniversal : MonoBehaviour
{
    public LayerMask collisionLayer;
    public float radius = 1f;
    public float damage = 2f;

    public bool isPlayer, isEnemy;

    public GameObject hitFX;
    
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectCollision();
    }

    void DetectCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position, radius, collisionLayer);
        if(hit.Length > 0)
        {
            if(isPlayer)
            {
                Vector3 hitFXPos = hit[0].transform.position;

                hitFXPos.y +=1.3f;
                if(hit[0].transform.forward.x > 0)
                {
                    hitFXPos.x += 0.3f;
                } else if(hit[0].transform.forward.x < 0)
                {
                    hitFXPos.x -= 0.3f;
                }

                Instantiate(hitFX, hitFXPos, Quaternion.identity);

                if (
                    gameObject.CompareTag("LeftArm") || 
                    gameObject.CompareTag("LeftLeg")
                )
                {
                    //hit[0].GetComponent<HealthScript>().ApplyDamage(damage,true);
                } else 
                {
                    //hit[0].GetComponent<HealthScript>().ApplyDamage(damage,false);
                }
            }
            // Debug.Log(hit[0].gameObject.name);


            gameObject.SetActive(false);
        }
    }
}
    