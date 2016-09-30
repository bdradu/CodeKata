using System;
using System.Collections.Generic;
using System.Linq;
using StringCalculator.Models;

namespace StringCalculator.Extensions
{
    public static class ListExtensions
    {
        public static List<IToken> Reduce(this List<IToken> source, Func<IToken, bool> filter)
        {
            while (source.Any(filter))
            {
                var pivotToken = source.First(filter);
                var povotTokenIndex = source.IndexOf(pivotToken);
                pivotToken.Left = source[povotTokenIndex - 1];
                pivotToken.Right = source[povotTokenIndex + 1];
                source.Insert(povotTokenIndex - 1, new TokenFactory().Create(pivotToken.Value));
                source.RemoveRange(povotTokenIndex, 3);
            }

            return source;
        }
    }
}
