using Avalonia;
using Avalonia.Controls;
using TeamTalkStation_TTS_Client.Models;

namespace TeamTalkStation_TTS_Client.Controls
{
    public class ImageChatBubble : ContentControl,ISelectable
    {
        public static readonly StyledProperty<bool> IsSelectedProperty = AvaloniaProperty.Register<ChatBubble, bool>(nameof(IsSelected));

        public static readonly StyledProperty<ChatRoleType> RoleProperty = AvaloniaProperty.Register<ChatBubble, ChatRoleType>(nameof(Role));

        public static readonly StyledProperty<bool> IsReadProperty = AvaloniaProperty.Register<ChatBubble, bool>(nameof(IsRead));

        public bool IsRead
        {
            get => GetValue(IsReadProperty); 
            set => SetValue(IsReadProperty, value); 
        }

        public ChatRoleType Role
        {
            get => GetValue(RoleProperty);
            set => SetValue(RoleProperty, value); 
        }

        public bool IsSelected
        {
            get => GetValue(IsSelectedProperty); 
            set
            {
                SetValue(IsSelectedProperty, value);
                IsRead = true;
            }
        }
    }
}