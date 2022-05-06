using UnityEngine;
using UnityEngine.UI;

namespace Extensions
{
    public static class ImageExtensions
    {
        public static bool IsTransparent(this Image img)
        {
            return img.color.a == 0;
        }

        public static void SetTransparent(this Image img)
        {
            var c = img.color;
            img.color = new Color(c.r, c.g, c.b, 0);
        }

        public static void SetOpaque(this Image img)
        {
            var c = img.color;
            img.color = new Color(c.r, c.g, c.b, 1);
        }
    }
}