using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIB_Lobby : UIBase
{
    public override void InitializeListeners()
    {
        AddButtonListen("BN_SwitchToGatcha", OnSwitchToGatcha); //����ButtonListener
        //ChangeTextContent("Text_N", "100,you are my heart! "); //�ı��ı�
    }

    public void OnSwitchToGatcha()
    {
        Debug.Log("SwitchToGatcha");
        SwitchToOtherBase(UIBases.Gatcha);
    }
}
