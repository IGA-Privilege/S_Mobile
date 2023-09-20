using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UIBase : MonoBehaviour
{
    public void AddBehavioursToChildren()
    {
        Transform[] allChildren = transform.GetComponentsInChildren<Transform>();//��ȡ�����ǵ�Transfrom
        for (int i = 0; i < allChildren.Length; i++)
        {
            if (GetBehaviourChildren())//��βΪ_N��������Ҫ�õ������
            {
                allChildren[i].gameObject.AddComponent<UIBehaviour>();//���UIBehaviour���
            }

            bool GetBehaviourChildren()
            {
                if (allChildren[i].name.StartsWith("BN_") ||
                    allChildren[i].name.StartsWith("TX_") ||
                    allChildren[i].name.StartsWith("XX_") ||
                    allChildren[i].name.StartsWith("XX_")
                    ) return true;
                else return false;
            }
        }
    }

    public virtual void InitializeListeners() { }

    public void ChangeTextContent(string wedgateName, string content)//�ı��ı�
    {
        UIBehaviour tmpBehaviour = GetUIBehaviour(wedgateName);
        if (tmpBehaviour != null)
        {
            tmpBehaviour.ChangeTextContent(content);
        }
    }

    public void AddButtonListen(string wedgateName, UnityAction action)//Button�����¼�
    {
        UIBehaviour tmpBehaviour = GetUIBehaviour(wedgateName);
        if (tmpBehaviour != null)
        {
            tmpBehaviour.AddButtonListen(action);
        }
    }

    public UIBehaviour GetUIBehaviour(string wedgateName)//��ȡ��Ӧ��UIBehaviour
    {
        UIBehaviour tmpUIBehaviour = GetGameObject(wedgateName).GetComponent<UIBehaviour>();
        if (tmpUIBehaviour != null)
        {
            return tmpUIBehaviour;
        }
        return null;
    }

    public GameObject GetGameObject(string wedgateName)//��ȡ��Ӧ��ui����
    {
        GameObject tmpGameObject = UIManager.Instance.GetGameObject(transform.name, wedgateName);
        if (tmpGameObject != null)
        {
            return tmpGameObject;
        }
        return null;
    }

    public void SwitchToOtherBase(UIBases targetBase)
    {
        float groupTransitionTime = 0.3f;
        CanvasGroup currentGroup = GetComponent<CanvasGroup>();
        GameObject targetBaseObj = UIManager.Instance.GetUIBase(targetBase);
        targetBaseObj.SetActive(true);
        CanvasGroup targetGroup = targetBaseObj.GetComponent<CanvasGroup>();

        DOTween.To(() => currentGroup.alpha, x => currentGroup.alpha = x, 0, groupTransitionTime);
        DOTween.To(() => targetGroup.alpha, x => targetGroup.alpha = x, 1, groupTransitionTime).
            OnComplete(() => gameObject.SetActive(false));
    }
}
