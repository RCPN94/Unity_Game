using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class CanonScript : MonoBehaviour    {
    public AudioSource canonAudio;
    public float canonTimeSeconds;
    [SerializeField] VisualEffect _canonShot;
    [SerializeField] VisualEffect _canonPrefab;

    // Start is called before the first frame update
    void Start()    {
        
        
    }

    // Update is called once per frame
    void Update()   {
        if(Input.GetKeyDown(KeyCode.Space))   {
            canonAudio.Play();
            //ShotCanon();
            SpawnCanon();
        }
    }

    void ShotCanon()    {
        _canonShot.Play();
    }

    void SpawnCanon()   {
        // instantiate new particle
        VisualEffect newCanonShot = Instantiate(_canonPrefab, transform.position, transform.rotation);
        // play the particle
        newCanonShot.Play();
        // destroy particle
        Destroy(newCanonShot.gameObject, canonTimeSeconds);
    }
}
