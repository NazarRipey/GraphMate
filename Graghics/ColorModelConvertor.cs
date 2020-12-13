using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Graghics
{
    public struct RGB
    {
        public int R;
        public int G;
        public int B;
    }

    public struct HSV
    {
        public double H;
        public double S;
        public double V;
    }
    class ColorModelConvertor
    {
        public static HSV ConvertToHSV(Color color)
        {
            HSV hsv = new HSV();
            Dictionary<char, double> colors = new Dictionary<char, double>();
            colors.Add('R', color.R);
            colors.Add('G', color.G);
            colors.Add('B', color.B);

            double max = colors.Values.Max();
            double min = colors.Values.Min();
            double delta = max - min;

            if (min == max)
            {
                hsv.H = 0;
            }
            else
            {
                if (max == colors['R'] && colors['G'] >= colors['B'])
                {
                    hsv.H = 60 * ((colors['G'] - colors['B']) / delta);
                }

                if (max == colors['R'] && colors['G'] < colors['B'])
                {
                    hsv.H = 60 * ((colors['G'] - colors['B']) / delta) + 360;
                }

                if (max == colors['G'])
                {
                    hsv.H = 60 * ((colors['B'] - colors['R']) / delta) + 120;
                }

                if (max == colors['B'])
                {
                    hsv.H = 60 * ((colors['R'] - colors['G']) / delta) + 240;
                }
            }

            if (max == 0)
            {
                hsv.S = 0;
            }
            else
            {
                hsv.S = 1 - (min / max);
            }

            hsv.V = max / 255;

            return hsv;
        }

        public static Color ConvertToRGB(HSV hsv)
        {
            double H, f, p, q, t;

            H = (int)(hsv.H / 60) % 6;
            f = (hsv.H / 60) - H;
            p = hsv.V * (1 - hsv.S);
            q = hsv.V * (1 - f * hsv.S);
            t = hsv.V * (1 - (1 - f) * hsv.S);

            RGB rgb = new RGB();
            switch (H)
            {
                case 0:
                    rgb.R = (int)(hsv.V * 255);
                    rgb.G = (int)(t * 255);
                    rgb.B = (int)(p * 255);
                    break;
                case 1:
                    rgb.R = (int)(q * 255);
                    rgb.G = (int)(hsv.V * 255);
                    rgb.B = (int)(p * 255);
                    break;
                case 2:
                    rgb.R = (int)(p * 255);
                    rgb.G = (int)(hsv.V * 255);
                    rgb.B = (int)(t * 255);
                    break;
                case 3:
                    rgb.R = (int)(p * 255);
                    rgb.G = (int)(q * 255);
                    rgb.B = (int)(hsv.V * 255);
                    break;
                case 4:
                    rgb.R = (int)(t * 255);
                    rgb.G = (int)(p * 255);
                    rgb.B = (int)(hsv.V * 255);
                    break;
                case 5:
                    rgb.R = (int)(hsv.V * 255);
                    rgb.G = (int)(p * 255);
                    rgb.B = (int)(q * 255);
                    break;
                default:
                    break;
            }
            return Color.FromArgb(255, rgb.R, rgb.G, rgb.B);
        }
    }
}
