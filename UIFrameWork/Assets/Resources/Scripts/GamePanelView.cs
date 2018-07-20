using UnityEngine;
using System.Collections;

public class GamePanel : UIBasePanel {

    public GamePanel():base(UIPanelType.GamePanel)
    {
        
    }


}
public class GamePanelView : AnimateView
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

    public void ReturnBackClick()
    {
        UIPanelManager.Instance.Pop();
    }

    public void NextPanelClick()
    {
        UIPanelManager.Instance.Push(new LoginPanel());
    }
}