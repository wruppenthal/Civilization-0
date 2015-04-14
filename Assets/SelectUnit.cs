using UnityEngine;
using System.Collections;

public class SelectUnit : MonoBehaviour {

	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			if (hit) 
			{
				Debug.Log("Hit " + hitInfo.transform.gameObject.name);
				Destroy(hitInfo.transform.gameObject);
			} else {
				Debug.Log("No hit");
			}
		} 
	}
}