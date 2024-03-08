using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrapMovement : MonoBehaviour
{
    [Range(1,5)] public float speed = 1.0f;
    public float length = 25.0f;

    public float posX = 0.0f;
    public float posY = 0.0f;
    public float posZ = 0.0f;

    public bool flip;

    Vector3 pos;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (flip == false)
        {
            //runTime += Time.deltaTime * speed;
            pos.x = Mathf.Sin(Time.time * 80 * Mathf.Deg2Rad) * length;
            transform.position = new Vector3(pos.x, posY, posZ);
        }

        else
        {
            pos.x = Mathf.Sin(Time.time * -80 * Mathf.Deg2Rad) * length;
            transform.position = new Vector3(pos.x, posY, posZ);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
