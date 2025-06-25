using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples.ISP
{
    interface IWorker
    {
        void WriteCode();
        void TestCode();
    }
    public class Manager : IWorker
    {
        public void TestCode()
        {
            //Manager can't test the code
                  }

        public void WriteCode()
        {
           //Manager can't write the code
        }
    }
    /* 
     To adhere to ISP, we can split the IWorker interface into two separate interfaces: 
    ICodeWriter and ICodeTester.
     */
    public interface ICodeWriter
    {
        void WriteCode();
    }
    public interface ICodeTester
    {
        void TestCode();
    }
    internal class Demo1
    {
    }
}
