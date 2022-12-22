using System.Collections.Generic;
using System.Windows.Media;

namespace ExampleOfSimpleProjectInMVVM.Models;

public class TopBar
{
    //Content
    private const string MainPath = "/Resources/";
    public const string AppIconPath = MainPath + "icon.png";
    public const string AppName = "GrontoMapa";
    public const string MinimizeIconPath = MainPath + "minimize.png";
    public const string StateIconPath = MainPath + "resize.png";
    public const string CloseIconPath = MainPath + "close.png";
    
    //Font
    public const double FontSize = 20;
    public const string FontFamily = "Congenial Black";
    public const string FontWeight = "Medium";
    
    //Colors
    private List<string> ColorHex = new();
    public List<SolidColorBrush> SolidColorBrushesList = new();
    public TopBar(int switchValue)
    {
        switch (switchValue)
        {
            case 0:
                ColorHex.Add("#ffd382");
                ColorHex.Add("#ad7100");
                ColorHex.Add("#ffa600");
                break;
            case 1:
                ColorHex.Add("#c5c7c9");
                ColorHex.Add("#9e9e9e");
                ColorHex.Add("#757575");
                break;
        }
        for (int i = 0; i < 3; i++)
        {
            Color color = (Color) ColorConverter.ConvertFromString(ColorHex[i]);
            SolidColorBrush brush = new SolidColorBrush(color);
            SolidColorBrushesList.Add(brush);
        }
    }
}