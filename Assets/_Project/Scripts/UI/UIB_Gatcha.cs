using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIB_Gatcha : UIBase
{
    public override void InitializeListeners()
    {
        AddButtonListen("BN_SwitchToLobby", OnSwitchToLobby); //����ButtonListener
        //ChangeTextContent("Text_N", "100,you are my heart! "); //�ı��ı�
    }

    public void OnSwitchToLobby()
    {
        Debug.Log("SwitchToLobby");
        SwitchToOtherBase(UIBases.Lobby);
    }
}
