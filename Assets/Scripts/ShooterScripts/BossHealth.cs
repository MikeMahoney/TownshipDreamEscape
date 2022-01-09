using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public Image healthBarImage;
    public int maxHealth;
    void Start ()
    {
        if(!PlayerPrefs.HasKey("SHIELD_COUNT")){
            PlayerPrefs.SetInt("SHIELD_COUNT", 4);
        }
    }
    void Update ()
    {
        UpdateHealthBar();
    }
    public void UpdateHealthBar() {
        healthBarImage.fillAmount = Mathf.Clamp(maxHealth, 0, 1f);
    }
}
