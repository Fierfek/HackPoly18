using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleManage : MonoBehaviour {

	List<Module> modules = new List<Module>();
	List<Module> slot1, slot2, slot3, slot4, slot5, slot6;

	public void Gather() {
		slot1 = new List<Module>();
		slot2 = new List<Module>();
		slot3 = new List<Module>();
		slot4 = new List<Module>();
		slot5 = new List<Module>();
		slot6 = new List<Module>();

		modules.AddRange(GetComponentsInChildren<Module>());
		modules.RemoveAt(0);

		DeactivateAll();

		slot1.AddRange(modules.GetRange(0, 5));
		slot2.AddRange(modules.GetRange(6, 11));
		//slot3.AddRange(modules.GetRange(12, 17));
		//slot4.AddRange(modules.GetRange(18, 23));
		//slot5.AddRange(modules.GetRange(24, 29));
		//slot6.AddRange(modules.GetRange(30, 35));
	}

	public void DeactivateAll() {
		foreach (Module m in modules) {
			Remove(m);
		}
	}

	public Module Remove(Module mod) {
		bool hit = false;
		Module temp = null;
		foreach(Module m in slot1) {
			if(m.Equals(mod)) {
				if (m.gameObject.activeSelf) {
					m.gameObject.SetActive(false);
					hit = true;
					temp = m;
				}
			}
		}

		if(!hit) {
			foreach (Module m in slot2) {
				if (m.Equals(mod)) {
					if (m.gameObject.activeSelf) {
						m.gameObject.SetActive(false);
						hit = true;
						temp = m;
					}
				}
			}
		}

		if (!hit) {
			foreach (Module m in slot3) {
				if (m.Equals(mod)) {
					if (m.gameObject.activeSelf) {
						m.gameObject.SetActive(false);
						hit = true;
						temp = m;
					}
				}
			}
		}

		if (!hit) {
			foreach (Module m in slot4) {
				if (m.Equals(mod)) {
					if (m.gameObject.activeSelf) {
						m.gameObject.SetActive(false);
						hit = true;
						temp = m;
					}
				}
			}
		}

		if (!hit) {
			foreach (Module m in slot5) {
				if (m.Equals(mod)) {
					if (m.gameObject.activeSelf) {
						m.gameObject.SetActive(false);
						hit = true;
						temp = m;
					}
				}
			}
		}

		if (!hit) {
			foreach (Module m in slot6) {
				if (m.Equals(mod)) {
					if (m.gameObject.activeSelf) {
						m.gameObject.SetActive(false);
						hit = true;
						temp = m;
					}
				}
			}
		}

		return temp;
	}

	public Module Activate(Module mod) {
		bool hit = false;
		Module temp = null;
		foreach (Module m in slot1) {
			if (m.Equals(mod)) {
				if (m.gameObject.activeSelf) {
					break;
				} else {
					m.gameObject.SetActive(true);
					hit = true;
					temp = m;
				}
			} else {
				m.gameObject.SetActive(false);
			}
		}

		if (!hit) {
			foreach (Module m in slot2) {
				if (m.Equals(mod)) {
					if (m.gameObject.activeSelf) {
						break;
					} else {
						m.gameObject.SetActive(true);
						hit = true;
						temp = m;
					}
				} else {
					m.gameObject.SetActive(false);
				}
			}
		}

		if (!hit) {
			foreach (Module m in slot3) {
				if (m.Equals(mod)) {
					if (m.gameObject.activeSelf) {
						break;
					} else {
						m.gameObject.SetActive(true);
						hit = true;
						temp = m;
					}
				} else {
					m.gameObject.SetActive(false);
				}
			}
		}

		if (!hit) {
			foreach (Module m in slot4) {
				if (m.Equals(mod)) {
					if (m.gameObject.activeSelf) {
						break;
					} else {
						m.gameObject.SetActive(true);
						hit = true;
						temp = m;
					}
				} else {
					m.gameObject.SetActive(false);
				}
			}
		}

		if (!hit) {
			foreach (Module m in slot5) {
				if (m.Equals(mod)) {
					if (m.gameObject.activeSelf) {
						break;
					} else {
						m.gameObject.SetActive(true);
						hit = true;
						temp = m;
					}
				} else {
					m.gameObject.SetActive(false);
				}
			}
		}

		if (!hit) {
			foreach (Module m in slot6) {
				if (m.Equals(mod)) {
					if (m.gameObject.activeSelf) {
						break;
					} else {
						m.gameObject.SetActive(true);
						hit = true;
						temp = m;
					}
				} else {
					m.gameObject.SetActive(false);
				}
			}
		}

		return temp;
	}
}
