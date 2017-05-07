namespace SuperGame.Interfaces
{
    using SuperGame.Characters;
    public interface IAttack
    {
        int Damage { get; }
        void Attack(Character enemy);
    }
} 
