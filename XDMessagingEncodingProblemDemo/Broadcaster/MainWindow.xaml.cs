using Shared;
using System.Windows;
using XDMessaging;

namespace Broadcaster
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            var client = new XDMessagingClient();
            var broadcaster = client.Broadcasters.GetBroadcasterForMode(XDTransportMode.Compatibility);
            broadcaster.SendToChannel(Constants.ChannelName, TextBox.Text);
        }
    }
}