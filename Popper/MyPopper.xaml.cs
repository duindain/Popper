using CommunityToolkit.Maui.Views;  

namespace Popper
{
    public partial class MyPopper : Popup
    {
        public MyPopperVM PopperVM => BindingContext as MyPopperVM;

        public MyPopper()
        {
            InitializeComponent();
        }
    }
}