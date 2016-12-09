using Shared;
using System.Windows;
using XDMessaging;

namespace Listener
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Listener_MessageReceived(object sender, XDMessageEventArgs e)
        {
            var message = e.DataGram.Message;
            MessageBox.Show(message);
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var client = new XDMessagingClient();
            var listener = client.Listeners.GetListenerForMode(XDTransportMode.Compatibility);
            listener.MessageReceived += Listener_MessageReceived;
            listener.RegisterChannel(Constants.ChannelName);
        }
    }
}