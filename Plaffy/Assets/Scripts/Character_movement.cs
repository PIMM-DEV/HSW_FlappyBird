using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(480, 800, false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            gameObject.GetComponent<Rigidbody>().AddForce(0, 250, 0);
        }
        if (Input.GetKeyDown(KeyCode.R)){
            Time.timeScale = 1;
            Application.LoadLevel("Game");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("GameOver");
        Time.timeScale = 0;
        gameObject.GetComponent<Animator>().Play("Death");
    }
}
