using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameJolt.UI;
using GameJolt.API;
using TMPro;

public class LifePlayer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        timerText.text = $"Timer: {timer}";
        if (timer >= 5)
        {
            Trophies.TryUnlock(216240);
        }
        if(timer >= 15)
        {
            Trophies.TryUnlock(216243);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Lose");
            Trophies.TryUnlock(216232);
        }
    }
}
