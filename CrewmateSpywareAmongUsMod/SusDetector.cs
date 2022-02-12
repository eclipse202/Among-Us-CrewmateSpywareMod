using System;
using UnityEngine;

namespace CrewmateSpywareMod
{
    public class SusDetector : MonoBehaviour
    {        
        public string firstImposter;
        public string secondImposter;
        public string thirdImposter;

        public SusDetector(IntPtr intPtr) : base(intPtr)
        {

        }

        void Update()
        {           
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (firstImposter == null)
                {
                    firstImposter = "*";
                }
                if (secondImposter == null)
                {
                    secondImposter = "*";
                }
                if (thirdImposter == null)
                {
                    thirdImposter = "*";
                }

                ImposterWindow(firstImposter, secondImposter, thirdImposter);
            }           
        }
        public void ImposterWindow(string imposter1, string imposter2, string imposter3)
        {
            HudManager.Instance.ShowPopUp("The imposters are: \n" + imposter1 + "\n" + imposter2 + "\n" + imposter3);
        }

        public void SetImposter(string imposter)
        {
            if (imposter != firstImposter)
            {
                firstImposter = imposter;
                return;
            }
            if (imposter != secondImposter)
            {
                secondImposter = imposter;
                return;
            }
            if (imposter != thirdImposter)
            {
                thirdImposter = imposter;
                return;
            }
        }

        void OnDestroy()
        {
            PlayerControl_Start.detector = null;
            Main.Logger.LogMessage("Round has ended.");
        }

    }
}
