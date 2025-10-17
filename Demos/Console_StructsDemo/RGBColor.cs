using System;

namespace Console_StructsDemo
{
    //class RGBColor
    struct RGBColor
    {
        private int r, g, b;

        public int R
        {
            get { return r; }
            set
            {
                if (value >= 0 && value <= 255)
                    r = value;
            }
        }
        public int G
        {
            get { return g; }
            set
            {
                if (value >= 0 && value <= 255)
                    g = value;
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value >= 0 && value <= 255)
                    b = value;
            }
        }

        public RGBColor(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
}
