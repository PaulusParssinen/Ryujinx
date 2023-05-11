namespace Ryujinx.HLE.HOS.Tamper.Operations
{
    class OpOr<T> : IOperation where T : unmanaged
    {
        IOperand _destination;
        IOperand _lhs;
        IOperand _rhs;

        public OpOr(IOperand destination, IOperand lhs, IOperand rhs)
        {
            _destination = destination;
            _lhs = lhs;
            _rhs = rhs;
        }

        public void Execute()
        {
            _destination.Set((T)((dynamic)_lhs.Get<T>() | (dynamic)_rhs.Get<T>()));
        }
    }
}