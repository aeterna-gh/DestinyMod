namespace DestinyMod.Utils
{
    public struct Mathf
    {
        public static int Average(int x, int y) => (int)Round((x + y) / 2);

        public static int Average(params int[] numbers)
        {
            int count = numbers.Length;

            int result = 0;

            if (numbers.Length <= 1)
                return numbers[0];

            foreach (int n in numbers)
                result += n;

            return (int)Round(result / count);
        }

        public static float Average(float x, float y) => (x + y) / 2;

        public static float Average(params float[] numbers)
        {
            int count = numbers.Length;

            float result = 0;

            if (numbers.Length <= 1)
                return numbers[0];

            foreach (float n in numbers)
                result += n;

            return (result / count);
        }

        public static float Ceil(float f) => (float)Math.Ceiling(f);

        public static float Clamp(float val, float min, float max)
        {
            if (val < min)
                val = min;

            else if (val > max)
                val = max;

            return val;
        }

        public static float Clamp_01(float val)
        {
            if (val < 0.0f)
                val = 0.0f;

            else if (val > 1.0f)
                val = 1.0f;

            return val;
        }

        public static float Round(float f) => (float)Math.Round(f);
    }
}