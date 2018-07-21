namespace App21072018.Core
{
    public class Entity<T> : IEntity<T>
    {
        public T Id { get; set; }
    }
}
