using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour
{
    private void Awake()
    {
        UIBase uiBase = transform.GetComponentInParent<UIBase>();//�ҵ��ϲ��panle
        UIManager.Instance.RegistGameObject(uiBase.name, transform.name, gameObject);//��UIManager����ע��
    }

    public void AddButtonListen(UnityAction action)//Button�����¼�
    {
        Button tmpButton = transform.GetComponent<Button>();
        if (tmpButton != null)
        {
            tmpButton.onClick.AddListener(action);
        }
    }

    public void AddSliderListen(UnityAction<float> action)//Slider�����¼�
    {
        Slider tmpSlider = transform.GetComponent<Slider>();
        if (tmpSlider != null)
        {
            tmpSlider.onValueChanged.AddListener(action);
        }
    }

    public void AddInputFieldEndEditorListen(UnityAction<string> action)//�����༭����
    {
        InputField tmpInputField = transform.GetComponent<InputField>();
        if (tmpInputField != null)
        {
            tmpInputField.onEndEdit.AddListener(action);
        }
    }

    public void AddInputFieldonValueChangeListen(UnityAction<string> action)//��������ݸı�
    {
        InputField tmpInputField = transform.GetComponent<InputField>();
        if (tmpInputField != null)
        {
            tmpInputField.onValueChanged.AddListener(action);
        }
    }

    public void ChangeTextContent(string content)//�ı����ݸı�
    {
        Text tmpText = transform.GetComponent<Text>();
        if (tmpText != null)
        {
            tmpText.text = content;
        }
    }

    public void ChangeImageSprite(Sprite name)//ͼƬ�������
    {
        Image tmpImage = transform.GetComponent<Image>();
        if (tmpImage != null)
        {
            tmpImage.sprite = name;
        }
    }
}
