using CommunityToolkit.Mvvm.Messaging.Messages;

namespace TapGestureRecognizerNotWorking.ViewModels.Messages
{
    public class UpdateSelectedStoreItemsMessage : ValueChangedMessage<bool>
    {
        public UpdateSelectedStoreItemsMessage(bool value) : base(value)
        {
            
        }
    }
}
