﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace InputRebinder.Runtime
{
    public class ActionMapContent : MonoBehaviour
    {
        /// <summary>
        /// Map associated with this content
        /// </summary>
        [HideInInspector]
        public InputActionMap Map;
    }
}