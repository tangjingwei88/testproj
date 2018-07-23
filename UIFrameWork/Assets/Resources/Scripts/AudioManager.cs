using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    #region 变量
    private AudioSource _BgMusic;
    private AudioSource _EffctMusic;


    //背景音乐音量大小
    public float BgMusicVolume {
        get { return _BgMusic.volume; }
        set { _BgMusic.volume = value; }
    }


    //音效音量大小
    public float EffctMusicVolume {
        get { return _EffctMusic.volume; }
        set { _EffctMusic.volume = value; }
    }

    #endregion


    private static AudioManager _instance;
    public static AudioManager Instance {

        get {
            if (_instance == null)
            {
                _instance = new AudioManager();
            }
            return _instance;
        }
    }


    void Awake()
    {
        //实例化背景音乐源
        _BgMusic = gameObject.AddComponent<AudioSource>();
        _BgMusic.loop = true;                //开启循环
        _BgMusic.volume = 1;                 //音量最大
        _BgMusic.playOnAwake = false;        //开始播放

        //实例化音效音乐源
        _EffctMusic = gameObject.AddComponent<AudioSource>();
        _EffctMusic.loop = true;
        _EffctMusic.playOnAwake = false;
        _EffctMusic.volume = 1;

    }


    /// <summary>
    ///播放背景音乐
    /// </summary>
    /// <param name="bgName">背景音乐名称</param>
    /// <param name="reStart">是否重新开始播放</param>
    private void PlayBgBase(Object bgName, bool reStart = false)
    {
        //当前背景音乐名称
        string curBgMusicName = string.Empty;

        //如果这个音乐源的音乐剪辑不为空
        if (_BgMusic.clip != null)
        {
            //获得该音乐剪辑的名称
            curBgMusicName = _BgMusic.clip.name;
        }

        //根据传入的音乐名称获取Audioclip
        //动态加载出该资源
        AudioClip audioClip = ResourceManager.Instance.Load<AudioClip>(bgName);
        //如果找到了，不为空
        if (audioClip != null)
        {
            //如果这个audioClip已经赋值给这个音乐源，并且正在播放不需要reStart，那么直接跳出
            if (curBgMusicName == audioClip.name && !reStart)
            {
                return;
            }
            //否则，将传入的audioclip赋值给音乐源，并播放
            else
            {
                _BgMusic.clip = audioClip;
                _BgMusic.Play();
            }
        }
        else {
            Debug.LogError("加载" + bgName + "失败！");
        }

    }


    /// <summary>
    /// 播放音效的基类
    /// </summary>
    /// <param name="effectName"></param>
    /// <param name="defAudio"></param>
    /// <param name="volume"></param>
    private void PlayEffectBase(Object effectName,bool defAudio = true,float volume =1)
    {
        //动态加载音效资源
        AudioClip effectClip = ResourceManager.Instance.Load<AudioClip>(effectName);
        //没加载到
        if (effectClip == null)
        {
            Debug.LogError("加载" + effectClip + "失败！");
            return;
        }
        else {
            //如果defAudio为ture，直接播放
            if (defAudio)
            {
                _EffctMusic.PlayOneShot(effectClip, volume);
            }
            else {
                //指定点播放
                AudioSource.PlayClipAtPoint(effectClip,Camera.main.transform.position,volume);
            }
        }


    }

}
