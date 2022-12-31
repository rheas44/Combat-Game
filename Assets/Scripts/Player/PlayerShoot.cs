using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerShoot : MonoBehaviour
{
    //only 1 system, make static
    public static Action shootInput;
    public static Action reloadInput;

    [SerializeField] private KeyCode reloadKey;

    private void Update() {
        if (Input.GetMouseButton(0)) {
            //question mark is null reference operator and avoids null reference exception in case there are no subscribers to the event
            shootInput?.Invoke();
        }

        if (Input.GetKeyDown(reloadKey)) {
            reloadInput?.Invoke();
        }
    }
}
