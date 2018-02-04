using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleManager : MonoBehaviour {
    ArrayList modules;
    bool fire;
    Cockpit pilot;
    PlayerController playerController;

    public int playerID;

    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
        modules = new ArrayList();

		playerID = GetComponent<PhotonView>().viewID;
    }

    // Use this for initialization
    private void FixedUpdate () {
        if (modules.Count > 0)
        {
            foreach (Module m in modules)
            {
                if (m is Booster)
                {
                    Booster temp = (Booster)m;
                    playerController.boostVelocity += temp.getBoost();
                }
                else if ((m is Weapons) && Input.GetButton("Fire1"))
                {
                    Weapons temp = (Weapons)m;
                    temp.Fire_Trigger();
                }
            }
        }
    }

    public void addModule(Module mod)
    {
        if (modules.Count < 6)
        {
            modules.Add(mod);
        }

        if (mod is Cockpit)
        {
            pilot = (Cockpit)mod;
        }
    }

    public void destroyModule(Module mod)
    {
        modules.Remove(mod);
    }
}
