namespace SimpleState.Something
{
    class Variable
    {
        IState value;
        public Variable() => value = new StateFalse();
        public void SetState(IState state) => value = state;
        public void False() => value.SetStateFalse(this);
        public void True() => value.SetStateTrue(this);
        public override string ToString() => value.ToString();
    }
}
