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

			Debug.Log(modules.Count);

			mod.transform.parent = transform;

			switch (modules.Count) {
				case 2:  mod.transform.localPosition = new Vector3(0, 1.2f, 0);  break;
				case 3:	 mod.transform.localPosition = new Vector3(0, -.5f, 0); break;
				case 4: mod.transform.localPosition = new Vector3(-.5f, -.7f, 0); break;
				case 5: mod.transform.localPosition = new Vector3(-1, -.7f, 0); break;
				case 6: mod.transform.localPosition = new Vector3(.5f, -.7f, 0); break;
				case 7: mod.transform.localPosition = new Vector3(1f, -.7f, 0); break;
			}

			mod.transform.localRotation = Quaternion.Euler(0, 0, 0);
			mod.transform.GetChild(0).transform.localScale = new Vector3(.25f, .25f, 0);

			Debug.Log("Yo : " + mod.transform.parent);

			
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
