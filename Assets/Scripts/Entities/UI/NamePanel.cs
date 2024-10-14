using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NamePanel : MonoBehaviour
{
    //플레이어 머리 위에 떠다니는 패널

    public Text nameTxt;
    string playerID = "";

    // Start is called before the first frame update
    public void Awake()
    {
        nameTxt = nameTxt.GetComponent<Text>();
        ReturnPlayerName();
    }

    public void ReturnPlayerName()
    {
        playerID = PlayerPrefs.GetString("CurrentPlayerName");
        nameTxt.text = playerID;
    }
}
