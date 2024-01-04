using System;

namespace LitMotion
{
    /// <summary>
    /// Options for shake motion.
    /// </summary>
    public struct ShakeOptions : IEquatable<ShakeOptions>, IMotionOptions
    {
        public int Frequency;
        public float DampingRatio;
        public Unity.Mathematics.Random RandomState;

        public static ShakeOptions Default
        {
            get
            {
                return new ShakeOptions()
                {
                    Frequency = 10,
                    DampingRatio = 1f
                };
            }
        }

        public readonly bool Equals(ShakeOptions other)
        {
            return other.Frequency == Frequency &&
                other.DampingRatio == DampingRatio &&
                other.RandomState.state == RandomState.state;
        }

        public override readonly bool Equals(object obj)
        {
            if (obj is ShakeOptions options) return Equals(options);
            return false;
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Frequency, DampingRatio, RandomState);
        }
    }
}