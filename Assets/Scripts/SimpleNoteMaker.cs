using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleNoteMaker : MonoBehaviour
{
    [Header("Set in Inspector")]
    public AudioSource audioSource;
    public AudioClip audioClip;
    public int bpm = 60;    // beats per minute of track

    public NoteManualMove notePrefab;
    
    // On screen string lines to place notes onto
    public Transform stringLine1;
    public Transform stringLine2;
    public Transform stringLine3;
    public Transform stringLine4;

    [Header("Set in Script")]
    [SerializeField] private float secondsPerBeat;
    [SerializeField] private float[] samples;

    void Start()
    {
        // Calculate how many seconds does a single beat take
        secondsPerBeat = (float)60 / bpm;

        // Creat an empty array to hold clip sample data (which is values between -1 & 1 according to Unity docs)
        // https://docs.unity3d.com/ScriptReference/AudioClip.GetData.html
        samples = new float[audioClip.samples];
        
        // Get audio clip sample data. If successful, start making notes
        if (audioClip.GetData(samples, 0))
        {
            print("Got data!");
            StartCoroutine(MakeNotes());
        }
    }

    IEnumerator MakeNotes()
    {
        int noteCount = 0;

        // Keep creating notes while audio source is playing
        while (audioSource.isPlaying)
        {
            // Wait for the beat interval
            yield return new WaitForSecondsRealtime(secondsPerBeat);

            // Get the clip playback time/position (in samples) at the moment a note is instantiated
            int clipTime = audioSource.timeSamples;

            // Pick a string line at the playback time
            Transform stringLine = PickLineAtClipTime(clipTime);

            // Create a new note instance and position it at the location of the chosen line
            NoteManualMove noteInstance = Instantiate(notePrefab, stringLine.position, Quaternion.identity);
            
            // Move the note down
            noteInstance.Move();

            noteCount++;
        }

        print("Number of notes created: " + noteCount);
    }

    //Selects which string line a new note will be created at
    private Transform PickLineAtClipTime(int clipTime)
    {
        Transform pickedLine;

        // We have 4 string lines, 2 on left side and 2 on right side
        // First we pick a side (left/right) by checking if the sample value is +ve or -ve

        if (samples[clipTime] < 0)  // left side
        {
            // pick a random string from the 2 on left side
            int random = Random.Range(0, 2);
            if (random == 0)
            {
                pickedLine = stringLine1;
            }
            else
            {
                pickedLine = stringLine2;
            }
        }
        else    // rigth side
        {
            // pick a random string from the 2 on right side
            int random = Random.Range(0, 2);
            if (random == 0)
            {
                pickedLine = stringLine3;
            }
            else
            {
                pickedLine = stringLine4;
            }
        }

        return pickedLine;
    }
}
