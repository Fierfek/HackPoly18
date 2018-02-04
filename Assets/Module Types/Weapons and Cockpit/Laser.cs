using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : Weapons {


    public float damageAmount = 1f;
    public float rateOfFire = 0f;
    public float laserRange = 100f;
    public GameObject laserPrefab;
    public LayerMask whatToHit;
    

    float timeToFire = 0;

    // Use this for initialization
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(rateOfFire == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
        else
        {
            if(Input.GetButton("Fire1") && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / rateOfFire;
            }
        }

    }

    void Shoot()
    {
       
        Vector2 mousePosition = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
        Vector2 playerPosition = new Vector2(transform.position.x, transform.position.y);
        RaycastHit2D hit = Physics2D.Raycast(playerPosition, mousePosition - playerPosition, laserRange, whatToHit);

        Debug.DrawLine(playerPosition, mousePosition, Color.green);
        float angle = AngleBetweenTwoPoints(positionOnScreen, mousePosition);
//transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        Effect(angle);

        if(hit.collider != null)
        {
            Debug.DrawLine(playerPosition, hit.point, Color.red);
            Debug.Log("Damage dealt = " + damageAmount);
        }
    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

    void Effect(float angle)
    {
        Instantiate(laserPrefab, transform.position, Quaternion.Euler(new Vector3(0f, 0f, angle)));
    }
 
}
