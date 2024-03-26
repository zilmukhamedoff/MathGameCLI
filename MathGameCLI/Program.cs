namespace MathGameCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            var date = DateTime.UtcNow;
            var name = Helpers.GetName();
            menu.ShowMenu(name, date);
        }
    }
}
