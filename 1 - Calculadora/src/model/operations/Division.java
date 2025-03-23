package model.operations;

import model.exception.DivisionByZeroException;

public class Division implements IOperation {
    @Override
    public float operation(float a, float b) {
        if (b == 0) throw new DivisionByZeroException("Dividing by zero");
        return a / b;
    }
}
