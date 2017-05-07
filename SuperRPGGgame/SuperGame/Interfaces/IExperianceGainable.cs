namespace SuperGame.Interfaces
{
    public interface IExperianceGainable
    {
        int Experience { get; }

        void LevelUp();
    }
}
