using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IStatic.Interfaces
{
    internal interface ICodeAcademy
    {
        string CodeEmail { get; set; }
        string GenerateEmail();
    }
}
