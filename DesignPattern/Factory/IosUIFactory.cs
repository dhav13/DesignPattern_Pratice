
using DesignPattern.Factory.Components;

namespace DesignPattern.Factory;

public class IosUiFactory : UIFactory
{

    //Override
    public Button createButton()
    {
        return new IosButton();
    }

    //Override
    public Menu createMenu()
    {
        return new IosMenu();
    }
}