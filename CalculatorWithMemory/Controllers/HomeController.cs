using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalculatorWithMemory.Models;
using System.Linq.Expressions;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace CalculatorWithMemory.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    public static Queue<String> Expressions = new Queue<String>();

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      IndexViewModel indexViewModel = new IndexViewModel();
      indexViewModel.Expressions = Expressions;
      return View(indexViewModel);
    }

    [HttpPost]
    public IActionResult Index(String display)
    {
      IndexViewModel indexViewModel = new IndexViewModel();
      indexViewModel.Result = EvaluateExpression(display);
      indexViewModel.Expressions = Expressions;
      return View(indexViewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private static String EvaluateExpression(String display)
    {
      if (display == null)
      {
        return "";
      }

      bool leftNegFlag = false;
      String left = String.Empty;
      String right = String.Empty;
      int operatorSymbol = 0;

      for (int i = 0; i < display.Length; i++)
      {
        if (display[i] == '-' && i == 0)
        {
          leftNegFlag = true;
        }
        else if ((display[i] == '+')||((display[i]== '-')&&(i != 0))||(display[i] == '*')||(display[i] == '/'))
        {
          operatorSymbol = i;
          break;
        }
        else
        {
          left += display[i];
        }
      }


      for (int i = operatorSymbol + 1; i < display.Length; i++)
      {
        right += display[i];
      }

      Double leftNumeric, rightNumeric;
      Double.TryParse(left, out leftNumeric);
      Double.TryParse(right, out rightNumeric);

      Double result = OperateOnLeftRight(leftNumeric, display[operatorSymbol], rightNumeric);

      QueueView(display + " = " + result);

      return result.ToString();
    }

    private static Double OperateOnLeftRight(Double left, char operatorSymbol, Double right)
    {
      Double result = 0;

      switch(operatorSymbol)
      {
        case '+': result = left + right; break;
        case '-': result = left - right; break;
        case '*': result = left * right; break;
        case '/': result = left / right; break;
      }

      return result;
    }

    private static void QueueView(String expression)
    {
      Expressions.Enqueue(expression);

      if (Expressions.Count > 10)
      {
        Expressions.Dequeue();
      }
    }
  }
}
