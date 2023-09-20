using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour
{
    private void Awake()
    {
        UIBase uiBase = transform.GetComponentInParent<UIBase>();//找到上层的panle
        UIManager.Instance.RegistGameObject(uiBase.name, transform.name, gameObject);//在UIManager里面注册
    }

    public void AddButtonListen(UnityAction action)//Button监听事件
    {
        Button tmpButton = transform.GetComponent<Button>();
        if (tmpButton != null)
        {
            tmpButton.onClick.AddListener(action);
        }
    }

    public void AddSliderListen(UnityAction<float> action)//Slider监听事件
    {
        Slider tmpSlider = transform.GetComponent<Slider>();
        if (tmpSlider != null)
        {
            tmpSlider.onValueChanged.AddListener(action);
        }
    }

    public void AddInputFieldEndEditorListen(UnityAction<string> action)//输入框编辑结束
    {
        InputField tmpInputField = transform.GetComponent<InputField>();
        if (tmpInputField != null)
        {
            tmpInputField.onEndEdit.AddListener(action);
        }
    }

    public void AddInputFieldonValueChangeListen(UnityAction<string> action)//输入框内容改变
    {
        InputField tmpInputField = transform.GetComponent<InputField>();
        if (tmpInputField != null)
        {
            tmpInputField.onValueChanged.AddListener(action);
        }
    }

    public void ChangeTextContent(string content)//文本内容改变
    {
        Text tmpText = transform.GetComponent<Text>();
        if (tmpText != null)
        {
            tmpText.text = content;
        }
    }

    public void ChangeImageSprite(Sprite name)//图片精灵更改
    {
        Image tmpImage = transform.GetComponent<Image>();
        if (tmpImage != null)
        {
            tmpImage.sprite = name;
        }
    }
}
