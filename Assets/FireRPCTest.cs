using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRPCTest : Weapons
{
    public float rateOfFire = .2f;
    public GameObject bulletPrefab;
    private float lastFire = 0;

    private PhotonView photonView;
    private ModuleManager moduleManager;

    private void Awake()
    {
        photonView = GetComponent<PhotonView>();
        moduleManager = GetComponent<ModuleManager>();
    }


    public override void Fire_Trigger()
    {
        if (photonView.isMine)
        {
            if (Time.time > lastFire + rateOfFire)
            {
                Fire();

                lastFire = Time.time;
            }
        }
    }


    public void Fire()
    {
        GameObject bullet = PhotonNetwork.Instantiate(bulletPrefab.name, transform.position + transform.forward, transform.rotation, 0);
        bullet.GetComponent<Projectile>().playerID = moduleManager.playerID;
    }
}
