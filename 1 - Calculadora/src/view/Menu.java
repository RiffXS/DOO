package view;

import model.dto.RequestDTO;
import model.dto.ResponseDTO;

import java.util.Scanner;

public class Menu {

    public void show() {
        System.out.print("Informe a operação:\n");
        System.out.print("  1 - Soma\n");
        System.out.print("  2 - Subtração\n");
        System.out.print("  3 - Multiplicação\n");
        System.out.print("  4 - Divisão\n\n");
        // System.out.print("  0 - Sair\n");
    }

    private String translateOption(int option) {
        if (option < 1 || option > 4) return "Error";

        if (option == 1) return "Addition";
        if (option == 2) return "Subtraction";
        if (option == 3) return "Multiplication";
        return "Division";
    }

    public RequestDTO retrieveValue() {
        Scanner s = new Scanner(System.in);
        String option = translateOption(s.nextInt());

        System.out.print("Informe o valor 1: ");
        float value1 = s.nextFloat();

        System.out.print("Informe o valor 2: ");
        float value2 = s.nextFloat();

        return new RequestDTO(option, value1, value2);
    }

    public void showResult(ResponseDTO response) {
        System.out.print("Resultado: " + response.getResult());
    }

}
