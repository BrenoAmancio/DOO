import factory.Factory;
import model.Operacao;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Operacao calc = new Factory().factory("Soma");
        System.out.println(calc.operacao(2,1));
        calc = new Factory().factory("Subtracao");
        System.out.println(calc.operacao(2,1));
        calc = new Factory().factory("Multiplicacao");
        System.out.println(calc.operacao(2,1));
        calc = new Factory().factory("Divisao");
        System.out.println(calc.operacao(2,1));
    }
}