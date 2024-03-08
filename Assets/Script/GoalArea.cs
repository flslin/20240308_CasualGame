using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalArea : MonoBehaviour
{
    public static bool goal;
    public GameObject resultUI;

    // Start is called before the first frame update
    void Start()
    {
        goal = false;
        resultUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            goal = true;
            Debug.Log("Goal!");
            resultUI.SetActive(true);
        }
    }
}
