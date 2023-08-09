using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerRename
{
    public partial class ExplorerItemViewModel: ObservableObject
    {
        [ObservableProperty]
        private bool @checked;

        [ObservableProperty]
        private string id;

        [ObservableProperty]
        private string idStr;

        [ObservableProperty]
        private string imagePath;

        [ObservableProperty]
        private double indentation;

        [ObservableProperty]
        private string original;

        [ObservableProperty]
        private string renamed;

        [ObservableProperty]
        private int state;

        [ObservableProperty]
        private int typeVM;

    }
}
