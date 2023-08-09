using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerRename
{
    internal partial class RenameOptionsViewModel : ObservableObject
    {

        [ObservableProperty]
        private string? name;
    }
}
