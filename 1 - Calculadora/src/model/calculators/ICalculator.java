package model.calculators;

import model.dto.RequestDTO;
import model.dto.ResponseDTO;
import model.exception.DivisionByZeroException;
import model.exception.InvalidOperationException;

public interface ICalculator {
    public ResponseDTO calculate(RequestDTO request) throws InvalidOperationException, DivisionByZeroException;
}
