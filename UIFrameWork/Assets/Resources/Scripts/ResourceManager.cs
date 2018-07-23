using UnityEngine;
using System.Collections;

public class ResourceManager : MonoBehaviour {

    #region 变量

    #endregion

    private static ResourceManager _instance;
    public static ResourceManager Instance {
        get {
            if (_instance == null)
            {
                _instance = new ResourceManager();
            }
            return _instance;
        }
    }


    /// <summary>
    /// 加载音频资源
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="enumName"></param>
    /// <returns></returns>
    public T Load<T>(Object enumName) where T : Object
    {
        string enumType = enumName.GetType().Name;
        string filePath = string.Empty;

        switch (enumType)
        {
            case "Main":
                filePath = "AudioSource/Main" + enumName;
                break;
            case "Monster":
                filePath = "AudioSource/Main" + enumName;
                break;
            case "Weapon":
                filePath = "AudioSource/Weapon" + enumName;
                break;

        }

        return Resources.Load<T>(filePath);
    }
}
