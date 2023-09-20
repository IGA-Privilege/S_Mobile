using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIB_Lobby : UIBase
{
    public override void InitializeListeners()
    {
        AddButtonListen("BN_SwitchToGatcha", OnSwitchToGatcha); //增加ButtonListener
        //ChangeTextContent("Text_N", "100,you are my heart! "); //文本改变
    }

    public void OnSwitchToGatcha()
    {
        Debug.Log("SwitchToGatcha");
        SwitchToOtherBase(UIBases.Gatcha);
    }
}
