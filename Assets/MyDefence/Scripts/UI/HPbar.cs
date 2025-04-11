using UnityEngine;
using TMPro;

namespace MyDefence
{

    public class HPbar : MonoBehaviour
    {
        #region Field
        //Live Text UI
        public TextMeshProUGUI livesText;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            livesText.text = PlayerStats.Lives.ToString();
        }
    }
}