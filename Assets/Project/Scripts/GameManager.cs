using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject clickSFX;
    [SerializeField] private Canvas canva;

    public GameObject MainGameCanvas;
    [SerializeField] private GameObject upgradeCanvas;
    [SerializeField] private TextMeshProUGUI eggCountText;
    [SerializeField] private TextMeshProUGUI eggsPerSecondText;
    [SerializeField] private GameObject eggObj;
    public GameObject EggTextPopup;
    [SerializeField] private GameObject backgroundobj;

    [SerializeField] private GameObject upgradeUIToSpawn;
    [SerializeField] private Transform upgradeUIParent;
    public GameObject EggsPerSecondToSpawn;

    public double CurrentEggCount { get; set; }
    public double CurrentEggPerSecond { get; set; }

    public double EggsPerClickUpgrade { get; set; }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Input.mousePosition;
            GameObject _gameObject = Instantiate(clickSFX, pos, clickSFX.transform.rotation);
            _gameObject.transform.SetParent(canva.transform);
        }
    }
}
