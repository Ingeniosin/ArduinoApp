using App20220513_3.Services;
using Microsoft.AspNetCore.Mvc;

namespace App20220513_3.Controllers; 

[ApiController]
[Route("/api/[controller]/[action]")]
public class ArduinoController : Controller {

   private ArduinoService _arduinoService;

   public ArduinoController(ArduinoService arduinoService) {
      _arduinoService = arduinoService;
   }

   [HttpGet]
   public IActionResult Encender() {
      _arduinoService.Encender();
      return Ok();
   }
   
   [HttpGet]
   public IActionResult Apagar() {
      _arduinoService.Apagar();
      return Ok();
   }
   
}