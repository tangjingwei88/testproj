/***
 * Author:TSoft
 * Title:  UI基类：UIBase  所有UI继承该基类
 * Date: 18-7-19
 * 
 * **/

using UnityEngine;
using System.Collections;



public class UIBase : MonoBehaviour {

    //UI第一次切入时调用
    public virtual void OnEnter(UIBasePanel uiPanel)
    {

    }

    //UI隐藏时调用
    public virtual void OnPause(UIBasePanel uiPanel)
    {

    }

    //UI重新切入时调用
    public virtual void OnResume(UIBasePanel uiPanel)
    {

    }

    //UI退出时调用
    public virtual void OnExit(UIBasePanel uiPanel)
    {

    }

    //自我销毁
    public void DestroySelf(UIBasePanel uiPanel)
    {
        Destroy(gameObject);
    }
}
