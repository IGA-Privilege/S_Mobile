using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIB_Shop : UIBase
{
    public override void InitializeListeners()
    {
        AddButtonListen("BN_SwitchToAny", OnSwitchToAny); //增加ButtonListener
        //ChangeTextContent("Text_N", "100,you are my heart! "); //文本改变
    }

    public void OnSwitchToAny()
    {
        Debug.Log("SwitchToLobby");
        SwitchToOtherBase(UIBases.Lobby);
    }
}
