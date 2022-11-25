using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popper
{
    public class MyPopperVM : BaseViewModel
    {
        private Size _size = new Size(400, 120);
        public Size Size
        {
            get => _size;
            set => SetProperty(ref _size, value);
        }

        private LayoutAlignment _viewVerticalOption = LayoutAlignment.Start;
        public LayoutAlignment ViewVerticalOption
        {
            get => _viewVerticalOption;
            set => SetProperty(ref _viewVerticalOption, value);
        }

        private LayoutAlignment _viewHorizontalOption = LayoutAlignment.Start;
        public LayoutAlignment ViewHorizontalOption
        {
            get => _viewHorizontalOption;
            set => SetProperty(ref _viewHorizontalOption, value);
        }

        
    }
}
