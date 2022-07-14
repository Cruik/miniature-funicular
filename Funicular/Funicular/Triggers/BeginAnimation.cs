using Xamarin.CommunityToolkit.Behaviors;
using Xamarin.Forms;
using AnimationBase = Funicular.Animations.Base.AnimationBase;

namespace Funicular.Triggers
{
    public class BeginAnimation : TriggerAction<VisualElement>
    {
        public AnimationBase Animation { get; set; }

        protected override async void Invoke(VisualElement sender)
        {
            if (Animation != null)
                await Animation.Begin();
        }
    }
}