using System;
using System.Collections.Generic;
using System.Text;

namespace Prism_POC.Core.UseCases
{
    public interface IUseCase<T>
    {
        T Execute();
    }
}
