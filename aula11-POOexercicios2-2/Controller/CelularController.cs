using aula11_POOexercicios2_2.Model;

namespace aula11_POOexercicios2_2.Controller {
    public class CelularController {
        CelularModel Celular = new CelularModel ();

        public void Ligado () {

            Celular.CelularLigar = true;
            System.Console.WriteLine ("Celular está ligado");
        }

        public void Desligado () {
            Celular.CelularDesligar = false;
            System.Console.WriteLine ("Celular está desligado ...");
        }

        public void FazerLigacao(){
            if(Celular.CelularLigar == true){
                System.Console.WriteLine("Ligando pra morena Kjkk");
            }else{
                System.Console.WriteLine("O celular está ligado, não dá pra ligar pra morena :/");
            }
        }

        public void EnviarSMS () {
            if(Celular.CelularLigar == true){
                System.Console.WriteLine("Enviando o ZapZapkjkjkk");
            }else{
                System.Console.WriteLine("O celular está desligado, não dá pra enviar o zapzapkkjkk pra morena :(");
            }
        } 
    }
}