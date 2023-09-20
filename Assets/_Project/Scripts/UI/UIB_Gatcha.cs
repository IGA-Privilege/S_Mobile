using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIB_Gatcha : UIBase
{
    public override void InitializeListeners()
    {
        AddButtonListen("BN_SwitchToLobby", OnSwitchToLobby); //增加ButtonListener
        //ChangeTextContent("Text_N", "100,you are my heart! "); //文本改变
    }

    public void OnSwitchToLobby()
    {
        Debug.Log("SwitchToLobby");
        SwitchToOtherBase(UIBases.Lobby);
    }
}
