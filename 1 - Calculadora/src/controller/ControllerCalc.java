package controller;

import model.calculators.Calculator;
import model.calculators.ICalculator;
import model.dto.RequestDTO;
import model.dto.ResponseDTO;
import model.exception.DivisionByZeroException;
import model.exception.InvalidOperationException;

public class ControllerCalc {

    public ResponseDTO Calculate(RequestDTO request) throws InvalidOperationException, DivisionByZeroException {
        ICalculator calculator = new Calculator();

        return calculator.calculate(request);
    }

}
