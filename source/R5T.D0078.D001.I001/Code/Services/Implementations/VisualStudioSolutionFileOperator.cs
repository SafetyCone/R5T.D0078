using System;

using R5T.Dacia;
using R5T.Lombardy;

using IVisualStudioSolutionFileOperatorCore = R5T.D0078.IVisualStudioSolutionFileOperator;


namespace R5T.D0078.D001.I001
{
    [ServiceImplementationMarker]
    public class VisualStudioSolutionFileOperator : IVisualStudioSolutionFileOperator
    {
        public IVisualStudioSolutionFileOperatorCore Core { get; set; }
        public IStringlyTypedPathOperator StringlyTypedPathOperator { get; set; }


        public VisualStudioSolutionFileOperator(
            IVisualStudioSolutionFileOperatorCore core,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.Core = core;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }
    }
}