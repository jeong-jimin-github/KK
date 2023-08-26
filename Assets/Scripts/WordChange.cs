using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordChange : MonoBehaviour
{
    public Text aiWord;
    public Text backWord;
    public Text twoBackWord;
    public InputField inputField;
    public GameObject wordDB;
    public Text errorText;
    
    void ErrorTextFunc(string error)
    {
        inputField.text = "";
        errorText.text = error;
    }
    public void WordChangeFunc()
    {
        errorText.text = "";
        if (aiWord.text[^1] == inputField.text[0])
        {
            if (wordDB.GetComponent<WordDB>().SearchWord(inputField.text) == true)
            {
                WordChangeFuncHelp();
            }
            else
            {
                ErrorTextFunc("사전에 없는 단어입니다.");
                Debug.Log("사전에 없는 단어");
                //사전에 없는 단어
            }
        }
        else
        {
            ErrorTextFunc("주어진 단어로 이어주세요.");
            Debug.Log("주어진 단어의 말미와 입력한 단어의 첫음이 다름");
            //두음법칙
        }
    }

    private void WordChangeFuncHelp()
    {
        twoBackWord.text = backWord.text;
        backWord.text = aiWord.text;
        aiWord.text = inputField.text;
        inputField.text = "";
        errorText.text = "";
    }
}
