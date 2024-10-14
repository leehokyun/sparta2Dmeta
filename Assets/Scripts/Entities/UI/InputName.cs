
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    //이름 입력하고 -> 이름 gamemanager로 전달 

    public InputField playerNameInput;
    public string playerName = null;
    public Button Button_Login;

    private void Awake()
    {
        Button_Login.GetComponent<Button>().interactable = false;
    }

    private void Update()
    {
        if (playerNameInput.text.Length < 2 || playerNameInput.text.Length > 10)
        {
            Button_Login.GetComponent<Button>().interactable = false;
        }
        else
        {
            Button_Login.GetComponent<Button>().interactable = true;
            ColorBlock colorBlock = Button_Login.colors;
            colorBlock.normalColor = new Color(0f, 255f, 15f, 255f);
            Button_Login.colors = colorBlock;
        }
    }

    public void LoginButtonClick()
    {
        InputNametoGM();
        SceneManager.LoadScene("SampleScene");
    }

    public void InputNametoGM()
    {
        playerName = playerNameInput.text;
        PlayerPrefs.SetString("CurrentPlayerName", playerName);
        GameManager.Instance.NameSet(playerName);
        ReturnName();
    }

    public string ReturnName()
    {
        return playerName;
    }
}