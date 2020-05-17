using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAzure.Service
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
