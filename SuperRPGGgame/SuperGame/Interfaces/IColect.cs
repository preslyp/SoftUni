namespace SuperGame.Interfaces
{
    using System.Collections.Generic;
    using SuperGame.Items;

    public interface IColect
    {
        IEnumerable<Item> Inventory { get; }

        void AddItemToInvetory(Item item);
    }
}
