﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KiddoApp
{
    public class Persistent : MonoBehaviour
    {
        // unity awake
        void Awake()
        {
            // tell unity to not delete this game object when the scene unloads
            DontDestroyOnLoad(this);
        }
    }
}
