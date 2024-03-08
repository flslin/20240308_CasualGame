using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResult : MonoBehaviour
{
    public GameObject resultUI;

    // Start is called before the first frame update
    void Start()
    {
        resultUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GoalArea.goal)
        {
            resultUI.SetActive(true);

        }
    }
}
