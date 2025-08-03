using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem
{
    /// <summary>
    ///  Contract for any report object handled by the system.
    ///  A report exposes a read-only Title and Content.
    /// </summary>
    public interface IReport
    {
        string Title { get; }
        string Content { get; }
    }
}

