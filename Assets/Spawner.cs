using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public AudioSource audioSource;
    public int numberOfBeats = 4;
    public int beatsPerMeasure = 4;

    private float beat;
    private float timer;

    void Start()
    {
        float musicLength = audioSource.clip.length;
        beat = musicLength / (numberOfBeats * beatsPerMeasure);
        beat *= 0.2f; // spawn cubes 20% faster

        // Schedule the end of the audio clip
        audioSource.PlayScheduled(AudioSettings.dspTime + musicLength);
        audioSource.SetScheduledEndTime(AudioSettings.dspTime + musicLength);
    }

    void Update()
    {
        timer += Time.deltaTime;

        while (timer > beat)
        {
            SpawnCube();
            timer -= beat;
        }
    }

    void SpawnCube()
    {
        GameObject cube = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]);
        cube.transform.localPosition = Vector3.zero;
        cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
    }
}
