using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIB_Shop : UIBase
{
    public override void InitializeListeners()
    {
        AddButtonListen("BN_SwitchToAny", OnSwitchToAny); //����ButtonListener
        //ChangeTextContent("Text_N", "100,you are my heart! "); //�ı��ı�
    }

    public void OnSwitchToAny()
    {
        Debug.Log("SwitchToLobby");
        SwitchToOtherBase(UIBases.Lobby);
    }
}
