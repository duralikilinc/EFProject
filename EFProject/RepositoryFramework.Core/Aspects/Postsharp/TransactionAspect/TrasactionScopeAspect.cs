using System;
using PostSharp.Aspects;
using System.Transactions;

namespace RepositoryFramework.Core.Aspects.Postsharp.TransactionAspect
{
    [Serializable]
    public class TrasactionScopeAspect : OnMethodBoundaryAspect
    {
        private TransactionScopeOption _option;
        public TrasactionScopeAspect(TransactionScopeOption option)
        {
            _option = option;
        }

        public TrasactionScopeAspect()
        {
            
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            args.MethodExecutionTag=new TransactionScope(_option);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Complete();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Dispose();
        }
    }
}
