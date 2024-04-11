
namespace DesignPattern.Factory;

public class Flutter
{
    public void setTheme()
    {

    }

    public void setRefreshRate()
    {

    }

    public UIFactory createUiFactory(SupportedPlatform platform)
    {
        return UiFactoryCreator.getUIFactoryForPlatform(platform);
    }

}
