
using DesignPattern.Factory.Components;

namespace DesignPattern.Factory;

public interface UIFactory
{

    public Button createButton();
    public Menu createMenu();
}
