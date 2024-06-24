using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    GameObject endScreen;

    [SerializeField]
    GameObject player,
        portalGun;

    bool gameOver = false;

    // if the player has collided with the goal, activate the end screen, disable the gun, and activate the cursor
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with goal");

        if (other.gameObject == player)
        {
            gameOver = true;

            // player.transform.position = new Vector3(5, 2, 3);

            endScreen.SetActive(true);
            // portalGun.SetActive(false);
			player.SetActive(false);
        }
    }

    private void LateUpdate()
    {
        if (gameOver)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
