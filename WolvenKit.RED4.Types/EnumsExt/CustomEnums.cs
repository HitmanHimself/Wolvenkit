// ReSharper disable InconsistentNaming

namespace WolvenKit.RED4.Types
{
    public static partial class Enums
    {
        // flags

        public enum EInterPolationType
        {
            Constant,
            Linear,
            BezierQuadratic,
            BezierCubic,
            Hermite
        }

        public enum EChannelLinkType
        {
            Normal,
            Smooth,
            SmoothSymmertric
        }

        public enum toolsSocketDirection
        {
            Invalid,
            Output,
        }

        public enum toolsSocketPlacement
        {
            Invalid,
            Bottom,
            Right,
        }

        public enum toolsAudioPlaybackDirectionSupport
        {
            Forward,
            Backward
        }

        public enum toolsAudioFastForwardSupport
        {
            MuteDuringFastForward,
            DontMuteDuringFastForward
        }

        public enum scnbPerformerAcquisitionPlanType
        {
            Invalid,
            Community,
            SpawnSet
        }
    }
}
