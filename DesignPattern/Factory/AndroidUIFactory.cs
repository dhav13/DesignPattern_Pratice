
using DesignPattern.Factory.Components;

namespace DesignPattern.Factory;

public class AndroidUiFactory : UIFactory
{
    //Override
    public Button createButton()
    {
        return new AndroidButton();
    }

    //Override
    public Menu createMenu()
    {
        return new AndroidMenu();
    }
}