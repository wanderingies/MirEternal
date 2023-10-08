#pragma warning disable CS8600
#pragma warning disable CS8619

namespace GameServer.Utility
{
    static class Reflection
    {
        public static IEnumerable<T> CreateAllInstancesOf<T>()
        {
            return typeof(Reflection).Assembly.GetTypes()
                .Where(t => typeof(T).IsAssignableFrom(t))
                .Where(t => !t.IsAbstract && t.IsClass)
                .Select(t => (T)Activator.CreateInstance(t));
        }
    }
}
