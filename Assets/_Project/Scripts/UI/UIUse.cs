using UnityEngine;

public class UIUse : UIBase
{
    void Start()
    {
        AddButtonListen("Button_N", OnClick);//����ButtonListener
        ChangeTextContent("Text_N", "100,you are my heart! ");//�ı��ı�
    }

    public void OnClick()
    {
        Debug.Log("����ɹ���");
    }
}
