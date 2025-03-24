package Application;

import models.Operacao;
import models.Soma;

import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        while (true) {
            System.out.println("Insira os operadores");

            try {
                System.out.print("\nDigite o primeiro número: ");
                double a = s.nextDouble();
                System.out.print("Digite o segundo número: ");
                double b = s.nextDouble();

                s.nextLine();

                System.out.print("\nEscolha a operação:\n1- Soma\n2- Subtracao\n3- Multiplicacao\n4- Divisao\n5- Sair\n: ");
                int op = s.nextInt();

                if (op == 5) {
                    System.out.println("\nAté mais");
                    break;
                }

                Operacao operacao = new Operacao();
                if(op == 1) {
                    operacao.setOperacao(new Soma());
                }

                if (operacao == null) {
                    System.out.println("\nOperação inválida!");
                    continue;
                } else {
                    System.out.println("\nResultado: " + operacao.calcular(a, b));
                }
            } catch (InputMismatchException e) {
                System.out.println("\nEntrada inválida! Certifique-se de digitar números válidos.");
                s.nextLine(); // Limpar buffer
            } catch (ArithmeticException e) {
                System.out.println("\n" + e.getMessage());
            }

        }
}