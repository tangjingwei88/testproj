using UnityEngine;
using System.Collections;

public class ChatPanel : UIBasePanel {

    public ChatPanel() : base(UIPanelType.ChatPanel)
    {

    }
}


public class ChatPanelView :AnimateView
{
    public override void OnEnter(UIBasePanel uiPanel)
    {
        base.OnEnter(uiPanel);
    }


    public override void OnExit(UIBasePanel uiPanel)
    {
        base.OnExit(uiPanel);
    }


    public override void OnPause(UIBasePanel uiPanel)
    {
        base.OnPause(uiPanel);
    }


    public override void OnResume(UIBasePanel uiPanel)
    {
        base.OnResume(uiPanel);
    }


    public void ReturnBtnClick()
    {
        UIPanelManager.Instance.Pop();
    }


    public void NextBtnClick()
    {
        UIPanelManager.Instance.Push(new GamePanel());

    }
}
