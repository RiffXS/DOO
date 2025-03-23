package model.calculators;

import model.dto.RequestDTO;
import model.dto.ResponseDTO;
import model.exception.DivisionByZeroException;
import model.exception.InvalidOperationException;
import model.factories.OperationFactory;
import model.operations.*;

public class Calculator implements ICalculator {

    @Override
    public ResponseDTO calculate(RequestDTO request) throws InvalidOperationException, DivisionByZeroException {
        IOperation operation = new OperationFactory().create(request.getOption());

        float value1 = request.getValue1();
        float value2 = request.getValue2();
        float result = -1;

        if (operation != null) result = operation.operation(value1, value2);

        return new ResponseDTO(result);
    }

}
