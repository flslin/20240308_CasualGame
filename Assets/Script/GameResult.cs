using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class GameResult : MonoBehaviour
{
    [Header("UI Text")]
    public GameObject resultUI;
    public Text DeathCountText;
    public Text ItemText;
    public Text StageText;

    public static int itemCount; // �� ������ ����
    public static int stageCount; // ���� ��������
    public static int deathCount; // ��ī

    [Header("Data")]
    public int getItemCount;
    public int maxStage = 5;

    Item[] items;

    // Start is called before the first frame update
    void Start()
    {
        resultUI.SetActive(false);
        //items = FindObjectsOfType<Item>(); // ������ Ÿ���� ������Ʈ���� ���ӳ����� ã�Ƽ� ������ �迭�� ���
        itemCount = items.Length;

        ReviewText(StageText);
        StageText.text = $"{stageCount} / {maxStage}";
        ItemText.text = $"{getItemCount} / {itemCount}";
    }


    // Update is called once per frame
    void Update()
    {
        if (GoalArea.goal)
        {
            resultUI.SetActive(true);
        }
    }
    private void ReviewText(Text stageText)
    {
        throw new NotImplementedException();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //cnt++;
            //DeathCount.text = "DeathCount : " + cnt;
            //PlayerPrefs.SetInt("DeathCount", cnt);
        }
    }
}
