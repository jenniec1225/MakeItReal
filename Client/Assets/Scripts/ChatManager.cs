using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChatManager : MonoBehaviour
{

//chat on&off
    [SerializeField] private GameObject ChattingUI;
    [SerializeField] private GameObject ChatListGO;
    [SerializeField] private GameObject Contents;

    [SerializeField] private Button SendMessageButton;
    [SerializeField] private TMP_InputField Chat_InputField;

    private void Awake()
    {
        SendMessageButton.onClick.AddListener(AddChatMessage); //함수 호출 --> contents transform 하위에 챗 리스트의 object 생성
    }
    public void ShowChattingUI(bool isActive)
    {
        ChattingUI.SetActive(isActive);

    }

    public void AddChatMessage()
    {
        GameObject chatListGO = Instantiate(ChatListGO, Contents.transform); //contents의 transform으로 생성
        chatListGO.GetComponent<ChatMessage>().SetChatMessage(Chat_InputField.text);
        Chat_InputField.text = "";

    }

}
