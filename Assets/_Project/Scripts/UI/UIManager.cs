using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIBases { Global, Lobby, Shop,Gatcha }
public class UIManager : MonoBehaviour
{ 
    public static UIManager Instance;//单例模式
    public UIBase[] uiBases;
    Dictionary<string, Dictionary<string, GameObject>> allWedgate;//字典类型，如上图那样的树形结构

    private void Awake()
    {
        Instance = this;//赋值
        allWedgate = new Dictionary<string, Dictionary<string, GameObject>>();//实例化
        foreach (UIBase uIBase in uiBases)
        {
            uIBase.AddBehavioursToChildren();
            uIBase.InitializeListeners();
        }
    }

    public void RegistGameObject(string panleName, string wedgateName, GameObject obj)//注册
    {
        if (!allWedgate.ContainsKey(panleName))//so the dictionary had not panle object that create one;
        {
            allWedgate[panleName] = new Dictionary<string, GameObject>();
        }
        allWedgate[panleName].Add(wedgateName, obj);
    }

    public GameObject GetGameObject(string panleName, string wedgateName)//获取物体
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
