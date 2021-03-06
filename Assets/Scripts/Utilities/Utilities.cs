﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Utilities
{
    public class Utilities : MonoBehaviour
    {

        // Write text to screen
        private float _letterPause = 0.05f;
        // private bool _writing;
        public IEnumerator TypeText(string message, Text TextComp)
        {
            for (int i = 0; i < message.Length; i++)
            {
                TextComp.text += message[i];
                yield return new WaitForSeconds(_letterPause);
            }
        }

    }
}
