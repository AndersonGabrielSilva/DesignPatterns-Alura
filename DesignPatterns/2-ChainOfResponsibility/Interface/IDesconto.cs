using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2_ChainOfResponsibility.Interface
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }

        public double Desconto(Orcamento orcamento);
    }
}
