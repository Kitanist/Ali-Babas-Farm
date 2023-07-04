using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject StartScene, GameScene;
    public GameEvent TimeKeeper;
    public int howMuchTimeSpended;
    private void Awake()
    {
        Application.targetFrameRate = 30;
    }
    public void StartGame()
    {
        StartScene.SetActive(false);
        GameScene.SetActive(true);
        StartCoroutine(ITimeKeeper());
    }
    public IEnumerator ITimeKeeper()
    {
        yield return new WaitForSeconds(1);
        TimeKeeper.Raise();
        howMuchTimeSpended++;
        StartCoroutine(ITimeKeeper());
    }
}
