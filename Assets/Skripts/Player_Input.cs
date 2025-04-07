using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input : MonoBehaviour {

	void Update () {
		Muwer.rid.muve = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
        Muwer.rid.rute = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Interface.rid.Sum(0);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Inventar.rid.On_INVER();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            InteraKtywer.rid.OnTached();
        }
    }
}
