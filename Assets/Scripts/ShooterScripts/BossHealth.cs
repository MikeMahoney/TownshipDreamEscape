﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public Image healthBarImage;
    public int maxHealth;
    public void UpdateHealthBar() {
        healthBarImage.fillAmount = Mathf.Clamp(maxHealth, 0, 1f);
    }
}
