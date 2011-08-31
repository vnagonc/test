using System;
using System.Collections.Generic;
using System.Text;

namespace CompilerLib
{
    public interface ICompiler
    {
        void Compile();
        
    }
    
    public class CompilerArgs : EventArgs
    {
        public CompileResultType  Result { get; private set; }
        public string Message { get; private set; }
        public CompilerArgs(CompileResultType result, string message)
        {
            Result = result;
            Message = message;
        }
    }
}
