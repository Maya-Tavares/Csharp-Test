using Microsoft.AspNetCore.Mvc;

namespace MvcIntroViews.Controllers;

public class CalculadoraController : Controller
{
    public IActionResult Operacao() {
        return View();
    }

    public IActionResult Resultado(string operacao, double n1, double n2) {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.OPERACAO = operacao;

        switch (operacao)
        {
            case "Soma":
                ViewBag.Resultado = n1 + n2;
                ViewBag.SIMBOLO = '+';
                break;
            case "Subtração":
                ViewBag.Resultado = n1 - n2;
                ViewBag.SIMBOLO = '-';
                break;
            case "Divisão":
                ViewBag.Resultado = n1/n2;
                ViewBag.SIMBOLO = '/';
                break;
            case "Multiplicação":
                ViewBag.Resultado = n1 * n2;
                ViewBag.SIMBOLO = '*';
                break;
        }
        return View();
    }
}
