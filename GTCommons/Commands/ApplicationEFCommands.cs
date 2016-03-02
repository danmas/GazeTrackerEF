using System.Windows;

namespace GTCommons.Commands
{
    public class ApplicationEFCommands : Window
    {
        public static readonly RoutedEvent ApplicationEFEvent = EventManager.RegisterRoutedEvent("ApplicationEFEvent",
                                                                                            RoutingStrategy.Bubble,
                                                                                            typeof (RoutedEventHandler),
                                                                                            typeof(ApplicationEFCommands));

        public void ApplicationEF()
        {
            var args1 = new RoutedEventArgs();
            args1 = new RoutedEventArgs(ApplicationEFEvent, this);
            RaiseEvent(args1);
        }

        public event RoutedEventHandler OnApplicationEFOpen
        {
            add { base.AddHandler(ApplicationEFEvent, value); }
            remove { base.RemoveHandler(ApplicationEFEvent, value); }
        }

    }
}