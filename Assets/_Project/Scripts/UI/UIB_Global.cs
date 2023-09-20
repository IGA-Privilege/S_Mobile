using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIB_Global : UIBase
{
    void Start()
    {
        //AddButtonListen("Button_N", OnClick); //增加ButtonListener
        //ChangeTextContent("Text_N", "100,you are my heart! "); //文本改变


    }

    public void OnClick()
    {
        Debug.Log("点击成功！");
    }

    public void OnSwitchToGatcha()
    {
        
    }
}
