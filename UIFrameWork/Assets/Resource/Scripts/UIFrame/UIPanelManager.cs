using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIPanelManager {

    private Stack<UIBasePanel> _UIPanelStack = new Stack<UIBasePanel>();

    public UIPanelManager()
    {

    }

    /// <summary>
    /// 入栈
    /// </summary>
    /// <param name="nextUIPanel"></param>
    public void Push(UIBasePanel nextUIPanel)
    {
        if (_UIPanelStack.Count != 0)
        {
            UIBasePanel curUIPanel = _UIPanelStack.Peek();
            UIBase curUI = UIManager.Instance.GetSingleUI(curUIPanel.PanelType).GetComponent<UIBase>();
            curUI.OnPause(curUIPanel);
        }

        _UIPanelStack.Push(nextUIPanel);
        UIBase nextUI = UIManager.Instance.GetSingleUI(nextUIPanel.PanelType).GetComponent<UIBase>();
        nextUI.OnEnter(nextUIPanel);
    }



    public void Pop()
    {
        if (_UIPanelStack.Count != 0)
        {
            UIBasePanel curUIPanel = _UIPanelStack.Peek();
            _UIPanelStack.Pop();

            UIBase curUI = UIManager.Instance.GetSingleUI(curUIPanel.PanelType).GetComponent<UIBase>();
            curUI.OnExit(curUIPanel);
        }

        if (_UIPanelStack.Count != 0)
        {
            UIBasePanel lastUIPanel = _UIPanelStack.Peek();
            UIBase curUI = UIManager.Instance.GetSingleUI(lastUIPanel.PanelType).GetComponent<UIBase>();
            curUI.OnResume(lastUIPanel);
        }

    }


    public UIBasePanel PeakOrNull()
    {
        if (_UIPanelStack.Count != 0)
        {
            return _UIPanelStack.Peek();
        }
        return null;
    }
}
