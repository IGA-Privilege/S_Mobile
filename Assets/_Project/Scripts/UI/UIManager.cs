using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIBases { Global, Lobby, Shop,Gatcha }
public class UIManager : MonoBehaviour
{ 
    public static UIManager Instance;//����ģʽ
    public UIBase[] uiBases;
    Dictionary<string, Dictionary<string, GameObject>> allWedgate;//�ֵ����ͣ�����ͼ���������νṹ

    private void Awake()
    {
        Instance = this;//��ֵ
        allWedgate = new Dictionary<string, Dictionary<string, GameObject>>();//ʵ����
        foreach (UIBase uIBase in uiBases)
        {
            uIBase.AddBehavioursToChildren();
            uIBase.InitializeListeners();
        }
    }

    public void RegistGameObject(string panleName, string wedgateName, GameObject obj)//ע��
    {
        if (!allWedgate.ContainsKey(panleName))//so the dictionary had not panle object that create one;
        {
            allWedgate[panleName] = new Dictionary<string, GameObject>();
        }
        allWedgate[panleName].Add(wedgateName, obj);
    }

    public GameObject GetGameObject(string panleName, string wedgateName)//��ȡ����
    {
        if (allWedgate[panleName] != null)
        {
            return allWedgate[panleName][wedgateName];
        }
        return null;
    }

    public GameObject GetUIBase(UIBases targetBase)
    {
        string uiBaseName = "";
        switch (targetBase)
        {
            case UIBases.Global:
                uiBaseName = "UIB_Global";
                break;
            case UIBases.Lobby:
                uiBaseName = "UIB_Lobby";
                break;
            case UIBases.Shop:
                uiBaseName = "UIB_Shop";
                break;
            case UIBases.Gatcha:
                uiBaseName = "UIB_Gatcha";
                break;
        }
        if (transform.Find(uiBaseName)!=null)
        {
            return transform.Find(uiBaseName).gameObject;
        }
        return null;
    }
}
