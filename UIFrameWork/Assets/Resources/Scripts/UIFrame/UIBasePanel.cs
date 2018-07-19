/***
 * Author:TSoft
 * Title:  Panel基类：UIBasePanel  
 * Date: 18-7-19
 * 
 * **/

using UnityEngine;
using System.Collections;


public class UIBasePanel {

    public UIPanelType PanelType {
        get;
        private set;    
    }

    public UIBasePanel(UIPanelType panelType)
    {
        PanelType = panelType;
    }

}
