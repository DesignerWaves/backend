using Aula.Models;

namespace Aula.Controllers {
    public class CarroEletricoController : CarroController {
        //declaramos objeto CarroEletricoModel
        CarroEletricoModel carroeletrico = new CarroEletricoModel ();
        //declarando objeto MotorModel
        MotorModel motor = new MotorModel ();

        public void CarregarBateria (float carga) {
            if (carroeletrico.Bateria < 100) {
                carroeletrico.Bateria += carga;

                //É o mesmo que ...
                // carro.Eletrico.Bateria = CarroEletrico.Bateria + carga;
            }else{
                System.Console.WriteLine("A bateria do carro já está completa! Pode Viajar!!!");
            }
        }
        public float StatusBateria(){
            return carroeletrico.Bateria;
        }

    }
}