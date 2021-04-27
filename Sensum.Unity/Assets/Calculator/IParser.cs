using System;
using System.Linq.Expressions;

namespace WPFApp
{
  public interface IParser<TResult>
  {
    Expression<Func<TResult>> Parse(string input);
  }
}