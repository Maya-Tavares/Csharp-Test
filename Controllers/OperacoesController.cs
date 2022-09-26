using Microsoft.AspNetCore.Mvc;

namespace MvcIntroViews.Controllers;

public class OperacoesController : Controller
{
    public IActionResult Somar() {
        return View();
    }

    public IActionResult ResultadoSoma(double n1, double n2) {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 + n2;
        return View();
    }

    public IActionResult Subtrair() {
        return View();
    }

    public IActionResult ResultadoSubtracao(double n1, double n2) {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 - n2;
        return View();
    }

    public IActionResult Dividir() {
        return View();
    }

    public IActionResult ResultadoDivisao(double n1, double n2) {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1/n2;
        return View();
    }

    public IActionResult Multiplicar() {
        return View();
    }

    public IActionResult ResultadoMultiplicacao(double n1, double n2) {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1*n2;
        return View();
    }
}
