using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text timeText;
    public Text treeInfoText;

    void Start()
    {
        UpdateTime();
        InvokeRepeating("UpdateTime", 0, 1);
    }

    void UpdateTime()
    {
        timeText.text = "Current Time: " + System.DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public void UpdateTreeInfo(string treeInfo)
    {
        treeInfoText.text = treeInfo;
    }
}