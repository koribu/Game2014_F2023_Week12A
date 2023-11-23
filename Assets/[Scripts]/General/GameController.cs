using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    [SerializeField]
    GameObject _onScreenControllers;

    [SerializeField]
    bool _testing;

    SoundManager _soundManager;
    // Start is called before the first frame update
    void Awake()
    {
        if(!_testing)
        {
            _onScreenControllers = GameObject.Find("ScreenController");
            _onScreenControllers.SetActive(Application.platform != RuntimePlatform.WindowsPlayer &&
                                           Application.platform != RuntimePlatform.WindowsEditor);
        }

        _soundManager = FindObjectOfType<SoundManager>();


    }

    void Start()
    {
        _soundManager.PlayMusic(Sound.MAIN_MUSIC);

    }

}
