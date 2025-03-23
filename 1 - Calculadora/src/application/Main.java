package application;

import controller.ControllerCalc;
import model.dto.RequestDTO;
import model.dto.ResponseDTO;
import model.exception.DivisionByZeroException;
import model.exception.InvalidOperationException;
import model.factories.OperationFactory;
import model.operations.IOperation;
import view.Menu;

public class Main {

    public static void main(String args[]) {
        try {
            Menu menu = new Menu();
            menu.show();
            RequestDTO request = menu.retrieveValue();
            ControllerCalc controllerCalc = new ControllerCalc();
            ResponseDTO response = null;
            response = controllerCalc.Calculate(request);
            menu.showResult(response);
        } catch (InvalidOperationException | DivisionByZeroException e) {
            System.out.print(e.getMessage() + "\n");
        } catch (Exception e) {
            System.out.print("Algum erro\n");
        }
    }

}
