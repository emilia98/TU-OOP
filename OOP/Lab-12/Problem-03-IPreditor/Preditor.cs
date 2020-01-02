namespace Problem_03_IPreditor
{
    public abstract class Preditor : IPreditor
    {
        public abstract void Eat();
        public abstract void GetSound();

        public abstract void Rest();

        public abstract void Run();
        public abstract void Walk();
    }
}
