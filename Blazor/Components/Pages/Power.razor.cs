namespace Blazor.Components.Pages
{
    public partial class Power
    {
        double number = 1;
        double power = 1;
        double result = 1;
        void RaisingToPower()
        {
            result = Math.Pow(number, power);
        }
    }
}
