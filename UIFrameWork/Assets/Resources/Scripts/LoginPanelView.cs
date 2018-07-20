using UnityEngine;
using System.Collections;

public class LoginPanel : UIBasePanel {

    public LoginPanel() : base(UIPanelType.LoginPanel)
    {
        //Debug.LogError("##UIPanelType.LoginPanel.Name " + UIPanelType.LoginPanel.Name);
    }

}


public class LoginPanelView : AnimateView
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


    //返回按钮
    public void ReturnBtnClick()
    {
        UIPanelManager.Instance.Pop();
    }


    public void NextPanelClick()
    {
        UIPanelManager.Instance.Push(new GamePanel());
    }
}