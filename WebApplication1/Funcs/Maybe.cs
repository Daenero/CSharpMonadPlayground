using System;

namespace WebApplication1.Funcs
{
    public class Maybe<TInput>
    {
        private readonly TInput _value;

        public Maybe(TInput value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            _value = value;
        }

        private Maybe() { }

        public static Maybe<TInput> None() => new Maybe<TInput>();

        public Maybe<TResult> Bind<TResult>(Func<TInput, Maybe<TResult>> func) where TResult: class
        {
            return func != null ? func(_value) : Maybe<TResult>.None();
        }
    }
}