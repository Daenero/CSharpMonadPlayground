namespace WebApplication1.Funcs
{
    public static class Extensions
    {
        public static Maybe<T> Return<T>(this T value) where T : class
            => value != null
                ? new Maybe<T>(value)
                : Maybe<T>.None();
    }
}