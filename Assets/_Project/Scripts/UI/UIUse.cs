using UnityEngine;

public class UIUse : UIBase
{
    void Start()
    {
        AddButtonListen("Button_N", OnClick);//增加ButtonListener
        ChangeTextContent("Text_N", "100,you are my heart! ");//文本改变
    }

    public void OnClick()
    {
        Debug.Log("点击成功！");
    }
}
