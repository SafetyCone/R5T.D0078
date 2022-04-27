using System;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.T0064;

using IVisualStudioSolutionFileOperatorCore = R5T.D0078.IVisualStudioSolutionFileOperator;


namespace R5T.D0078.D001
{
    /// <summary>
    /// An open-internals service useful as an extension method base.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IVisualStudioSolutionFileOperator
    {
        IVisualStudioSolutionFileOperatorCore Core { get; }
        IStringlyTypedPathOperator StringlyTypedPathOperator { get; }
    }
}