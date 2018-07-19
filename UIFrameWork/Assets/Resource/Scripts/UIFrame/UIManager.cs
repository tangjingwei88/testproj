/***
 * Author:TSoft
 * Title:  Panel管理类：UIManager
 * Date: 18-7-19
 * 
 * **/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIManager : MonoBehaviour {

    public Dictionary<UIPanelType, GameObject> UIDic = new Dictionary<UIPanelType, GameObject>();

    private Transform _uiRoot;

    private static UIManager _instance;
    public static UIManager Instance {
        get {
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }

    public UIManager()
    {
        _uiRoot = GameObject.Find("UIRoot").transform;
        foreach (Transform item in _uiRoot)
        {
            GameObject.Destroy(item.gameObject);
        }
    }

    /// <summary>
    /// 获取到ui prefab 的实例
    /// </summary>
    /// <param name="uiPanelType"></param>
    /// <returns></returns>
    public GameObject GetSingleUI(UIPanelType uiPanelType)
    {
        if (UIDic.ContainsKey(uiPanelType) == false || UIDic[uiPanelType] == null)
        {
            GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(uiPanelType.Path)) as GameObject;
            go.transform.SetParent(_uiRoot,false);
            go.name = uiPanelType.Name;
            UIDic.AddOrReplace(uiPanelType,go);
            return go;
        }
        return UIDic[uiPanelType];
    }

}
