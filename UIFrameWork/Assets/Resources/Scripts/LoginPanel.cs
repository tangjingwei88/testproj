using UnityEngine;
using System.Collections;

public class LoginPanel : UIBasePanel {

    public LoginPanel() : base(UIPanelType.LoginPanel)
    {
        //Debug.LogError("##UIPanelType.LoginPanel.Name " + UIPanelType.LoginPanel.Name);
    }

    public class LoginPanelView : AnimateView
    {

    }
}
