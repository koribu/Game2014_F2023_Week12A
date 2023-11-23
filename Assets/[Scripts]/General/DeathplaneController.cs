using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathplaneController : MonoBehaviour
{
    Vector3 _spawnPoint;

    SoundManager _soundManager;

    // Start is called before the first frame update
    void Start()
    {
        _soundManager = FindObjectOfType<SoundManager>();
        _spawnPoint = new Vector3(0, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = _spawnPoint;
            _soundManager.PlaySound(Channel.PLAYER_DEATH_SFX, Sound.DEATH);
        }
    }

    public void UpdateSpawnPoint(Vector3 spawnPoint)
    {
        _spawnPoint = spawnPoint;
    }
}
