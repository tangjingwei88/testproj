using UnityEngine;
using System.Collections;

public class GameData {

    #region 变量

    #endregion


    private static GameData _instance;
    public static GameData Instance {
        get {
            if (_instance == null)
            {
                _instance = new GameData();
            }
            return _instance;
        }
    }


    public class MusicType {

        public enum Main {
            BgMusic,
            Click,
            Select,
        }


        public enum Monster {
            BigBoss,
            Ent_001,
            Ent_002,
        }

        public enum Weapon {
            Arrow,
            Anchor,
            Snow,
            Star,
        }
    }



}
