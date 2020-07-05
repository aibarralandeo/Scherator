using System.Windows;
using System.Windows.Input;

namespace Scherator.Client.Desktop.Extensions
{
    public static class WindowExtensions
    {
        public static Point GetMousePosition(this Window window)
        {
            var position = Mouse.GetPosition(window);

            return new Point(position.X + window.Left, position.Y + window.Top);
        }
    }
}
