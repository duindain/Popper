using CommunityToolkit.Maui.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Popper
{
    public class MainVM : BaseViewModel
    {
        public ICommand ClickoCmd { get; set; }

        public MainVM()
        {
            ClickoCmd = new Command(async () => await OpenAndConfigurePopup());
        }

        private async Task OpenAndConfigurePopup()
        {
            var popper = new MyPopper();

            popper.PopperVM.ViewHorizontalOption = LayoutAlignment.End;
            popper.PopperVM.ViewVerticalOption = LayoutAlignment.End;

            await Application.Current.MainPage.ShowPopupAsync(popper);
        }
    }
}
