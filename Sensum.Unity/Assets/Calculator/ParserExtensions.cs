using System;
using System.Collections.Generic;
using System.Text;

namespace WPFApp
{
  public static class ParserExtensions
  {
    public static TResult Execute<TResult>(this IParser<TResult> parser, string input)
    {
      return parser.Parse(input).Compile().Invoke();
    }
  }
}
