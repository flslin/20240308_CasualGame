using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform spawnArea;
    Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        rotation = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0, 0, 4) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(-4, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(0, 0, -4) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(4, 0, 0) * Time.deltaTime;
        }
    }

    private void Item(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            GameResult.itemCount++;
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Trap")
        {
            GameResult.itemCount = 0;
            GameResult.deathCount++;
            gameObject.transform.position = spawnArea.position;
        }
    }

}
