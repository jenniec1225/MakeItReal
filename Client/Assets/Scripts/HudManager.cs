using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{

    //on off button

    [SerializeField] private Button ChatButton;
    private bool isActiveChatUI = false;
    private ChatManager ChatManager;

    private void Awake()
    {
        //when button clicked
        ChatButton.onClick.AddListener(OnClickChatButton);
    }

    // Start is called before the first frame update
    void Start()
    {
        ChatManager = GetComponent<ChatManager>();
    }


    private void OnClickChatButton()
    {
        isActiveChatUI = !isActiveChatUI;
        ChatManager.ShowChattingUI(isActiveChatUI);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
