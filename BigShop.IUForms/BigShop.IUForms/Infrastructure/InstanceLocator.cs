namespace BigShop.IUForms.InfraStructure
{
    using BigShop.UIForms.ViewModels;
    using ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
