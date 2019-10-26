using System;
using Teste.Domain.Context.Criterio.Interface;

namespace Teste.Domain.Context.Criterio.Factory
{
    public class CriterioFactory
    {
        public static ICriterio Get(Criterio.Enum.Criterio criterio)
        {
            switch (criterio)
            {
                case Criterio.Enum.Criterio.Lambda:
                    return new CriterioLambda();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}