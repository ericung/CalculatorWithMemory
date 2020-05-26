using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CalculatorWithMemory.Models
{
  public class IndexViewModel
  {
    public Queue<String> Expressions { get; set; }

    public String Result { get; set; }
  }
}
