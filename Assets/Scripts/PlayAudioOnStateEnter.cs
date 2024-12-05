using UnityEngine;

public class PlayAudioOnStateEnter : StateMachineBehaviour
{
    public AudioClip audioClip; // Assign this in the Animator
    private AudioSource audioSource;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (audioSource == null)
        {
            // Look for the AudioSource component on the character
            audioSource = animator.gameObject.GetComponent<AudioSource>();
            if (audioSource == null)
            {
                Debug.LogError("No AudioSource found on the character!");
                return;
            }
        }

        if (audioClip != null)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
