using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterChoiceButton : MonoBehaviour
{

    public Button Button_CharacterChoice;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick(int num)
    {
        //GameManager.Instance.playerId = num;
        GameManager.Instance.Start(num);
        //SceneManager.LoadScene("NamingScene");
    }

    
}
