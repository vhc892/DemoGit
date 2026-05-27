using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerData : MonoBehaviour
    {
        [Header("--- USER DATA ---")]
        public bool isNoAds = false;
        public int currentMapIndex = 0;

        public bool isSound = true;
        public bool isMusic = true;
        public bool isVibration = true;
        public float musicVolume = 1f;

        public int pearls = 200;
        public int ruby = 0;
}
