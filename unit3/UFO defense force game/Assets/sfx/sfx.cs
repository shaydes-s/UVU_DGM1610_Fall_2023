using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour
{
  public AudioSource BlastSound;
  public AudioSource Button;
  public AudioSource Explosion;
 public void PlayBlastSound()
  {
    BlastSound.Play();
  }
  public void PlayButton()
  {
    Button.Play();
  }
  public void PlayExplosion()
  {
    Explosion.Play();
  }
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
      BlastSound.Play();
  }
  void OnTriggerEnter()
  {
    Explosion.Play();
  }
}
