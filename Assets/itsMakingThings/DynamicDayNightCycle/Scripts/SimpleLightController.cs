// @itsmakingthings
using UnityEngine;

namespace itsmakingthings_daynightcycle
{
    public class SimpleLightController : MonoBehaviour
    {
        [Header("Assign Lights Here")]
        [Tooltip("Drag all the light components you want to control into this list.")]
        public Light[] lights;

        [Header("Optional: Emissive Materials")]
        [Tooltip("If you have lamp meshes that glow, assign their renderers here to toggle emission.")]
        public Renderer[] lampRenderers;
        public string emissionKeyword = "_EMISSION";

        /// <summary>
        /// Call this via the "On Night Started" event.
        /// </summary>
        public void TurnLightsOn()
        {
            ToggleLights(true);
        }

        /// <summary>
        /// Call this via the "On Day Started" event.
        /// </summary>
        public void TurnLightsOff()
        {
            ToggleLights(false);
        }

        private void ToggleLights(bool state)
        {
            // Toggle the actual light sources
            if (lights != null)
            {
                foreach (Light l in lights)
                {
                    if (l != null) l.enabled = state;
                }
            }

            // Optional: Toggle the "Glow" on the lamp mesh
            if (lampRenderers != null)
            {
                foreach (Renderer r in lampRenderers)
                {
                    if (r != null)
                    {
                        if (state) r.material.EnableKeyword(emissionKeyword);
                        else r.material.DisableKeyword(emissionKeyword);
                    }
                }
            }
        }
    }
}
